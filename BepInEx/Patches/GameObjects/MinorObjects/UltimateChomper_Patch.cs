using HarmonyLib;
using System;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(UltimateChomper), nameof(UltimateChomper.UpdateText))]
    public static class UltimateChomper_Patch
    {
        [HarmonyPostfix]
        public static void UpdateText(UltimateChomper __instance)
        {
            StringStore.TranslateText(__instance.killingText);
            StringStore.TranslateText(__instance.killingTextShadow);
        }
    }
}