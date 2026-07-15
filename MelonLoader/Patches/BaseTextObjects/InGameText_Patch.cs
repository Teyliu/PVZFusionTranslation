using HarmonyLib;
using Il2Cpp;
using Il2CppCore;
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
            if (txt.text == currentText) return;

            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            string originalText = txt.text;
            string lockedPlantMatch = CheckLockedMessage(originalText);
            string travelMatch = TravelMgr_Patch.MatchTravelBuff(originalText);
            int godsGachaCheck = CheckGodsGachaPopup(originalText);
            string godsGachaMatch = "";
            string superEditorPlantMatch = CheckSuperEditorPopup(originalText);
            string customLevelRegexMatch = CheckCustomLevelRegex(originalText);
            string qualityCheckMatch = CheckQualityUpgrade(originalText);

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
                txt.text = TravelMgr_Patch.AddBuffName(travelMatch);
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
            else if(qualityCheckMatch != "")
            {
                txt.text = qualityCheckMatch;
            }
            else if(superEditorPlantMatch != "")
            {
                txt.text = superEditorPlantMatch;
            }
            else if(lockedPlantMatch != "")
            {
                txt.text = lockedPlantMatch;
            }
            else if(customLevelRegexMatch != "")
            {
                txt.text = customLevelRegexMatch;
            }
            else if((Regex.Match(txt.text, @"(<color[^>]*>.*?</color>)", RegexOptions.Singleline).Success) && 
                !StringStore.translationString.ContainsKey(txt.text) && 
                !StringStore.fsTipCollectionString.ContainsKey(txt.text) && 
                !StringStore.izTipCollectionString.ContainsKey(txt.text) && 
                !StringStore.customLevelString.ContainsKey(txt.text))
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

            currentText = txt.text;
        }

        public static string namePlantedPattern = "种植了：([^\\s]+)";
        public static string nameUpgradedPattern = "升级成功：([^\\s]+) -> ([^\\s]+)";
        public static string nameAlreadyPlantedPattern = "场上已经有一个([^\\s]+)了";
        public static string upgradePathRemovedPattern = "已移除路线：([^\\s]+)";

        public static string lockedPlantPattern = "^([\\s\\S]+)\\+([\\S]+)$";
        public static string multiLockedPlantPattern = "^或 ([\\s\\S]+)\\+([\\S]+)$";

        public static string qualityChangePattern = "诸神注视着你，并选中了一个他们喜欢的词条\n植物<color=green>【([\\S]+)】</color>的词条<color=yellow>【强化：([\\S]+)】</color>获得品质升级\n当前品质：([\\S]+)";

        public static Dictionary<string, string> fallbackFStrs = new Dictionary<string, string>()
        {
            { namePlantedPattern, "{0} planted!"},
            { nameUpgradedPattern, "{0} successfully upgraded to {1}!"},
            { nameAlreadyPlantedPattern, "{0} already exists on the lawn!"},
            { upgradePathRemovedPattern, "Upgrade Path removed for {0}" },
            { @"([^\s]+)\((\d+)\)", "{0}({1})" },
            { lockedPlantPattern, "{0} + {1}" },
            { multiLockedPlantPattern, "or {0} + {1}" },
            { qualityChangePattern, "The gods are watching you, and they have granted you an upgrade!\nThe <color=yellow>{1}</color> upgrade for <color=green>{0}</color> has been upgraded.\nCurrent Quality: {2}" }
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
                    res = StringStore.TranslateText(originalText, namePlantedPattern);
                    break;
                case 2:
                    res = StringStore.TranslateText(originalText, nameUpgradedPattern);
                    break;
                case 3:
                    res = StringStore.TranslateText(originalText, nameAlreadyPlantedPattern);
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
                res = StringStore.TranslateText(originalText, upgradePathRemovedPattern);
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
                        if (Utils.plantIndiceString.ContainsKey(groups[1].Value) && Utils.plantIndiceString.ContainsKey(groups[2].Value))
                        {
                            firstLine = StringStore.TranslateText(firstLine, lockedPlantPattern);
                            List<string> translatedLines = new List<string>() { firstLine };
                            for(int i = 1; i < lines.Length; i++)
                            {
                                string nextLine = lines[i];
                                string translatedNextLine = StringStore.TranslateText(nextLine, multiLockedPlantPattern);
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
                        if (Utils.plantIndiceString.ContainsKey(groups[1].Value) && Utils.plantIndiceString.ContainsKey(groups[2].Value))
                        {
                            res = StringStore.TranslateText(originalText, lockedPlantPattern);
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

        public static string CheckCustomLevelRegex(string originalText)
        {
            string res = "";

            foreach(var pair in StringStore.customLevelStringRegex)
            {
                if(StringStore.TestRegex(originalText, pair.Key))
                {
                    res = StringStore.TranslateText(originalText, pair.Key);
                }
            }
            return res;
        }

        public static string CheckQualityUpgrade(string originalText)
        {
            string res = "";

            if(Regex.IsMatch(originalText, qualityChangePattern))
            {
                res = StringStore.TranslateText(originalText, qualityChangePattern);
            }

            return res;
        }
    }
}