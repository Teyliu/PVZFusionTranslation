using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.Patches.Modes.Odyssey.TravelMgr_Patch;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(TravelStoreWindow))]
    public static class TravelStoreWindow_Patch
    {
        [HarmonyPatch(nameof(TravelStoreWindow.SetType))]
        [HarmonyPostfix]
        private static void SetType(TravelStoreWindow __instance)
        {
            var buffSet = translatedTravelBuffs[buffLinks[__instance.buffType]];

            string buff = __instance.show != null && __instance.introduce.text != "词条已选完" ? buffSet[__instance.buffIndex] : StringStore.TranslateText("词条已选完");
            string originalText = __instance.introduce.text;

            string affinities = TranslateAffinities(originalText);

            __instance.introduce.text = buff + affinities;

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
            string discolored = Utils.RemoveColorTags(originalText);
            int firstNewlineIndex = discolored.IndexOf('\n');

            string result = "";
            List<string> translatedAffinities = [];

            if(firstNewlineIndex >= 0)
            {
                string affinityString = discolored.Substring(firstNewlineIndex);
                string[] affinities = affinityString.Split('\n');

                string fStr = StringStore.translationStringRegex.ContainsKey("【([^\\s]+)】_IV") ? StringStore.translationStringRegex["【([^\\s]+)】_IV"] : "[{0}]";
                string originalPattern = "【([^\\s]+)】";

                foreach (string affinity in affinities)
                {
                    if(affinity != "")
                    {
                        string translatedAffinity = affinity;
                        if (StringStore.TestRegex(affinity, originalPattern))
                        {
                            // Extract dynamic parts from the original text
                            var regex = new Regex(originalPattern);
                            var match = regex.Match(affinity);
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
                            translatedAffinity = string.Format(fStr, [.. dynamicParts]);
                        }

                        translatedAffinities.Add(translatedAffinity);
                    }
                }
                result = "\n" + "<color=red>" + String.Join("\n", translatedAffinities) + "</color>";
            }

            return result;
        }
    }
}
