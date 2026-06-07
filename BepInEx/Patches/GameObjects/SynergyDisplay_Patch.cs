using HarmonyLib;
using System;
using System.Collections.Generic;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;

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

            string translatedText = TravelMgr_Patch.MatchTravelBuff(__result);
            if (!string.IsNullOrEmpty(translatedText) && translatedText != __result)
            {
                __result = translatedText;
            }
            else
            {
                string translatedColorText = StringStore.TranslateColorText(__result);
                if (translatedColorText != __result)
                {
                    __result = translatedColorText;
                }
            }
        }

        [HarmonyPatch(nameof(SynergyDisplay.UpdateText))]
        [HarmonyPostfix]
        private static void Post_UpdateText(SynergyDisplay __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (__instance.text != null)
            {
                string originalText = __instance.text.text;
                string translatedText = TranslateInvestDisplay(originalText);
                __instance.text.text = translatedText;
                __instance.text.font = fontAsset;
            }
        }

        public static string TranslateInvestDisplay(string originalText)
        {
            if (string.IsNullOrEmpty(originalText))
                return originalText;

            string[] parts = originalText.Split("\n\n");
            List<string> translatedParts = new List<string>();

            foreach (string part in parts)
            {
                string translated = StringStore.TranslateColorText(part);
                if (translated == part)
                {
                    translated = StringStore.TranslateText(part);
                }

                if (translated == part)
                {
                    string matched = Managers.TravelMgr_Patch.MatchTravelBuff(part);
                    if (!string.IsNullOrEmpty(matched) && matched != part)
                    {
                        translated = matched;
                    }
                }

                translatedParts.Add(translated);
            }

            return string.Join("\n\n", translatedParts);
        }
    }
}
