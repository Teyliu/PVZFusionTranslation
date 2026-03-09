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
        private static void SetType(TravelStoreWindow __instance)
        {
            Log.LogInfo($"[TravelStoreWindow_Patch] SetType called. buffType: {__instance.buffType}, buffIndex: {__instance.buffIndex}");
            
            if (!__instance.set || __instance.introduce == null)
                return;

            string originalText = __instance.introduce.text;
            Log.LogInfo($"[TravelStoreWindow_Patch] Original text: '{originalText}'");

            string translatedText = TravelMgr_Patch.ResolveBuffTranslation(__instance.buffType, __instance.buffIndex, originalText);

            string affinities = TranslateAffinities(originalText);

            if (!string.IsNullOrEmpty(translatedText) && translatedText != originalText)
            {
                Log.LogInfo($"[TravelStoreWindow_Patch] Found translation: '{translatedText}'");
                __instance.introduce.text = translatedText + affinities;
            }
            else
            {
                Log.LogWarning($"[TravelStoreWindow_Patch] Translation unchanged for ({__instance.buffType}, {__instance.buffIndex}).");
                __instance.introduce.text = StringStore.TranslateText(originalText) + affinities;
            }

            if (__instance.buttonText != null)
            {
                foreach (var text in __instance.buttonText)
                {
                    text.text = StringStore.TranslateText(text.text);
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
                    text.text = StringStore.TranslateText(text.text);
                }
            }
        }

        public static string TranslateAffinities(string originalText)
        {
            if (string.IsNullOrEmpty(originalText))
                return "";

            string discolored = Utils.RemoveColorTags(originalText);
            int firstNewlineIndex = discolored.IndexOf('\n');

            string result = "";
            List<string> translatedAffinities = new List<string>();

            if (firstNewlineIndex >= 0)
            {
                string affinityString = discolored.Substring(firstNewlineIndex);
                string[] affinities = affinityString.Split('\n');

                string fStr = StringStore.translationStringRegex.ContainsKey("【([^\\s]+)】_IV") ? StringStore.translationStringRegex["【([^\\s]+)】_IV"] : "[{0}]";
                string originalPattern = "【([^\\s]+)】";

                foreach (string affinity in affinities)
                {
                    if (affinity != "")
                    {
                        string translatedAffinity = affinity;
                        if (StringStore.TestRegex(affinity, originalPattern))
                        {
                            var regex = new Regex(originalPattern);
                            var match = regex.Match(affinity);
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

                            try
                            {
                                translatedAffinity = string.Format(fStr, dynamicParts.ToArray());
                            }
                            catch
                            {
                                translatedAffinity = affinity;
                            }
                        }

                        translatedAffinities.Add(translatedAffinity);
                    }
                }
                result = "\n" + "<color=red>" + string.Join("\n", translatedAffinities) + "</color>";
            }

            return result;
        }
    }
}
