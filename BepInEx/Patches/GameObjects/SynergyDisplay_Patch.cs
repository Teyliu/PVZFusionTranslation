using HarmonyLib;
using System;
using System.Collections.Generic;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(SynergyDisplay))]
    public static class SynergyDisplay_Patch
    {
        [HarmonyPatch(typeof(SynergyDisplay), "GetText", new Type[] { typeof(string) })]
        [HarmonyPostfix]
        private static void Post_GetText(ref string __result)
        {
            if (string.IsNullOrEmpty(__result))
                return;

            string translatedText = Managers.TravelMgr_Patch.MatchTravelBuff(__result);
            if (!string.IsNullOrEmpty(translatedText))
            {
                __result = translatedText;
            }
        }

        [HarmonyPatch(nameof(SynergyDisplay.UpdateText))]
        [HarmonyPostfix]
        private static void Post_UpdateText(SynergyDisplay __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (__instance.text1 != null)
            {
                string translatedText = StringStore.TranslateText(__instance.text1.text, false);
                __instance.text1.text = translatedText;
                __instance.text1.font = fontAsset;
            }

            if (__instance.text_shadow != null)
            {
                string translatedShadowText = Utils.RemoveColorTags(__instance.text_shadow.text);
                __instance.text_shadow.text = translatedShadowText;
                __instance.text_shadow.font = fontAsset;
            }
        }
    }
}
