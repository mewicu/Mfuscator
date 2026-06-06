using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Mfuscator {

	[Serializable]
	internal sealed class SettingsObject {
		// defaults
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
	internal static class Settings {

		private static SettingsObject _object;
		public static SettingsObject Object {
			get {
				if (_object == null)
					Load();
				return _object;
			}
		}

		private const string _FILENAME = "MFSSettings.json";
		private static string Filepath => Path.Combine(Application.dataPath, "..", _FILENAME);

		public static void Load() {
			if (File.Exists(Filepath))
				try {
					_object = JsonUtility.FromJson<SettingsObject>(File.ReadAllText(Filepath));
					return;
				}
				catch (Exception e) {
					Utils.LogError($"Failed to load \"{Filepath}\"\n{e}");
				}
			_object = new();
			Save();
		}
		public static void Save() {
			// tabs (divine will)
			File.WriteAllText(Filepath, JsonUtility.ToJson(Object, true).Replace("    ", "\t") + '\n');
		}
		public static void Reset() {
			_object = new();
			Save();
		}
	}
	internal sealed class SettingsWindow : EditorWindow {

		// TODO: why "default"?
		[SerializeField]
		private Font _iconFont = default;

		// used to clear the cache for the builds after disabling MFS
		public const string CLEAR_CACHE_PP_SUB_KEY = "CLEAR_CACHE";

		[MenuItem("Window/MFS Settings", priority = 502)]
		private static void Open() {
			// TODO: redundant?
			Settings.Load();
			// https://youtu.be/GsOD6X-gUlw?t=91
			// TODO: remove
			_ = GetWindow<SettingsWindow>(false, "Mfuscator" + ((DateTime.UtcNow < new DateTime(2025, 1, 1)) ? " (Remastered)" : string.Empty));
		}
		private void OnFocus() {
			// TODO: redundant?
			Settings.Load();
		}
		private void CreateGUI() {
			var root = rootVisualElement;

			minSize = new(416f, 472f);
			//// TODO: safe?
			//maxSize = minSize;

			static void SetMargin(VisualElement element) {
				element.style.marginTop = element.style.marginRight = element.style.marginLeft = 4f;
				element.style.marginBottom = 0f;
			}
			static FieldT Add<ValueT, FieldT>(VisualElement root, ValueT v, string label, Action<ValueT> callback, string tooltip = null) where FieldT
				: BaseField<ValueT>, new() {
				var element = new FieldT {
					label = label,
					tooltip = tooltip
				};
				SetMargin(element);
				element.Q<Label>().style.minWidth = 192f;
				element.SetValueWithoutNotify(v);
				_ = element.RegisterValueChangedCallback<ValueT>(e => {
					callback.Invoke(e.newValue);
					Settings.Save();
				});
				root.Add(element);
				return element;
			}
			// TODO: "IntegerField" doesn't exist in earlier versions, so we do this
			static void AddInteger(VisualElement root, int v, string label, Action<int> callback, string tooltip = null) {
				Add<string, TextField>(root, v.ToString(), label, v => {
					if (!int.TryParse(v, out int vInt)) {
						_ = EditorUtility.DisplayDialog("Error", "Expected an integer", "Proceed");
						return;
					}
					callback.Invoke(vInt);
				}, tooltip);
			}
			void AddButton(VisualElement root, string text, string icon, Action callback, string tooltip = null, Color iconColor = default) {
				var button = new Button() {
					text = text,
					tooltip = tooltip
				};
				SetMargin(button);
				button.style.paddingTop = button.style.paddingBottom = button.style.paddingRight = button.style.paddingLeft = 4f;
				button.style.unityTextAlign = TextAnchor.MiddleLeft;

				// content
				{
					var label = new Label {
#if !UNITY_6000_0_OR_NEWER
						text = $"{(iconColor != default ? $"<color=#{ColorUtility.ToHtmlStringRGB(iconColor)}>" : string.Empty)}\\u{icon}"
#else
						text = $"{(iconColor != default ? $"<color=#{ColorUtility.ToHtmlStringRGB(iconColor)}>" : string.Empty)}{(char)Convert.ToInt32(icon, 16)}"
#endif
					};
					label.style.unityFont = _iconFont;
					label.style.unityFontDefinition = new();
					label.style.unityTextAlign = TextAnchor.MiddleRight;

					button.Add(label);
				}

				root.Add(button);

				button.clicked += callback;
			}
			static void AddSpacer(VisualElement root, float height) {
				var spacer = new VisualElement();
				if (height <= 0f)
					spacer.style.flexGrow = 1f;
				else
					spacer.style.height = height;

				root.Add(spacer);
			}

			// -> main
			Add<bool, Toggle>(root, Settings.Object.enable, "<b>Enable Core Layers</b>", v => {
				Settings.Object.enable = v;
				if (!Settings.Object.enable)
					PlayerPrefs.SetString(Utils.GetPlayerPrefsKey(CLEAR_CACHE_PP_SUB_KEY), "https://youtu.be/5lrqtbrI2xI");
			});
			AddInteger(root, Settings.Object.callbackOrder, "Callback Order", v => {
				Settings.Object.callbackOrder = v;
			}, "Adjusts the pre/post-build processing order. Modify this to resolve compatibility issues with other packages");
			Add<bool, Toggle>(root, Settings.Object.logInfo, "Log Info", v => {
				Settings.Object.logInfo = v;
			}, "Toggles informational messages in the Unity console. Disable to reduce log spam");
			Add<bool, Toggle>(root, Settings.Object.inter.removeStringLiterals, "Remove String Literals", v => {
				Settings.Object.inter.removeStringLiterals = v;
			}, "Removes string constants from the binary, making the disassembled code harder to analyze");
			Add<bool, Toggle>(root, Settings.Object.inter.preserveUnityCrashHandler, "Preserve Unity Crash Handler", v => {
				Settings.Object.inter.preserveUnityCrashHandler = v;
			}, "Prevents the removal of Unity's default crash handler. Enable if you rely on standard crash reporting");
			TextField renameExportsBlacklistTextField = null;
			Add<bool, Toggle>(root, Settings.Object.inter.checkFunctionCalls, "Verify Export Calls", v => {
				Settings.Object.inter.checkFunctionCalls = v;
				renameExportsBlacklistTextField.style.display = Settings.Object.inter.checkFunctionCalls || Settings.Object.inter.renameExports ? DisplayStyle.Flex : DisplayStyle.None;
			}, "Ensures IL2CPP exports are only called by the engine, which helps prevent runtime dumping");
			Add<bool, Toggle>(root, Settings.Object.inter.renameExports, "Rename Exports", v => {
				Settings.Object.inter.renameExports = v;
				renameExportsBlacklistTextField.style.display = Settings.Object.inter.checkFunctionCalls || Settings.Object.inter.renameExports ? DisplayStyle.Flex : DisplayStyle.None;
			}, "Renames IL2CPP exports to random names, breaking tools that rely on them for runtime dumping");
			renameExportsBlacklistTextField = Add<string, TextField>(root, Settings.Object.inter.renameExportsBlacklist, "Export Exclusion", v => {
				Settings.Object.inter.renameExportsBlacklist = v;
			}, "List export names (one per line) to exclude from 'Rename Exports' and 'Verify Export Calls'. Use for compatibility with third-party packages");
			renameExportsBlacklistTextField.multiline = true;
			renameExportsBlacklistTextField.style.display = Settings.Object.inter.checkFunctionCalls || Settings.Object.inter.renameExports ? DisplayStyle.Flex : DisplayStyle.None;
			Add<bool, Toggle>(root, Settings.Object.inter.removeMonoExports, "Remove Mono Exports", v => {
				Settings.Object.inter.removeMonoExports = v;
			}, "Removes unused Mono compatibility exports to reduce binary size and attack surface");
			Add<bool, Toggle>(root, Settings.Object.inter.modifyInternalStructures, "Modify Internal Structures <b>(Experimental)</b>", v => {
				Settings.Object.inter.modifyInternalStructures = v;
			}, "Modifies internal IL2CPP data structures to break advanced runtime analysis and dumping tools");
			TextField detectProxyLibrariesWhitelistTextField = null;
			Add<bool, Toggle>(root, Settings.Object.inter.detectProxyLibraries, "Detect Proxy Libraries", v => {
				Settings.Object.inter.detectProxyLibraries = v;
				detectProxyLibrariesWhitelistTextField.style.display = Settings.Object.inter.detectProxyLibraries ? DisplayStyle.Flex : DisplayStyle.None;
			}, "Scans for common proxy libraries (DLLs) often used for cheating");
			detectProxyLibrariesWhitelistTextField = Add<string, TextField>(root, Settings.Object.inter.detectProxyLibrariesWhitelist, "Proxy Exclusion", v => {
				Settings.Object.inter.detectProxyLibrariesWhitelist = v;
			}, "List DLL names (one per line, e.g. 'MyMod.dll') to allow when 'Detect Proxy Libraries' is enabled");
			detectProxyLibrariesWhitelistTextField.multiline = true;
			detectProxyLibrariesWhitelistTextField.style.display = Settings.Object.inter.detectProxyLibraries ? DisplayStyle.Flex : DisplayStyle.None;
			AddSpacer(root, 8f);
			AddButton(root, "<b>Restore Default Settings</b>", "f0ad", () => {
				if (EditorUtility.DisplayDialog("Mfuscator", "Are you sure you want to reset the settings to default?", "Proceed", "Cancel")) {
					Settings.Reset();
					Close();
					Open();
				}
			});
			AddButton(root, "<b>Restore IL2CPP</b>", "f2ea", () => {
				Pipeline.Restore();
			}, "Restores original IL2CPP files from a backup. Use this to fix a broken build state after an error");
			void AddURLButton(string text, string icon, string uRL, Color iconColor = default) {
				AddButton(root, text, icon, () => {
					Application.OpenURL(uRL);
				}, tooltip: $"Open \"{uRL}\"", iconColor: iconColor);
			}
			AddURLButton("<i>Mfuscator SaaS (<b>NEW</b>)</i>", "e4f0", "https://mfuscator.com");
			AddURLButton("<i>Issue Tracker</i>", "e490", "https://github.com/Mewiof/asset-issue-tracker/issues");
			AddURLButton("<i>Community (<b>Discord</b>)</i>", "f086", "https://discord.gg/tYFstqd7jE");
			AddURLButton("<i>Email</i>", "f0e0", "mailto:contact@mew.icu");
			AddURLButton("<i>Buy Us a Coffee</i>", "f004", "https://ko-fi.com/mewiof", Color.red);

			// -> spacer
			AddSpacer(root, 0f);

			// -> bottom
			var bottom = new VisualElement();
			bottom.style.flexDirection = FlexDirection.Row;

			// bottom content
			{
				void AddLabel(string text, string uRL) {
					var label = new Label() {
						text = text
					};
					SetMargin(label);
					label.style.marginBottom = 4f;

					bottom.Add(label);

					if (uRL != null) {
						label.RegisterCallback<MouseEnterEvent>(e => {
							label.text = $"<u>{label.text}</u>";
						});
						label.RegisterCallback<MouseLeaveEvent>(e => {
							label.text = label.text[3..^4];
						});
						label.RegisterCallback<ClickEvent>(e => {
							Application.OpenURL(uRL);
						});
						label.tooltip = $"Open \"{uRL}\"";
					}
				}

				AddLabel($"Version: <b>b{Shared.BUILD_NUMBER}</b>", null);
				AddSpacer(bottom, 0f);
				string[] ego = {
					"mew.icu"
				};
				// 5% chance
				if (UnityEngine.Random.value < 0.05f)
					ego = new string[] {
						"Sharks are cool. You're too!",
						"Thank you for being here~"
					};
				AddLabel(ego[UnityEngine.Random.Range(0, ego.Length)], "https://mew.icu/");
			}

			root.Add(bottom);
		}
	}
}
