using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System;
using TMPro;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.BaseTextObjects
{
	[HarmonyPatch(typeof(InGameText))]
	public static class InGameText_Patch
	{
		[HarmonyPatch(nameof(InGameText.EnableText), new Type[] { typeof(string), typeof(float), typeof(bool) })]
		[HarmonyPrefix]
		private static void EnableText(InGameText __instance, ref string text) => text = StringStore.TranslateText(text, true);

		[HarmonyPatch(nameof(InGameText.EnableText), new Type[] { typeof(string), typeof(float), typeof(bool) })]
		[HarmonyPostfix]
		private static void EnableText(InGameText __instance)
		{
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

			__instance.t.text = StringStore.TranslateText(__instance.t.text, true);
			__instance.t.font = fontAsset;
		}
	}
}
