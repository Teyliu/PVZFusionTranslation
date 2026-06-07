using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    // [HarmonyPatch(typeof(OppositeBuffManager))]  // REMOVED in 3.7 - replaced by OppsiteBuff (static class)
    public static class OppositeBuffManager_Patch
    {
        public static string badPattern = @"^但(.*)";
        public static string badFormat = StringStore.translationStringRegex != null && StringStore.translationStringRegex.ContainsKey(badPattern) ? StringStore.translationStringRegex[badPattern] : "But, {0}";

        // [HarmonyPatch(nameof(OppositeBuffManager.Awake))]
        // [HarmonyPostfix]
        // private static void Awake(OppositeBuffManager __instance)
        // {
        //     string goodAText = TravelMgr.Instance.GetText(__instance.buffA.goodBuff);
        //     string badAText = TravelMgr.Instance.GetText(__instance.buffA.badBuff);
        //     string goodBText = TravelMgr.Instance.GetText(__instance.buffB.goodBuff);
        //     string badBText = TravelMgr.Instance.GetText(__instance.buffB.badBuff);
        //     string badAFormatted = string.Format(badFormat, badAText);
        //     string badBFormatted = string.Format(badFormat, badBText);
        //     if (__instance.textA_good != null)
        //         foreach (var t in __instance.textA_good)
        //             if (t != null) { t.text = goodAText; t.font = fontAsset; }
        //     if (__instance.textA_bad != null)
        //         foreach (var t in __instance.textA_bad)
        //             if (t != null) { t.text = badAFormatted; t.font = fontAsset; }
        //     if (__instance.textB_good != null)
        //         foreach (var t in __instance.textB_good)
        //             if (t != null) { t.text = goodBText; t.font = fontAsset; }
        //     if (__instance.textB_bad != null)
        //         foreach (var t in __instance.textB_bad)
        //             if (t != null) { t.text = badBFormatted; t.font = fontAsset; }
        // }
    }
}