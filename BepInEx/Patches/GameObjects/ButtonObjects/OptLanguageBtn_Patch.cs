#if MULTI_LANGUAGE
using HarmonyLib;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;
using BepInEx.Configuration;
using BepInEx;
using UnityEngine.Experimental.Rendering.RenderGraphModule;
using BepInEx.Unity.IL2CPP.Utils;
using Unity.VisualScripting.FullSerializer;

public class OptionButtonData
{
	public OptionBtn Button { get; set; }
	public Vector3 Position { get; set; }
	public Utils.LanguageEnum? Language { get; set; }
	public Utils.ToggleEnum? Toggle { get; set; }
	public bool IsNextButton { get; set; }
	public bool shifted = false;
}

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
	internal class OptLanguageBtn_Patch
	{
		public static Dictionary<int, OptionButtonData> LanguageBtnDict = new();
		public static Dictionary<int, OptionButtonData> ToggleBtnDict = new();
        public static bool buttonsCreated = false;
		public static bool togglesCreated = false;
        public static OptionBtn cachedTemplateButton;
        public static OptionBtn cachedTemplateToggleButton;

        private const float startX = 4.3241f + 2.56f;
		private const float startY = 2.7769f;
		private const float ySpacing = 1.2505f;

		private const float toggleStartX = 4.3241f;
		private const float toggleStartY = -0.9746f;

        private static List<Utils.LanguageEnum> AvailableLanguages;
        private static List<Utils.ToggleEnum> AvailableToggles;
        private const int LanguagesPerPage = 5;
		private static int currentPage = 0;
		private static OptionBtn[] buttonSlots = new OptionBtn[6];
		private static OptionBtn[] toggleSlots = new OptionBtn[3];

        private static bool IsInLanguageMenu(OptionBtn btn)
        {
            if (btn.tag == "LangOpt")
                return true;

            Transform parent = btn.transform.parent;
            while (parent != null)
            {
                if (parent.name == "LanguageMenu")
                    return true;
                parent = parent.parent;
            }
            return false;
        }

        public static void InitializeLanguageMenu(OptionBtn templateButton)
        {
            cachedTemplateButton = templateButton;
            CreateLanguageButtons(cachedTemplateButton);
            CreateToggleButtons(cachedTemplateButton);
            UpdatePage();
        }

        public static void CreateLanguageButtons(OptionBtn templateButton)
		{
			if (buttonsCreated) return;
			buttonsCreated = true;
			cachedTemplateButton = templateButton;

			AvailableLanguages = Enum.GetValues(typeof(Utils.LanguageEnum))
				.Cast<Utils.LanguageEnum>()
				.Where(lang => lang != Utils.LanguageEnum.LANG_END)
				.ToList();

			for (int i = 0; i < 6; i++)
			{
				var newButton = Object.Instantiate(templateButton, templateButton.transform.parent);
				newButton.optionType = 80 + i;
				newButton.tag = "LangOpt";

				float yPos = startY - i * ySpacing;
				Vector3 pos = new(startX, yPos);
				newButton.transform.position = pos;

				buttonSlots[i] = newButton;

				LanguageBtnDict[newButton.GetInstanceID()] = new OptionButtonData
				{
					Button = newButton,
					Position = pos
				};
			}
		}

		public static void CreateToggleButtons(OptionBtn templateButton)
		{
            if (togglesCreated) return;
            togglesCreated = true;
            cachedTemplateToggleButton = templateButton;

            AvailableToggles = Enum.GetValues(typeof(Utils.ToggleEnum))
                .Cast<Utils.ToggleEnum>()
                .Where(lang => lang != Utils.ToggleEnum.TOGGLE_END)
                .ToList();

            for (int i = 0; i < 3; i++)
            {
                var newButton = Object.Instantiate(templateButton, templateButton.transform.parent);
                newButton.optionType = 100 + i;
                newButton.tag = "LangOpt";

                float yPos = toggleStartY - i * ySpacing;
                Vector3 pos = new(toggleStartX, yPos);
                newButton.transform.position = pos;

                toggleSlots[i] = newButton;

                ToggleBtnDict[newButton.GetInstanceID()] = new OptionButtonData
                {
                    Button = newButton,
                    Position = pos
                };
            }
        }

		private static void UpdatePage()
		{
			if (buttonSlots == null) buttonSlots = new OptionBtn[6];
			if (toggleSlots == null) toggleSlots = new OptionBtn[3];
			
			int startIndex = currentPage * LanguagesPerPage;
			int langCount = (AvailableLanguages != null) ? AvailableLanguages.Count : 0;
			int toggleCount = (togglesCreated && AvailableToggles != null) ? AvailableToggles.Count : 0;

            for (int i = 0; i < 5; i++)
			{
				if (buttonSlots[i] == null) continue;
				var btn = buttonSlots[i];
				
				if (!LanguageBtnDict.TryGetValue(btn.GetInstanceID(), out var data)) continue;

				if (startIndex + i < langCount)
				{
					var lang = AvailableLanguages[startIndex + i];
					data.Language = lang;
					data.IsNextButton = false;
					btn.gameObject.SetActive(true);
					UpdateButtonText(btn, lang.ToString());
				}
				else
				{
					data.Language = null;
					data.IsNextButton = false;
					btn.gameObject.SetActive(false);
				}
			}

			if (togglesCreated)
			{
				for (int i = 0; i < 3; i++)
				{
					if (toggleSlots[i] == null) continue;
					var btn = toggleSlots[i];
					
					if (!ToggleBtnDict.TryGetValue(btn.GetInstanceID(), out var data)) continue;

					if (i < toggleCount)
					{
						var toggle = AvailableToggles[i];
						data.Toggle = toggle;
						data.IsNextButton = false;
						btn.gameObject.SetActive(true);
						string buttonText = Utils.ToggleNames[toggle];
						UpdateButtonText(btn, buttonText);
					}
					else
					{
						data.Language = null;
						data.IsNextButton = false;
						btn.gameObject.SetActive(false);
					}
				}
			}

			if (buttonSlots[5] != null)
			{
				if (LanguageBtnDict.TryGetValue(buttonSlots[5].GetInstanceID(), out var nextData))
				{
					nextData.Language = null;
					nextData.IsNextButton = true;
					buttonSlots[5].gameObject.SetActive(true);
					UpdateButtonText(buttonSlots[5], "Next");
				}
			}
		}

		public static void UpdateButtonText(OptionBtn button, string languageName)
		{
			TMP_FontAsset defaultAsset = FontStore.LoadTMPFont("English");

			for (int i = 0; i < 3; i++)
			{
				Transform textTransform = button.transform.GetChild(i);
				if (textTransform != null)
				{
					if (i == 0) textTransform.gameObject.SetActive(false);

					TextMeshProUGUI text = textTransform.GetComponent<TextMeshProUGUI>();
					if (text != null)
					{
						if (i == 0)
						{
							text.text = "";
							text.color = Color.red;
						}
						else
						{
							text.text = languageName;
						}
						text.fontSize = 16;
						text.font = defaultAsset;
						text.autoSizeTextContainer = false;
					}
				}
			}
		}

		private static void FlashMessage(OptionBtn button, string message, float yShift = 0.0f)
		{
			var child = button.transform.GetChild(0);
			if (child != null)
			{
				var text = child.GetComponent<TextMeshProUGUI>();
				if (text != null)
                {
                    text.text = message;
					OptionButtonData data;
                    bool isToggle = ToggleBtnDict.TryGetValue(button.GetInstanceID(), out data);

					if(isToggle)
					{
                        text.transform.position = new Vector3(text.transform.position.x, text.transform.position.y + (ToggleBtnDict[button.GetInstanceID()].shifted ? 0.0f : yShift), text.transform.position.z);
						ToggleBtnDict[button.GetInstanceID()].shifted = true;
                    }
                    else
					{
                        text.transform.position = new Vector3(text.transform.position.x, text.transform.position.y + (LanguageBtnDict[button.GetInstanceID()].shifted ? 0.0f : yShift), text.transform.position.z);
						LanguageBtnDict[button.GetInstanceID()].shifted = true;
                    }
				}
				child.gameObject.SetActive(true);

                System.Threading.Tasks.Task.Delay(1000).ContinueWith(_ =>
				{
					if (button != null && child != null && child.gameObject.activeSelf)
					{
						child.gameObject.SetActive(false);
					}
				});
			}
		}

		private static void ToggleCustomAssets(string type)
		{
			if (type != "Textures" && type != "Audio" && type != "SwapLocal") return;

            if (type == "Textures")
            {
                ConfigEntry<bool> customTexturesEntry;
                Core.Instance.Config.TryGetEntry<bool>(new ConfigDefinition("PvZ_Fusion_Translator", "DefaultTextures"), out customTexturesEntry);
                customTexturesEntry.BoxedValue = !customTexturesEntry.Value;
                TextureStore.Reload();
                if (Core.MonoInstance != null)
                    Core.MonoInstance.StartCoroutine(TextureStore.ReplaceTexturesCoroutine());
            }

            if (type == "Audio")
            {
                ConfigEntry<bool> customAudioEntry;
                Core.Instance.Config.TryGetEntry<bool>(new ConfigDefinition("PvZ_Fusion_Translator", "DefaultAudio"), out customAudioEntry);
                customAudioEntry.BoxedValue = !customAudioEntry.Value;
            }

			if (type == "SwapLocal")
			{
                Utils.WarnLocalData();
            }

            Core.Instance.Config.Save();
        }

        [HarmonyPatch(typeof(OptionBtn))]
		public static class OptLangBtn_Patch
		{
			[HarmonyPatch(nameof(OptionBtn.Awake))]
			[HarmonyPostfix]
			private static void Awake(OptionBtn __instance)
			{
				if (!IsInLanguageMenu(__instance))
					return;
				
				if (LanguageBtnDict.ContainsKey(__instance.GetInstanceID()) || 
				   ToggleBtnDict.ContainsKey(__instance.GetInstanceID()))
				{
					return;
				}
				
				if (cachedTemplateButton == null)
				{
					cachedTemplateButton = __instance;
				}
				
				if (cachedTemplateButton != null && !buttonsCreated)
				{
					CreateLanguageButtons(cachedTemplateButton);
				}
				
				if (cachedTemplateButton != null && !togglesCreated)
				{
					CreateToggleButtons(cachedTemplateButton);
				}
				
				if (buttonsCreated && togglesCreated)
				{
					UpdatePage();
				}
			}

			[HarmonyPatch("OnMouseUpAsButton")]
			[HarmonyPrefix]
			private static void OnMouseUpAsButton(OptionBtn __instance)
			{
				if (LanguageBtnDict.TryGetValue(__instance.GetInstanceID(), out var btnData))
				{
					if (btnData.IsNextButton)
					{
						currentPage = (currentPage + 1) % (int)Math.Ceiling((float)AvailableLanguages.Count / LanguagesPerPage);
						UpdatePage();
						return;
					}

					if (btnData.Language is Utils.LanguageEnum selectedLang)
					{
						string currentLang = Utils.Language.ToString();

						if (currentLang == selectedLang.ToString())
						{
							FlashMessage(btnData.Button, "Already Selected!");
						}
						else
						{
							Utils.ChangeLanguage(selectedLang.ToString());
							Debug.Log($"Language changed to: {selectedLang}");
							FlashMessage(btnData.Button, "Language Changed!");
						}
					}
				}

				if (ToggleBtnDict.TryGetValue(__instance.GetInstanceID(), out var toggleData))
				{
					string toggleType = toggleData.Toggle.ToString();
					ToggleCustomAssets(toggleType);
					if (toggleType == "Textures")
					{
						FlashMessage(toggleData.Button, "<size=10>Toggled custom textures!\n(Restart Required)", 0.1f);
					}
					else if (toggleType == "Audio")
					{
						FlashMessage(toggleData.Button, "<size=10>Toggled custom audio!", 0.1f);
					}
				}
			}

			[HarmonyPatch(nameof(OptionBtn.Update))]
			[HarmonyPostfix]
			private static void Update(OptionBtn __instance)
			{
				if (LanguageBtnDict.TryGetValue(__instance.GetInstanceID(), out var btnData))
				{
					btnData.Button.transform.position = btnData.Position;
				}

				if (ToggleBtnDict.TryGetValue(__instance.GetInstanceID(), out var toggleData))
				{
					toggleData.Button.transform.position = toggleData.Position;
				}
			}
		}
	}
}
#endif