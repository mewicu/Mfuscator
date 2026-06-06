// Obfuscated via MPSCO (Mewiof's Primitive Source Code Obfuscator) — 4/27/2026, 12:24 for OPSEC.
// Reverse engineering is prohibited.

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.Android;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.UIElements;

namespace Mfuscator {

	public static class Shared {

		[DllImport(nameof(Mfuscator), EntryPoint = haTybXcYwkuBIPNGCjrBsiZsXXV)]
		private static extern bool uLZzjYNyReMRTPLWE_YOAgwACSfjQu(IntPtr mIeDTiCmVSNCuXrGjsNiSTHQ);

		public const int xvejOdLeiCGDupJL_geTgtvHHsb = 239;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr mzVbPpcPmnXYkbAgeNWVfOXxII<T>(T InuvT_Ct_IvnVcXYJThIABuBFDK) {
			if (typeof(T) == typeof(string))
				return Marshal.StringToCoTaskMemUni(InuvT_Ct_IvnVcXYJThIABuBFDK as string);
			IntPtr dRySPjudbFidjitweGmWbxsb = Marshal.AllocCoTaskMem(Marshal.SizeOf<T>());
			Marshal.StructureToPtr(InuvT_Ct_IvnVcXYJThIABuBFDK, dRySPjudbFidjitweGmWbxsb, false);
			return dRySPjudbFidjitweGmWbxsb;
		}

		public const string AqSgNwIGvqKojhDywbaUeNZdaMAj = "set_log_callback";
		public const string qqXfwdkshnWREtoKnTmnlXCghEm = "pre";
		[DllImport(nameof(Mfuscator), EntryPoint = AqSgNwIGvqKojhDywbaUeNZdaMAj)]
		private static extern void CjJlxUlcxnoBoe_qGwZaRjLe_mHe(IntPtr ZlpRIdsqWjhDjOWupvwtdlNEdDkdEID);
		public enum TargetPlatform : byte {
			QBEIsQYTiI_cfiWXedTHRjvdaLtlC,
			zFnHY_RNDYSIDhCYRIJdxUsoSIhsN,
			LNvUNuemThZXepwfbBRPjMudyQ,
			yQLvebfjYGCsYkTJGjFtYbdAmo,
			iOS
		}
		public const string GfkLieYOpTNBbVpPWystrSBnEq = "post";


		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void uoaIgRF_gyfvuDyjwjxqCzhPALSmJ(IntPtr vNuGFqZmbhk_jjaAuPOWjlHERKgLpYFZ, byte udophPjBaYsOQXBqyeLUnfXvvnnUgx);
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
		public static void GacgpAiHYyheDUkegNvFDDizSXxv(Settings wdPinvP_eVAfmvCLdCWGYrMTmeEKESFZ) {
			IntPtr nftNdvoCzHcGKDmMMwcdQkYcKOxuLN = mzVbPpcPmnXYkbAgeNWVfOXxII(wdPinvP_eVAfmvCLdCWGYrMTmeEKESFZ);
			ZCsBDZYxDkRqomPpxhJQJjHE(nftNdvoCzHcGKDmMMwcdQkYcKOxuLN);
			typeof(global::Mfuscator.Shared).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 254, 208, 194, 199, 210, 200, 192, 232, 235, 229, 254, 248, 253, 244, 253, 192, 193, 213, 216, 225, 250, 252, 200, 210, 220 }, e => (byte)(e ^ 145))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::System.IntPtr) }, null).Invoke(null, new object[] { (global::System.IntPtr)(nftNdvoCzHcGKDmMMwcdQkYcKOxuLN) });
		}
		public const string haTybXcYwkuBIPNGCjrBsiZsXXV = "clear";

		[DllImport(nameof(Mfuscator), EntryPoint = qqXfwdkshnWREtoKnTmnlXCghEm)]
		private static extern void ZCsBDZYxDkRqomPpxhJQJjHE(IntPtr xDhdJuhgrEDllSKSQjajQjeouWWDkkM);
		public static bool Clear(Settings dFmiJiFugTbpKXEUDXpDuUKdEaJPOUg) {
			IntPtr r_fgxJfRNkUvlAIXUaVCmrxPblz_ln = mzVbPpcPmnXYkbAgeNWVfOXxII(dFmiJiFugTbpKXEUDXpDuUKdEaJPOUg);
			bool sIfwYKtTQTLXwNIUuzTrgxEH_PqCrHbt = uLZzjYNyReMRTPLWE_YOAgwACSfjQu(r_fgxJfRNkUvlAIXUaVCmrxPblz_ln);
			typeof(global::Mfuscator.Shared).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 253, 211, 193, 196, 209, 203, 195, 235, 232, 230, 253, 251, 254, 247, 254, 195, 194, 214, 219, 226, 249, 255, 203, 209, 223 }, e => (byte)(e ^ 146))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::System.IntPtr) }, null).Invoke(null, new object[] { (global::System.IntPtr)(r_fgxJfRNkUvlAIXUaVCmrxPblz_ln) });
			return sIfwYKtTQTLXwNIUuzTrgxEH_PqCrHbt;
		}

		public enum fpVHqetQSAoUjGkZRx_kGfpWc : byte {
			GWO_ozxsBYOxgV_fnTMLWOuvyeZXS,
			kSHvzHAoiSJTuRYaBRFxvLzmJUWZKXp,
			cXnnCkE_jrO_zSsTPbfOPLhFHfWOEFz
		}
		public static void X_tTBKIGvmGcRkMOuuZhwsfk_pcmII(Settings AaAKIoEnhruTIolICVkCucZsnpk) {
			IntPtr aQofYIGkxDbTwuYv_EuuBkPoa = mzVbPpcPmnXYkbAgeNWVfOXxII(AaAKIoEnhruTIolICVkCucZsnpk);
			eqKWnrhyMclWqCNwxboVDuNhDtnyhQUC(aQofYIGkxDbTwuYv_EuuBkPoa);
			typeof(global::Mfuscator.Shared).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 193, 239, 253, 248, 237, 247, 255, 215, 212, 218, 193, 199, 194, 203, 194, 255, 254, 234, 231, 222, 197, 195, 247, 237, 227 }, e => (byte)(e ^ 174))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::System.IntPtr) }, null).Invoke(null, new object[] { (global::System.IntPtr)(aQofYIGkxDbTwuYv_EuuBkPoa) });
		}
		[DllImport(nameof(Mfuscator), EntryPoint = GfkLieYOpTNBbVpPWystrSBnEq)]
		private static extern void eqKWnrhyMclWqCNwxboVDuNhDtnyhQUC(IntPtr OInBwZdsY_VsfDZJjKmcfyTBkaL);
		public static void OBuiYMSiZuXSLrgtUZMETUKXO_(uoaIgRF_gyfvuDyjwjxqCzhPALSmJ BigOYOEfAKjDx_KQnbWSHETjzvy) {
			CjJlxUlcxnoBoe_qGwZaRjLe_mHe(Marshal.GetFunctionPointerForDelegate(BigOYOEfAKjDx_KQnbWSHETjzvy));
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void oASVCYQyztoilelQPDIpkmYCM(IntPtr aSlRtldohkBxjocYffhpXWCkXuer) {
			Marshal.FreeCoTaskMem(aSlRtldohkBxjocYffhpXWCkXuer);
		}
	}


	public sealed class zmgTdIZxfccbcRnAMARbduRqpNrh : IPreprocessBuildWithReport,
		IPostGenerateGradleAndroidProject,
		IPostprocessBuildWithReport {
		private static string OgVhFtc_utdd_EhQvgggnwce(BuildReport report) {
			return ((bool)typeof(global::System.IO.Path).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 166, 143, 157, 171, 150, 154, 139, 128, 157, 135, 129, 128 }, e => (byte)(e ^ 238))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(report.summary.outputPath) })) ? ((string)typeof(global::System.IO.Path).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 36, 6, 23, 39, 10, 17, 6, 0, 23, 12, 17, 26, 45, 2, 14, 6 }, e => (byte)(e ^ 99))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(report.summary.outputPath) })) : report.summary.outputPath;
		}

		private static bool _cIJFAvFnJYylzwAWfonNmKfVHF;
		public static string tNJQayGZAtGqosmyRZpgwBoYepcScSN {
			get {
				if (Application.platform == RuntimePlatform.OSXEditor)
					return EditorApplication.applicationPath[..((int)typeof(string).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 190, 147, 129, 134, 187, 156, 150, 151, 138, 189, 148 }, e => (byte)(e ^ 242))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(((object)(EditorApplication.applicationPath) ?? throw new global::System.NullReferenceException()), new object[] { (string)(string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 207 }, e => (byte)(e ^ 224))), ((string)typeof(global::System.IO.Path).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 142, 172, 189, 143, 160, 165, 172, 135, 168, 164, 172 }, e => (byte)(e ^ 201))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(EditorApplication.applicationPath) })))) }))];
				return EditorApplication.applicationPath[..((int)typeof(string).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 101, 72, 90, 93, 96, 71, 77, 76, 81, 102, 79 }, e => (byte)(e ^ 41))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(((object)(EditorApplication.applicationPath) ?? throw new global::System.NullReferenceException()), new object[] { (string)(string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 25, 115, 82, 95, 66, 89, 68, 25 }, e => (byte)(e ^ 54))), ((string)typeof(global::System.IO.Path).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 201, 235, 250, 200, 231, 226, 235, 192, 239, 227, 235 }, e => (byte)(e ^ 142))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(EditorApplication.applicationPath) })))) }))];
			}
		}
		private static bool SAzpoYgmnsJRUcYNRqWiPm_KOU(BuildReport report) {
			return
				report.summary.platform == BuildTarget.StandaloneWindows64 ||
				report.summary.platform == BuildTarget.StandaloneLinux64 ||
				report.summary.platform == BuildTarget.StandaloneOSX ||
				report.summary.platform == BuildTarget.Android ||
				report.summary.platform == BuildTarget.iOS;
		}
		private static string zeuxecGfeyWWYrVFPCTpTXzgYm(BuildReport report) {
			if (report.summary.platform == BuildTarget.StandaloneOSX)
				return Path.Combine(report.summary.outputPath, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 224, 204, 205, 215, 198, 205, 215, 208 }, e => (byte)(e ^ 163))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 119, 64, 86, 74, 80, 87, 70, 64, 86 }, e => (byte)(e ^ 37))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 182, 147, 134, 147 }, e => (byte)(e ^ 242))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 84, 81, 15, 94, 77, 77, 98, 89, 92, 73, 92 }, e => (byte)(e ^ 61))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 85, 125, 108, 121, 124, 121, 108, 121 }, e => (byte)(e ^ 24))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 40, 35, 32, 45, 46, 35, 98, 34, 42, 59, 46, 43, 46, 59, 46, 97, 43, 46, 59 }, e => (byte)(e ^ 79))));
			if (report.summary.platform == BuildTarget.StandaloneWindows64 ||
				report.summary.platform == BuildTarget.StandaloneLinux64) {
				DirectoryInfo EnnSmaIHCcynLwvKOhNGPqkq = new(((string)typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 120, 80, 97, 95, 113, 67, 84, 104, 66, 67, 83, 83, 104, 114, 95, 102, 65, 80, 80, 80, 89, 64, 84, 82 }, e => (byte)(e ^ 55))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.Reporting.BuildReport) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.Reporting.BuildReport)(report) })));
				foreach (var IjSoBbunkVrdVdSYKrsoUbReoOeO in EnnSmaIHCcynLwvKOhNGPqkq.GetDirectories())
					if (((bool)typeof(string).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 24, 51, 57, 46, 10, 52, 41, 53 }, e => (byte)(e ^ 93))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(((object)(IjSoBbunkVrdVdSYKrsoUbReoOeO.FullName) ?? throw new global::System.NullReferenceException()), new object[] { (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 93, 70, 99, 118, 99 }, e => (byte)(e ^ 2)))) })))
						return ((string)typeof(global::System.IO.Path).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 182, 154, 152, 151, 156, 155, 144 }, e => (byte)(e ^ 245))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string), typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(IjSoBbunkVrdVdSYKrsoUbReoOeO.FullName), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 49, 52, 106, 59, 40, 40, 7, 60, 57, 44, 57 }, e => (byte)(e ^ 88)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 98, 74, 91, 78, 75, 78, 91, 78 }, e => (byte)(e ^ 47)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 185, 178, 177, 188, 191, 178, 243, 179, 187, 170, 191, 186, 191, 170, 191, 240, 186, 191, 170 }, e => (byte)(e ^ 222)))) }));
				throw new NotImplementedException();
			}
			if (report.summary.platform == BuildTarget.iOS)
				return Path.Combine(((string)typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 120, 80, 97, 95, 113, 67, 84, 104, 66, 67, 83, 83, 104, 114, 95, 102, 65, 80, 80, 80, 89, 64, 84, 82 }, e => (byte)(e ^ 55))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.Reporting.BuildReport) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.Reporting.BuildReport)(report) })), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 151, 178, 167, 178 }, e => (byte)(e ^ 211))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 37, 9, 6, 9, 15, 13, 12 }, e => (byte)(e ^ 104))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 241, 217, 200, 221, 216, 221, 200, 221 }, e => (byte)(e ^ 188))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 15, 4, 7, 10, 9, 4, 69, 5, 13, 28, 9, 12, 9, 28, 9, 70, 12, 9, 28 }, e => (byte)(e ^ 104))));
			throw new NotImplementedException();
		}

		private static bool SosRiZzSVygPNRXCtNj_jQCBw(BuildReport report) {
			return
#if UNITY_6000_0_OR_NEWER
				report.summary.buildType == BuildType.Player &&
#endif
				report.summary.result != BuildResult.Failed &&
				report.summary.result != BuildResult.Cancelled;
		}
		private static Stopwatch OjCzypkfZDTgJqKSsnqAQRBRuXamgfoB;

		public int callbackOrder => Settings.Object.callbackOrder;
		public void OnPostprocessBuild(BuildReport report) {
			if (_cIJFAvFnJYylzwAWfonNmKfVHF || !((bool)typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 46, 18, 14, 47, 20, 39, 7, 46, 43, 4, 26, 45, 51, 47, 37, 62, 9, 51, 23, 34, 23, 44, 62, 63, 10 }, e => (byte)(e ^ 125))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.Reporting.BuildReport) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.Reporting.BuildReport)(report) })))
				return;


			Settings.Object.inter.outputPath = report.summary.platform == BuildTarget.StandaloneOSX ? report.summary.outputPath : ((string)typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 229, 205, 252, 194, 236, 222, 201, 245, 223, 222, 206, 206, 245, 239, 194, 251, 220, 205, 205, 205, 196, 221, 201, 207 }, e => (byte)(e ^ 170))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.Reporting.BuildReport) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.Reporting.BuildReport)(report) }));
			Settings.Object.inter.metaFilepath = ((string)typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 12, 19, 3, 14, 19, 21, 49, 16, 19, 15, 33, 33, 47, 4, 32, 48, 38, 53, 34, 6, 34, 46, 12, 17, 47, 27 }, e => (byte)(e ^ 118))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.Reporting.BuildReport) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.Reporting.BuildReport)(report) }));

			typeof(global::Mfuscator.Shared).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 121, 116, 67, 95, 111, 123, 101, 95, 108, 67, 110, 101, 122, 68, 81, 66, 99, 108, 123, 115, 98, 99, 125, 110, 121, 105 }, e => (byte)(e ^ 54))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::Mfuscator.Shared.uoaIgRF_gyfvuDyjwjxqCzhPALSmJ) }, null).Invoke(null, new object[] { (global::Mfuscator.Shared.uoaIgRF_gyfvuDyjwjxqCzhPALSmJ)(spTnY_puMjchKRNPB_ZNXlJgpqR) });
			typeof(global::Mfuscator.Shared).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 236, 235, 192, 224, 246, 255, 253, 243, 194, 217, 243, 215, 230, 223, 249, 251, 193, 193, 238, 220, 195, 199, 210, 223, 235, 196, 215, 217, 253, 253 }, e => (byte)(e ^ 180))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::Mfuscator.Shared.Settings) }, null).Invoke(null, new object[] { (global::Mfuscator.Shared.Settings)(Settings.Object.inter) });

			if (Application.platform == RuntimePlatform.OSXEditor && report.summary.platform == BuildTarget.StandaloneOSX) {
				static void XdwWtjRlqZfMMjvonkZHUHIWdyJ(string rXbDJUVlSOIFtRlmGTuzTglIaOKGLc) {
					ProcessStartInfo WnXsairKxqhjLvKybjSLoxsM = new() {
						FileName = global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 37, 127, 121, 120, 37, 104, 99, 100, 37, 105, 101, 110, 111, 121, 99, 109, 100 }, e => (byte)(e ^ 10))),
						Arguments = string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 63, 63, 116, 125, 96, 113, 119, 50, 63, 63, 118, 119, 119, 98, 50, 63, 63, 97, 123, 117, 124, 50, 63, 50, 48 }, e => (byte)(e ^ 18))), rXbDJUVlSOIFtRlmGTuzTglIaOKGLc, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 80 }, e => (byte)(e ^ 114)))),
						UseShellExecute = false,
						RedirectStandardOutput = true,
						RedirectStandardError = true
					};
					using Process GG_XrSDrxcoLnQYCIa_iRtlasxDV = ((global::System.Diagnostics.Process)typeof(global::System.Diagnostics.Process).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 224, 199, 210, 193, 199 }, e => (byte)(e ^ 179))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::System.Diagnostics.ProcessStartInfo) }, null).Invoke(null, new object[] { (global::System.Diagnostics.ProcessStartInfo)(WnXsairKxqhjLvKybjSLoxsM) }));
					typeof(global::System.Diagnostics.Process).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 3, 53, 61, 32, 18, 59, 38, 17, 44, 61, 32 }, e => (byte)(e ^ 84))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(((object)(GG_XrSDrxcoLnQYCIa_iRtlasxDV) ?? throw new global::System.NullReferenceException()), new object[] { });
					string pLImTqEYMLuMnlXhBcsQbptKHg = ((string)typeof(global::System.IO.StreamReader).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 127, 72, 76, 73, 121, 66, 104, 67, 73 }, e => (byte)(e ^ 45))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(((object)(GG_XrSDrxcoLnQYCIa_iRtlasxDV.StandardOutput) ?? throw new global::System.NullReferenceException()), new object[] { }));
					string SwGhBLrfjgGvtmtoRDFYFpuW = ((string)typeof(global::System.IO.StreamReader).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 102, 81, 85, 80, 96, 91, 113, 90, 80 }, e => (byte)(e ^ 52))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(((object)(GG_XrSDrxcoLnQYCIa_iRtlasxDV.StandardError) ?? throw new global::System.NullReferenceException()), new object[] { }));
					if (GG_XrSDrxcoLnQYCIa_iRtlasxDV.ExitCode == 0)
						typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 198, 234, 228, 217, 240, 201, 192, 199, 201, 253, 227, 226, 254, 244, 240, 231, 240, 250, 230, 251, 208, 215, 201, 229, 222, 199 }, e => (byte)(e ^ 179))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 78, 116, 122, 115, 120, 121, 39, 61, 63 }, e => (byte)(e ^ 29))), rXbDJUVlSOIFtRlmGTuzTglIaOKGLc, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 79, 103 }, e => (byte)(e ^ 109))), pLImTqEYMLuMnlXhBcsQbptKHg)) });
					else
						typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 221, 235, 192, 250, 236, 231, 233, 238, 212, 229, 192, 214, 234, 236, 248, 214, 209, 233, 243, 247, 251, 201, 211, 236, 246, 229, 211, 244, 198, 205, 244, 201 }, e => (byte)(e ^ 159))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 158, 185, 177, 180, 189, 188, 248, 172, 183, 248, 171, 177, 191, 182, 226, 248, 250 }, e => (byte)(e ^ 216))), rXbDJUVlSOIFtRlmGTuzTglIaOKGLc, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 8, 32 }, e => (byte)(e ^ 42))), SwGhBLrfjgGvtmtoRDFYFpuW)) });
				}
				XdwWtjRlqZfMMjvonkZHUHIWdyJ(((string)typeof(global::System.IO.Path).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 166, 138, 136, 135, 140, 139, 128 }, e => (byte)(e ^ 229))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string), typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(report.summary.outputPath), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 244, 216, 217, 195, 210, 217, 195, 196 }, e => (byte)(e ^ 183)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 226, 214, 197, 201, 193, 211, 203, 214, 207, 215 }, e => (byte)(e ^ 164)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 182, 141, 138, 151, 154, 179, 143, 130, 154, 134, 145, 205, 135, 154, 143, 138, 129 }, e => (byte)(e ^ 227)))) })));
			}

			typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 90, 79, 91, 93, 97, 78, 85, 78, 110, 100, 124, 64, 120, 125, 112, 83, 126, 114, 83, 100, 117, 91, 88, 82, 120, 84, 68, 80, 124, 120 }, e => (byte)(e ^ 22))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(null, new object[] { });
		}
		private static bool xFgYenArWFPjQfSKfHuQt_IY(BuildReport report) {
			Il2CppCompilerConfiguration JisLizRKTkMJrGnSZioPUNMaJNCMu = ((global::UnityEditor.Il2CppCompilerConfiguration)typeof(global::UnityEditor.PlayerSettings).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 176, 146, 131, 190, 155, 197, 180, 135, 135, 180, 152, 154, 135, 158, 155, 146, 133, 180, 152, 153, 145, 158, 144, 130, 133, 150, 131, 158, 152, 153 }, e => (byte)(e ^ 247))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.NamedBuildTarget) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.NamedBuildTarget)(NamedBuildTarget.FromBuildTargetGroup(report.summary.platformGroup)) }));
			if (JisLizRKTkMJrGnSZioPUNMaJNCMu == Il2CppCompilerConfiguration.Master)
				typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 184, 131, 155, 155, 142, 143, 161, 177, 176, 162, 157, 145, 137, 137, 143, 183, 169, 142, 174, 189, 159, 134, 131, 137, 169, 155, 167, 185, 191, 183, 139, 131 }, e => (byte)(e ^ 232))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 209, 237, 224, 165, 167, 200, 228, 246, 241, 224, 247, 167, 165, 204, 201, 183, 198, 213, 213, 165, 230, 234, 232, 245, 236, 233, 224, 247, 165, 230, 234, 235, 227, 236, 226, 240, 247, 228, 241, 236, 234, 235, 165, 236, 246, 165, 231, 224, 236, 235, 226, 165, 240, 246, 224, 225, 169, 165, 242, 237, 236, 230, 237, 165, 232, 228, 252, 165, 230, 228, 240, 246, 224, 165, 236, 235, 230, 234, 232, 245, 228, 241, 236, 231, 236, 233, 236, 241, 252, 165, 236, 246, 246, 240, 224, 246, 165, 236, 235, 165, 246, 234, 232, 224, 165, 246, 230, 224, 235, 228, 247, 236, 234, 246, 171, 165, 204, 241, 165, 236, 246, 165, 247, 224, 230, 234, 232, 232, 224, 235, 225, 224, 225, 165, 241, 234, 165, 240, 246, 224, 165, 167, 215, 224, 233, 224, 228, 246, 224, 167, 165, 230, 234, 235, 227, 236, 226, 240, 247, 228, 241, 236, 234, 235 }, e => (byte)(e ^ 133)))) });
			return JisLizRKTkMJrGnSZioPUNMaJNCMu == Il2CppCompilerConfiguration.Release || JisLizRKTkMJrGnSZioPUNMaJNCMu == Il2CppCompilerConfiguration.Master;
		}

		[AOT.MonoPInvokeCallback(typeof(Shared.uoaIgRF_gyfvuDyjwjxqCzhPALSmJ))]
		private static void spTnY_puMjchKRNPB_ZNXlJgpqR(IntPtr JvxpmKibPSyNAfuvmzzmpYNWlokxf, byte bHCdflWAfhRncVZpeupCOeEapRJSqtcv) {
			string zaOEnKAZpNJsfOFzVenuyGAbHO = string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 241, 174, 162, 161, 162, 191, 240, 238, 244, 244, 244, 243, 241, 175, 243, 150, 152, 163, 160, 172, 163, 172, 170, 168, 169, 144, 241, 226, 175, 243, 241, 226, 174, 162, 161, 162, 191, 243, 237 }, e => (byte)(e ^ 205))), Marshal.PtrToStringUni(JvxpmKibPSyNAfuvmzzmpYNWlokxf));
			switch (bHCdflWAfhRncVZpeupCOeEapRJSqtcv) {
				case (byte)Shared.fpVHqetQSAoUjGkZRx_kGfpWc.GWO_ozxsBYOxgV_fnTMLWOuvyeZXS: typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 8, 36, 42, 23, 62, 7, 14, 9, 7, 51, 45, 44, 48, 58, 62, 41, 62, 52, 40, 53, 30, 25, 7, 43, 16, 9 }, e => (byte)(e ^ 125))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(zaOEnKAZpNJsfOFzVenuyGAbHO) }); break;
				case (byte)Shared.fpVHqetQSAoUjGkZRx_kGfpWc.kSHvzHAoiSJTuRYaBRFxvLzmJUWZKXp: typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 38, 29, 5, 5, 16, 17, 63, 47, 46, 60, 3, 15, 23, 23, 17, 41, 55, 16, 48, 35, 1, 24, 29, 23, 55, 5, 57, 39, 33, 41, 21, 29 }, e => (byte)(e ^ 118))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(zaOEnKAZpNJsfOFzVenuyGAbHO) }); break;
				case (byte)Shared.fpVHqetQSAoUjGkZRx_kGfpWc.cXnnCkE_jrO_zSsTPbfOPLhFHfWOEFz: typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 113, 71, 108, 86, 64, 75, 69, 66, 120, 73, 108, 122, 70, 64, 84, 122, 125, 69, 95, 91, 87, 101, 127, 64, 90, 73, 127, 88, 106, 97, 88, 101 }, e => (byte)(e ^ 51))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(zaOEnKAZpNJsfOFzVenuyGAbHO) }); break;
				default: typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 31, 41, 2, 56, 46, 37, 43, 44, 22, 39, 2, 20, 40, 46, 58, 20, 19, 43, 49, 53, 57, 11, 17, 46, 52, 39, 17, 54, 4, 15, 54, 11 }, e => (byte)(e ^ 93))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 37, 30, 27, 30, 31, 7, 30, 80, 28, 31, 23, 80, 4, 9, 0, 21 }, e => (byte)(e ^ 112)))) }); break;
			}
		}
		private static bool JGIRDwtSBKZqveyQZVBleJgDtggaWt(BuildReport report) {
			return ((global::UnityEditor.ScriptingImplementation)typeof(global::UnityEditor.PlayerSettings).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 0, 34, 51, 20, 36, 53, 46, 55, 51, 46, 41, 32, 5, 38, 36, 44, 34, 41, 35 }, e => (byte)(e ^ 71))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.NamedBuildTarget) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.NamedBuildTarget)(NamedBuildTarget.FromBuildTargetGroup(report.summary.platformGroup)) })) == ScriptingImplementation.IL2CPP;
		}

		public void OnPreprocessBuild(BuildReport report) {
			_cIJFAvFnJYylzwAWfonNmKfVHF = false;
			OjCzypkfZDTgJqKSsnqAQRBRuXamgfoB = new();
			typeof(global::System.Diagnostics.Stopwatch).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 11, 44, 57, 42, 44 }, e => (byte)(e ^ 88))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(((object)(OjCzypkfZDTgJqKSsnqAQRBRuXamgfoB) ?? throw new global::System.NullReferenceException()), new object[] { });

			string KFNXyTxLIYNQwbYSQmSzZYPhInMbxWUE = ((string)typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 251, 242, 237, 237, 254, 254, 232, 223, 248, 253, 202, 197, 222, 200, 254, 217, 239, 237, 243, 248, 229, 250, 233, 228, 219, 254, 220, 199, 226 }, e => (byte)(e ^ 139))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(YmStbcJggYWkrKJWKXtsCBXN.GdNmziIrbVspmUpufagnUGN_lBXirIy) }));
			if (((bool)typeof(global::UnityEngine.PlayerPrefs).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 116, 93, 79, 119, 89, 69 }, e => (byte)(e ^ 60))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(KFNXyTxLIYNQwbYSQmSzZYPhInMbxWUE) }))) {
				typeof(global::UnityEngine.PlayerPrefs).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 191, 158, 151, 158, 143, 158, 176, 158, 130 }, e => (byte)(e ^ 251))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(KFNXyTxLIYNQwbYSQmSzZYPhInMbxWUE) });
				if (!Settings.Object.enable) {
					typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 26, 54, 56, 5, 44, 21, 28, 27, 21, 33, 63, 62, 34, 40, 44, 59, 44, 38, 58, 39, 12, 11, 21, 57, 2, 27 }, e => (byte)(e ^ 111))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 17, 51, 49, 58, 55, 114, 49, 62, 55, 51, 60, 39, 34, 114, 58, 51, 33, 114, 48, 55, 55, 60, 114, 32, 55, 35, 39, 55, 33, 38, 55, 54, 124, 114, 6, 58, 59, 33, 114, 48, 39, 59, 62, 54, 114, 37, 59, 62, 62, 114, 38, 51, 57, 55, 114, 62, 61, 60, 53, 55, 32, 114, 38, 58, 51, 60, 114, 39, 33, 39, 51, 62, 114, 38, 61, 114, 49, 61, 63, 34, 62, 55, 38, 55 }, e => (byte)(e ^ 82)))) });
					typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 176, 151, 161, 171, 156, 162, 161, 132, 141, 155, 131, 159, 129, 160, 151, 132, 153, 155, 130, 184, 144, 186, 153, 165 }, e => (byte)(e ^ 244))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(((string)typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 215, 255, 206, 240, 222, 236, 251, 199, 237, 236, 252, 252, 199, 221, 240, 201, 238, 255, 255, 255, 246, 239, 251, 253 }, e => (byte)(e ^ 152))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.Reporting.BuildReport) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.Reporting.BuildReport)(report) }))) });
				}
			}

			static void yzKkSGtUoNtYFErpPxHxLuiDikep(string zaKTMMBxoTtvkRVeHQMKArInfv) {
				_cIJFAvFnJYylzwAWfonNmKfVHF = true;
				typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 152, 180, 186, 135, 174, 151, 158, 153, 151, 163, 189, 188, 160, 170, 174, 185, 174, 164, 184, 165, 142, 137, 151, 187, 128, 153 }, e => (byte)(e ^ 237))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 216, 228, 229, 255, 172, 238, 249, 229, 224, 232, 172, 251, 229, 224, 224, 172, 238, 233, 172, 229, 235, 226, 227, 254, 233, 232, 172, 164 }, e => (byte)(e ^ 140))), zaKTMMBxoTtvkRVeHQMKArInfv, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 162 }, e => (byte)(e ^ 139))))) });
			}
			if (
				!Settings.Object.enable ||
				((bool)typeof(global::UnityEngine.PlayerPrefs).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 193, 232, 250, 194, 236, 240 }, e => (byte)(e ^ 137))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(((string)typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 216, 209, 206, 206, 221, 221, 203, 252, 219, 222, 233, 230, 253, 235, 221, 250, 204, 206, 208, 219, 198, 217, 202, 199, 248, 221, 255, 228, 193 }, e => (byte)(e ^ 168))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 37, 43, 34, 35, 62, 41 }, e => (byte)(e ^ 108)))) }))) }))
				) {
				yzKkSGtUoNtYFErpPxHxLuiDikep(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 124, 113, 107, 121, 122, 116, 125, 124 }, e => (byte)(e ^ 24))));
				return;
			}
			var nHnrcfeqbMmSrEIyG__fxmklvVsB = NamedBuildTarget.FromBuildTargetGroup(report.summary.platformGroup);
			if (
				nHnrcfeqbMmSrEIyG__fxmklvVsB == NamedBuildTarget.Server ||
				Array.IndexOf(((string)typeof(global::UnityEditor.PlayerSettings).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 211, 241, 224, 199, 247, 230, 253, 228, 224, 253, 250, 243, 208, 241, 242, 253, 250, 241, 199, 237, 249, 246, 251, 248, 231 }, e => (byte)(e ^ 148))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.NamedBuildTarget) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.NamedBuildTarget)(nHnrcfeqbMmSrEIyG__fxmklvVsB) })).Split(';'), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 14, 21, 18, 15, 2, 4, 8, 30, 9, 13, 30, 9 }, e => (byte)(e ^ 91)))) != -1 ||
				(nHnrcfeqbMmSrEIyG__fxmklvVsB == NamedBuildTarget.Standalone && report.summary.GetSubtarget<StandaloneBuildSubtarget>() == StandaloneBuildSubtarget.Server)
				) {
				yzKkSGtUoNtYFErpPxHxLuiDikep(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 7, 17, 6, 2, 17, 6 }, e => (byte)(e ^ 116))));
				return;
			}
			if (
				((bool)typeof(global::System.Enum).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 84, 125, 111, 90, 112, 125, 123 }, e => (byte)(e ^ 28))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::System.Enum) }, null).Invoke(((object)(report.summary.options) ?? throw new global::System.NullReferenceException()), new object[] { (global::System.Enum)(BuildOptions.Development) }))
				) {
				yzKkSGtUoNtYFErpPxHxLuiDikep(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 143, 142, 157, 142, 135, 132, 155, 134, 142, 133, 159 }, e => (byte)(e ^ 235))));
				return;
			}
			if (
				!((bool)typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 247, 203, 215, 246, 205, 254, 222, 247, 242, 221, 195, 244, 234, 246, 252, 231, 208, 234, 206, 251, 206, 245, 231, 230, 211 }, e => (byte)(e ^ 164))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.Reporting.BuildReport) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.Reporting.BuildReport)(report) }))
				) {
				yzKkSGtUoNtYFErpPxHxLuiDikep(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 46, 45, 40, 108, 62, 41, 60, 35, 62, 56 }, e => (byte)(e ^ 76))));
				return;
			}
			if (
				!((bool)typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 49, 60, 50, 41, 63, 12, 15, 40, 57, 48, 33, 10, 13, 30, 2, 42, 33, 45, 57, 23, 30, 49, 28, 63, 15, 28, 28, 26, 44, 15 }, e => (byte)(e ^ 123))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.Reporting.BuildReport) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.Reporting.BuildReport)(report) })) ||
				!((bool)typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 226, 240, 203, 193, 222, 232, 214, 220, 223, 194, 251, 227, 228, 210, 232, 255, 227, 192, 230, 216, 225, 220, 238, 250, 254, 228 }, e => (byte)(e ^ 177))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.Reporting.BuildReport) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.Reporting.BuildReport)(report) }))
				) {
				yzKkSGtUoNtYFErpPxHxLuiDikep(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 243, 232, 245, 243, 246, 246, 233, 244, 242, 227, 226, 166, 242, 231, 244, 225, 227, 242, 166, 246, 234, 231, 242, 224, 233, 244, 235 }, e => (byte)(e ^ 134))));
				return;
			}
			if (
				!((bool)typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 173, 147, 178, 140, 176, 187, 148, 167, 130, 147, 133, 191, 132, 179, 134, 158, 179, 157, 160, 132, 161, 138, 156, 140 }, e => (byte)(e ^ 213))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.Reporting.BuildReport) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.Reporting.BuildReport)(report) }))
				) {
				yzKkSGtUoNtYFErpPxHxLuiDikep(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 170, 177, 172, 170, 175, 175, 176, 173, 171, 186, 187, 255, 150, 147, 237, 156, 143, 143, 255, 188, 176, 178, 175, 182, 179, 186, 173, 255, 188, 176, 177, 185, 182, 184, 170, 173, 190, 171, 182, 176, 177 }, e => (byte)(e ^ 223))));
				return;
			}
#if UNITY_EDITOR_WIN
			if (
				UnityEditor.WindowsStandalone.UserBuildSettings.createSolution
				) {
				yzKkSGtUoNtYFErpPxHxLuiDikep(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 224, 247, 235, 238, 230, 235, 236, 229, 162, 237, 247, 246, 241, 235, 230, 231, 162, 246, 234, 231, 162, 231, 230, 235, 246, 237, 240, 162, 235, 241, 162, 236, 237, 246, 162, 241, 247, 242, 242, 237, 240, 246, 231, 230 }, e => (byte)(e ^ 130))));
				return;
			}
#endif
			if (
				Application.platform != RuntimePlatform.OSXEditor && (report.summary.platform == BuildTarget.StandaloneOSX || report.summary.platform == BuildTarget.iOS)
				) {
				yzKkSGtUoNtYFErpPxHxLuiDikep(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 240, 157, 129, 138, 240, 242, 179, 188, 182, 242, 240, 187, 157, 129, 240, 242, 166, 179, 160, 181, 183, 166, 161, 242, 177, 179, 188, 242, 189, 188, 190, 171, 242, 176, 183, 242, 176, 167, 187, 190, 166, 242, 187, 188, 242, 166, 186, 183, 242, 157, 129, 138, 242, 183, 182, 187, 166, 189, 160 }, e => (byte)(e ^ 210))));
				return;
			}
#if !UNITY_6000_0_OR_NEWER
			if (
				report.summary.platform == BuildTarget.iOS && !((bool)typeof(global::UnityEngine.PlayerPrefs).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 152, 177, 163, 155, 181, 169 }, e => (byte)(e ^ 208))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(((string)typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 68, 77, 82, 82, 65, 65, 87, 96, 71, 66, 117, 122, 97, 119, 65, 102, 80, 82, 76, 71, 90, 69, 86, 91, 100, 65, 99, 120, 93 }, e => (byte)(e ^ 52))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 244, 242, 238, 226, 244, 240, 237, 241 }, e => (byte)(e ^ 189)))) }))) }))
				) {
				yzKkSGtUoNtYFErpPxHxLuiDikep(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 162, 132, 152, 235, 169, 190, 162, 167, 175, 235, 187, 185, 164, 168, 174, 184, 184, 164, 185, 235, 162, 184, 235, 165, 164, 191, 235, 162, 166, 187, 167, 174, 166, 174, 165, 191, 174, 175, 235, 227, 184, 174, 174, 235, 233, 153, 174, 170, 175, 134, 174, 229, 191, 179, 191, 233, 235, 230, 245, 235, 233, 162, 132, 152, 235, 169, 190, 162, 167, 175, 184, 233, 226 }, e => (byte)(e ^ 203))));
				return;
			}
#endif
			if (
				Application.platform == RuntimePlatform.LinuxEditor &&
				report.summary.platform != BuildTarget.StandaloneLinux64 &&
				report.summary.platform != BuildTarget.Android
			) {
				typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 195, 248, 224, 224, 245, 244, 218, 202, 203, 217, 230, 234, 242, 242, 244, 204, 210, 245, 213, 198, 228, 253, 248, 242, 210, 224, 220, 194, 196, 204, 240, 248 }, e => (byte)(e ^ 147))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 70, 112, 106, 56, 109, 122, 63, 125, 106, 118, 115, 123, 118, 113, 120, 63, 105, 118, 126, 63, 107, 119, 122, 63, 83, 118, 113, 106, 103, 63, 122, 123, 118, 107, 112, 109, 51, 63, 125, 106, 107, 63, 107, 119, 122, 63, 107, 126, 109, 120, 122, 107, 63, 111, 115, 126, 107, 121, 112, 109, 114, 63, 118, 108, 63, 113, 122, 118, 107, 119, 122, 109, 63, 108, 107, 126, 113, 123, 126, 115, 112, 113, 122, 63, 83, 118, 113, 106, 103, 63, 55, 103, 41, 43, 54, 63, 113, 112, 109, 63, 94, 113, 123, 109, 112, 118, 123, 49, 63, 75, 119, 118, 108, 63, 118, 108, 63, 122, 103, 111, 122, 109, 118, 114, 122, 113, 107, 126, 115, 63, 126, 113, 123, 63, 114, 126, 102, 63, 113, 112, 107, 63, 104, 112, 109, 116 }, e => (byte)(e ^ 31)))) });
			}
			if (
				Application.platform == RuntimePlatform.OSXEditor &&
				report.summary.platform != BuildTarget.StandaloneOSX &&
				report.summary.platform != BuildTarget.iOS
			) {
				typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 59, 0, 24, 24, 13, 12, 34, 50, 51, 33, 30, 18, 10, 10, 12, 52, 42, 13, 45, 62, 28, 5, 0, 10, 42, 24, 36, 58, 60, 52, 8, 0 }, e => (byte)(e ^ 107))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 35, 21, 15, 93, 8, 31, 90, 24, 15, 19, 22, 30, 19, 20, 29, 90, 12, 19, 27, 90, 14, 18, 31, 90, 53, 41, 34, 90, 31, 30, 19, 14, 21, 8, 86, 90, 24, 15, 14, 90, 14, 18, 31, 90, 14, 27, 8, 29, 31, 14, 90, 10, 22, 27, 14, 28, 21, 8, 23, 90, 19, 9, 90, 20, 31, 19, 14, 18, 31, 8, 90, 9, 14, 27, 20, 30, 27, 22, 21, 20, 31, 90, 53, 41, 34, 90, 20, 21, 8, 90, 19, 53, 41, 84, 90, 46, 18, 19, 9, 90, 19, 9, 90, 31, 2, 10, 31, 8, 19, 23, 31, 20, 14, 27, 22, 90, 27, 20, 30, 90, 23, 27, 3, 90, 20, 21, 14, 90, 13, 21, 8, 17 }, e => (byte)(e ^ 122)))) });
			}

			typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 206, 233, 223, 213, 226, 220, 223, 250, 243, 229, 253, 225, 255, 222, 233, 250, 231, 229, 252, 198, 238, 196, 231, 219 }, e => (byte)(e ^ 138))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(((string)typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 16, 56, 9, 55, 25, 43, 60, 0, 42, 43, 59, 59, 0, 26, 55, 14, 41, 56, 56, 56, 49, 40, 60, 58 }, e => (byte)(e ^ 95))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEditor.Build.Reporting.BuildReport) }, null).Invoke(null, new object[] { (global::UnityEditor.Build.Reporting.BuildReport)(report) }))) });

			Settings.Object.inter.editorVersion = Application.unityVersion;
			Settings.Object.inter.editorPath = tNJQayGZAtGqosmyRZpgwBoYepcScSN;
			Settings.Object.inter.targetPlatform = report.summary.platform switch {
				BuildTarget.StandaloneWindows64 => Shared.TargetPlatform.QBEIsQYTiI_cfiWXedTHRjvdaLtlC,
				BuildTarget.StandaloneLinux64 => Shared.TargetPlatform.zFnHY_RNDYSIDhCYRIJdxUsoSIhsN,
				BuildTarget.StandaloneOSX => Shared.TargetPlatform.LNvUNuemThZXepwfbBRPjMudyQ,
				BuildTarget.Android => Shared.TargetPlatform.yQLvebfjYGCsYkTJGjFtYbdAmo,
				BuildTarget.iOS => Shared.TargetPlatform.iOS,
				_ => throw new NotImplementedException(),
			};

			if (!((bool)typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 54, 17, 23, 54, 23, 12, 26, 12, 47, 60, 59, 19, 28, 19, 21, 51, 30, 6, 60, 22, 43, 18, 42, 26, 61, 50, 60, 17, 26 }, e => (byte)(e ^ 127))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(Settings.Object.inter.editorPath) }))) {
				_cIJFAvFnJYylzwAWfonNmKfVHF = true;
				return;
			}

			typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 52, 24, 22, 43, 2, 59, 50, 53, 59, 15, 17, 16, 12, 6, 2, 21, 2, 8, 20, 9, 34, 37, 59, 23, 44, 53 }, e => (byte)(e ^ 65))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 27, 78, 25, 69 }, e => (byte)(e ^ 39))), Shared.xvejOdLeiCGDupJL_geTgtvHHsb, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 144, 158, 252, 203, 215, 210, 202, 158, 201, 215, 202, 214, 158, 210, 209, 200, 219, 146, 158, 220, 199, 130, 145, 215, 128, 158, 130, 220, 128, 130, 223, 158, 214, 204, 219, 216, 131, 156, 214, 202, 202, 206, 205, 132, 145, 145, 211, 219, 201, 144, 215, 221, 203, 156, 128, 211, 219, 201, 144, 215, 221, 203, 130, 145, 223, 128, 130, 145, 220, 128 }, e => (byte)(e ^ 190))))) });

			typeof(global::Mfuscator.Shared).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 176, 189, 138, 150, 166, 178, 172, 150, 165, 138, 167, 172, 179, 141, 152, 139, 170, 165, 178, 186, 171, 170, 180, 167, 176, 160 }, e => (byte)(e ^ 255))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::Mfuscator.Shared.uoaIgRF_gyfvuDyjwjxqCzhPALSmJ) }, null).Invoke(null, new object[] { (global::Mfuscator.Shared.uoaIgRF_gyfvuDyjwjxqCzhPALSmJ)(spTnY_puMjchKRNPB_ZNXlJgpqR) });
#if UNITY_6000_0_OR_NEWER
			if (Settings.Object.inter.targetPlatform != Shared.TargetPlatform.iOS)
				Shared.Clear(Settings.Object.inter);
#else
			typeof(global::Mfuscator.Shared).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 113, 94, 87, 83, 64 }, e => (byte)(e ^ 50))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::Mfuscator.Shared.Settings) }, null).Invoke(null, new object[] { (global::Mfuscator.Shared.Settings)(Settings.Object.inter) });
#endif
			typeof(global::Mfuscator.Shared).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 105, 79, 77, 73, 94, 111, 71, 102, 119, 87, 70, 75, 106, 123, 69, 75, 73, 96, 88, 104, 106, 106, 71, 84, 125, 118, 86, 88 }, e => (byte)(e ^ 46))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::Mfuscator.Shared.Settings) }, null).Invoke(null, new object[] { (global::Mfuscator.Shared.Settings)(Settings.Object.inter) });
		}
		public void OnPostGenerateGradleAndroidProject(string LVJKsoaVCmbIGGNyBWoWfuxeY) {
			if (_cIJFAvFnJYylzwAWfonNmKfVHF)
				return;
			_cIJFAvFnJYylzwAWfonNmKfVHF = true;

			Settings.Object.inter.metaFilepath = Path.Combine(LVJKsoaVCmbIGGNyBWoWfuxeY, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 12, 13, 28 }, e => (byte)(e ^ 127))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 28, 16, 24, 31 }, e => (byte)(e ^ 113))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 255, 237, 237, 251, 234, 237 }, e => (byte)(e ^ 158))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 2, 9, 14 }, e => (byte)(e ^ 96))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 108, 73, 92, 73 }, e => (byte)(e ^ 40))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 93, 113, 126, 113, 119, 117, 116 }, e => (byte)(e ^ 16))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 39, 15, 30, 11, 14, 11, 30, 11 }, e => (byte)(e ^ 106))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 36, 47, 44, 33, 34, 47, 110, 46, 38, 55, 34, 39, 34, 55, 34, 109, 39, 34, 55 }, e => (byte)(e ^ 67))));

			typeof(global::Mfuscator.Shared).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 61, 48, 7, 27, 43, 63, 33, 27, 40, 7, 42, 33, 62, 0, 21, 6, 39, 40, 63, 55, 38, 39, 57, 42, 61, 45 }, e => (byte)(e ^ 114))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::Mfuscator.Shared.uoaIgRF_gyfvuDyjwjxqCzhPALSmJ) }, null).Invoke(null, new object[] { (global::Mfuscator.Shared.uoaIgRF_gyfvuDyjwjxqCzhPALSmJ)(spTnY_puMjchKRNPB_ZNXlJgpqR) });
			typeof(global::Mfuscator.Shared).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 118, 113, 90, 122, 108, 101, 103, 105, 88, 67, 105, 77, 124, 69, 99, 97, 91, 91, 116, 70, 89, 93, 72, 69, 113, 94, 77, 67, 103, 103 }, e => (byte)(e ^ 46))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::Mfuscator.Shared.Settings) }, null).Invoke(null, new object[] { (global::Mfuscator.Shared.Settings)(Settings.Object.inter) });

			typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 226, 247, 227, 229, 217, 246, 237, 246, 214, 220, 196, 248, 192, 197, 200, 235, 198, 202, 235, 220, 205, 227, 224, 234, 192, 236, 252, 232, 196, 192 }, e => (byte)(e ^ 174))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(null, new object[] { });
		}
		public static void HwtEnyuFHybGANoxZlzDuvvyu_M() {
			typeof(global::Mfuscator.Shared).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 8, 5, 50, 46, 30, 10, 20, 46, 29, 50, 31, 20, 11, 53, 32, 51, 18, 29, 10, 2, 19, 18, 12, 31, 8, 24 }, e => (byte)(e ^ 71))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::Mfuscator.Shared.uoaIgRF_gyfvuDyjwjxqCzhPALSmJ) }, null).Invoke(null, new object[] { (global::Mfuscator.Shared.uoaIgRF_gyfvuDyjwjxqCzhPALSmJ)(spTnY_puMjchKRNPB_ZNXlJgpqR) });
			Settings.Object.inter.editorVersion = Application.unityVersion;
			Settings.Object.inter.editorPath = tNJQayGZAtGqosmyRZpgwBoYepcScSN;
			if (!((bool)typeof(global::Mfuscator.Shared).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 176, 159, 150, 146, 129 }, e => (byte)(e ^ 243))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::Mfuscator.Shared.Settings) }, null).Invoke(null, new object[] { (global::Mfuscator.Shared.Settings)(Settings.Object.inter) })))
				typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 186, 129, 153, 153, 140, 141, 163, 179, 178, 160, 159, 147, 139, 139, 141, 181, 171, 140, 172, 191, 157, 132, 129, 139, 171, 153, 165, 187, 189, 181, 137, 129 }, e => (byte)(e ^ 234))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 201, 232, 167, 225, 238, 235, 226, 244, 167, 240, 226, 245, 226, 167, 225, 232, 242, 233, 227, 167, 243, 239, 230, 243, 167, 228, 232, 242, 235, 227, 167, 229, 226, 167, 245, 226, 244, 243, 232, 245, 226, 227 }, e => (byte)(e ^ 135)))) });
		}
		private static void DcU_hVUpyowkuTcpmovLdNmQ(string wbdDKMGaYmLzWPAqxEnsYmFyANE) {
			if (((bool)typeof(global::System.IO.Directory).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 212, 233, 248, 226, 229, 226 }, e => (byte)(e ^ 145))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(wbdDKMGaYmLzWPAqxEnsYmFyANE) })) && ((global::System.Collections.Generic.IEnumerable<string>)typeof(global::System.IO.Directory).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 239, 196, 223, 199, 207, 216, 203, 222, 207, 236, 195, 198, 207, 249, 211, 217, 222, 207, 199, 239, 196, 222, 216, 195, 207, 217 }, e => (byte)(e ^ 170))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(wbdDKMGaYmLzWPAqxEnsYmFyANE) })).Any()) {
				string BVpSkKgUqqdUmjCBIbPpaZbVEs_jWc = string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 168, 148, 153, 220, 136, 157, 142, 155, 153, 136, 220, 158, 137, 149, 144, 152, 220, 154, 147, 144, 152, 153, 142, 220, 149, 143, 220, 146, 147, 136, 220, 153, 145, 140, 136, 133, 220, 212, 222 }, e => (byte)(e ^ 252))), wbdDKMGaYmLzWPAqxEnsYmFyANE, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 76, 71, 85, 78, 35, 8, 27, 29, 13, 15, 26, 1, 28, 78, 25, 7, 2, 2, 78, 28, 11, 3, 1, 24, 11, 78, 7, 26, 29, 78, 13, 1, 0, 26, 11, 0, 26, 29, 78, 8, 1, 28, 78, 30, 28, 1, 30, 11, 28, 78, 1, 30, 11, 28, 15, 26, 7, 1, 0, 64, 78, 55, 1, 27, 78, 13, 15, 0, 78, 13, 6, 15, 0, 9, 11, 78, 26, 6, 11, 78, 76, 45, 15, 2, 2, 12, 15, 13, 5, 78, 33, 28, 10, 11, 28, 76, 78, 7, 0, 78, 29, 11, 26, 26, 7, 0, 9, 29, 78, 29, 1, 78, 26, 6, 15, 26, 78, 23, 1, 27, 28, 78, 13, 27, 29, 26, 1, 3, 78, 12, 27, 7, 2, 10, 78, 30, 7, 30, 11, 2, 7, 0, 11, 78, 70, 7, 8, 78, 15, 0, 23, 71, 78, 9, 11, 0, 11, 28, 15, 26, 11, 29, 78, 8, 7, 2, 11, 29, 78, 15, 8, 26, 11, 28, 78, 35, 8, 27, 29, 13, 15, 26, 1, 28 }, e => (byte)(e ^ 110))));
				if (
					(((bool)typeof(global::System.IO.Directory).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 251, 198, 215, 205, 202, 205 }, e => (byte)(e ^ 190))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(((string)typeof(global::System.IO.Path).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 236, 192, 194, 205, 198, 193, 202 }, e => (byte)(e ^ 175))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(wbdDKMGaYmLzWPAqxEnsYmFyANE), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 157, 175, 175, 185, 168, 175 }, e => (byte)(e ^ 220)))) }))) })) || ((bool)typeof(global::System.IO.Directory).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 86, 107, 122, 96, 103, 96 }, e => (byte)(e ^ 19))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(((string)typeof(global::System.IO.Path).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 219, 247, 245, 250, 241, 246, 253 }, e => (byte)(e ^ 152))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(wbdDKMGaYmLzWPAqxEnsYmFyANE), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 195, 230, 237, 253, 238, 253, 246 }, e => (byte)(e ^ 143)))) }))) }))) &&
					!Application.isBatchMode &&
					!((bool)typeof(global::UnityEditor.EditorUtility).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 98, 79, 85, 86, 74, 71, 95, 98, 79, 71, 74, 73, 65 }, e => (byte)(e ^ 38))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string), typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 237, 198, 213, 211, 195, 193, 212, 207, 210 }, e => (byte)(e ^ 160)))), (string)(string.Concat(BVpSkKgUqqdUmjCBIbPpaZbVEs_jWc, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 211 }, e => (byte)(e ^ 253))))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 218, 248, 229, 233, 239, 239, 238 }, e => (byte)(e ^ 138)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 253, 223, 208, 221, 219, 210 }, e => (byte)(e ^ 190)))) }))
					)
					throw new OperationCanceledException();
				string zgdnhpODHlmGzadiRqvFAMPisqvmPR = global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 55, 56, 49, 53, 38, 43, 55, 53, 55, 60, 49, 43, 35, 53, 38, 58, 61, 58, 51 }, e => (byte)(e ^ 116)));
				if (
					!((bool)typeof(global::UnityEngine.PlayerPrefs).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 65, 104, 122, 66, 108, 112 }, e => (byte)(e ^ 9))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(((string)typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 22, 31, 0, 0, 19, 19, 5, 50, 21, 16, 39, 40, 51, 37, 19, 52, 2, 0, 30, 21, 8, 23, 4, 9, 54, 19, 49, 42, 15 }, e => (byte)(e ^ 102))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(zgdnhpODHlmGzadiRqvFAMPisqvmPR) }))) })) &&
					!Application.isBatchMode &&
					!((bool)typeof(global::UnityEditor.EditorUtility).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 32, 13, 23, 20, 8, 5, 29, 32, 13, 5, 8, 11, 3 }, e => (byte)(e ^ 100))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string), typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 7, 44, 63, 57, 41, 43, 62, 37, 56 }, e => (byte)(e ^ 74)))), (string)(string.Concat(BVpSkKgUqqdUmjCBIbPpaZbVEs_jWc, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 49, 63, 75, 119, 118, 108, 63, 114, 122, 108, 108, 126, 120, 122, 63, 114, 126, 102, 63, 113, 112, 63, 115, 112, 113, 120, 122, 109, 63, 125, 122, 63, 123, 118, 108, 111, 115, 126, 102, 122, 123, 62 }, e => (byte)(e ^ 31))))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 207, 237, 240, 252, 250, 250, 251 }, e => (byte)(e ^ 159)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 76, 110, 97, 108, 106, 99 }, e => (byte)(e ^ 15)))) }))
					)
					throw new OperationCanceledException();
				typeof(global::UnityEngine.PlayerPrefs).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 198, 240, 225, 198, 225, 231, 252, 251, 242 }, e => (byte)(e ^ 149))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(((string)typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 110, 103, 120, 120, 107, 107, 125, 74, 109, 104, 95, 80, 75, 93, 107, 76, 122, 120, 102, 109, 112, 111, 124, 113, 78, 107, 73, 82, 119 }, e => (byte)(e ^ 30))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(zgdnhpODHlmGzadiRqvFAMPisqvmPR) }))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 159, 131, 131, 135, 132, 205, 216, 216, 142, 152, 130, 131, 130, 217, 149, 146, 216, 173, 188, 163, 194, 165, 184, 218, 180, 218, 157, 128 }, e => (byte)(e ^ 247)))) });
				typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 122, 86, 88, 101, 76, 117, 124, 123, 117, 65, 95, 94, 66, 72, 76, 91, 76, 70, 90, 71, 108, 107, 117, 89, 98, 123 }, e => (byte)(e ^ 15))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(BVpSkKgUqqdUmjCBIbPpaZbVEs_jWc) });
				typeof(global::System.IO.Directory).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 123, 90, 83, 90, 75, 90 }, e => (byte)(e ^ 63))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(bool) }, null).Invoke(null, new object[] { (string)(wbdDKMGaYmLzWPAqxEnsYmFyANE), (bool)(true) });
				_ = ((global::System.IO.DirectoryInfo)typeof(global::System.IO.Directory).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 7, 54, 33, 37, 48, 33, 0, 45, 54, 33, 39, 48, 43, 54, 61 }, e => (byte)(e ^ 68))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(wbdDKMGaYmLzWPAqxEnsYmFyANE) }));
			}
			string NiMbwmHnpZIjtJgcIQbGCVmm = ((string)typeof(global::System.IO.Path).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 80, 124, 126, 113, 122, 125, 118 }, e => (byte)(e ^ 19))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string), typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(Application.dataPath), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 194, 194 }, e => (byte)(e ^ 236)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 39, 2, 9, 25, 10, 25, 18 }, e => (byte)(e ^ 107)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 155, 188, 188 }, e => (byte)(e ^ 217)))) }));
			if (((bool)typeof(global::System.IO.Directory).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 145, 172, 189, 167, 160, 167 }, e => (byte)(e ^ 212))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(NiMbwmHnpZIjtJgcIQbGCVmm) })))
				typeof(global::System.IO.Directory).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 24, 57, 48, 57, 40, 57 }, e => (byte)(e ^ 92))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(bool) }, null).Invoke(null, new object[] { (string)(NiMbwmHnpZIjtJgcIQbGCVmm), (bool)(true) });
		}
		private static void LYMKwXCXxrjVnkfEhdErcMNDnBRFjn() {
			if (OjCzypkfZDTgJqKSsnqAQRBRuXamgfoB == null)
				return;
			typeof(global::System.Diagnostics.Stopwatch).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 93, 122, 97, 126 }, e => (byte)(e ^ 14))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(((object)(OjCzypkfZDTgJqKSsnqAQRBRuXamgfoB) ?? throw new global::System.NullReferenceException()), new object[] { });
			var RCgwtAlogDOAgCmrqssUdywQ = OjCzypkfZDTgJqKSsnqAQRBRuXamgfoB.Elapsed;
			string hAyzCMBeuUZKjelmAiqZG_fLw_fCTy = RCgwtAlogDOAgCmrqssUdywQ switch {
				{ TotalSeconds: < 1 } => string.Concat((int)RCgwtAlogDOAgCmrqssUdywQ.TotalMilliseconds, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 178, 255, 225 }, e => (byte)(e ^ 146)))),
				{ TotalMinutes: < 1 } => $"{RCgwtAlogDOAgCmrqssUdywQ.TotalSeconds:F1} s",
				_ => $"{RCgwtAlogDOAgCmrqssUdywQ.TotalMinutes:F1} min"
			};
			typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 139, 167, 169, 148, 189, 132, 141, 138, 132, 176, 174, 175, 179, 185, 189, 170, 189, 183, 171, 182, 157, 154, 132, 168, 147, 138 }, e => (byte)(e ^ 254))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 42, 117, 121, 122, 121, 100, 43, 113, 100, 115, 115, 120, 40, 80, 127, 120, 127, 101, 126, 115, 114, 54, 102, 100, 121, 117, 115, 101, 101, 127, 120, 113, 42, 57, 117, 121, 122, 121, 100, 40, 54, 62, 115, 122, 119, 102, 101, 115, 114, 44, 54 }, e => (byte)(e ^ 22))), hAyzCMBeuUZKjelmAiqZG_fLw_fCTy, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 200 }, e => (byte)(e ^ 225))))) });

			typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 137, 165, 171, 150, 191, 134, 143, 136, 134, 178, 172, 173, 177, 187, 191, 168, 191, 181, 169, 180, 159, 152, 134, 170, 145, 136 }, e => (byte)(e ^ 252))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 245, 170, 166, 165, 166, 187, 244, 234, 249, 249, 139, 143, 143, 143, 247, 245, 171, 247, 142, 187, 172, 168, 189, 233, 135, 172, 190, 186, 243, 245, 230, 171, 247, 245, 230, 170, 166, 165, 166, 187, 247, 233, 136, 175, 189, 172, 187, 233, 176, 172, 168, 187, 186, 233, 166, 175, 233, 186, 172, 187, 191, 160, 167, 174, 233, 156, 136, 154, 233, 188, 186, 172, 187, 186, 233, 168, 167, 173, 233, 161, 168, 187, 173, 233, 190, 166, 187, 162, 229, 233, 190, 172, 238, 191, 172, 233, 175, 160, 167, 168, 165, 165, 176, 233, 175, 160, 167, 160, 186, 161, 172, 173, 233, 166, 188, 187, 233, 167, 172, 190, 233, 185, 187, 166, 163, 172, 170, 189, 243, 233, 189, 161, 172, 233, 160, 167, 173, 172, 185, 172, 167, 173, 172, 167, 189, 233, 245, 171, 247, 132, 175, 188, 186, 170, 168, 189, 166, 187, 233, 154, 168, 168, 154, 245, 230, 171, 247, 232, 233, 154, 172, 172, 233, 245, 171, 247, 245, 168, 233, 161, 187, 172, 175, 244, 235, 161, 189, 189, 185, 186, 243, 230, 230, 164, 175, 188, 186, 170, 168, 189, 166, 187, 231, 170, 166, 164, 235, 247, 164, 175, 188, 186, 170, 168, 189, 166, 187, 231, 170, 166, 164, 245, 230, 168, 247, 245, 230, 171, 247, 233, 225, 166, 187, 233, 245, 171, 247, 245, 168, 233, 161, 187, 172, 175, 244, 235, 161, 189, 189, 185, 186, 243, 230, 230, 173, 172, 175, 172, 167, 186, 172, 231, 164, 172, 190, 231, 160, 170, 188, 235, 247, 173, 172, 175, 172, 167, 186, 172, 231, 164, 172, 190, 231, 160, 170, 188, 245, 230, 168, 247, 245, 230, 171, 247, 224, 231, 233, 128, 175, 233, 176, 166, 188, 233, 185, 188, 187, 170, 161, 168, 186, 172, 173, 233, 132, 175, 188, 186, 170, 168, 189, 166, 187, 233, 171, 172, 175, 166, 187, 172, 229, 233, 190, 172, 233, 173, 172, 172, 185, 165, 176, 233, 191, 168, 165, 188, 172, 233, 176, 166, 188, 187, 233, 186, 188, 185, 185, 166, 187, 189, 232, 233, 136, 185, 185, 165, 176, 233, 175, 166, 187, 233, 168, 167, 233, 166, 187, 174, 168, 167, 160, 179, 168, 189, 160, 166, 167, 233, 166, 167, 233, 189, 161, 172, 233, 167, 172, 190, 233, 185, 165, 168, 189, 175, 166, 187, 164, 233, 168, 167, 173, 233, 188, 186, 172, 233, 176, 166, 188, 187, 233, 156, 167, 160, 189, 176, 233, 160, 167, 191, 166, 160, 170, 172, 233, 189, 166, 233, 174, 172, 189, 233, 168, 233, 245, 171, 247, 175, 187, 172, 172, 233, 171, 168, 165, 168, 167, 170, 172, 245, 230, 171, 247, 231, 233, 156, 186, 172, 187, 186, 233, 190, 161, 166, 233, 187, 172, 170, 172, 167, 189, 165, 176, 233, 185, 188, 187, 170, 161, 168, 186, 172, 173, 233, 132, 175, 188, 186, 170, 168, 189, 166, 187, 233, 166, 167, 233, 189, 161, 172, 233, 136, 186, 186, 172, 189, 233, 154, 189, 166, 187, 172, 233, 175, 166, 187, 233, 189, 161, 172, 233, 175, 188, 165, 165, 233, 185, 187, 160, 170, 172, 233, 170, 168, 167, 233, 187, 172, 170, 172, 160, 191, 172, 233, 188, 185, 233, 189, 166, 233, 183, 250, 231, 252, 233, 245, 171, 247, 176, 172, 168, 187, 186, 245, 230, 171, 247, 233, 166, 175, 233, 175, 187, 172, 172, 233, 188, 186, 168, 174, 172, 233, 166, 167, 233, 189, 161, 172, 233, 167, 172, 190, 233, 185, 165, 168, 189, 175, 166, 187, 164, 232 }, e => (byte)(e ^ 201)))) });
		}
	}

	internal static class Settings {
		public static void hcvtipTnrDUCXvHTzqsvpxeICY() {
			typeof(global::System.IO.File).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 137, 172, 183, 170, 187, 159, 178, 178, 138, 187, 166, 170 }, e => (byte)(e ^ 222))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(EvWjvUlGmxsOuVxPXrxccZmnkSczxUtO), (string)(((string)typeof(string).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 5, 50, 39, 59, 54, 52, 50 }, e => (byte)(e ^ 87))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string) }, null).Invoke(((object)(((string)typeof(global::UnityEngine.JsonUtility).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 218, 225, 196, 253, 225, 224 }, e => (byte)(e ^ 142))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object), typeof(bool) }, null).Invoke(null, new object[] { (object)(Object), (bool)(true) }))) ?? throw new global::System.NullReferenceException()), new object[] { (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 66, 66, 66, 66 }, e => (byte)(e ^ 98)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 246 }, e => (byte)(e ^ 255)))) })) + '\n') });
		}
		public static GeuJrEJWICIZptSvtCnQSJEkQblPnM Object {
			get {
				if (ztIoenYb_fyf__zmbQjZSvMxnMPOJV == null)
					typeof(global::Mfuscator.Settings).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 126, 124, 111, 71, 84, 77, 87, 113, 103, 118, 75, 71, 82, 114, 110, 109, 68, 122, 112, 103, 110, 68, 103, 117, 101, 81, 103, 86, 103 }, e => (byte)(e ^ 29))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(null, new object[] { });
				return ztIoenYb_fyf__zmbQjZSvMxnMPOJV;
			}
		}

		public static void carZIPJlzkVZOospYgmzsYzhxLzKz() {
			if (((bool)typeof(global::System.IO.File).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 198, 251, 234, 240, 247, 240 }, e => (byte)(e ^ 131))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(EvWjvUlGmxsOuVxPXrxccZmnkSczxUtO) })))
				try {
					ztIoenYb_fyf__zmbQjZSvMxnMPOJV = JsonUtility.FromJson<GeuJrEJWICIZptSvtCnQSJEkQblPnM>(((string)typeof(global::System.IO.File).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 226, 213, 209, 212, 241, 220, 220, 228, 213, 200, 196 }, e => (byte)(e ^ 176))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(EvWjvUlGmxsOuVxPXrxccZmnkSczxUtO) })));
					return;
				}
				catch (Exception e) {
					typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 246, 192, 235, 209, 199, 204, 194, 197, 255, 206, 235, 253, 193, 199, 211, 253, 250, 194, 216, 220, 208, 226, 248, 199, 221, 206, 248, 223, 237, 230, 223, 226 }, e => (byte)(e ^ 180))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 253, 218, 210, 215, 222, 223, 155, 207, 212, 155, 215, 212, 218, 223, 155, 153 }, e => (byte)(e ^ 187))), EvWjvUlGmxsOuVxPXrxccZmnkSczxUtO, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 192, 232 }, e => (byte)(e ^ 226))), e)) });
				}
			ztIoenYb_fyf__zmbQjZSvMxnMPOJV = new();
			typeof(global::Mfuscator.Settings).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 46, 37, 48, 50, 47, 54, 18, 40, 52, 2, 19, 5, 30, 48, 14, 18, 60, 55, 53, 48, 54, 62, 35, 15, 5, 31 }, e => (byte)(e ^ 70))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(null, new object[] { });
		}
		public static void Reset() {
			ztIoenYb_fyf__zmbQjZSvMxnMPOJV = new();
			typeof(global::Mfuscator.Settings).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 214, 221, 200, 202, 215, 206, 234, 208, 204, 250, 235, 253, 230, 200, 246, 234, 196, 207, 205, 200, 206, 198, 219, 247, 253, 231 }, e => (byte)(e ^ 190))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(null, new object[] { });
		}

		private static GeuJrEJWICIZptSvtCnQSJEkQblPnM ztIoenYb_fyf__zmbQjZSvMxnMPOJV;

		private const string PNOKVtpdyCFFwXH_uCHAywMlzDjP = "MFSSettings.json";
		private static string EvWjvUlGmxsOuVxPXrxccZmnkSczxUtO => ((string)typeof(global::System.IO.Path).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 136, 164, 166, 169, 162, 165, 174 }, e => (byte)(e ^ 203))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(Application.dataPath), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 222, 222 }, e => (byte)(e ^ 240)))), (string)(PNOKVtpdyCFFwXH_uCHAywMlzDjP) }));
	}


	[Serializable]
	internal sealed class GeuJrEJWICIZptSvtCnQSJEkQblPnM {
		public bool enable = true;
		public int callbackOrder = 5002;
		public bool logInfo = true;
		public Shared.Settings inter = new() {
			removeStringLiterals = true,
			preserveUnityCrashHandler = false,
			checkFunctionCalls = false,
			renameExports = true,
			renameExportsBlacklist = string.Empty,
			removeMonoExports = true,
			modifyInternalStructures = false,
			detectProxyLibraries = false,
			detectProxyLibrariesWhitelist = string.Empty
		};
	}


	internal static class vVKiHqHT_ejoexokVyNqqiiVIj {
		public static void Bt_esxvqKz_IusgINvlhdVLsizLkYRkV(object mAnDZYYGAtbGlCasXKgROUGTOViTmY) {
			string bAHRydBtWKrXMGDiqdkdpRxT = ((string)typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 138, 128, 147, 189, 150, 186, 137, 169, 135, 180, 175, 128, 151, 176, 171, 137, 156, 130, 176, 169, 131, 138, 159, 182, 156, 136, 142, 138, 136, 160 }, e => (byte)(e ^ 229))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(mAnDZYYGAtbGlCasXKgROUGTOViTmY) }));
			typeof(global::UnityEngine.Debug).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 94, 125, 117, 87, 96, 96, 125, 96 }, e => (byte)(e ^ 18))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(bAHRydBtWKrXMGDiqdkdpRxT) });
			if (BuildPipeline.isBuildingPlayer)
				throw new BuildFailedException(bAHRydBtWKrXMGDiqdkdpRxT);
		}

		private static string GlLQdFYUJogXAxLLfCvAgFBqxs(this string IZPWV_FgLmhPtHT_iRpcUsUbR, string _bUkvQdxOVXYuWjuTNkrkxJKVM) {
			IZPWV_FgLmhPtHT_iRpcUsUbR = ((string)typeof(global::System.Text.RegularExpressions.Regex).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 161, 150, 131, 159, 146, 144, 150 }, e => (byte)(e ^ 243))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(IZPWV_FgLmhPtHT_iRpcUsUbR), (string)(string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 104 }, e => (byte)(e ^ 84))), ((string)typeof(global::System.Text.RegularExpressions.Regex).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 82, 100, 116, 118, 103, 114 }, e => (byte)(e ^ 23))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(_bUkvQdxOVXYuWjuTNkrkxJKVM) })), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 238, 235, 139, 232, 159, 139 }, e => (byte)(e ^ 181))))), (string)(string.Empty) }));
			return ((string)typeof(string).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 81, 102, 115, 111, 98, 96, 102 }, e => (byte)(e ^ 3))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string) }, null).Invoke(((object)(IZPWV_FgLmhPtHT_iRpcUsUbR) ?? throw new global::System.NullReferenceException()), new object[] { (string)(string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 237, 254 }, e => (byte)(e ^ 209))), _bUkvQdxOVXYuWjuTNkrkxJKVM, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 61 }, e => (byte)(e ^ 3))))), (string)(string.Empty) }));
		}
		public static string oevXs_lLbQJerUNlygULfozSymkomE(object eCwc_wU_ybRtUeqjMttqzQyolxrU) {
			string cLXyNv_WjZxnYIHbHuQjWTuQ = string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 119, 41, 117, 16 }, e => (byte)(e ^ 75))), nameof(Mfuscator), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 156, 253, 238, 163, 255, 225 }, e => (byte)(e ^ 193))), eCwc_wU_ybRtUeqjMttqzQyolxrU);
			if (Application.isBatchMode)
				cLXyNv_WjZxnYIHbHuQjWTuQ = cLXyNv_WjZxnYIHbHuQjWTuQ.GlLQdFYUJogXAxLLfCvAgFBqxs(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 175 }, e => (byte)(e ^ 205)))).GlLQdFYUJogXAxLLfCvAgFBqxs(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 242 }, e => (byte)(e ^ 155)))).GlLQdFYUJogXAxLLfCvAgFBqxs(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 100 }, e => (byte)(e ^ 5)))).GlLQdFYUJogXAxLLfCvAgFBqxs(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 204, 192, 195, 192, 221 }, e => (byte)(e ^ 175))));
			return cLXyNv_WjZxnYIHbHuQjWTuQ;
		}
		public static string pyffuucTsvANUCuRdfxsnqboPuWLi(string cLbsIBbxNqKmBslDuWWW_kVApiX) {
			return string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 236, 231, 242, 254 }, e => (byte)(e ^ 161))), cLbsIBbxNqKmBslDuWWW_kVApiX);
		}
		public static void uYWjCzstzNPQMGCTCIUHcdzVmt(object jadIovVSNQHkKXPIbpmdfGJHxqvmYKu) {
			if (!Settings.Object.logInfo)
				return;
			typeof(global::UnityEngine.Debug).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 78, 109, 101 }, e => (byte)(e ^ 2))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(((string)typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 215, 221, 206, 224, 203, 231, 212, 244, 218, 233, 242, 221, 202, 237, 246, 212, 193, 223, 237, 244, 222, 215, 194, 235, 193, 213, 211, 215, 213, 253 }, e => (byte)(e ^ 184))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(jadIovVSNQHkKXPIbpmdfGJHxqvmYKu) }))) });
		}
		public static bool InhIhsesPCDlcljLayCiTmUeBMCne(string GilZGqmeVepSYYWyZBFGiQYVwxiQBR) {
			bool YsRGLAtxBYnJRHaIZyrIHCOhi() {
				string kKDtXuyVEnadtTSZWwcQiBRQXv = ((string)typeof(global::System.IO.Path).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 237, 193, 195, 204, 199, 192, 203 }, e => (byte)(e ^ 174))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(GilZGqmeVepSYYWyZBFGiQYVwxiQBR), (string)(string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 64, 65, 72, 65, 80, 65, 91, 73, 65, 91 }, e => (byte)(e ^ 4))), Guid.NewGuid())) }));
				string DImRXZbFcooaNLjMOEJQLavmyP_LvRnV = ((string)typeof(global::System.IO.Path).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 246, 218, 216, 215, 220, 219, 208 }, e => (byte)(e ^ 181))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(kKDtXuyVEnadtTSZWwcQiBRQXv), (string)(((string)typeof(global::System.IO.Path).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 124, 94, 79, 105, 90, 85, 95, 84, 86, 125, 82, 87, 94, 117, 90, 86, 94 }, e => (byte)(e ^ 59))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(null, new object[] { }))) }));
				try {
					typeof(global::System.IO.Directory).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 29, 44, 59, 63, 42, 59, 26, 55, 44, 59, 61, 42, 49, 44, 39 }, e => (byte)(e ^ 94))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(kKDtXuyVEnadtTSZWwcQiBRQXv) });
					File.WriteAllBytes(DImRXZbFcooaNLjMOEJQLavmyP_LvRnV, new byte[] { 1 });
					if (File.ReadAllBytes(DImRXZbFcooaNLjMOEJQLavmyP_LvRnV)[0] != 1)
						throw new Exception();
					typeof(global::System.IO.File).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 36, 6, 31, 12 }, e => (byte)(e ^ 105))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(DImRXZbFcooaNLjMOEJQLavmyP_LvRnV), (string)(DImRXZbFcooaNLjMOEJQLavmyP_LvRnV + 'a') });
					return true;
				}
				catch {
					return false;
				}
				finally {
					try {
						if (((bool)typeof(global::System.IO.File).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 30, 35, 50, 40, 47, 40 }, e => (byte)(e ^ 91))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(DImRXZbFcooaNLjMOEJQLavmyP_LvRnV + 'a') })))
							typeof(global::System.IO.File).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 117, 84, 93, 84, 69, 84 }, e => (byte)(e ^ 49))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(DImRXZbFcooaNLjMOEJQLavmyP_LvRnV + 'a') });
						if (((bool)typeof(global::System.IO.File).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 204, 241, 224, 250, 253, 250 }, e => (byte)(e ^ 137))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(DImRXZbFcooaNLjMOEJQLavmyP_LvRnV) })))
							typeof(global::System.IO.File).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 122, 91, 82, 91, 74, 91 }, e => (byte)(e ^ 62))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(DImRXZbFcooaNLjMOEJQLavmyP_LvRnV) });
						if (((bool)typeof(global::System.IO.Directory).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 77, 112, 97, 123, 124, 123 }, e => (byte)(e ^ 8))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(kKDtXuyVEnadtTSZWwcQiBRQXv) })))
							typeof(global::System.IO.Directory).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 135, 166, 175, 166, 183, 166 }, e => (byte)(e ^ 195))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(kKDtXuyVEnadtTSZWwcQiBRQXv) });
					}
					catch { }
				}
			}
			bool CcDDJrlzufLitCofZVnNedZrbNCUa() {
				typeof(global::UnityEditor.EditorUtility).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 123, 86, 76, 79, 83, 94, 70, 111, 77, 80, 88, 77, 90, 76, 76, 125, 94, 77 }, e => (byte)(e ^ 63))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string), typeof(float) }, null).Invoke(null, new object[] { (string)(nameof(Mfuscator)), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 23, 34, 49, 62, 36, 57, 62, 55, 112, 49, 51, 51, 53, 35, 35, 126, 126, 126 }, e => (byte)(e ^ 80)))), (float)(0f) });
				using Process KxmhTFKErvFlfxbVgOuB_OwF = new() {
					StartInfo = new() {
						Verb = global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 47, 40, 51, 60, 46 }, e => (byte)(e ^ 93))),
						Arguments = string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 97, 13, 110, 39, 45, 47, 45, 34, 61, 110, 108 }, e => (byte)(e ^ 78))), GilZGqmeVepSYYWyZBFGiQYVwxiQBR, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 33, 35, 44, 100, 113, 98, 109, 119, 35, 38, 118, 112, 102, 113, 109, 98, 110, 102, 38, 57, 43, 76, 74, 42, 43, 64, 74, 42, 69 }, e => (byte)(e ^ 3)))),
						CreateNoWindow = true,
						UseShellExecute = true,
						FileName = global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 121, 119, 126, 52, 127, 98, 127 }, e => (byte)(e ^ 26))),
						WindowStyle = ProcessWindowStyle.Hidden
					}
				};
				try {
					_ = ((bool)typeof(global::System.Diagnostics.Process).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 255, 216, 205, 222, 216 }, e => (byte)(e ^ 172))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(((object)(KxmhTFKErvFlfxbVgOuB_OwF) ?? throw new global::System.NullReferenceException()), new object[] { }));
					typeof(global::System.Diagnostics.Process).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 124, 74, 66, 95, 109, 68, 89, 110, 83, 66, 95 }, e => (byte)(e ^ 43))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(((object)(KxmhTFKErvFlfxbVgOuB_OwF) ?? throw new global::System.NullReferenceException()), new object[] { });
					return true;
				}
				catch (Win32Exception) {
					typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 184, 142, 165, 159, 137, 130, 140, 139, 177, 128, 165, 179, 143, 137, 157, 179, 180, 140, 150, 146, 158, 172, 182, 137, 147, 128, 182, 145, 163, 168, 145, 172 }, e => (byte)(e ^ 250))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 27, 57, 54, 59, 61, 52, 61, 60, 120, 58, 33, 120, 45, 43, 61, 42 }, e => (byte)(e ^ 88)))) });
					return false;
				}
				finally {
					typeof(global::UnityEditor.EditorUtility).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 186, 149, 156, 152, 139, 169, 139, 150, 158, 139, 156, 138, 138, 187, 152, 139 }, e => (byte)(e ^ 249))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(null, new object[] { });
				}
			}
			if (!YsRGLAtxBYnJRHaIZyrIHCOhi())
				if (Application.platform != RuntimePlatform.WindowsEditor) {
					typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 187, 128, 152, 152, 141, 140, 162, 178, 179, 161, 158, 146, 138, 138, 140, 180, 170, 141, 173, 190, 156, 133, 128, 138, 170, 152, 164, 186, 188, 180, 136, 128 }, e => (byte)(e ^ 235))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 23, 43, 38, 99, 32, 54, 49, 49, 38, 45, 55, 99, 48, 58, 48, 55, 38, 46, 99, 54, 48, 38, 49, 99, 39, 44, 38, 48, 99, 45, 44, 55, 99, 43, 34, 53, 38, 99, 49, 38, 34, 39, 99, 34, 45, 39, 99, 52, 49, 42, 55, 38, 99, 34, 32, 32, 38, 48, 48, 99, 55, 44, 99, 97 }, e => (byte)(e ^ 67))), GilZGqmeVepSYYWyZBFGiQYVwxiQBR, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 206, 204, 141, 130, 136, 204, 133, 152, 159, 204, 159, 153, 142, 138, 131, 128, 136, 137, 158, 159, 204, 141, 130, 136, 204, 138, 133, 128, 137, 159 }, e => (byte)(e ^ 236))))) });
					return false;
				}
				else if (!CcDDJrlzufLitCofZVnNedZrbNCUa())
					return false;
			return true;
		}
		public static void PkssfgIYXJuyaag_AfFUwnkaAsOQW_ck(object TWLoyiqjwwtynXjVQpnewObUQLtrJsbY) {
			typeof(global::UnityEngine.Debug).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 189, 158, 150, 166, 144, 131, 159, 152, 159, 150 }, e => (byte)(e ^ 241))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(((string)typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 23, 29, 14, 32, 11, 39, 20, 52, 26, 41, 50, 29, 10, 45, 54, 20, 1, 31, 45, 52, 30, 23, 2, 43, 1, 21, 19, 23, 21, 61 }, e => (byte)(e ^ 120))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(object) }, null).Invoke(null, new object[] { (object)(TWLoyiqjwwtynXjVQpnewObUQLtrJsbY) }))) });
		}
	}

	internal sealed class YmStbcJggYWkrKJWKXtsCBXN : EditorWindow {

		public const string GdNmziIrbVspmUpufagnUGN_lBXirIy = "CLEAR_CACHE";

		[MenuItem("Window/MFS Settings", priority = 502)]
		private static void jtAnbmKOxdqKQdoisrCmVfNCaSREr() {
			typeof(global::Mfuscator.Settings).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 200, 202, 217, 241, 226, 251, 225, 199, 209, 192, 253, 241, 228, 196, 216, 219, 242, 204, 198, 209, 216, 242, 209, 195, 211, 231, 209, 224, 209 }, e => (byte)(e ^ 171))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(null, new object[] { });
			_ = GetWindow<YmStbcJggYWkrKJWKXtsCBXN>(false, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 82, 121, 106, 108, 124, 126, 107, 112, 109 }, e => (byte)(e ^ 31))) + ((DateTime.UtcNow < new DateTime(2025, 1, 1)) ? global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 91, 83, 41, 30, 22, 26, 8, 15, 30, 9, 30, 31, 82 }, e => (byte)(e ^ 123))) : string.Empty));
		}
		private void OnFocus() {
			typeof(global::Mfuscator.Settings).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 136, 138, 153, 177, 162, 187, 161, 135, 145, 128, 189, 177, 164, 132, 152, 155, 178, 140, 134, 145, 152, 178, 145, 131, 147, 167, 145, 160, 145 }, e => (byte)(e ^ 235))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(null, new object[] { });
		}
		private void CreateGUI() {
			var FlWKPLyAfDS_cyHrzwUIQxUVUFZX = rootVisualElement;

			Font JlOHSgHrRakvWxhmyNYglVHPRDOC(string oYyegZtIcaMePMuhETHAaZmwULAG) {
				string[] JbzztuqkSqNAVdHUtrEAuCpczSYPu = AssetDatabase.FindAssets(string.Concat(oYyegZtIcaMePMuhETHAaZmwULAG, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 132, 208, 158, 194, 203, 202, 208 }, e => (byte)(e ^ 164)))));
				if (JbzztuqkSqNAVdHUtrEAuCpczSYPu.Length > 0) {
					string TwdQfsHHLsyOdEAoENqDklgecqzFSK = ((string)typeof(global::UnityEditor.AssetDatabase).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 77, 95, 67, 78, 94, 101, 75, 121, 121, 111, 126, 90, 107, 126, 98 }, e => (byte)(e ^ 10))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(JbzztuqkSqNAVdHUtrEAuCpczSYPu[0]) }));
					return AssetDatabase.LoadAssetAtPath<Font>(TwdQfsHHLsyOdEAoENqDklgecqzFSK);
				}
				return null;
			}
			Font DTjNNqhTzGmGQEHpLjKZguPCqZT = JlOHSgHrRakvWxhmyNYglVHPRDOC(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 74, 99, 98, 120, 44, 77, 123, 105, 127, 99, 97, 105, 44, 58, 44, 74, 126, 105, 105, 33, 95, 99, 96, 101, 104, 33, 53, 60, 60 }, e => (byte)(e ^ 12))));

			minSize = new(416f, 472f);

			static void fTFfaYiZjANaPgJPhHqVyYrfyILUlMt(VisualElement PcejOW_vQKraq_DdEmnfToSk) {
				PcejOW_vQKraq_DdEmnfToSk.style.marginTop = PcejOW_vQKraq_DdEmnfToSk.style.marginRight = PcejOW_vQKraq_DdEmnfToSk.style.marginLeft = 4f;
				PcejOW_vQKraq_DdEmnfToSk.style.marginBottom = 0f;
			}
			static FieldT UejvRLLHFzQTz_LurHPfAhoSey<ValueT, FieldT>(VisualElement tpxWEgZhkxhPxEVenVzGixyIklHn, ValueT pYxmEUktTxcpVTECEwMtapbwK, string hwJrYMwgDzOEuZMFRWOxajjBUXcASgi, Action<ValueT> DlnGkYFf_esxjsNrc_kSRxyARltNF, string VfrIlRvkeANrIkwWFpsGvsyEyhw = null) where FieldT
				: BaseField<ValueT>, new() {
				var KKSGc_DftFiOcYbnLmitHVqnYrU = new FieldT {
					label = hwJrYMwgDzOEuZMFRWOxajjBUXcASgi,
					tooltip = VfrIlRvkeANrIkwWFpsGvsyEyhw
				};
				fTFfaYiZjANaPgJPhHqVyYrfyILUlMt(KKSGc_DftFiOcYbnLmitHVqnYrU);
				KKSGc_DftFiOcYbnLmitHVqnYrU.Q<Label>().style.minWidth = 192f;
				KKSGc_DftFiOcYbnLmitHVqnYrU.SetValueWithoutNotify(pYxmEUktTxcpVTECEwMtapbwK);
				_ = KKSGc_DftFiOcYbnLmitHVqnYrU.RegisterValueChangedCallback<ValueT>(IpoTrrqWDgIEUqqOyPAeMlrPrxLxR_ => {
					DlnGkYFf_esxjsNrc_kSRxyARltNF.Invoke(IpoTrrqWDgIEUqqOyPAeMlrPrxLxR_.newValue);
					typeof(global::Mfuscator.Settings).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 73, 66, 87, 85, 72, 81, 117, 79, 83, 101, 116, 98, 121, 87, 105, 117, 91, 80, 82, 87, 81, 89, 68, 104, 98, 120 }, e => (byte)(e ^ 33))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(null, new object[] { });
				});
				typeof(global::UnityEngine.UIElements.VisualElement).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 185, 156, 156 }, e => (byte)(e ^ 248))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEngine.UIElements.VisualElement) }, null).Invoke(((object)(tpxWEgZhkxhPxEVenVzGixyIklHn) ?? throw new global::System.NullReferenceException()), new object[] { (global::UnityEngine.UIElements.VisualElement)(KKSGc_DftFiOcYbnLmitHVqnYrU) });
				return KKSGc_DftFiOcYbnLmitHVqnYrU;
			}
			static void AGIFIxCYWKUbYWSVVhHRpdQDInKWM(VisualElement BEToeVqHhwjjcGEzDGvRpJEkDlErTYi, int YmauIrbAfkPMQNPXqPoLtIZbqX, string cmNirsDJHBQsTIpzsNUKABTuZx, Action<int> PWOsdmQouwFRybSCwZJLIznAE, string TMzrtiDByJyUIScogBHFFTkbFz = null) {
				UejvRLLHFzQTz_LurHPfAhoSey<string, TextField>(BEToeVqHhwjjcGEzDGvRpJEkDlErTYi, YmauIrbAfkPMQNPXqPoLtIZbqX.ToString(), cmNirsDJHBQsTIpzsNUKABTuZx, sbpTumYcnPafnPdcB_Bpqbhf => {
					if (!int.TryParse(sbpTumYcnPafnPdcB_Bpqbhf, out int vInt)) {
						_ = ((bool)typeof(global::UnityEditor.EditorUtility).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 10, 39, 61, 62, 34, 47, 55, 10, 39, 47, 34, 33, 41 }, e => (byte)(e ^ 78))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 201, 254, 254, 227, 254 }, e => (byte)(e ^ 140)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 191, 130, 138, 159, 153, 142, 159, 158, 218, 155, 148, 218, 147, 148, 142, 159, 157, 159, 136 }, e => (byte)(e ^ 250)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 203, 233, 244, 248, 254, 254, 255 }, e => (byte)(e ^ 155)))) }));
						return;
					}
					PWOsdmQouwFRybSCwZJLIznAE.Invoke(vInt);
				}, TMzrtiDByJyUIScogBHFFTkbFz);
			}
			void _SyPXQbAUdzQGhwfylzwCcSgzyvjfvl(VisualElement eNbnKhxFyFvAkAQCLiqRDdugn, string text, string rIPoI_DapCBveCVJJOA_ZRsERxjjGj, Action jzWHcQFGvNpijwQQuFIseUHjQZW, string qZMDv_ZuAiOQAtixkSzlGtRGqoJEZ = null, Color efV_aJRs_bGguQssJnGLLiKq = default) {
				var WESkcbhFpKZXoLOGpzpEkdZfTUawJ = new Button() {
					text = text,
					tooltip = qZMDv_ZuAiOQAtixkSzlGtRGqoJEZ
				};
				fTFfaYiZjANaPgJPhHqVyYrfyILUlMt(WESkcbhFpKZXoLOGpzpEkdZfTUawJ);
				WESkcbhFpKZXoLOGpzpEkdZfTUawJ.style.paddingTop = WESkcbhFpKZXoLOGpzpEkdZfTUawJ.style.paddingBottom = WESkcbhFpKZXoLOGpzpEkdZfTUawJ.style.paddingRight = WESkcbhFpKZXoLOGpzpEkdZfTUawJ.style.paddingLeft = 4f;
				WESkcbhFpKZXoLOGpzpEkdZfTUawJ.style.unityTextAlign = TextAnchor.MiddleLeft;

				{
					var VNmFkmEbBMKXv_npddHOKcSTnAjfLVSP = new Label {
#if !UNITY_6000_0_OR_NEWER
						text = string.Concat((efV_aJRs_bGguQssJnGLLiKq != default ? string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 28, 67, 79, 76, 79, 82, 29, 3 }, e => (byte)(e ^ 32))), ((string)typeof(global::UnityEngine.ColorUtility).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 65, 122, 93, 97, 120, 121, 70, 97, 103, 124, 123, 114, 71, 82, 87 }, e => (byte)(e ^ 21))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEngine.Color) }, null).Invoke(null, new object[] { (global::UnityEngine.Color)(efV_aJRs_bGguQssJnGLLiKq) })), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 48 }, e => (byte)(e ^ 14)))) : string.Empty), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 17, 56 }, e => (byte)(e ^ 77))), rIPoI_DapCBveCVJJOA_ZRsERxjjGj)
#else
						text = $"{(efV_aJRs_bGguQssJnGLLiKq != default ? $"<color=#{ColorUtility.ToHtmlStringRGB(efV_aJRs_bGguQssJnGLLiKq)}>" : string.Empty)}{(char)Convert.ToInt32(rIPoI_DapCBveCVJJOA_ZRsERxjjGj, 16)}"
#endif
					};
					VNmFkmEbBMKXv_npddHOKcSTnAjfLVSP.style.unityFont = DTjNNqhTzGmGQEHpLjKZguPCqZT;
					VNmFkmEbBMKXv_npddHOKcSTnAjfLVSP.style.unityFontDefinition = new();
					VNmFkmEbBMKXv_npddHOKcSTnAjfLVSP.style.unityTextAlign = TextAnchor.MiddleRight;

					typeof(global::UnityEngine.UIElements.VisualElement).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 46, 11, 11 }, e => (byte)(e ^ 111))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEngine.UIElements.VisualElement) }, null).Invoke(((object)(WESkcbhFpKZXoLOGpzpEkdZfTUawJ) ?? throw new global::System.NullReferenceException()), new object[] { (global::UnityEngine.UIElements.VisualElement)(VNmFkmEbBMKXv_npddHOKcSTnAjfLVSP) });
				}

				typeof(global::UnityEngine.UIElements.VisualElement).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 249, 220, 220 }, e => (byte)(e ^ 184))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEngine.UIElements.VisualElement) }, null).Invoke(((object)(eNbnKhxFyFvAkAQCLiqRDdugn) ?? throw new global::System.NullReferenceException()), new object[] { (global::UnityEngine.UIElements.VisualElement)(WESkcbhFpKZXoLOGpzpEkdZfTUawJ) });

				WESkcbhFpKZXoLOGpzpEkdZfTUawJ.clicked += jzWHcQFGvNpijwQQuFIseUHjQZW;
			}
			static void mZwybUXwkYQnSfPBfrSjuyNUg_FYowSp(VisualElement oVohcXZIPzowMmsrBwJJClRZMo, float RqBvlnNByEmtMLdQ_eVWheDpayIQSXv) {
				var emfqer_MUeEjYoOsQGxycepZmE = new VisualElement();
				if (RqBvlnNByEmtMLdQ_eVWheDpayIQSXv <= 0f)
					emfqer_MUeEjYoOsQGxycepZmE.style.flexGrow = 1f;
				else
					emfqer_MUeEjYoOsQGxycepZmE.style.height = RqBvlnNByEmtMLdQ_eVWheDpayIQSXv;

				typeof(global::UnityEngine.UIElements.VisualElement).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 228, 193, 193 }, e => (byte)(e ^ 165))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEngine.UIElements.VisualElement) }, null).Invoke(((object)(oVohcXZIPzowMmsrBwJJClRZMo) ?? throw new global::System.NullReferenceException()), new object[] { (global::UnityEngine.UIElements.VisualElement)(emfqer_MUeEjYoOsQGxycepZmE) });
			}

			UejvRLLHFzQTz_LurHPfAhoSey<bool, Toggle>(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, Settings.Object.enable, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 160, 254, 162, 217, 242, 253, 254, 240, 249, 188, 223, 243, 238, 249, 188, 208, 253, 229, 249, 238, 239, 160, 179, 254, 162 }, e => (byte)(e ^ 156))), IsyjdeUpfHzSrLxzBIIdskHEoQBYhP => {
				Settings.Object.enable = IsyjdeUpfHzSrLxzBIIdskHEoQBYhP;
				if (!Settings.Object.enable)
					typeof(global::UnityEngine.PlayerPrefs).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 55, 1, 16, 55, 16, 22, 13, 10, 3 }, e => (byte)(e ^ 100))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(((string)typeof(global::Mfuscator.vVKiHqHT_ejoexokVyNqqiiVIj).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 51, 58, 37, 37, 54, 54, 32, 23, 48, 53, 2, 13, 22, 0, 54, 17, 39, 37, 59, 48, 45, 50, 33, 44, 19, 54, 20, 15, 42 }, e => (byte)(e ^ 67))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(GdNmziIrbVspmUpufagnUGN_lBXirIy) }))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 149, 137, 137, 141, 142, 199, 210, 210, 132, 146, 136, 137, 136, 211, 159, 152, 210, 200, 145, 143, 140, 137, 159, 143, 180, 207, 133, 180 }, e => (byte)(e ^ 253)))) });
			});
			AGIFIxCYWKUbYWSVVhHRpdQDInKWM(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, Settings.Object.callbackOrder, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 132, 166, 171, 171, 165, 166, 164, 172, 231, 136, 181, 163, 162, 181 }, e => (byte)(e ^ 199))), NIQGBEbxOoRKTiIIyRuDOuZWJTQZzqW => {
				Settings.Object.callbackOrder = NIQGBEbxOoRKTiIIyRuDOuZWJTQZzqW;
			}, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 213, 240, 254, 225, 231, 224, 231, 180, 224, 252, 241, 180, 228, 230, 241, 187, 228, 251, 231, 224, 185, 246, 225, 253, 248, 240, 180, 228, 230, 251, 247, 241, 231, 231, 253, 250, 243, 180, 251, 230, 240, 241, 230, 186, 180, 217, 251, 240, 253, 242, 237, 180, 224, 252, 253, 231, 180, 224, 251, 180, 230, 241, 231, 251, 248, 226, 241, 180, 247, 251, 249, 228, 245, 224, 253, 246, 253, 248, 253, 224, 237, 180, 253, 231, 231, 225, 241, 231, 180, 227, 253, 224, 252, 180, 251, 224, 252, 241, 230, 180, 228, 245, 247, 255, 245, 243, 241, 231 }, e => (byte)(e ^ 148))));
			UejvRLLHFzQTz_LurHPfAhoSey<bool, Toggle>(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, Settings.Object.logInfo, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 150, 181, 189, 250, 147, 180, 188, 181 }, e => (byte)(e ^ 218))), qeOhsRDIaWNpVNmrQibygwWsP => {
				Settings.Object.logInfo = qeOhsRDIaWNpVNmrQibygwWsP;
			}, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 4, 63, 55, 55, 60, 53, 35, 112, 57, 62, 54, 63, 34, 61, 49, 36, 57, 63, 62, 49, 60, 112, 61, 53, 35, 35, 49, 55, 53, 35, 112, 57, 62, 112, 36, 56, 53, 112, 5, 62, 57, 36, 41, 112, 51, 63, 62, 35, 63, 60, 53, 126, 112, 20, 57, 35, 49, 50, 60, 53, 112, 36, 63, 112, 34, 53, 52, 37, 51, 53, 112, 60, 63, 55, 112, 35, 32, 49, 61 }, e => (byte)(e ^ 80))));
			UejvRLLHFzQTz_LurHPfAhoSey<bool, Toggle>(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, Settings.Object.inter.removeStringLiterals, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 40, 31, 23, 21, 12, 31, 90, 41, 14, 8, 19, 20, 29, 90, 54, 19, 14, 31, 8, 27, 22, 9 }, e => (byte)(e ^ 122))), kbbOZTadTUhSSSxrKZg_zLGqjptUcwCY => {
				Settings.Object.inter.removeStringLiterals = kbbOZTadTUhSSSxrKZg_zLGqjptUcwCY;
			}, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 241, 198, 206, 204, 213, 198, 208, 131, 208, 215, 209, 202, 205, 196, 131, 192, 204, 205, 208, 215, 194, 205, 215, 208, 131, 197, 209, 204, 206, 131, 215, 203, 198, 131, 193, 202, 205, 194, 209, 218, 143, 131, 206, 194, 200, 202, 205, 196, 131, 215, 203, 198, 131, 199, 202, 208, 194, 208, 208, 198, 206, 193, 207, 198, 199, 131, 192, 204, 199, 198, 131, 203, 194, 209, 199, 198, 209, 131, 215, 204, 131, 194, 205, 194, 207, 218, 217, 198 }, e => (byte)(e ^ 163))));
			UejvRLLHFzQTz_LurHPfAhoSey<bool, Toggle>(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, Settings.Object.inter.preserveUnityCrashHandler, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 249, 219, 204, 218, 204, 219, 223, 204, 137, 252, 199, 192, 221, 208, 137, 234, 219, 200, 218, 193, 137, 225, 200, 199, 205, 197, 204, 219 }, e => (byte)(e ^ 169))), LNZKRKWRwyfcGuQrBneWYwbvTzAJZ => {
				Settings.Object.inter.preserveUnityCrashHandler = LNZKRKWRwyfcGuQrBneWYwbvTzAJZ;
			}, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 251, 217, 206, 221, 206, 197, 223, 216, 139, 223, 195, 206, 139, 217, 206, 198, 196, 221, 202, 199, 139, 196, 205, 139, 254, 197, 194, 223, 210, 140, 216, 139, 207, 206, 205, 202, 222, 199, 223, 139, 200, 217, 202, 216, 195, 139, 195, 202, 197, 207, 199, 206, 217, 133, 139, 238, 197, 202, 201, 199, 206, 139, 194, 205, 139, 210, 196, 222, 139, 217, 206, 199, 210, 139, 196, 197, 139, 216, 223, 202, 197, 207, 202, 217, 207, 139, 200, 217, 202, 216, 195, 139, 217, 206, 219, 196, 217, 223, 194, 197, 204 }, e => (byte)(e ^ 171))));
			TextField pvdhfOHSOPcLWFdCOcmLWzsfY = null;
			UejvRLLHFzQTz_LurHPfAhoSey<bool, Toggle>(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, Settings.Object.inter.checkFunctionCalls, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 223, 236, 251, 224, 239, 240, 169, 204, 241, 249, 230, 251, 253, 169, 202, 232, 229, 229, 250 }, e => (byte)(e ^ 137))), UecVGfgwHSChHswGEGkoyWOnyGNOVUDC => {
				Settings.Object.inter.checkFunctionCalls = UecVGfgwHSChHswGEGkoyWOnyGNOVUDC;
				pvdhfOHSOPcLWFdCOcmLWzsfY.style.display = Settings.Object.inter.checkFunctionCalls || Settings.Object.inter.renameExports ? DisplayStyle.Flex : DisplayStyle.None;
			}, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 200, 227, 254, 248, 255, 232, 254, 173, 196, 193, 191, 206, 221, 221, 173, 232, 245, 253, 226, 255, 249, 254, 173, 236, 255, 232, 173, 226, 227, 225, 244, 173, 238, 236, 225, 225, 232, 233, 173, 239, 244, 173, 249, 229, 232, 173, 232, 227, 234, 228, 227, 232, 161, 173, 250, 229, 228, 238, 229, 173, 229, 232, 225, 253, 254, 173, 253, 255, 232, 251, 232, 227, 249, 173, 255, 248, 227, 249, 228, 224, 232, 173, 233, 248, 224, 253, 228, 227, 234 }, e => (byte)(e ^ 141))));
			UejvRLLHFzQTz_LurHPfAhoSey<bool, Toggle>(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, Settings.Object.inter.renameExports, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 15, 56, 51, 60, 48, 56, 125, 24, 37, 45, 50, 47, 41, 46 }, e => (byte)(e ^ 93))), viIUnpuRVruWAmYSxxprCeLSXLPtrZ => {
				Settings.Object.inter.renameExports = viIUnpuRVruWAmYSxxprCeLSXLPtrZ;
				pvdhfOHSOPcLWFdCOcmLWzsfY.style.display = Settings.Object.inter.checkFunctionCalls || Settings.Object.inter.renameExports ? DisplayStyle.Flex : DisplayStyle.None;
			}, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 3, 52, 63, 48, 60, 52, 34, 113, 24, 29, 99, 18, 1, 1, 113, 52, 41, 33, 62, 35, 37, 34, 113, 37, 62, 113, 35, 48, 63, 53, 62, 60, 113, 63, 48, 60, 52, 34, 125, 113, 51, 35, 52, 48, 58, 56, 63, 54, 113, 37, 62, 62, 61, 34, 113, 37, 57, 48, 37, 113, 35, 52, 61, 40, 113, 62, 63, 113, 37, 57, 52, 60, 113, 55, 62, 35, 113, 35, 36, 63, 37, 56, 60, 52, 113, 53, 36, 60, 33, 56, 63, 54 }, e => (byte)(e ^ 81))));
			pvdhfOHSOPcLWFdCOcmLWzsfY = UejvRLLHFzQTz_LurHPfAhoSey<string, TextField>(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, Settings.Object.inter.renameExportsBlacklist, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 253, 192, 200, 215, 202, 204, 152, 253, 192, 219, 212, 205, 203, 209, 215, 214 }, e => (byte)(e ^ 184))), pEmOuSwBIOgCDuJYzvxCZIZBTB => {
				Settings.Object.inter.renameExportsBlacklist = pEmOuSwBIOgCDuJYzvxCZIZBTB;
			}, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 229, 192, 218, 221, 137, 204, 209, 217, 198, 219, 221, 137, 199, 200, 196, 204, 218, 137, 129, 198, 199, 204, 137, 217, 204, 219, 137, 197, 192, 199, 204, 128, 137, 221, 198, 137, 204, 209, 202, 197, 220, 205, 204, 137, 207, 219, 198, 196, 137, 142, 251, 204, 199, 200, 196, 204, 137, 236, 209, 217, 198, 219, 221, 218, 142, 137, 200, 199, 205, 137, 142, 255, 204, 219, 192, 207, 208, 137, 236, 209, 217, 198, 219, 221, 137, 234, 200, 197, 197, 218, 142, 135, 137, 252, 218, 204, 137, 207, 198, 219, 137, 202, 198, 196, 217, 200, 221, 192, 203, 192, 197, 192, 221, 208, 137, 222, 192, 221, 193, 137, 221, 193, 192, 219, 205, 132, 217, 200, 219, 221, 208, 137, 217, 200, 202, 194, 200, 206, 204, 218 }, e => (byte)(e ^ 169))));
			pvdhfOHSOPcLWFdCOcmLWzsfY.multiline = true;
			pvdhfOHSOPcLWFdCOcmLWzsfY.style.display = Settings.Object.inter.checkFunctionCalls || Settings.Object.inter.renameExports ? DisplayStyle.Flex : DisplayStyle.None;
			UejvRLLHFzQTz_LurHPfAhoSey<bool, Toggle>(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, Settings.Object.inter.removeMonoExports, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 247, 192, 200, 202, 211, 192, 133, 232, 202, 203, 202, 133, 224, 221, 213, 202, 215, 209, 214 }, e => (byte)(e ^ 165))), EgAdTbwOGyIdWyGldWmxhIbbEMoq => {
				Settings.Object.inter.removeMonoExports = EgAdTbwOGyIdWyGldWmxhIbbEMoq;
			}, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 46, 25, 17, 19, 10, 25, 15, 92, 9, 18, 9, 15, 25, 24, 92, 49, 19, 18, 19, 92, 31, 19, 17, 12, 29, 8, 21, 30, 21, 16, 21, 8, 5, 92, 25, 4, 12, 19, 14, 8, 15, 92, 8, 19, 92, 14, 25, 24, 9, 31, 25, 92, 30, 21, 18, 29, 14, 5, 92, 15, 21, 6, 25, 92, 29, 18, 24, 92, 29, 8, 8, 29, 31, 23, 92, 15, 9, 14, 26, 29, 31, 25 }, e => (byte)(e ^ 124))));
			UejvRLLHFzQTz_LurHPfAhoSey<bool, Toggle>(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, Settings.Object.inter.modifyInternalStructures, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 148, 182, 189, 176, 191, 160, 249, 144, 183, 173, 188, 171, 183, 184, 181, 249, 138, 173, 171, 172, 186, 173, 172, 171, 188, 170, 249, 229, 187, 231, 241, 156, 161, 169, 188, 171, 176, 180, 188, 183, 173, 184, 181, 240, 229, 246, 187, 231 }, e => (byte)(e ^ 217))), YprDjKXKJdjLBLaGIyNjAfyXMegYOg => {
				Settings.Object.inter.modifyInternalStructures = YprDjKXKJdjLBLaGIyNjAfyXMegYOg;
			}, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 112, 82, 89, 84, 91, 84, 88, 78, 29, 84, 83, 73, 88, 79, 83, 92, 81, 29, 116, 113, 15, 126, 109, 109, 29, 89, 92, 73, 92, 29, 78, 73, 79, 72, 94, 73, 72, 79, 88, 78, 29, 73, 82, 29, 95, 79, 88, 92, 86, 29, 92, 89, 75, 92, 83, 94, 88, 89, 29, 79, 72, 83, 73, 84, 80, 88, 29, 92, 83, 92, 81, 68, 78, 84, 78, 29, 92, 83, 89, 29, 89, 72, 80, 77, 84, 83, 90, 29, 73, 82, 82, 81, 78 }, e => (byte)(e ^ 61))));
			TextField lWRLNcRqPszKgbH_eZBEoNjsQfhmwmqQ = null;
			UejvRLLHFzQTz_LurHPfAhoSey<bool, Toggle>(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, Settings.Object.inter.detectProxyLibraries, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 93, 124, 109, 124, 122, 109, 57, 73, 107, 118, 97, 96, 57, 85, 112, 123, 107, 120, 107, 112, 124, 106 }, e => (byte)(e ^ 25))), ngYOiSLSxJBEj_oEUDuMtiyq => {
				Settings.Object.inter.detectProxyLibraries = ngYOiSLSxJBEj_oEUDuMtiyq;
				lWRLNcRqPszKgbH_eZBEoNjsQfhmwmqQ.style.display = Settings.Object.inter.detectProxyLibraries ? DisplayStyle.Flex : DisplayStyle.None;
			}, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 235, 219, 217, 214, 203, 152, 222, 215, 202, 152, 219, 215, 213, 213, 215, 214, 152, 200, 202, 215, 192, 193, 152, 212, 209, 218, 202, 217, 202, 209, 221, 203, 152, 144, 252, 244, 244, 203, 145, 152, 215, 222, 204, 221, 214, 152, 205, 203, 221, 220, 152, 222, 215, 202, 152, 219, 208, 221, 217, 204, 209, 214, 223 }, e => (byte)(e ^ 184))));
			lWRLNcRqPszKgbH_eZBEoNjsQfhmwmqQ = UejvRLLHFzQTz_LurHPfAhoSey<string, TextField>(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, Settings.Object.inter.detectProxyLibrariesWhitelist, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 70, 100, 121, 110, 111, 54, 83, 110, 117, 122, 99, 101, 127, 121, 120 }, e => (byte)(e ^ 22))), MbEgBEAYxRuhtIvoMMjiOZudtZhdx => {
				Settings.Object.inter.detectProxyLibrariesWhitelist = MbEgBEAYxRuhtIvoMMjiOZudtZhdx;
			}, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 170, 143, 149, 146, 198, 162, 170, 170, 198, 136, 135, 139, 131, 149, 198, 206, 137, 136, 131, 198, 150, 131, 148, 198, 138, 143, 136, 131, 202, 198, 131, 200, 129, 200, 198, 193, 171, 159, 171, 137, 130, 200, 130, 138, 138, 193, 207, 198, 146, 137, 198, 135, 138, 138, 137, 145, 198, 145, 142, 131, 136, 198, 193, 162, 131, 146, 131, 133, 146, 198, 182, 148, 137, 158, 159, 198, 170, 143, 132, 148, 135, 148, 143, 131, 149, 193, 198, 143, 149, 198, 131, 136, 135, 132, 138, 131, 130 }, e => (byte)(e ^ 230))));
			lWRLNcRqPszKgbH_eZBEoNjsQfhmwmqQ.multiline = true;
			lWRLNcRqPszKgbH_eZBEoNjsQfhmwmqQ.style.display = Settings.Object.inter.detectProxyLibraries ? DisplayStyle.Flex : DisplayStyle.None;
			mZwybUXwkYQnSfPBfrSjuyNUg_FYowSp(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, 8f);
			_SyPXQbAUdzQGhwfylzwCcSgzyvjfvl(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 227, 189, 225, 141, 186, 172, 171, 176, 173, 186, 255, 155, 186, 185, 190, 170, 179, 171, 255, 140, 186, 171, 171, 182, 177, 184, 172, 227, 240, 189, 225 }, e => (byte)(e ^ 223))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 144, 198, 151, 146 }, e => (byte)(e ^ 246))), () => {
				if (((bool)typeof(global::UnityEditor.EditorUtility).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 207, 226, 248, 251, 231, 234, 242, 207, 226, 234, 231, 228, 236 }, e => (byte)(e ^ 139))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string), typeof(string), typeof(string), typeof(string) }, null).Invoke(null, new object[] { (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 250, 209, 194, 196, 212, 214, 195, 216, 197 }, e => (byte)(e ^ 183)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 135, 180, 163, 230, 191, 169, 179, 230, 181, 179, 180, 163, 230, 191, 169, 179, 230, 177, 167, 168, 178, 230, 178, 169, 230, 180, 163, 181, 163, 178, 230, 178, 174, 163, 230, 181, 163, 178, 178, 175, 168, 161, 181, 230, 178, 169, 230, 162, 163, 160, 167, 179, 170, 178, 249 }, e => (byte)(e ^ 198)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 179, 145, 140, 128, 134, 134, 135 }, e => (byte)(e ^ 227)))), (string)(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 199, 229, 234, 231, 225, 232 }, e => (byte)(e ^ 132)))) }))) {
					typeof(global::Mfuscator.Settings).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 61, 10, 28, 10, 27 }, e => (byte)(e ^ 111))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(null, new object[] { });
					typeof(global::UnityEditor.EditorWindow).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 211, 252, 255, 227, 245 }, e => (byte)(e ^ 144))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(this, new object[] { });
					typeof(global::Mfuscator.YmStbcJggYWkrKJWKXtsCBXN).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 76, 82, 103, 72, 68, 75, 109, 105, 94, 66, 87, 109, 119, 66, 73, 79, 85, 84, 101, 75, 112, 64, 104, 101, 71, 117, 116, 99, 84 }, e => (byte)(e ^ 38))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(null, new object[] { });
				}
			});
			_SyPXQbAUdzQGhwfylzwCcSgzyvjfvl(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 105, 55, 107, 7, 48, 38, 33, 58, 39, 48, 117, 28, 25, 103, 22, 5, 5, 105, 122, 55, 107 }, e => (byte)(e ^ 85))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 189, 233, 190, 186 }, e => (byte)(e ^ 219))), () => {
				typeof(global::Mfuscator.zmgTdIZxfccbcRnAMARbduRqpNrh).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 203, 244, 247, 198, 237, 250, 246, 197, 203, 250, 225, 196, 194, 205, 236, 251, 217, 239, 249, 199, 246, 245, 245, 250, 246, 220, 206 }, e => (byte)(e ^ 131))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { }, null).Invoke(null, new object[] { });
			}, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 92, 107, 125, 122, 97, 124, 107, 125, 46, 97, 124, 103, 105, 103, 96, 111, 98, 46, 71, 66, 60, 77, 94, 94, 46, 104, 103, 98, 107, 125, 46, 104, 124, 97, 99, 46, 111, 46, 108, 111, 109, 101, 123, 126, 32, 46, 91, 125, 107, 46, 122, 102, 103, 125, 46, 122, 97, 46, 104, 103, 118, 46, 111, 46, 108, 124, 97, 101, 107, 96, 46, 108, 123, 103, 98, 106, 46, 125, 122, 111, 122, 107, 46, 111, 104, 122, 107, 124, 46, 111, 96, 46, 107, 124, 124, 97, 124 }, e => (byte)(e ^ 14))));
			void VNEVIsMswIAxpOIglUTyvm_uoqvYS(string text, string pFvmevjSydphzY_cZaUlCSVoXZGNGl, string vhvAOotSxLrXHGRmNuJYzqRJHVqQ, Color FaPdYXtBVtNgNl_ifPNGKnsmxLGjsLD = default) {
				_SyPXQbAUdzQGhwfylzwCcSgzyvjfvl(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, text, pFvmevjSydphzY_cZaUlCSVoXZGNGl, () => {
					typeof(global::UnityEngine.Application).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 158, 161, 180, 191, 132, 131, 157 }, e => (byte)(e ^ 209))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(vhvAOotSxLrXHGRmNuJYzqRJHVqQ) });
				}, qZMDv_ZuAiOQAtixkSzlGtRGqoJEZ: string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 117, 74, 95, 84, 26, 24 }, e => (byte)(e ^ 58))), vhvAOotSxLrXHGRmNuJYzqRJHVqQ, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 31 }, e => (byte)(e ^ 61)))), efV_aJRs_bGguQssJnGLLiKq: FaPdYXtBVtNgNl_ifPNGKnsmxLGjsLD);
			}
			VNEVIsMswIAxpOIglUTyvm_uoqvYS(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 115, 38, 113, 2, 41, 58, 60, 44, 46, 59, 32, 61, 111, 28, 46, 46, 28, 111, 103, 115, 44, 32, 35, 32, 61, 114, 108, 127, 127, 13, 9, 9, 9, 113, 115, 45, 113, 1, 42, 56, 115, 96, 45, 113, 115, 96, 44, 32, 35, 32, 61, 113, 102, 115, 96, 38, 113 }, e => (byte)(e ^ 79))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 138, 219, 137, 223 }, e => (byte)(e ^ 239))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 169, 181, 181, 177, 178, 251, 238, 238, 172, 167, 180, 178, 162, 160, 181, 174, 179, 239, 162, 174, 172 }, e => (byte)(e ^ 193))));
			VNEVIsMswIAxpOIglUTyvm_uoqvYS(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 111, 58, 109, 26, 32, 32, 38, 54, 115, 7, 33, 50, 48, 56, 54, 33, 111, 124, 58, 109 }, e => (byte)(e ^ 83))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 149, 196, 201, 192 }, e => (byte)(e ^ 240))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 192, 220, 220, 216, 219, 146, 135, 135, 207, 193, 220, 192, 221, 202, 134, 203, 199, 197, 135, 229, 205, 223, 193, 199, 206, 135, 201, 219, 219, 205, 220, 133, 193, 219, 219, 221, 205, 133, 220, 218, 201, 203, 195, 205, 218, 135, 193, 219, 219, 221, 205, 219 }, e => (byte)(e ^ 168))));
			VNEVIsMswIAxpOIglUTyvm_uoqvYS(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 12, 89, 14, 115, 95, 93, 93, 69, 94, 89, 68, 73, 16, 24, 12, 82, 14, 116, 89, 67, 83, 95, 66, 84, 12, 31, 82, 14, 25, 12, 31, 89, 14 }, e => (byte)(e ^ 48))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 178, 228, 236, 226 }, e => (byte)(e ^ 212))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 51, 47, 47, 43, 40, 97, 116, 116, 63, 50, 40, 56, 52, 41, 63, 117, 60, 60, 116, 47, 2, 29, 40, 47, 42, 63, 108, 49, 30 }, e => (byte)(e ^ 91))));
			VNEVIsMswIAxpOIglUTyvm_uoqvYS(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 224, 181, 226, 153, 177, 189, 181, 176, 224, 243, 181, 226 }, e => (byte)(e ^ 220))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 152, 206, 155, 206 }, e => (byte)(e ^ 254))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 138, 134, 142, 139, 147, 136, 221, 132, 136, 137, 147, 134, 132, 147, 167, 138, 130, 144, 201, 142, 132, 146 }, e => (byte)(e ^ 231))));
			VNEVIsMswIAxpOIglUTyvm_uoqvYS(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 69, 16, 71, 59, 12, 0, 89, 44, 10, 89, 24, 89, 58, 22, 31, 31, 28, 28, 69, 86, 16, 71 }, e => (byte)(e ^ 121))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 48, 102, 102, 98 }, e => (byte)(e ^ 86))), global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 56, 36, 36, 32, 35, 106, 127, 127, 59, 63, 125, 54, 57, 126, 51, 63, 61, 127, 61, 53, 39, 57, 63, 54 }, e => (byte)(e ^ 80))), Color.red);

			mZwybUXwkYQnSfPBfrSjuyNUg_FYowSp(FlWKPLyAfDS_cyHrzwUIQxUVUFZX, 0f);

			var cvJajawgRTQbxzxfkyOYlfKbKn = new VisualElement();
			cvJajawgRTQbxzxfkyOYlfKbKn.style.flexDirection = FlexDirection.Row;

			{
				void bRTDlNPsSsPzNTrOWpEOaEBpv(string text, string m_cdwOLCvXVmQVNwQLm_lIrvhbPT) {
					var KOLDnHnXdxaBqMWhUtK_NJChX = new Label() {
						text = text
					};
					fTFfaYiZjANaPgJPhHqVyYrfyILUlMt(KOLDnHnXdxaBqMWhUtK_NJChX);
					KOLDnHnXdxaBqMWhUtK_NJChX.style.marginBottom = 4f;

					typeof(global::UnityEngine.UIElements.VisualElement).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 171, 142, 142 }, e => (byte)(e ^ 234))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEngine.UIElements.VisualElement) }, null).Invoke(((object)(cvJajawgRTQbxzxfkyOYlfKbKn) ?? throw new global::System.NullReferenceException()), new object[] { (global::UnityEngine.UIElements.VisualElement)(KOLDnHnXdxaBqMWhUtK_NJChX) });

					if (m_cdwOLCvXVmQVNwQLm_lIrvhbPT != null) {
						KOLDnHnXdxaBqMWhUtK_NJChX.RegisterCallback<MouseEnterEvent>(hrypoHCzVdzr_RjRDcwsdvQeUI => {
							KOLDnHnXdxaBqMWhUtK_NJChX.text = string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 133, 204, 135 }, e => (byte)(e ^ 185))), KOLDnHnXdxaBqMWhUtK_NJChX.text, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 40, 59, 97, 42 }, e => (byte)(e ^ 20))));
						});
						KOLDnHnXdxaBqMWhUtK_NJChX.RegisterCallback<MouseLeaveEvent>(hHdkPzYeZtDLHhVNjrvyDYdqQUICBlHS => {
							KOLDnHnXdxaBqMWhUtK_NJChX.text = KOLDnHnXdxaBqMWhUtK_NJChX.text[3..^4];
						});
						KOLDnHnXdxaBqMWhUtK_NJChX.RegisterCallback<ClickEvent>(gBIpeDipxyWFPvX_lsMdFUWrvBV => {
							typeof(global::UnityEngine.Application).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 195, 252, 233, 226, 217, 222, 192 }, e => (byte)(e ^ 140))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(string) }, null).Invoke(null, new object[] { (string)(m_cdwOLCvXVmQVNwQLm_lIrvhbPT) });
						});
						KOLDnHnXdxaBqMWhUtK_NJChX.tooltip = string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 165, 154, 143, 132, 202, 200 }, e => (byte)(e ^ 234))), m_cdwOLCvXVmQVNwQLm_lIrvhbPT, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 220 }, e => (byte)(e ^ 254))));
					}
				}

				bRTDlNPsSsPzNTrOWpEOaEBpv(string.Concat(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 178, 129, 150, 151, 141, 139, 138, 222, 196, 216, 134, 218, 134 }, e => (byte)(e ^ 228))), Shared.xvejOdLeiCGDupJL_geTgtvHHsb, global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 191, 172, 225, 189 }, e => (byte)(e ^ 131)))), null);
				mZwybUXwkYQnSfPBfrSjuyNUg_FYowSp(cvJajawgRTQbxzxfkyOYlfKbKn, 0f);
				string[] lDKVVhrCYQoABGBFIficlXWXUmPUoDW = {
					global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 98, 106, 120, 33, 102, 108, 122 }, e => (byte)(e ^ 15)))
				};
				if (UnityEngine.Random.value < 0.03f)
					lDKVVhrCYQoABGBFIficlXWXUmPUoDW = new string[] {
						global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 108, 87, 94, 77, 84, 76, 31, 94, 77, 90, 31, 92, 80, 80, 83, 17, 31, 102, 80, 74, 24, 77, 90, 31, 75, 80, 80, 30 }, e => (byte)(e ^ 63))),
						global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 4, 56, 49, 62, 59, 112, 41, 63, 37, 112, 54, 63, 34, 112, 50, 53, 57, 62, 55, 112, 56, 53, 34, 53, 46 }, e => (byte)(e ^ 80)))
					};
				bRTDlNPsSsPzNTrOWpEOaEBpv(lDKVVhrCYQoABGBFIficlXWXUmPUoDW[((int)typeof(global::UnityEngine.Random).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 89, 106, 101, 108, 110 }, e => (byte)(e ^ 11))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(int), typeof(int) }, null).Invoke(null, new object[] { (int)(0), (int)(lDKVVhrCYQoABGBFIficlXWXUmPUoDW.Length) }))], global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 163, 191, 191, 187, 184, 241, 228, 228, 166, 174, 188, 229, 162, 168, 190, 228 }, e => (byte)(e ^ 203))));
			}

			typeof(global::UnityEngine.UIElements.VisualElement).GetMethod(global::System.Text.Encoding.UTF8.GetString(global::System.Array.ConvertAll(new byte[] { 187, 158, 158 }, e => (byte)(e ^ 250))), (global::System.Reflection.BindingFlags)60, null, new global::System.Type[] { typeof(global::UnityEngine.UIElements.VisualElement) }, null).Invoke(((object)(FlWKPLyAfDS_cyHrzwUIQxUVUFZX) ?? throw new global::System.NullReferenceException()), new object[] { (global::UnityEngine.UIElements.VisualElement)(cvJajawgRTQbxzxfkyOYlfKbKn) });
		}
	}
}
