using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using Il2CppZenGarden;

namespace PvZ_Fusion_Translator.Patches.OtherManagers
{
    [HarmonyPatch(typeof(GardenUI))]
	public static class GardenUI_Patch
	{
		[HarmonyPatch(nameof(GardenUI.Update))]
		[HarmonyPostfix]
		public static void Update(GardenUI __instance)
		{
			__instance.currentPageText = StringStore.TranslateText(__instance.currentPageText, false);

			// Transform PageText = __instance.transform.Find("PageText");
            // StringStore.TranslateTextTransform(PageText.transform);
		}
	}
}
