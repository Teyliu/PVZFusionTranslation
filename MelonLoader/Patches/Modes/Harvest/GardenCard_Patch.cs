using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
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
