using HarmonyLib;

using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(AbyssLevelEnter))]
    public static class AbyssLevelEnter_Patch
    {
        [HarmonyPatch(nameof(AbyssLevelEnter.SetLevel))]
        [HarmonyPostfix]
        private static void SetLevel(AbyssLevelEnter __instance)
        {
            __instance.levelName = StringStore.TranslateText(__instance.levelName);
        }
    }
}
