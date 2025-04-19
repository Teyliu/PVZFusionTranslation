using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Managers
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
