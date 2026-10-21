using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.Modes.Odyssey;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.BaseTextObjects;

[HarmonyPatch(typeof(InGameText))]
public static class InGameText_Patch
{
#pragma warning disable CA2211
    public static string CurrentText = "";
#pragma warning restore CA2211
    [HarmonyPatch(nameof(InGameText.ShowText)), HarmonyPostfix]
    public static void ShowText(InGameText __instance) => TranslateInGameText(__instance);

    [HarmonyPatch(nameof(InGameText.DebugWarning)), HarmonyPostfix]
    public static void DebugWarning(InGameText __instance) => TranslateInGameText(__instance);

    [HarmonyPatch(nameof(InGameText.Update)), HarmonyPostfix]
    public static void Update(InGameText __instance) => TranslateInGameText(__instance);

    public static void TranslateInGameText(InGameText __instance)
    {
        TextMeshProUGUI txt = null;

        if (__instance.textMesh == null || __instance.textHead == null)
        {
            if (__instance.TryGetComponent(out TextMeshProUGUI selfTxt))
                txt = selfTxt;
        }
        else
            txt = __instance.textMesh;

        if (txt == null)
            return;

        if (!txt.gameObject.active)
            return;

        TranslateInGameTextMesh(txt);
    }

    public static void TranslateInGameTextMesh(TextMeshProUGUI txt)
    {
        if (txt == null)
            return;

        if (txt.text == CurrentText)
            return;

        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        var originalText = txt.text;
        var lockedPlantMatch = CheckLockedMessage(originalText);
        var travelMatch = TravelMgr_Patch.MatchTravelBuff(originalText);
        var godsGachaCheck = CheckGodsGachaPopup(originalText);
        var godsGachaMatch = "";
        var superEditorPlantMatch = CheckSuperEditorPopup(originalText);
        var customLevelRegexMatch = CheckCustomLevelRegex(originalText);
        var qualityCheckMatch = CheckQualityUpgrade(originalText);

        godsGachaMatch = godsGachaCheck switch
        {
            1 or 2 or 3 => TranslateGodsGachaPopup(originalText, godsGachaCheck),
            _ => godsGachaMatch,
        };

        if (godsGachaMatch != "")
        {
            txt.text = godsGachaMatch;

            if (txt.gameObject.name.Contains("main"))
            {
                originalText = txt.text;
                var shadowText = txt.transform.parent.Find("Text_shadow");

                if (shadowText != null)
                    shadowText.GetComponent<TextMeshProUGUI>().text = Utils.RemoveColorTags(originalText);
            }
        }
        else if (travelMatch != "")
        {
            txt.text = TravelMgr_Patch.AddBuffName(travelMatch);

            if (txt.gameObject.name.Contains("main"))
            {
                originalText = txt.text;
                var shadowText = txt.transform.parent.Find("Text_shadow");

                if (shadowText != null)
                    shadowText.GetComponent<TextMeshProUGUI>().text = Utils.RemoveColorTags(originalText);
            }
        }
        else if (qualityCheckMatch != "")
            txt.text = qualityCheckMatch;
        else if (superEditorPlantMatch != "")
            txt.text = superEditorPlantMatch;
        else if (lockedPlantMatch != "")
            txt.text = lockedPlantMatch;
        else if (customLevelRegexMatch != "")
            txt.text = customLevelRegexMatch;
        else if (Regex.Match(txt.text, "(<color[^>]*>.*?</color>)", RegexOptions.Singleline).Success &&
            !StringStore.TranslationString.ContainsKey(txt.text) &&
            !StringStore.FSTipCollectionString.ContainsKey(txt.text) &&
            !StringStore.IZTipCollectionString.ContainsKey(txt.text) &&
            !StringStore.CustomLevelString.ContainsKey(txt.text))
        {
            txt.text = StringStore.TranslateColorText(txt.text, true);

            if (txt.gameObject.name.Contains("main"))
            {
                originalText = txt.text;
                var shadowText = txt.transform.parent.Find("Text_shadow");

                if (shadowText != null)
                    shadowText.GetComponent<TextMeshProUGUI>().text = Utils.RemoveColorTags(originalText);
            }
        }
        else
        {
            txt.text = StringStore.TranslateText(txt.text, true);

            if (txt.gameObject.name.Contains("main"))
            {
                originalText = txt.text;
                var shadowText = txt.transform.parent.Find("Text_shadow");

                if (shadowText != null)
                    shadowText.GetComponent<TextMeshProUGUI>().text = Utils.RemoveColorTags(originalText);
            }
        }

        txt.font = fontAsset;

        CurrentText = txt.text;
    }

    public const string NamePlantedPattern = "种植了：([^\\s]+)";
    public const string NameUpgradedPattern = @"升级成功：([^\s]+) -> ([^\s]+)";
    public const string NameAlreadyPlantedPattern = "场上已经有一个([^\\s]+)了";
    public const string UpgradePathRemovedPattern = "已移除路线：([^\\s]+)";

    public const string LockedPlantPattern = @"^([\s\S]+)\+([\S]+)$";
    public const string MultiLockedPlantPattern = @"^或 ([\s\S]+)\+([\S]+)$";

    public const string QualityChangePattern =
        """
        诸神注视着你，并选中了一个他们喜欢的词条
        植物<color=green>【([\S]+)】</color>的词条<color=yellow>【强化：([\S]+)】</color>获得品质升级
        当前品质：([\S]+)
        """;

    public static readonly Dictionary<string, string> FallbackFStrs = new()
    {
        { NamePlantedPattern, "{0} planted!" },
        { NameUpgradedPattern, "{0} successfully upgraded to {1}!" },
        { NameAlreadyPlantedPattern, "{0} already exists on the lawn!" },
        { UpgradePathRemovedPattern, "Upgrade Path removed for {0}" },
        { @"([^\s]+)\((\d+)\)", "{0}({1})" },
        { LockedPlantPattern, "{0} + {1}" },
        { MultiLockedPlantPattern, "or {0} + {1}" },
        {
            QualityChangePattern,
            """
            The gods are watching you, and they have granted you an upgrade!
            The <color=yellow>{1}</color> upgrade for <color=green>{0}</color> has been upgraded.
            Current Quality: {2}
            """
        },
    };

    public static int CheckGodsGachaPopup(string originalText)
    {
        var res = 0;

        if (Regex.IsMatch(originalText, NamePlantedPattern))
            res = 1;
        else if (Regex.IsMatch(originalText, NameUpgradedPattern))
            res = 2;
        else if (Regex.IsMatch(originalText, NameAlreadyPlantedPattern))
            res = 3;

        return res;
    }

    public static string TranslateGodsGachaPopup(string originalText, int type) =>
        type switch
        {
            1 => StringStore.TranslateText(originalText, NamePlantedPattern),
            2 => StringStore.TranslateText(originalText, NameUpgradedPattern),
            3 => StringStore.TranslateText(originalText, NameAlreadyPlantedPattern),
            _ => originalText,
        };

    public static string TranslatePlantNameParts(string originalText, string pattern)
    {
        var res = "";
        var match = Regex.Match(originalText, pattern);

        if (!match.Success)
            return res;

        var groups = match.Groups;

        var fStr = StringStore.TranslationStringRegex.TryGetValue(pattern, out var value)
            ? value
            : FallbackFStrs[pattern];

        List<string> dynamicParts = [];

        for (var i = 1; i < groups.Count; i++)
        {
            var group = groups[i].Value;
            var plantName = Utils.GetPlantNameFromAlmanac(group);
            dynamicParts.Add(plantName);
        }

        res = string.Format(fStr, [..dynamicParts]);

        return res;
    }

    public static string TranslatePlantNameParts(string originalText, string pattern, string fallback)
    {
        var res = "";
        var match = Regex.Match(originalText, pattern);

        if (!match.Success)
            return res;

        var groups = match.Groups;

        var fStr = StringStore.TranslationStringRegex.GetValueOrDefault(pattern, fallback);

        List<string> dynamicParts = [];

        for (var i = 1; i < groups.Count; i++)
        {
            var group = groups[i].Value;
            var plantName = Utils.GetPlantNameFromAlmanac(group);

            if (plantName == "")
                plantName = StringStore.TranslateText(group);

            dynamicParts.Add(plantName);
        }

        res = string.Format(fStr, [..dynamicParts]);

        return res;
    }

    public static string CheckSuperEditorPopup(string originalText)
    {
        var res = "";

        if (Regex.IsMatch(originalText, UpgradePathRemovedPattern))
            res = StringStore.TranslateText(originalText, UpgradePathRemovedPattern);
        else if (Regex.IsMatch(originalText, "当前全部基础植物：(.*)"))
        {
            const string Pattern = "当前全部基础植物：(.*)";
            var match = Regex.Match(originalText, Pattern);

            if (!match.Success)
                return res;

            var groups = match.Groups;
            var plantNameGroup = groups[1].Value;
            var plantNames = plantNameGroup.Split(" ");
            var plantRes = "";
            const string ShortPattern = @"([^\s]+)\((\d+)\)";

            foreach (var shortMatch in plantNames
               .Select(plantName => Regex.Match(plantName, ShortPattern))
               .Where(shortMatch => shortMatch.Success))
            {
                var fStr = StringStore.TranslationStringRegex.TryGetValue(ShortPattern, out var value)
                    ? value
                    : FallbackFStrs[ShortPattern];

                var shortRes = string.Format(
                    fStr,
                    [Utils.GetPlantNameFromAlmanac(shortMatch.Groups[1].Value), shortMatch.Groups[2].Value]
                );

                plantRes += shortRes + " ";
            }

            res = StringStore.TranslateText("当前全部基础植物：" + plantRes);
        }

        return res;
    }

    public static string CheckLockedMessage(string originalText)
    {
        var res = "";

        var lockedPlantRegex = new Regex(LockedPlantPattern);
        // var multiLockedPlantRegex = new Regex(MultiLockedPlantPattern);

        if (!lockedPlantRegex.IsMatch(originalText))
            return res;

        if (originalText.Contains('\n'))
        {
            var lines = originalText.Split("\n");

            if (!lockedPlantRegex.IsMatch(lines[0]))
                return res;

            var firstLine = lines[0];
            var match = lockedPlantRegex.Match(firstLine);
            var groups = match.Groups;

            if (Utils.PlantIndiceString.ContainsKey(groups[1].Value) &&
                Utils.PlantIndiceString.ContainsKey(groups[2].Value))
            {
                firstLine = StringStore.TranslateText(firstLine, LockedPlantPattern);
                var translatedLines = new List<string> { firstLine };

                for (var i = 1; i < lines.Length; i++)
                {
                    var nextLine = lines[i];
                    var translatedNextLine = StringStore.TranslateText(nextLine, MultiLockedPlantPattern);
                    translatedLines.Add(translatedNextLine);
                }

                res = string.Join("\n", translatedLines);
            }
            else
                return "";
        }
        else
        {
            if (!lockedPlantRegex.IsMatch(originalText))
                return res;

            var match = lockedPlantRegex.Match(originalText);
            var groups = match.Groups;

            if (Utils.PlantIndiceString.ContainsKey(groups[1].Value) &&
                Utils.PlantIndiceString.ContainsKey(groups[2].Value))
                res = StringStore.TranslateText(originalText, LockedPlantPattern);
            else
                return "";
        }

        return res;
    }

    public static string CheckCustomLevelRegex(string originalText) =>
        StringStore.TranslationStringRegex.All(p => !StringStore.TestRegex(originalText, p.Key)) &&
        StringStore.CustomLevelStringRegex.FirstOrDefault(p => StringStore.TestRegex(originalText, p.Key)) is
            { Key: var key }
            ? StringStore.TranslateText(originalText, key)
            : null;

    public static string CheckQualityUpgrade(string originalText)
    {
        var res = "";

        if (Regex.IsMatch(originalText, QualityChangePattern))
            res = StringStore.TranslateText(originalText, QualityChangePattern);

        return res;
    }
}
