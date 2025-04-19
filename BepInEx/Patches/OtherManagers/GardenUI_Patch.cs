using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.OtherManagers
{
	[HarmonyPatch(typeof(GardenUI))]
	public static class GardenUI_Patch
	{
		[HarmonyPatch(nameof(GardenUI.Update))]
		[HarmonyPostfix]
		public static void Update(GardenUI __instance)
		{
			__instance.currentPageText = StringStore.TranslateText(__instance.currentPageText, false);
			__instance.currentPageText2 = StringStore.TranslateText(__instance.currentPageText2, false);
		}
	}
}
