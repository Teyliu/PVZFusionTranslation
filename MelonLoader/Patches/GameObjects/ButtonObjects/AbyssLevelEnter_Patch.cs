using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
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
