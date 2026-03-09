using HarmonyLib;
using System;
using System.Collections.Generic;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;
using System.Text.RegularExpressions;

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

            Log.LogInfo($"[SynergyDisplay_Patch] GetText called with: '{__result}'");

            string translatedText = Managers.TravelMgr_Patch.MatchTravelBuff(__result);
            if (!string.IsNullOrEmpty(translatedText) && translatedText != __result)
            {
                Log.LogInfo($"[SynergyDisplay_Patch] Found translation via MatchTravelBuff: '{translatedText}'");
                __result = translatedText;
#if DEBUG
                FileLoader.DumpUntranslatedStrings(__result);
#endif
            }
            else
            {
                string translatedColorText = StringStore.TranslateColorText(__result);
                if (translatedColorText != __result)
                {
                    Log.LogInfo($"[SynergyDisplay_Patch] Found translation via TranslateColorText: '{translatedColorText}'");
                    __result = translatedColorText;
#if DEBUG
                    FileLoader.DumpUntranslatedStrings(__result);
#endif
                }
            }
        }

        [HarmonyPatch(nameof(SynergyDisplay.UpdateText))]
        [HarmonyPostfix]
        private static void Post_UpdateText(SynergyDisplay __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (__instance.text1 != null)
            {
                string originalText = __instance.text1.text;
                Log.LogInfo($"[SynergyDisplay_Patch] UpdateText original: '{originalText}'");
                
                string translatedText = TranslateInvestDisplay(originalText);
                __instance.text1.text = translatedText;
                __instance.text1.font = fontAsset;
                
                Log.LogInfo($"[SynergyDisplay_Patch] UpdateText translated: '{translatedText}'");
#if DEBUG
                if (translatedText != originalText)
                {
                    FileLoader.DumpUntranslatedStrings(originalText);
                }
#endif
            }

            if (__instance.text_shadow != null)
            {
                string translatedShadowText = Utils.RemoveColorTags(__instance.text_shadow.text);
                __instance.text_shadow.text = translatedShadowText;
                __instance.text_shadow.font = fontAsset;
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
