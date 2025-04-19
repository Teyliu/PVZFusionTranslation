using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using Object = UnityEngine.Object;

public class OptionButtonData
{
	public OptionBtn Button { get; set; }
	public Vector3 Position { get; set; }
	public Utils.LanguageEnum? Language { get; set; } // Null if it's the "Next" button
	public bool IsNextButton { get; set; }
}

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
	internal class OptLanguageBtn_Patch
	{
		public static Dictionary<int, OptionButtonData> LanguageBtnDict = new();
		private static bool buttonsCreated = false;
		private static OptionBtn cachedTemplateButton;

		private const float startX = 4.3241f + 2.56f;
		private const float startY = 2.7769f;
		private const float ySpacing = 1.2505f;

		private static List<Utils.LanguageEnum> AvailableLanguages;
		private const int LanguagesPerPage = 5;
		private static int currentPage = 0;
		private static OptionBtn[] buttonSlots = new OptionBtn[6]; // 5 language buttons + 1 next button

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

			UpdatePage();
		}

		private static void UpdatePage()
		{
			int startIndex = currentPage * LanguagesPerPage;
			int langCount = AvailableLanguages.Count;

			for (int i = 0; i < 5; i++)
			{
				var btn = buttonSlots[i];
				var data = LanguageBtnDict[btn.GetInstanceID()];

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

			// "Next" button always visible at index 5
			var nextBtn = buttonSlots[5];
			var nextData = LanguageBtnDict[nextBtn.GetInstanceID()];
			nextData.Language = null;
			nextData.IsNextButton = true;
			nextBtn.gameObject.SetActive(true);
			UpdateButtonText(nextBtn, "Next");
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

		private static void FlashMessage(OptionBtn button, string message)
		{
			var child = button.transform.GetChild(0);
			if (child != null)
			{
				var text = child.GetComponent<TextMeshProUGUI>();
				if (text != null)
				{
					text.text = message;
				}
				child.gameObject.SetActive(true);

				Task.Delay(1000).ContinueWith(_ =>
				{
					if (button != null && child != null && child.gameObject.activeSelf)
					{
						child.gameObject.SetActive(false);
					}
				});
			}
		}

		[HarmonyPatch(typeof(OptionBtn))]
		public static class OptLangBtn_Patch
		{
			[HarmonyPatch(nameof(OptionBtn.Awake))]
			[HarmonyPostfix]
			private static void Awake(OptionBtn __instance)
			{
				if (!buttonsCreated || cachedTemplateButton == null)
				{
					buttonsCreated = false;
					CreateLanguageButtons(__instance);
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
			}

			[HarmonyPatch(nameof(OptionBtn.Update))]
			[HarmonyPostfix]
			private static void Update(OptionBtn __instance)
			{
				if (LanguageBtnDict.TryGetValue(__instance.GetInstanceID(), out var btnData))
				{
					btnData.Button.transform.position = btnData.Position;
				}
			}
		}
	}
}
