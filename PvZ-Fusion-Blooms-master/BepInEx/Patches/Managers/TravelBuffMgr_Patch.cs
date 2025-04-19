using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(TravelBuffMgr))]
	public static class TravelBuffMgr_Patch
	{
		[HarmonyPatch(nameof(TravelBuffMgr.Awake))]
		[HarmonyPostfix]
		private static void Awake(TravelBuffMgr __instance)
		{
			__instance.text = StringStore.TranslateText(__instance.text);
			__instance.text2 = StringStore.TranslateText(__instance.text2);
		}

		[HarmonyPatch(nameof(TravelBuffMgr.ShowText), new Type[] { typeof(int), typeof(int) })]
		[HarmonyPostfix]
		private static void ShowText(TravelBuffMgr __instance)
		{
			__instance.text = StringStore.TranslateText(__instance.text);
			__instance.text2 = StringStore.TranslateText(__instance.text2);
		}
	}
}
