using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using UnityEngine;
using static Il2CppSystem.Globalization.TimeSpanFormat;
using static PvZ_Fusion_Translator.Patches.Modes.Odyssey.TravelMgr_Patch;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(TravelStoreWindow))]
    public static class TravelStoreWindow_Patch
    {
        [HarmonyPatch(nameof(TravelStoreWindow.SetType))]
        [HarmonyPostfix]
        private static void SetType(TravelStoreWindow __instance)
        {
            /*var buffSet = translatedTravelBuffs[buffLinks[__instance.buffType]];

            string buff = __instance.show != null && __instance.introduce.text != "词条已选完" ? buffSet[__instance.buffIndex] : StringStore.TranslateText("词条已选完");*/
            string originalText = __instance.introduce.text;
            string affinityPattern = "([\\s\\S]+)(\\\n<color=red>)([\\s\\S]+)(<\\/color>)";
            if(Regex.IsMatch(__instance.introduce.text, affinityPattern, options: RegexOptions.Singleline))
            {
                Match match = Regex.Match(__instance.introduce.text, affinityPattern, options: RegexOptions.Singleline);
                string startText = match.Groups[1].Value;
                string affinityText = match.Groups[3].Value;
                string affinities = TranslateAffinities(affinityText);
                __instance.introduce.text = AddBuffName(startText) + affinities;
            }
            else
            {
                __instance.introduce.text = AddBuffName(originalText);
            }

            foreach (var text in __instance.buttonText)
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        [HarmonyPatch(nameof(TravelStoreWindow.UpdateButtonText))]
        [HarmonyPostfix]
        private static void UpdateButtonText(TravelStoreWindow __instance)
        {
            foreach (var text in __instance.buttonText)
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        public static string TranslateAffinities(string originalText)
        {
            string result = "";
            List<string> translatedAffinities = [];

            string[] lines = originalText.Split('\n');

            foreach(string line in lines)
            {
                if (string.IsNullOrEmpty(line)) continue;

                string fStr = StringStore.translationStringRegex.ContainsKey("【([^\\s]+)】_IV") ? StringStore.translationStringRegex["【([^\\s]+)】_IV"] : "[{0}]";
                
                // Extract dynamic parts from the original text
                var regex = new Regex("【([^\\s]+)】");
                var match = regex.Match(line);
                int groupCount = match.Groups.Count;

                // List to hold formatted dynamic parts
                List<string> dynamicParts = [];

                // Loop through each group and determine its translation
                for (int i = 1; i < groupCount; i++)
                {
                    string groupValue = match.Groups[i].Value;
                    string translatedValue = StringStore.translationString.ContainsKey(groupValue)
                        ? StringStore.translationString[groupValue]
                        : groupValue;
                    dynamicParts.Add(translatedValue);
                }

                // Format the output string with dynamic parts
                string translatedAffinity = string.Format(fStr, [.. dynamicParts]);
                translatedAffinities.Add(translatedAffinity);
            }

            result = "\n" + "<color=red>" + String.Join("\n", translatedAffinities) + "</color>";
            return result;
        }
    }
}
