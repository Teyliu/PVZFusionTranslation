using HarmonyLib;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelStoreWindow))]
    public static class TravelStoreWindow_Patch
    {
        [HarmonyPatch(nameof(TravelStoreWindow.SetType))]
        [HarmonyPostfix]
        private static void SetType(TravelStoreWindow __instance, object buff)
        {
            Log.LogInfo("==== [TravelStoreWindow.SetType] ====");
            
            string originalText = __instance.introduce.text;
            string affinityPattern = "([\\s\\S]+)(\\\n<color=red>)([\\s\\S]+)(<\\/color>)";
            if (Regex.IsMatch(__instance.introduce.text, affinityPattern, options: RegexOptions.Singleline))
            {
                Match match = Regex.Match(__instance.introduce.text, affinityPattern, options: RegexOptions.Singleline);
                string startText = match.Groups[1].Value;
                string affinityText = match.Groups[3].Value;
                string affinities = TranslateAffinities(affinityText);
                __instance.introduce.text = startText + affinities;
            }
            else
            {
                __instance.introduce.text = originalText;
            }

            __instance.introduce.text = TravelMgr_Patch.TranslateTravelText(__instance.introduce.text);
            if (TravelMgr_Patch.TryGetTranslatedBuff(buff, out string translatedBuff))
                __instance.introduce.text = translatedBuff;

            if (__instance.buttonText != null)
            {
                foreach (var text in __instance.buttonText)
                {
                    text.text = TravelMgr_Patch.TranslateTravelText(text.text);
                }
            }
        }

        [HarmonyPatch(nameof(TravelStoreWindow.UpdateButtonText))]
        [HarmonyPostfix]
        private static void UpdateButtonText(TravelStoreWindow __instance)
        {
            if (__instance.buttonText != null)
            {
                foreach (var text in __instance.buttonText)
                {
                    text.text = TravelMgr_Patch.TranslateTravelText(text.text);
                }
            }
        }

        public static string TranslateAffinities(string originalText)
        {
            string result = "";
            List<string> translatedAffinities = new List<string>();

            string[] lines = originalText.Split('\n');

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line)) continue;

                string fStr = StringStore.translationStringRegex.ContainsKey("【([^\\s]+)】_IV") ? StringStore.translationStringRegex["【([^\\s]+)】_IV"] : "[{0}]";

                var regex = new Regex("【([^\\s]+)】");
                var match = regex.Match(line);
                int groupCount = match.Groups.Count;

                List<string> dynamicParts = new List<string>();

                for (int i = 1; i < groupCount; i++)
                {
                    string groupValue = match.Groups[i].Value;
                    string translatedValue = StringStore.translationString.ContainsKey(groupValue)
                        ? StringStore.translationString[groupValue]
                        : groupValue;
                    dynamicParts.Add(translatedValue);
                }

                string translatedAffinity = string.Format(fStr, dynamicParts.ToArray());
                translatedAffinities.Add(translatedAffinity);
            }

            result = "\n" + "<color=red>" + string.Join("\n", translatedAffinities) + "</color>";

            return result;
        }
    }
}