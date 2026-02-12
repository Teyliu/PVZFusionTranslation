using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.Patches.Modes.Odyssey.TravelMgr_Patch;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(TravelStore))]
    public static class TravelStore_Patch
    {
        [HarmonyPatch(nameof(TravelStore.Start))]
        [HarmonyPostfix]
        private static void Start(TravelStore __instance)
        {
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

            foreach (var text in window.buttonText)
            {
                text.text = StringStore.TranslateText(text.text);
            }

            __instance.investText.text = TranslateInvestText(__instance.investText.text);
            __instance.investTextshadow.text = TranslateInvestText(__instance.investTextshadow.text);
        }

        public static void TranslateStoreText(TravelStore __instance)
        {
            __instance.investText.text = TranslateInvestText(__instance.investText.text);
            __instance.investTextshadow.text = TranslateInvestText(__instance.investTextshadow.text);

            foreach (var text in __instance.pointText)
            {
                text.text = StringStore.TranslateText(text.text);
            }
            foreach (var text in __instance.refreshText)
            {
                text.text = StringStore.TranslateText(text.text);
            }
            foreach(var text in __instance.transform.Find("Quit").GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText("合上");
            }
        }

        public static string TranslateInvestText(string investText)
        {
            string res = investText;

            string[] investStats = investText.Split("\n\n");
            List<string> translatedInvestStats = new List<string>();
            foreach(string investStat in investStats)
            {
                string[] lines = investStat.Split("\n");
                List<string> translatedLines = new List<string>();
                foreach(string line in lines)
                {
                    translatedLines.Add(StringStore.TranslateColorText(line));
                }
                string translatedInvestStat = String.Join("\n", translatedLines);
                translatedInvestStats.Add(translatedInvestStat);
            }

            res = String.Join("\n\n", translatedInvestStats);

            return res;
        }
    }
}
