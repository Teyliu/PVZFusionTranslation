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
                string translatedInvestStat = StringStore.TranslateText(investStat);
                translatedInvestStats.Add(translatedInvestStat);
            }

            res = String.Join("\n\n", translatedInvestStats);

            return res;
        }
    }
}
