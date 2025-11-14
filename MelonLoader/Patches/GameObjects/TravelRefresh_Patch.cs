using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelRefresh))]
    public static class TravelRefresh_Patch
    {
        [HarmonyPatch(nameof(TravelRefresh.Start))]
        [HarmonyPostfix]
        private static void Start(TravelRefresh __instance)
        {
            __instance.text = StringStore.TranslateText(__instance.text);
            __instance.text_shadow = StringStore.TranslateText(__instance.text_shadow);
        }

        [HarmonyPatch(nameof(TravelRefresh.OnMouseUpAsButton))]
        [HarmonyPostfix]
        private static void OnMouseUpAsButton(TravelRefresh __instance)
        {
            __instance.text = StringStore.TranslateText(__instance.text);
            __instance.text_shadow = StringStore.TranslateText(__instance.text_shadow);
        }
    }
}
