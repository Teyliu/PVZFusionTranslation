using HarmonyLib;
using System;
using System.Collections.Generic;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;
using System.Linq;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    public static class TravelStore_Patch
    {
        [HarmonyPatch(nameof(TravelStore.Start))]
        [HarmonyPostfix]
        private static void Start(TravelStore __instance)
        {
            Log.LogInfo($"[TravelStore_Patch] Start called. investText: {__instance.investText?.text}");
            TranslateStoreText(__instance);
        }

        [HarmonyPatch(nameof(TravelStore.Update))]
        [HarmonyPostfix]
        private static void Update(TravelStore __instance)
        {
            if (__instance.pointText != null)
            {
                foreach (var textMesh in __instance.pointText)
                {
                    textMesh.text = StringStore.TranslateText(textMesh.text);
                }
            }
            
            if (__instance.refreshText != null)
            {
                foreach (var textMesh in __instance.refreshText)
                {
                    textMesh.text = StringStore.TranslateText(textMesh.text);
                }
            }
        }

        [HarmonyPatch(nameof(TravelStore.RefreshBuff))]
        [HarmonyPostfix]
        private static void RefreshBuff(TravelStore __instance)
        {
            Log.LogInfo("[TravelStore_Patch] RefreshBuff called");
            TranslateStoreText(__instance);
        }

        [HarmonyPatch(nameof(TravelStore.SelectBuff))]
        [HarmonyPostfix]
        private static void SelectBuff(TravelStore __instance, ref TravelStoreWindow window)
        {
            Log.LogInfo($"[TravelStore_Patch] SelectBuff called. window: {window != null}");
            TranslateStoreText(__instance);

            if (window != null && window.buttonText != null)
            {
                foreach (var text in window.buttonText)
                {
                    text.text = StringStore.TranslateText(text.text);
                }
            }

            if (__instance.investText != null)
            {
                string original = __instance.investText.text;
                __instance.investText.text = TranslateInvestText(__instance.investText.text);
                Log.LogInfo($"[TravelStore_Patch] investText translated: '{original}' -> '{__instance.investText.text}'");
#if DEBUG
                if (__instance.investText.text != original)
                {
                    FileLoader.DumpUntranslatedStrings(original);
                }
#endif
            }
            if (__instance.investTextshadow != null)
            {
                __instance.investTextshadow.text = TranslateInvestText(__instance.investTextshadow.text);
            }
        }

        public static void TranslateStoreText(TravelStore __instance)
        {
            if (__instance.investText != null)
            {
                string original = __instance.investText.text;
                __instance.investText.text = TranslateInvestText(__instance.investText.text);
                Log.LogInfo($"[TravelStore_Patch] TranslateStoreText - investText: '{original}' -> '{__instance.investText.text}'");
            }
            if (__instance.investTextshadow != null)
            {
                __instance.investTextshadow.text = TranslateInvestText(__instance.investTextshadow.text);
            }
            if (__instance.pointText != null)
            {
                foreach (var textMesh in __instance.pointText)
                {
                    textMesh.text = StringStore.TranslateText(textMesh.text);
                }
            }
            if (__instance.refreshText != null)
            {
                foreach (var textMesh in __instance.refreshText)
                {
                    textMesh.text = StringStore.TranslateText(textMesh.text);
                }
            }
        }

        public static string TranslateInvestText(string investText)
        {
            if (string.IsNullOrEmpty(investText))
                return investText;

            Log.LogInfo($"[TravelStore_Patch] TranslateInvestText input: '{investText}'");

            string[] investStats = investText.Split("&&");
            List<string> translatedInvestStats = new List<string>();

            foreach (string investStat in investStats)
            {
                string[] lines = investStat.Split("\n");
                List<string> translatedLines = new List<string>();

                foreach (string line in lines)
                {
                    string translatedLine = Managers.TravelMgr_Patch.MatchTravelBuff(line);
                    if (string.IsNullOrEmpty(translatedLine))
                    {
                        translatedLine = StringStore.TranslateColorText(line);
                    }
                    translatedLines.Add(translatedLine);
                }

                string translatedInvestStat = string.Join("\n", translatedLines);
                translatedInvestStats.Add(translatedInvestStat);
            }

            string result = string.Join("&&", translatedInvestStats);
            Log.LogInfo($"[TravelStore_Patch] TranslateInvestText output: '{result}'");

#if DEBUG
            if (result != investText)
            {
                FileLoader.DumpUntranslatedStrings(investText);
            }
#endif

            return result;
        }

        [HarmonyPatch(typeof(TravelStoreWindow), nameof(TravelStoreWindow.SetType))]
        [HarmonyPostfix]
        private static void SetType(TravelStoreWindow __instance, int index, BuffType buffType)
        {
            Log.LogInfo($"[TravelStore_Patch] SetType called. buffType: {buffType}, index: {index}");
            
            if (__instance.set && __instance.buttonText != null)
            {
                string originalText = TravelMgr.Instance.GetText((int)buffType, index);
                string translatedText = Managers.TravelMgr_Patch.ResolveBuffTranslation(buffType, index, originalText);
                
                Log.LogInfo($"[TravelStore_Patch] SetType original: '{originalText}', translated: '{translatedText}'");

                if (!string.IsNullOrEmpty(translatedText) && translatedText != originalText)
                {
                    foreach (var textMesh in __instance.buttonText)
                    {
                        if (textMesh != null)
                        {
                            textMesh.text = translatedText;
                        }
                    }
                }
            }
        }
    }
}
