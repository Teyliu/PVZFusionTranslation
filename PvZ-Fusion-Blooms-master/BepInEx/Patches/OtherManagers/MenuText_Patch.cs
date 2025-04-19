using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System;
using TMPro;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.OtherManagers
{
   [HarmonyPatch(typeof(MenuText))]
	public static class MenuText_Patch
	{
		[HarmonyPatch(nameof(MenuText.UpdateText), new Type[] { typeof(string) })]
		[HarmonyPostfix]
		private static void UpdateTextPatch(MenuText __instance)
		{
			TextMeshProUGUI text_1 = __instance.transform.GetChild(0).Find("text1").GetComponent<TextMeshProUGUI>();
			text_1.text = StringStore.TranslateText(text_1.text);
			TextMeshProUGUI text = __instance.transform.GetChild(0).Find("text").GetComponent<TextMeshProUGUI>();
			text.text = StringStore.TranslateText(text_1.text);
		}
	}
}
