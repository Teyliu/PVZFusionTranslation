using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.Patches.Modes.Odyssey.TravelMgr_Patch;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(TravelSynergyMenu))]
    public static class TravelSynergyMenu_Patch
    {
        [HarmonyPatch(nameof(TravelSynergyMenu.Awake))]
        [HarmonyPostfix]
        public static void Awake(TravelSynergyMenu __instance)
        {
            Transform background = __instance.transform.Find("Background");
            Transform tip = __instance.transform.Find("Text (TMP)");

            foreach(TextMeshProUGUI text in background.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }

            foreach (TextMeshProUGUI text in tip.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }
    }

    [HarmonyPatch(typeof(SynergyNode))]
    public static class SynergyNode_Patch
    {
        [HarmonyPatch(nameof(SynergyNode.InitNode))]
        [HarmonyPostfix]
        public static void InitNode(SynergyNode __instance)
        {
            int firstNewlineIndex = __instance.synergyTitle.text.IndexOf("\n");
            string title = __instance.synergyTitle.text.Substring(0, firstNewlineIndex);
            string description = __instance.synergyTitle.text.Substring(firstNewlineIndex + 1);
            description = (description.Substring(0, 8) == "</color>") ? description.Substring(8) : description;

            string pattern = @"<color=[^>]+>[\s\S]*?(?:<\/color>|$)|(?:<(?!color=)|[^<])+";
            string smallPattern = @"(<color=[^>]+>)(.*?)(</color>)";
            MatchCollection matches = Regex.Matches(description, pattern);
            string translatedDescription = "";
            foreach(Match match in matches)
            {
                Match colorMatch = Regex.Match(match.Value, smallPattern, RegexOptions.Singleline);
                if (colorMatch.Success)
                {
                    translatedDescription += colorMatch.Groups[1].Value + TranslateSegment(colorMatch.Groups[2].Value) + colorMatch.Groups[3].Value;
                }
                else
                {
                    FileLoader.DumpUntranslatedStrings(match.Value);
                    translatedDescription += TranslateSegment(match.Value) + "\n";
                }
            }

            __instance.synergyTitle.text = "<size=95%>" + StringStore.TranslateColorText(title) + "\n" + translatedDescription;
        }

        public static string TranslateSegment(string text)
        {
            string res = "";

            List<string> parts = SplitSecondNewLines(text);

            foreach(string part in parts)
            {
                string temp = "";
                string[] lines = part.Split('\n');
                if(lines.Length > 1)
                {
                    FileLoader.DumpUntranslatedStrings(lines[0]);
                    FileLoader.DumpUntranslatedStrings(lines[1]);
                    temp = StringStore.TranslateText(lines[0]) + "\n" + StringStore.TranslateText(lines[1]);
                }
                res += temp + "\n";
            }
            return res.Substring(0, res.Length - 1);
        }

        public static List<string> SplitSecondNewLines(string originalText)
        {
            List<string> results = new List<string>();

            string[] lines = originalText.Split('\n');
            for (int i = 0; i < lines.Length; i += 2)
            {
                string res = "";
                if(i + 1 < lines.Length)
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
