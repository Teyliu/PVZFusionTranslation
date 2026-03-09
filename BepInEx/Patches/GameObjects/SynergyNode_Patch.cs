using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(SynergyNode))]
    public static class SynergyNode_Patch
    {
        [HarmonyPatch(nameof(SynergyNode.InitNode))]
        [HarmonyPostfix]
        public static void InitNode(SynergyNode __instance)
        {
            if (__instance.synergyTitle == null)
                return;

            // Log.LogInfo($"[SynergyNode_Patch] InitNode called. Original text: '{__instance.synergyTitle.text}'");

            try
            {
                int firstNewlineIndex = __instance.synergyTitle.text.IndexOf("\n");
                if (firstNewlineIndex < 0)
                {
                    Log.LogWarning($"[SynergyNode_Patch] No newline found in text!");
                    return;
                }

                string title = __instance.synergyTitle.text.Substring(0, firstNewlineIndex);
                string description = __instance.synergyTitle.text.Substring(firstNewlineIndex + 1);
                description = (description.Length >= 8 && description.Substring(0, 8) == "</color>") ? description.Substring(8) : description;

                string pattern = @"<color=[^>]+>[\s\S]*?(?:<\/color>|$)|(?:<(?!color=)|[^<])+";
                string smallPattern = @"(<color=[^>]+>)(.*?)(</color>)";
                MatchCollection matches = Regex.Matches(description, pattern);
                string translatedDescription = "";

                foreach (Match match in matches)
                {
                    Match colorMatch = Regex.Match(match.Value, smallPattern, RegexOptions.Singleline);
                    if (colorMatch.Success)
                    {
                        translatedDescription += colorMatch.Groups[1].Value + TranslateSegment(colorMatch.Groups[2].Value) + colorMatch.Groups[3].Value;
                    }
                    else
                    {
                        translatedDescription += TranslateSegment(match.Value) + "\n";
                    }
                }

                string finalTitle = StringStore.TranslateColorText(title);
                if (finalTitle == title)
                {
                    finalTitle = StringStore.TranslateText(title);
                }
                __instance.synergyTitle.text = "<size=95%>" + finalTitle + "\n" + translatedDescription;
                
                // Log.LogInfo($"[SynergyNode_Patch] Translated to: '{__instance.synergyTitle.text}'");
#if DEBUG
                FileLoader.DumpUntranslatedStrings(title);
#endif
            }
            catch (Exception ex)
            {
                Log.LogError($"[SynergyNode_Patch] Error translating: {ex.Message}");
            }
        }

        public static string TranslateSegment(string text)
        {
            string res = "";

            if (string.IsNullOrEmpty(text))
                return res;

            List<string> parts = SplitSecondNewLines(text);

            foreach (string part in parts)
            {
                string temp = "";
                string[] lines = part.Split('\n');
                if (lines.Length > 1)
                {
                    string translated1 = StringStore.TranslateColorText(lines[0]);
                    if (translated1 == lines[0])
                        translated1 = StringStore.TranslateText(lines[0]);

                    string translated2 = StringStore.TranslateColorText(lines[1]);
                    if (translated2 == lines[1])
                        translated2 = StringStore.TranslateText(lines[1]);
                    
                    string matched1 = Managers.TravelMgr_Patch.MatchTravelBuff(lines[0]);
                    string matched2 = Managers.TravelMgr_Patch.MatchTravelBuff(lines[1]);
                    
                    temp = (!string.IsNullOrEmpty(matched1) ? matched1 : translated1) + "\n" + 
                           (!string.IsNullOrEmpty(matched2) ? matched2 : translated2);
                }
                else
                {
                    string translated = StringStore.TranslateColorText(part);
                    if (translated == part)
                        translated = StringStore.TranslateText(part);

                    string matched = Managers.TravelMgr_Patch.MatchTravelBuff(part);
                    temp = !string.IsNullOrEmpty(matched) ? matched : translated;
                }
                res += temp + "\n";
            }
            
            return res.Length > 0 ? res.Substring(0, res.Length - 1) : res;
        }

        public static List<string> SplitSecondNewLines(string originalText)
        {
            List<string> results = new List<string>();

            string[] lines = originalText.Split('\n');
            for (int i = 0; i < lines.Length; i += 2)
            {
                string res = "";
                if (i + 1 < lines.Length)
                {
                    res = lines[i] + "\n" + lines[i + 1];
                    results.Add(res);
                }
                else
                {
                    res = lines[i];
                    results.Add(res);
                }
            }

            return results;
        }
    }
}
