using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(UIDifficulty))]
	public static class UIDifficulty_Patch
	{
		[HarmonyPatch(nameof(UIDifficulty.Update))]
		[HarmonyPostfix]
		private static void Update(UIDifficulty __instance)
		{
			__instance.t.text = StringStore.TranslateText(__instance.t.text);
			foreach(TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
			{
				text.text = StringStore.TranslateText(text.text);
			}
		}
	}
}