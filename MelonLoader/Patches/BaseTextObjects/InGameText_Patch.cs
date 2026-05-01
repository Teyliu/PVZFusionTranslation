using HarmonyLib;
using Il2Cpp;
using Il2CppAlmanacData;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.Modes.Odyssey;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.BaseTextObjects
{
	[HarmonyPatch(typeof(InGameText))]
	public static class InGameText_Patch
	{
        public static string currentText = "";

        [HarmonyPatch(nameof(InGameText.ShowText))]
        [HarmonyPostfix]
        public static void ShowText(InGameText __instance)
        {
            TranslateInGameText(__instance);
        }

        [HarmonyPatch(nameof(InGameText.DebugWarning))]
        [HarmonyPostfix]
        public static void DebugWarning(InGameText __instance)
        {
            TranslateInGameText(__instance);
        }

        [HarmonyPatch(nameof(InGameText.Update))]
        [HarmonyPostfix]
        public static void Update(InGameText __instance)
        {
            TranslateInGameText(__instance);
        }

        public static void TranslateInGameText(InGameText __instance)
        {
            TextMeshProUGUI txt = null;

            if (__instance.textMesh == null || __instance.textHead == null)
            {
                if (__instance.TryGetComponent<TextMeshProUGUI>(out TextMeshProUGUI selfTxt))
                {
                    txt = selfTxt;
                }
            }
            else
            {
                txt = __instance.textMesh;
            }

            if(txt != null)
            {
                if (!txt.gameObject.active) return;

                TranslateInGameTextMesh(txt);
            }
        }

        public static void TranslateInGameTextMesh(TextMeshProUGUI txt)
        {
            if (txt == null) return;

            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            string originalText = txt.text;
            string lockedPlantMatch = CheckLockedMessage(originalText);
            string travelMatch = TravelMgr_Patch.MatchTravelBuff(originalText);
            int godsGachaCheck = CheckGodsGachaPopup(originalText);
            string godsGachaMatch = "";
            string superEditorPlantMatch = CheckSuperEditorPopup(originalText);

            switch(godsGachaCheck)
            {
                case 1:
                case 2:
                case 3:
                    godsGachaMatch = TranslateGodsGachaPopup(originalText, godsGachaCheck);
                    break;
                default:
                    break;
            }

            if(godsGachaMatch != "")
            {
                txt.text = godsGachaMatch;
                if (txt.gameObject.name.Contains("main"))
                {
                    originalText = txt.text;
                    Transform shadowText = txt.transform.parent.Find("Text_shadow");
                    if (shadowText != null)
                    {
                        shadowText.GetComponent<TextMeshProUGUI>().text = Utils.RemoveColorTags(originalText);
                    }
                }
            }
            else if (travelMatch != "")
            {
                txt.text = travelMatch;
                if (txt.gameObject.name.Contains("main"))
                {
                    originalText = txt.text;
                    Transform shadowText = txt.transform.parent.Find("Text_shadow");
                    if (shadowText != null)
                    {
                        shadowText.GetComponent<TextMeshProUGUI>().text = Utils.RemoveColorTags(originalText);
                    }
                }
            }
            else if(superEditorPlantMatch != "")
            {
                txt.text = superEditorPlantMatch;
            }
            else if(lockedPlantMatch != "")
            {
                txt.text = lockedPlantMatch;
            }
            else if((Regex.Match(txt.text, @"(<color[^>]*>.*?</color>)", RegexOptions.Singleline).Success) && (!StringStore.translationString.ContainsKey(txt.text) && !StringStore.fsTipCollectionString.ContainsKey(txt.text) && !StringStore.izTipCollectionString.ContainsKey(txt.text)))
            {
                txt.text = StringStore.TranslateColorText(txt.text, true);
                if (txt.gameObject.name.Contains("main"))
                {
                    originalText = txt.text;
                    Transform shadowText = txt.transform.parent.Find("Text_shadow");
                    if (shadowText != null)
                    {
                        shadowText.GetComponent<TextMeshProUGUI>().text = Utils.RemoveColorTags(originalText);
                    }
                }
            }
            else
            {
                txt.text = StringStore.TranslateText(txt.text, true);
                if (txt.gameObject.name.Contains("main"))
                {
                    originalText = txt.text;
                    Transform shadowText = txt.transform.parent.Find("Text_shadow");
                    if (shadowText != null)
                    {
                        shadowText.GetComponent<TextMeshProUGUI>().text = Utils.RemoveColorTags(originalText);
                    }
                }
            }
            txt.font = fontAsset;
        }

        public static string namePlantedPattern = "种植了：([^\\s]+)";
        public static string nameUpgradedPattern = "升级成功：([^\\s]+) -> ([^\\s]+)";
        public static string nameAlreadyPlantedPattern = "场上已经有一个([^\\s]+)了";
        public static string upgradePathRemovedPattern = "已移除路线：([^\\s]+)";

        public static string lockedPlantPattern = "^([^\\s:]+)\\+([^\\s:]+)";
        public static string multiLockedPlantPattern = "^或 ([^\\s:]+)\\+([^\\s:]+)";

        public static Dictionary<string, string> fallbackFStrs = new Dictionary<string, string>()
        {
            { namePlantedPattern, "{0} planted!"},
            { nameUpgradedPattern, "{0} successfully upgraded to {1}!"},
            { nameAlreadyPlantedPattern, "{0} already exists on the lawn!"},
            { upgradePathRemovedPattern, "Upgrade Path removed for {0}" },
            { @"([^\s]+)\((\d+)\)", "{0}({1})" },
            { lockedPlantPattern, "{0} + {1}" },
            { multiLockedPlantPattern, "or {0} + {1}" }
        };
	    
        public static int CheckGodsGachaPopup(string originalText)
        {
            int res = 0;

            if (Regex.IsMatch(originalText, namePlantedPattern))
            {
                res = 1;
            }
            else if(Regex.IsMatch(originalText, nameUpgradedPattern))
            {
                res = 2;
            }
            else if(Regex.IsMatch(originalText, nameAlreadyPlantedPattern))
            {
                res = 3;
            }

            return res;
        }

        public static string TranslateGodsGachaPopup(string originalText, int type)
        {
            string res = originalText;

            switch(type)
            {
                case 1:
                    res = TranslatePlantNameParts(originalText, namePlantedPattern);
                    break;
                case 2:
                    res = TranslatePlantNameParts(originalText, nameUpgradedPattern);
                    break;
                case 3:
                    res = TranslatePlantNameParts(originalText, nameAlreadyPlantedPattern);
                    break;
                default:
                    break;
            }

            return res;
        }

        public static string TranslatePlantNameParts(string originalText, string pattern)
        {
            string res = "";
            string fStr = "";
            Match match = Regex.Match(originalText, pattern);
            if(match.Success)
            {
                GroupCollection groups = match.Groups;
                fStr = StringStore.translationStringRegex.ContainsKey(pattern) ? StringStore.translationStringRegex[pattern] : fallbackFStrs[pattern];
                List<string> dynamicParts = [];
                for(int i = 1; i < groups.Count; i++)
                {
                    string group = groups[i].Value;
                    string plantName = Utils.GetPlantNameFromAlmanac(group);
                    dynamicParts.Add(plantName);
                }
                res = string.Format(fStr, [.. dynamicParts]);
            }
            return res;
        }

        public static string TranslatePlantNameParts(string originalText, string pattern, string fallback)
        {
            string res = "";
            string fStr = "";
            Match match = Regex.Match(originalText, pattern);
            if(match.Success)
            {
                GroupCollection groups = match.Groups;
                fStr = StringStore.translationStringRegex.ContainsKey(pattern) ? StringStore.translationStringRegex[pattern] : fallback;
                List<string> dynamicParts = [];
                for(int i = 1; i < groups.Count; i++)
                {
                    string group = groups[i].Value;
                    string plantName = Utils.GetPlantNameFromAlmanac(group);
                    if (plantName == "") plantName = StringStore.TranslateText(group);
                    dynamicParts.Add(plantName);
                }
                res = string.Format(fStr, [.. dynamicParts]);
            }
            return res;
        }
    
        public static string CheckSuperEditorPopup(string originalText)
        {
            string res = "";

            if(Regex.IsMatch(originalText, upgradePathRemovedPattern))
            {
                res = TranslatePlantNameParts(originalText, upgradePathRemovedPattern);
            }
            else if(Regex.IsMatch(originalText, "当前全部基础植物：(.*)"))
            {
                string pattern = "当前全部基础植物：(.*)";
                Match match = Regex.Match(originalText, pattern);
                if(match.Success)
                {
                    GroupCollection groups = match.Groups;
                    string plantNameGroup = groups[1].Value;
                    string[] plantNames = plantNameGroup.Split(" ");
                    string plantRes = "";
                    string shortPattern = @"([^\s]+)\((\d+)\)";
                    foreach (string plantName in plantNames)
                    {
                        Match shortMatch = Regex.Match(plantName, shortPattern);
                        if(shortMatch.Success)
                        {
                            string fStr = StringStore.translationStringRegex.ContainsKey(shortPattern) ? StringStore.translationStringRegex[shortPattern] : fallbackFStrs[shortPattern];
                            string shortRes = string.Format(fStr, [Utils.GetPlantNameFromAlmanac(shortMatch.Groups[1].Value), shortMatch.Groups[2].Value]);
                            plantRes += shortRes + " ";                        
                        }
                    }
                    res = StringStore.TranslateText("当前全部基础植物：" + plantRes);
                }
            }

            return res;
        }

        public static string CheckLockedMessage(string originalText)
        {
            string res = "";

            Regex lockedPlantRegex = new Regex(lockedPlantPattern);
            Regex multiLockedPlantRegex = new Regex(multiLockedPlantPattern);

            if(lockedPlantRegex.IsMatch(originalText))
            {
                if(originalText.Contains("\n"))
                {
                    string[] lines = originalText.Split("\n");
                    if (lockedPlantRegex.IsMatch(lines[0]))
                    {
                        string firstLine = lines[0];
                        Match match = lockedPlantRegex.Match(firstLine);
                        GroupCollection groups = match.Groups;
                        Log.LogDebug(Utils.plantIndiceStrings.ContainsKey(groups[1].Value));
                        Log.LogDebug(Utils.plantIndiceStrings.ContainsKey(groups[2].Value));
                        if (Utils.plantIndiceStrings.ContainsKey(groups[1].Value) && Utils.plantIndiceStrings.ContainsKey(groups[2].Value))
                        {
                            firstLine = TranslatePlantNameParts(firstLine, lockedPlantPattern);
                            List<string> translatedLines = new List<string>() { firstLine };
                            for(int i = 1; i < lines.Length; i++)
                            {
                                string nextLine = lines[i];
                                Log.LogDebug(nextLine);
                                string translatedNextLine = TranslatePlantNameParts(nextLine, multiLockedPlantPattern);
                                translatedLines.Add(translatedNextLine);
                            }
                            res = string.Join("\n", translatedLines);
                        }
                        else
                        {
                            return "";
                        }
                    }
                }
                else
                {
                    if (lockedPlantRegex.IsMatch(originalText))
                    {
                        Match match = lockedPlantRegex.Match(originalText);
                        GroupCollection groups = match.Groups;
                        if (Utils.plantIndiceStrings.ContainsKey(groups[1].Value) && Utils.plantIndiceStrings.ContainsKey(groups[2].Value))
                        {
                            res = TranslatePlantNameParts(originalText, lockedPlantPattern);
                        }
                        else
                        {
                            return "";
                        }
                    }
                }
            }

            return res;
        }
    }
}