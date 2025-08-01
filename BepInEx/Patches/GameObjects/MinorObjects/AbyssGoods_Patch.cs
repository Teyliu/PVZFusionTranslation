using HarmonyLib;
using System;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(AbyssGoods))]
    public static class AbyssGoods_Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch(nameof(AbyssGoods.Start))]
        private static void Start(AbyssGoods __instance)
        {
            __instance.costText.text = StringStore.TranslateText(__instance.costText.text, false);
            __instance.costText_shadow.text = StringStore.TranslateText(__instance.costText_shadow.text, false);
            __instance.hasText.text = StringStore.TranslateText(__instance.hasText.text, false);
            __instance.hasText_shadow.text = StringStore.TranslateText(__instance.hasText_shadow.text, false);
        }
    }
}
