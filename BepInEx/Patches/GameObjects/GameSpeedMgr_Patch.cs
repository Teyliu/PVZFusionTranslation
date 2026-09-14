using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(GameSpeedMgr))]
    public static class GameSpeedMgr_Patch
    {
        [HarmonyPatch(nameof(GameSpeedMgr.Update))]
        [HarmonyPostfix]
        private static void Post_Update(GameSpeedMgr __instance)
        {
            if (__instance != null && __instance.tmp != null)
            {
                StringStore.TranslateTextUI(__instance.tmp);
            }
        }
    }
}
