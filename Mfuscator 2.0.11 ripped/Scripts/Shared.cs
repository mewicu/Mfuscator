using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mfuscator {

	public static class Shared {

		// NOTE: must be compatible with "netstandard2.1"

		public const int BUILD_NUMBER = 220;

		public enum LogType : byte {
			Info,
			Warning,
			Error
		}
		public enum TargetPlatform : byte {
			Windows,
			Linux,
			macOS,
			Android,
			iOS
		}
		[Serializable]
		public struct Settings {
			[NonSerialized] public string editorVersion;
			[NonSerialized] public string editorPath;
			[NonSerialized] public TargetPlatform targetPlatform;
			[NonSerialized] public string outputPath;
			[NonSerialized] public string metaFilepath;
			public bool removeStringLiterals;
			public bool preserveUnityCrashHandler;
			public bool checkFunctionCalls;
			public bool renameExports;
			public string renameExportsBlacklist;
			public bool removeMonoExports;
			public bool modifyInternalStructures;
			public bool detectProxyLibraries;
			public string detectProxyLibrariesWhitelist;
		}

		public const string SET_LOG_CALLBACK_ENTRY_POINT = "set_log_callback";
		public const string PRE_ENTRY_POINT = "pre";
		public const string POST_ENTRY_POINT = "post";
		public const string CLEAR_ENTRY_POINT = "clear";

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr Allocate<T>(T v) {
			if (typeof(T) == typeof(string))
				return Marshal.StringToCoTaskMemUni(v as string);
			IntPtr result = Marshal.AllocCoTaskMem(Marshal.SizeOf<T>());
			Marshal.StructureToPtr(v, result, false);
			return result;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Free(IntPtr p) {
			Marshal.FreeCoTaskMem(p);
		}

		// from "Bridge.cs"

		// log
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void LogCallback(IntPtr messageP, byte type);
#if UNITY_EDITOR
#pragma warning disable SYSLIB1054
		[DllImport(nameof(Mfuscator), EntryPoint = SET_LOG_CALLBACK_ENTRY_POINT)]
		private static extern void SetLogCallback_Internal(IntPtr p);
		public static void SetLogCallback(LogCallback v) {
			SetLogCallback_Internal(Marshal.GetFunctionPointerForDelegate(v));
		}

		// action
		[DllImport(nameof(Mfuscator), EntryPoint = PRE_ENTRY_POINT)]
		private static extern void Pre_Internal(IntPtr settingsP);
		public static void Pre(Settings settings) {
			IntPtr settingsP = Allocate(settings);
			Pre_Internal(settingsP);
			Free(settingsP);
		}
		[DllImport(nameof(Mfuscator), EntryPoint = POST_ENTRY_POINT)]
		private static extern void Post_Internal(IntPtr settingsP);
		public static void Post(Settings settings) {
			IntPtr settingsP = Allocate(settings);
			Post_Internal(settingsP);
			Free(settingsP);
		}

		// clear
		[DllImport(nameof(Mfuscator), EntryPoint = CLEAR_ENTRY_POINT)]
		private static extern bool Clear_Internal(IntPtr settingsP);
		public static bool Clear(Settings settings) {
			IntPtr settingsP = Allocate(settings);
			bool result = Clear_Internal(settingsP);
			Free(settingsP);
			return result;
		}
#endif
	}
}
