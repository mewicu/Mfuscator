using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;

namespace Mfuscator {

	internal static class Utils {

		private static string RemoveTag(this string str, string tag) {
			str = Regex.Replace(str, @$"<{Regex.Escape(tag)}[^>]*>", string.Empty);
			return str.Replace($"</{tag}>", string.Empty);
		}
		public static string Format(object obj) {
			string str = $"<b>[{nameof(Mfuscator)}]</b> {obj}";
			if (Application.isBatchMode)
				// HERE: tags we use
				str = str.RemoveTag("b").RemoveTag("i").RemoveTag("a").RemoveTag("color");
			return str;
		}
		public static void LogInfo(object v) {
			if (!Settings.Object.logInfo)
				return;
			UnityEngine.Debug.Log(Format(v));
		}
		public static void LogWarning(object v) {
			UnityEngine.Debug.LogWarning(Format(v));
		}
		public static void LogError(object v) {
			string message = Format(v);
			UnityEngine.Debug.LogError(message);
			if (BuildPipeline.isBuildingPlayer)
				throw new BuildFailedException(message);
		}
		public static string GetPlayerPrefsKey(string subKey) {
			return $"MFS_{subKey}";
		}
		public static bool TryObtainAccess(string path) {
			bool CheckAccess() {
				// stupid but effective
				string testPath = Path.Combine(path, $"DELETE_ME_{Guid.NewGuid()}");
				string filepath = Path.Combine(testPath, Path.GetRandomFileName());
				try {
					Directory.CreateDirectory(testPath);
					File.WriteAllBytes(filepath, new byte[] { 1 });
					if (File.ReadAllBytes(filepath)[0] != 1)
						throw new Exception();
					File.Move(filepath, filepath + 'a');
					return true;
				}
				catch {
					return false;
				}
				finally {
					try {
						if (File.Exists(filepath + 'a'))
							File.Delete(filepath + 'a');
						if (File.Exists(filepath))
							File.Delete(filepath);
						if (Directory.Exists(testPath))
							Directory.Delete(testPath);
					}
					catch { }
				}
			}
			bool GrantAccess() {
				EditorUtility.DisplayProgressBar(nameof(Mfuscator), "Granting access...", 0f);
				using Process console = new() {
					StartInfo = new() {
						Verb = "runas",
						Arguments = $"/C icacls \"{path}\" /grant %username%:(OI)(CI)F",
						CreateNoWindow = true,
						UseShellExecute = true,
						FileName = "cmd.exe",
						WindowStyle = ProcessWindowStyle.Hidden
					}
				};
				try {
					_ = console.Start();
					console.WaitForExit();
					return true;
				}
				catch (Win32Exception) {
					LogError("Canceled by user");
					return false;
				}
				finally {
					EditorUtility.ClearProgressBar();
				}
			}
			if (!CheckAccess())
				if (Application.platform != RuntimePlatform.WindowsEditor) {
					LogWarning($"The current system user does not have read and write access to \"{path}\" and its subfolders and files");
					return false;
				}
				else if (!GrantAccess())
					return false;
			return true;
		}
	}
}
