using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEditor.Android;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace Mfuscator {

	public sealed class Pipeline : IPreprocessBuildWithReport,
		IPostGenerateGradleAndroidProject,
		IPostprocessBuildWithReport {

		private static bool _doNotContinue;
		private static Stopwatch _stopwatch;

		private static bool IsGoodReport(BuildReport report) {
			return
#if UNITY_6000_0_OR_NEWER
				report.summary.buildType == BuildType.Player &&
#endif
				report.summary.result != BuildResult.Failed &&
				report.summary.result != BuildResult.Cancelled;
		}
		private static bool IsIL2CPP(BuildReport report) {
			return PlayerSettings.GetScriptingBackend(NamedBuildTarget.FromBuildTargetGroup(report.summary.platformGroup)) == ScriptingImplementation.IL2CPP;
		}
		private static bool IsSupportedTargetPlatform(BuildReport report) {
			return
				report.summary.platform == BuildTarget.StandaloneWindows64 ||
				report.summary.platform == BuildTarget.StandaloneLinux64 ||
				report.summary.platform == BuildTarget.StandaloneOSX ||
				report.summary.platform == BuildTarget.Android ||
				report.summary.platform == BuildTarget.iOS;
		}
		private static bool IsSupportedCompilerConfiguration(BuildReport report) {
			Il2CppCompilerConfiguration compilerConfiguration = PlayerSettings.GetIl2CppCompilerConfiguration(NamedBuildTarget.FromBuildTargetGroup(report.summary.platformGroup));
			if (compilerConfiguration == Il2CppCompilerConfiguration.Master)
				Utils.LogWarning("The \"Master\" IL2CPP compiler configuration is being used, which may cause incompatibility issues in some scenarios. It is recommended to use \"Release\" configuration");
			return compilerConfiguration == Il2CppCompilerConfiguration.Release || compilerConfiguration == Il2CppCompilerConfiguration.Master;
		}
		public static string EditorPath {
			get {
				if (Application.platform == RuntimePlatform.OSXEditor)
					return EditorApplication.applicationPath[..EditorApplication.applicationPath.LastIndexOf($"/{Path.GetFileName(EditorApplication.applicationPath)}")];
				return EditorApplication.applicationPath[..EditorApplication.applicationPath.LastIndexOf($"/Editor/{Path.GetFileName(EditorApplication.applicationPath)}")];
			}
		}
		private static string GetOutputPath(BuildReport report) {
			return Path.HasExtension(report.summary.outputPath) ? Path.GetDirectoryName(report.summary.outputPath) : report.summary.outputPath;
		}
		private static string GetMetadataFilepath(BuildReport report) {
			if (report.summary.platform == BuildTarget.StandaloneOSX)
				return Path.Combine(report.summary.outputPath, "Contents", "Resources", "Data", "il2cpp_data", "Metadata", "global-metadata.dat");
			if (report.summary.platform == BuildTarget.StandaloneWindows64 ||
				report.summary.platform == BuildTarget.StandaloneLinux64) {
				DirectoryInfo outputDirectory = new(GetOutputPath(report));
				foreach (var directory in outputDirectory.GetDirectories())
					if (directory.FullName.EndsWith("_Data"))
						return Path.Combine(directory.FullName, "il2cpp_data", "Metadata", "global-metadata.dat");
				throw new NotImplementedException();
			}
			if (report.summary.platform == BuildTarget.iOS)
				return Path.Combine(GetOutputPath(report), "Data", "Managed", "Metadata", "global-metadata.dat");
			throw new NotImplementedException();
		}

		// [Unity]
		public int callbackOrder => Settings.Object.callbackOrder;

		[AOT.MonoPInvokeCallback(typeof(Shared.LogCallback))]
		private static void OnLog(IntPtr messageP, byte type) {
			string message = $"<color=#999><b>[Unmanaged]</b></color> {Marshal.PtrToStringUni(messageP)}";
			switch (type) {
				case (byte)Shared.LogType.Info: Utils.LogInfo(message); break;
				case (byte)Shared.LogType.Warning: Utils.LogWarning(message); break;
				case (byte)Shared.LogType.Error: Utils.LogError(message); break;
				default: Utils.LogError("Unknown log type"); break;
			}
		}
		// clear
		public static void Restore() {
			Shared.SetLogCallback(OnLog);
			Settings.Object.inter.editorVersion = Application.unityVersion;
			Settings.Object.inter.editorPath = EditorPath;
			if (!Shared.Clear(Settings.Object.inter))
				Utils.LogWarning("No files were found that could be restored");
		}
		private static void ClearCache(string outputPath) {
			if (Directory.Exists(outputPath) && Directory.EnumerateFileSystemEntries(outputPath).Any()) {
				string foolproofMessage = $"The target build folder is not empty (\"{outputPath}\"); Mfuscator will remove its contents for proper operation. You can change the \"Callback Order\" in settings so that your custom build pipeline (if any) generates files after Mfuscator";
				if (
					(Directory.Exists(Path.Combine(outputPath, "Assets")) || Directory.Exists(Path.Combine(outputPath, "Library"))) &&
					!Application.isBatchMode &&
					!EditorUtility.DisplayDialog("Mfuscator", $"{foolproofMessage}.", "Proceed", "Cancel")
					)
					throw new OperationCanceledException();
				const string CLEAR_CACHE_WARNING_PP_SUB_KEY = "CLEAR_CACHE_WARNING";
				if (
					!PlayerPrefs.HasKey(Utils.GetPlayerPrefsKey(CLEAR_CACHE_WARNING_PP_SUB_KEY)) &&
					!Application.isBatchMode &&
					!EditorUtility.DisplayDialog("Mfuscator", $"{foolproofMessage}. This message may no longer be displayed!", "Proceed", "Cancel")
					)
					throw new OperationCanceledException();
				PlayerPrefs.SetString(Utils.GetPlayerPrefsKey(CLEAR_CACHE_WARNING_PP_SUB_KEY), "https://youtu.be/ZKT5RO-C-jw");
				Utils.LogInfo(foolproofMessage);
				Directory.Delete(outputPath, true);
				_ = Directory.CreateDirectory(outputPath);
			}
			// "Bee"
			string cachePath = Path.Combine(Application.dataPath, "..", "Library", "Bee");
			if (Directory.Exists(cachePath))
				Directory.Delete(cachePath, true);
		}
		private static void Finish() {
			if (_stopwatch == null)
				return;
			_stopwatch.Stop();
			var elapsedSpan = _stopwatch.Elapsed;
			string elapsed = elapsedSpan switch {
				{ TotalSeconds: < 1 } => $"{(int)elapsedSpan.TotalMilliseconds} ms",
				{ TotalMinutes: < 1 } => $"{elapsedSpan.TotalSeconds:F1} s",
				_ => $"{elapsedSpan.TotalMinutes:F1} min"
			};
			Utils.LogInfo($"<color=green>Finished processing</color> (elapsed: {elapsed})");

			// SaaS / Legacy Notice
			Utils.LogInfo("<color=#ffcc00><b>Notice:</b></color> This package has entered legacy maintenance mode (LTS) and won't receive new features. A more powerful version is now live! Visit <b><a href=\"https://mfuscator.com\">mfuscator.com</a></b> (or <b><a href=\"https://defense.mew.icu\">defense.mew.icu</a></b>) for more info.");
		}

		// [Unity]
		public void OnPreprocessBuild(BuildReport report) {
			// reset
			_doNotContinue = false;
			_stopwatch = new();
			_stopwatch.Start();

			// clear cache request?
			string clearCachePPKey = Utils.GetPlayerPrefsKey(SettingsWindow.CLEAR_CACHE_PP_SUB_KEY);
			if (PlayerPrefs.HasKey(clearCachePPKey)) {
				PlayerPrefs.DeleteKey(clearCachePPKey);
				if (!Settings.Object.enable) {
					Utils.LogInfo("Cache cleanup has been requested. This build will take longer than usual to complete");
					ClearCache(GetOutputPath(report));
				}
			}

			// ignore?
			static void Ignore(string reason) {
				_doNotContinue = true;
				Utils.LogInfo($"This build will be ignored ({reason})");
			}
			if (
				!Settings.Object.enable ||
				PlayerPrefs.HasKey(Utils.GetPlayerPrefsKey("IGNORE"))
				) {
				Ignore("disabled");
				return;
			}
			var namedTarget = NamedBuildTarget.FromBuildTargetGroup(report.summary.platformGroup);
			if (
				namedTarget == NamedBuildTarget.Server ||
				Array.IndexOf(PlayerSettings.GetScriptingDefineSymbols(namedTarget).Split(';'), "UNITY_SERVER") != -1 ||
				(namedTarget == NamedBuildTarget.Standalone && report.summary.GetSubtarget<StandaloneBuildSubtarget>() == StandaloneBuildSubtarget.Server)
				) {
				Ignore("server");
				return;
			}
			if (
				report.summary.options.HasFlag(BuildOptions.Development)
				) {
				Ignore("development");
				return;
			}
			if (
				!IsGoodReport(report)
				) {
				Ignore("bad report");
				return;
			}
			if (
				!IsIL2CPP(report) ||
				!IsSupportedTargetPlatform(report)
				) {
				Ignore("unsupported target platform");
				return;
			}
			if (
				!IsSupportedCompilerConfiguration(report)
				) {
				Ignore("unsupported IL2CPP compiler configuration");
				return;
			}
#if UNITY_EDITOR_WIN
			if (
				UnityEditor.WindowsStandalone.UserBuildSettings.createSolution
				) {
				Ignore("building outside the editor is not supported");
				return;
			}
#endif
			if (
				Application.platform != RuntimePlatform.OSXEditor && (report.summary.platform == BuildTarget.StandaloneOSX || report.summary.platform == BuildTarget.iOS)
				) {
				Ignore("\"OSX\" and \"iOS\" targets can only be built in the OSX editor");
				return;
			}
#if !UNITY_6000_0_OR_NEWER
			if (
				report.summary.platform == BuildTarget.iOS && !PlayerPrefs.HasKey(Utils.GetPlayerPrefsKey("IOS_IMPL"))
				) {
				Ignore("iOS build processor is not implemented (see \"ReadMe.txt\" -> \"iOS builds\")");
				return;
			}
#endif
			if (
				Application.platform == RuntimePlatform.LinuxEditor &&
				report.summary.platform != BuildTarget.StandaloneLinux64 &&
				report.summary.platform != BuildTarget.Android
			) {
				Utils.LogWarning("You're building via the Linux editor, but the target platform is neither standalone Linux (x64) nor Android. This is experimental and may not work");
			}
			if (
				Application.platform == RuntimePlatform.OSXEditor &&
				report.summary.platform != BuildTarget.StandaloneOSX &&
				report.summary.platform != BuildTarget.iOS
			) {
				Utils.LogWarning("You're building via the OSX editor, but the target platform is neither standalone OSX nor iOS. This is experimental and may not work");
			}

			ClearCache(GetOutputPath(report));

			Settings.Object.inter.editorVersion = Application.unityVersion;
			Settings.Object.inter.editorPath = EditorPath;
			Settings.Object.inter.targetPlatform = report.summary.platform switch {
				BuildTarget.StandaloneWindows64 => Shared.TargetPlatform.Windows,
				BuildTarget.StandaloneLinux64 => Shared.TargetPlatform.Linux,
				BuildTarget.StandaloneOSX => Shared.TargetPlatform.macOS,
				BuildTarget.Android => Shared.TargetPlatform.Android,
				BuildTarget.iOS => Shared.TargetPlatform.iOS,
				_ => throw new NotImplementedException(),
			};

			if (!Utils.TryObtainAccess(Settings.Object.inter.editorPath)) {
				_doNotContinue = true;
				return;
			}

			// temp
			Utils.LogInfo($"<i>b{Shared.BUILD_NUMBER}. Built with love, by</i> <b><a href=\"https://mew.icu\">mew.icu</a></b>");

			Shared.SetLogCallback(OnLog);
#if UNITY_6000_0_OR_NEWER
			if (Settings.Object.inter.targetPlatform != Shared.TargetPlatform.iOS)
				Shared.Clear(Settings.Object.inter);
#else
			Shared.Clear(Settings.Object.inter);
#endif
			Shared.Pre(Settings.Object.inter);
		}
		// [Unity]
		public void OnPostGenerateGradleAndroidProject(string path) {
			// ignore?
			if (_doNotContinue)
				return;
			_doNotContinue = true;

			// "Settings.Object.inter.outputPath" is not yet used for Android
			Settings.Object.inter.metaFilepath = Path.Combine(path, "src", "main", "assets", "bin", "Data", "Managed", "Metadata", "global-metadata.dat");

			Shared.SetLogCallback(OnLog);
			Shared.Post(Settings.Object.inter);

			Finish();
		}
		// [Unity]
		public void OnPostprocessBuild(BuildReport report) {
			// ignore?
			if (_doNotContinue || !IsGoodReport(report))
				return;

			// called when building for iOS

			Settings.Object.inter.outputPath = report.summary.platform == BuildTarget.StandaloneOSX ? report.summary.outputPath : GetOutputPath(report);
			Settings.Object.inter.metaFilepath = GetMetadataFilepath(report);

			Shared.SetLogCallback(OnLog);
			Shared.Post(Settings.Object.inter);

			// sign
			if (Application.platform == RuntimePlatform.OSXEditor && report.summary.platform == BuildTarget.StandaloneOSX) {
				static void Sign(string filepath) {
					ProcessStartInfo processStartInfo = new() {
						FileName = "/usr/bin/codesign",
						Arguments = $"--force --deep --sign - \"{filepath}\"",
						UseShellExecute = false,
						RedirectStandardOutput = true,
						RedirectStandardError = true
					};
					using Process process = Process.Start(processStartInfo);
					process.WaitForExit();
					string output = process.StandardOutput.ReadToEnd();
					string error = process.StandardError.ReadToEnd();
					if (process.ExitCode == 0)
						Utils.LogInfo($"Signed: \"{filepath}\"\n{output}");
					else
						Utils.LogError($"Failed to sign: \"{filepath}\"\n{error}");
				}
				Sign(Path.Combine(report.summary.outputPath, "Contents", "Frameworks", "UnityPlayer.dylib"));
			}

			Finish();
		}
	}
}
