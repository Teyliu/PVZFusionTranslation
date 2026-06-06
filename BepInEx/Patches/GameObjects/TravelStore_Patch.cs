using HarmonyLib;
using System.Collections.Generic;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    public static class TravelStore_Patch
    {
        [HarmonyPatch(nameof(TravelStore.Start))]
        [HarmonyPostfix]
        private static void Start(TravelStore __instance)
        {
            Log.LogInfo("==== [TravelStore.Start] ====");
            TranslateStoreText(__instance);
        }

        [HarmonyPatch(nameof(TravelStore.Update))]
        [HarmonyPostfix]
        private static void Update(TravelStore __instance)
        {
            TranslateStoreText(__instance);
        }

        [HarmonyPatch(nameof(TravelStore.RefreshBuff))]
        [HarmonyPostfix]
        private static void RefreshBuff(TravelStore __instance)
        {
            TranslateStoreText(__instance);
        }

        [HarmonyPatch(nameof(TravelStore.SelectBuff))]
        [HarmonyPostfix]
        private static void SelectBuff(TravelStore __instance, ref TravelStoreWindow window)
        {
            TranslateStoreText(__instance);

            if (window != null && window.buttonText != null)
            {
                foreach (var text in window.buttonText)
                {
                    text.text = StringStore.TranslateText(text.text);
                }
            }

            __instance.investText.text = TranslateInvestText(__instance.investText.text);
            __instance.investTextshadow.text = TranslateInvestText(__instance.investTextshadow.text);
        }

        public static void TranslateStoreText(TravelStore __instance)
        {
            Log.LogInfo("==== [TravelStore_Patch.TranslateStoreText] ====");
            
            if (__instance.investText != null)
            {
                __instance.investText.text = TranslateInvestText(__instance.investText.text);
            }
            if (__instance.investTextshadow != null)
            {
                __instance.investTextshadow.text = TranslateInvestText(__instance.investTextshadow.text);
            }
            if (__instance.pointText != null)
            {
                foreach (var text in __instance.pointText)
                {
                    text.text = StringStore.TranslateText(text.text);
                }
            }
            if (__instance.refreshText != null)
            {
                foreach (var text in __instance.refreshText)
                {
                    text.text = StringStore.TranslateText(text.text);
                }
            }
            Transform quitTransform = __instance.transform.Find("Quit");
            if (quitTransform != null)
            {
                foreach (TextMeshProUGUI text in quitTransform.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    text.text = StringStore.TranslateText("合上");
                }
            }
        }

        public static string TranslateInvestText(string investText)
        {
            if (string.IsNullOrEmpty(investText))
                return investText;

            if (!Utils.CheckForUntranslatedText(investText))
            {
                return investText;
            }

            string[] investStats = investText.Split("\n\n");
            List<string> translatedInvestStats = new List<string>();

            foreach (string investStat in investStats)
            {
                string[] lines = investStat.Split("\n");
                List<string> translatedLines = new List<string>();

                foreach (string line in lines)
                {
                    translatedLines.Add(TravelMgr_Patch.TranslateTravelText(line));
                }

                string translatedInvestStat = string.Join("\n", translatedLines);
                translatedInvestStats.Add(translatedInvestStat);
            }

            string result = string.Join("\n\n", translatedInvestStats);
            Log.LogInfo($"[TravelStore_Patch] TranslateInvestText: \"{investText}\" -> \"{result}\"");

            return result;
        }
    }
}