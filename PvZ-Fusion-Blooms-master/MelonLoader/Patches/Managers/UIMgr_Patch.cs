using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Managers
{
	[HarmonyPatch(typeof(UIMgr))]
	public class UIMgr_Patch
	{
		[HarmonyPatch(nameof(UIMgr.EnterMainMenu))]
		[HarmonyPostfix]
		private static void EnterMainMenu(UIMgr __instance)
		{
			// Log.LogInfo("Entered Main Menu");
			#if MULTI_LANGUAGE
			WarningStore.WarningReload(Utils.Language);
			#else
			WarningStore.WarningReload();
			#endif
		}
	}
}