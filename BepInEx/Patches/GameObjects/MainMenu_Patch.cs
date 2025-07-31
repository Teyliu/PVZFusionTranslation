using HarmonyLib;

using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(MainMenu))]
    public class MainMenu_Patch
    {
        private static bool _warningShown = false;

        [HarmonyPostfix]
        [HarmonyPatch("AnimOver")]
        private static void AnimOver(MainMenu __instance)
		{
			bool flag = _warningShown || NoticeMenu.Instance == null;
			if (!flag)
			{
				WarningStore.WarningReload(Utils.Language, NoticeMenu.Instance);
				_warningShown = true;
			}
		}
    }
}