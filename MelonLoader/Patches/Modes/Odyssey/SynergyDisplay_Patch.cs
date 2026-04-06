using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.Patches.Modes.Odyssey.TravelMgr_Patch;
using UnityEngine;
using MelonLoader;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(SynergyDisplay))]
    public static class SynergyDisplay_Patch
    {
        [HarmonyPatch(nameof(SynergyDisplay.Start))]
        [HarmonyPostfix]
        public static void Start(SynergyDisplay __instance)
        {
            __instance.text1.text = TranslateInvestDisplay(__instance.text1.text);
            __instance.text_shadow.text = Utils.RemoveColorTags(__instance.text1.text);
        }

        public static string TranslateInvestDisplay(string originalText)
        {
            string[] parts = originalText.Split("\n\n");
            List<string> translatedParts = new List<string>();
            foreach(string part in parts)
            {
                translatedParts.Add(StringStore.TranslateColorText(part));
            }
            return String.Join("\n\n", translatedParts);
        }
    }
}