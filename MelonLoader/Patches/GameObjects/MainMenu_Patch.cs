using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(MainMenu))]
    public class MainMenu_Patch
    {
        private static bool _warningShown = false;

        [HarmonyPostfix]
        [HarmonyPatch(nameof(MainMenu.FixedUpdate))]
        private static void FixedUpdate(MainMenu __instance)
        {
            if (_warningShown || NoticeMenu.Instance == null)
                return;

            WarningStore.WarningReload(Utils.Language, NoticeMenu.Instance);
            _warningShown = true;
        }
    }
}