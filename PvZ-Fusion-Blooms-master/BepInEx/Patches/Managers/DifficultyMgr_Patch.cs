using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(DifficultyMgr))]
	public static class DifficultyMgr_Patch
	{
		[HarmonyPatch(nameof(DifficultyMgr.Update))]
		[HarmonyPostfix]
		private static void DifficultyMgr_Update(DifficultyMgr __instance)
		{
			__instance.t = StringStore.TranslateText(__instance.t);
			__instance.t.autoSizeTextContainer = false;
		}
	}
}
