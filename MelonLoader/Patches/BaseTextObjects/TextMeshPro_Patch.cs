﻿using HarmonyLib;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.BaseTextObjects
{
    [HarmonyPatch(typeof(TextMeshPro))]
    public static class TextMeshPro_Patch
    {
        [HarmonyPatch(nameof(TextMeshPro.OnEnable))]
        [HarmonyPostfix]
        private static void OnEnable(TextMeshPro __instance)
        {
            if (!string.IsNullOrEmpty(__instance.text))
            {
                if (__instance.transform.parent.name.StartsWith("AlmanacHelp") || __instance.transform.parent.name.StartsWith("CardBank"))
                {
                    __instance = StringStore.TranslateText(__instance);
                    __instance.autoSizeTextContainer = false;
                    return;
                } else if (!(__instance.transform.name.Contains("AlmanacZombie") || __instance.transform.name.Contains("AlmanacPlant")))
                {
                    __instance = StringStore.TranslateText(__instance);
                    __instance.autoSizeTextContainer = true;
                }
            }
        }  
    }
}