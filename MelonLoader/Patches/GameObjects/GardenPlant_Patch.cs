using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(GardenPlant))]
	public static class GardenPlant_Patch
	{
		[HarmonyPatch(nameof(GardenPlant.Update))]
		[HarmonyPostfix]
		private static void Update(GardenPlant __instance)
		{
			__instance.infoText = StringStore.TranslateText(__instance.infoText);
		}

		[HarmonyPatch(nameof(GardenPlant.UpdateInfo))]
		[HarmonyPostfix]
		private static void UpdateInfo(GardenPlant __instance)
		{
			__instance.infoText = StringStore.TranslateText(__instance.infoText);
		}
	}
}