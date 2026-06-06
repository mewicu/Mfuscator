This editor-only tool was developed to protect Unity IL2CPP builds using several uncommon techniques found in AAA games (e.g., Genshin Impact).
These techniques include layout-randomized metadata encryption, export modification, and initialization pattern obfuscation.

The entire process is automated, and the asset does not contain any demo scenes.
By importing Mfuscator and initiating the build, the protection measures are applied.
To examine the result, try to dump the build with any popular Unity IL2CPP dumping tool (or dumper).

[!] Close the editor and delete the "Mfuscator" folder before updating.
[!] If you use other build postprocessing scripts, you can configure the callback order in the "Window/MFS Settings" window to avoid any conflicts.
Use "PlayerPrefs.SetString("MFS_IGNORE", "-");" and "PlayerPrefs.DeleteKey("MFS_IGNORE");" to disable/enable MFS in your custom building pipeline.

The settings are designed for advanced users; however, you can hover the cursor over them to get more information in a tooltip.

iOS builds (advanced users, experimental)
----------------------------------------------------------------

IMPORTANT UPDATE !!! Please note that starting with Unity 6, lib2ilcpp is automatically
compiled in Xcode, and you don't need to do anything. This information remains for users of previous versions of Unity.

In Unity, for non-iOS targets, the IL2CPP library is compiled directly from the source code during the build.
For iOS, however, Unity relies on a precompiled static library ("libil2cpp.a"). When exporting an Xcode project, Unity
references this prebuilt "libil2cpp.a" file (via copy or symbolic link). Therefore, when building for iOS, you need to manually
compile a new "libil2cpp.a" separately, then replace the default version in the exported Xcode project.

Mfuscator lets you automate this step via a custom build processor:
```csharp
// MyBuildProcessor.cs

#if UNITY_EDITOR
using System.IO;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

internal sealed class MyBuildProcessor : IPreprocessBuildWithReport, IPostprocessBuildWithReport {

	// the value must be "<" than "Callback Order" in "MFS Settings"
	public int callbackOrder => 1000;

	private static bool _doNotContinue;

	public void OnPreprocessBuild(BuildReport report) {
		_doNotContinue = false;

		// only for OSX editor -> iOS
		if (Application.platform != RuntimePlatform.OSXEditor || report.summary.platform != UnityEditor.BuildTarget.iOS) {
			_doNotContinue = true;
			return;
		}

		// this lets Mfuscator know that a proper build processor is implemented
		PlayerPrefs.SetInt("MFS_IOS_IMPL", 1);
	}
	public void OnPostprocessBuild(BuildReport report) {
		if (_doNotContinue)
			return;

		string iL2CPPSourcePath = Path.Combine(Mfuscator.Pipeline.EditorPath, "Unity.app", "Contents", "il2cpp");
		string librariesPath = Path.Combine(report.summary.outputPath, "Libraries");
		string iL2CPPIncludePath = Path.Combine(librariesPath, "libil2cpp", "include");
		string libIL2CPPFilepath = Path.Combine(librariesPath, "libil2cpp.a");
		Debug.Log($"Source: \"{iL2CPPSourcePath}\"\nLibraries: \"{librariesPath}\"\nInclude: \"{iL2CPPIncludePath}\"\nTarget: \"{libIL2CPPFilepath}\"");

		// HERE: implement code that will compile a new "libil2cpp.a" file from the source and replace the one in
		// Xcode. For simplicity, you can install CMake, generate a "CMakeLists.txt" file, and execute it with C#'s "Process.Start"

		// use "iL2CPPSourcePath" only for reading

		// clear
		PlayerPrefs.DeleteKey("MFS_IOS_IMPL");
	}
}
#endif
```

END ------------------------------------------------------------

FREQUENTLY ASKED QUESTIONS:

1. I get a "The current system user does not have full access" error when building.
- To fix the error, you need to either run Unity as an administrator (not recommended) or grant
the current system user read and write access to the folder and subfolders where Unity Editor is installed.
The default path for Windows is "C:\Program Files\Unity\Hub".

2. Mfuscator deletes my files on build.
- To clarify Mfuscator's intended behavior: The tool is designed to only clear the build target
folder (the folder where Unity generates its build output, e.g., "Project/Builds/Android") to ensure Unity's cache
regenerates properly. It should never delete files outside this directory. It is recommended to have a separate build
folder for each platform (e.g., ".../Build/Android/Your.apk") and avoid using root or high-level
directories (like a parent folder containing critical files) as the build target.

3. I can't update the package. I get a "Cannot Delete" error.
- Close Unity Editor to release the process, navigate to the path where your
project is located, and delete the "Mfuscator" folder. Then you can open Unity
again and import the new version.

4. A third-party antivirus interferes with the game process or generates false positives.
- To avoid false positives, your ".exe"/".dll" PE files must be signed with a valid
digital signature (see https://www.digicert.com/faq/code-signing-trust/what-is-code-signing).
Note that anti-viruses usually have whitelisting services, and if for some reason you still have false positives with a valid signature, you should
send an email to the anti-virus whitelisting service to have them manually whitelist your game.

5. My project building process and startup times increased.
- Unity depends on caching to avoid compiling all code on each build; thus, builds are substantially faster
than the first and nearly instantaneous if the C# code remains unchanged. Mfuscator generates different IL2CPP code
for each build to make automated dumping more challenging. This means that Unity must compile new code with
each build, which takes more time. Similarly, generated obfuscated code can increase the startup time of your game.
It is recommended to enable Mfuscator only when building for shipping to save time.

6. I'm getting a "DllNotFoundException" exception on macOS.
- This is typically caused by macOS's security features blocking an unrecognized dynamic library.
To fix this, you need to grant the Unity Editor special permissions. Navigate to "System Settings > Privacy & Security",
find the "Developer Tools" list, and add your Unity Editor application ("Unity.app") to it. This allows
Unity to use libraries without being blocked by security prompts. Restart Unity after making this change.

[!] If MFS doesn't compile but there are no errors in the console after the build, make sure you have automatic
cleanup disabled ("Clear on Build", "Clear on Recompile").

If you encounter any issues, please feel free to email contact@mew.icu, and we will try to help you as soon as we can.
https://mew.icu/
