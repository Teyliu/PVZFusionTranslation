using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.BaseTextObjects
{
	[HarmonyPatch(typeof(TextMeshProUGUI))]
	public static class TextMeshProUGUI_Patch
	{
		[HarmonyPatch(nameof(TextMeshProUGUI.OnEnable))]
		[HarmonyPostfix]
		private static void OnEnable(TextMeshProUGUI __instance)
		{
			if (!string.IsNullOrEmpty(__instance.text))
			{
				__instance = StringStore.TranslateText(__instance);
				__instance.autoSizeTextContainer = false;

				if (__instance.name.StartsWith("LevelName"))
				{
					__instance.text = __instance.text.Replace("\n", " ");
				}
				if ((__instance.transform.parent != null) && (__instance.transform.parent.name.StartsWith("Window")))
				{
					__instance.fontSizeMin = 10;
					__instance.fontSize = 12;
				}

				// __instance.ForceMeshUpdate();
			}
		}

		[HarmonyPatch(nameof(TextMeshProUGUI.Awake))]
		[HarmonyPostfix]
		private static void Awake(TextMeshProUGUI __instance)
		{
			if (!string.IsNullOrEmpty(__instance.text))
			{
				__instance = StringStore.TranslateText(__instance);
				__instance.autoSizeTextContainer = false;

				if (__instance.name.StartsWith("LevelName"))
				{
					__instance.text = __instance.text.Replace("\n", " ");
				}
				if ((__instance.transform.parent != null) && (__instance.transform.parent.name.StartsWith("Window")))
				{
					__instance.fontSizeMin = 10;
					__instance.fontSize = 12;
				}

				if (__instance.text == "Полный Хаос" && __instance.transform.parent.parent.Find("Image").GetComponent<Image>().activeSprite.name == "Present")
				{
					__instance.text += "\nБесконечно";
				}

				// __instance.ForceMeshUpdate();
			}
		}
	}
	[HarmonyPatch(typeof(TMP_SubMeshUI))]
	public static class TMP_SubMeshUI_Patch
	{
		[HarmonyPatch(nameof(TMP_SubMeshUI.OnEnable))]
		[HarmonyPostfix]
		public static void OnEnable(TMP_SubMeshUI __instance)
		{
			if (!string.IsNullOrEmpty(__instance.textComponent.text))
			{
				string text = StringStore.TranslateText(__instance.textComponent.text);
				__instance.m_TextComponent.text = StringStore.TranslateText(text);
				__instance.textComponent.text = StringStore.TranslateText(text);
			}
		}
	}
}
