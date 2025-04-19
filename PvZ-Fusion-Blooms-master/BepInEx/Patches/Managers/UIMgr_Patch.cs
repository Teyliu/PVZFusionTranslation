using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(UIMgr))]
	public class UIMgr_Patch
	{
		[HarmonyPatch(nameof(UIMgr.EnterMainMenu))]
		[HarmonyPostfix]
		private static void EnterMainMenu(UIMgr __instance)
		{
			// Log.LogInfo("Entered Main Menu");
			WarningStore.WarningReload(Utils.Language);
		}
	}
}
