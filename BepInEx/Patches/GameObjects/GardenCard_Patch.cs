using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(GardenCard))]
	public static class GardenCard_Patch
    {
		[HarmonyPatch(nameof(GardenCard.Start))]
		[HarmonyPostfix]
		private static void Start(GardenCard __instance)
		{
			__instance.text.text = StringStore.TranslateText(__instance.text.text).Replace("26", "16");
		}

		[HarmonyPatch(nameof(GardenCard.ChangeCardSprite))]
		[HarmonyPostfix]
		private static void ChangeCardSprite(GardenCard __instance)
		{
            __instance.text.text = StringStore.TranslateText(__instance.text.text).Replace("26", "16");
        }
    }
}
