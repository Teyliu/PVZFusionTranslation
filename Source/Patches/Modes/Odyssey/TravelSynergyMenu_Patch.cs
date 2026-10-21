using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey;

[HarmonyPatch(typeof(TravelSynergyMenu))]
public static class TravelSynergyMenu_Patch
{
    [HarmonyPatch(nameof(TravelSynergyMenu.Awake)), HarmonyPostfix]
    public static void Awake(TravelSynergyMenu __instance)
    {
        var background = __instance.transform.Find("Background");
        var tip = __instance.transform.Find("Text (TMP)");

        foreach (var text in background.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText(text.text);

        foreach (var text in tip.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText(text.text);
    }
}

[HarmonyPatch(typeof(SynergyNode))]
public static class SynergyNode_Patch
{
    [HarmonyPatch(nameof(SynergyNode.InitNode)), HarmonyPostfix]
    public static void InitNode(SynergyNode __instance)
    {
        var firstNewlineIndex = __instance.synergyTitle.text.IndexOf("\n", StringComparison.Ordinal);
        var title = __instance.synergyTitle.text[..firstNewlineIndex];
        var description = __instance.synergyTitle.text[(firstNewlineIndex + 1)..];
        description = description[..8] == "</color>" ? description[8..] : description;

        const string Pattern = @"<color=[^>]+>[\s\S]*?(?:<\/color>|$)|(?:<(?!color=)|[^<])+";
        const string SmallPattern = "(<color=[^>]+>)(.*?)(</color>)";
        var matches = Regex.Matches(description, Pattern);
        var translatedDescription = "";

        foreach (Match match in matches)
        {
            var colorMatch = Regex.Match(match.Value, SmallPattern, RegexOptions.Singleline);

            if (colorMatch.Success)
                translatedDescription += colorMatch.Groups[1].Value +
                    TranslateSegment(colorMatch.Groups[2].Value) +
                    colorMatch.Groups[3].Value;
            else
                translatedDescription += TranslateSegment(match.Value) + "\n";
        }

        __instance.synergyTitle.text =
            "<size=95%>" + StringStore.TranslateColorText(title) + "\n" + translatedDescription;
    }

    public static string TranslateSegment(string text)
    {
        var res = "";

        var parts = SplitSecondNewLines(text);

        foreach (var part in parts)
        {
            var temp = "";
            var lines = part.Split('\n');

            if (lines.Length > 1)
                temp = StringStore.TranslateText(lines[0]) + "\n" + StringStore.TranslateText(lines[1]);

            res += temp + "\n";
        }

        return res[..^1];
    }

    public static List<string> SplitSecondNewLines(string originalText)
    {
        var results = new List<string>();

        var lines = originalText.Split('\n');

        for (var i = 0; i < lines.Length; i += 2)
            results.Add(i + 1 < lines.Length ? lines[i] + "\n" + lines[i + 1] : lines[i]);

        return results;
    }
}
