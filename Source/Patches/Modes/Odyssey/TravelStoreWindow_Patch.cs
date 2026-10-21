using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using static PvZ_Fusion_Translator.Patches.Modes.Odyssey.TravelMgr_Patch;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey;

[HarmonyPatch(typeof(TravelStoreWindow))]
public static class TravelStoreWindow_Patch
{
    [HarmonyPatch(nameof(TravelStoreWindow.SetType)), HarmonyPostfix]
    private static void SetType(TravelStoreWindow __instance)
    {
#if false
        var buffSet = translatedTravelBuffs[buffLinks[__instance.buffType]];

        var buff = __instance.show != null && __instance.introduce.text != "词条已选完"
            ? buffSet[__instance.buffIndex]
            : StringStore.TranslateText("词条已选完");
#endif
        var originalText = __instance.introduce.text;
        const string AffinityPattern = "([\\s\\S]+)(\\\n<color=red>)([\\s\\S]+)(<\\/color>)";

        if (Regex.IsMatch(__instance.introduce.text, AffinityPattern, RegexOptions.Singleline))
        {
            var match = Regex.Match(__instance.introduce.text, AffinityPattern, RegexOptions.Singleline);
            var startText = match.Groups[1].Value;
            var affinityText = match.Groups[3].Value;
            var affinities = TranslateAffinities(affinityText);
            __instance.introduce.text = AddBuffName(startText) + affinities;
        }
        else
            __instance.introduce.text = AddBuffName(originalText);

        foreach (var text in __instance.buttonText)
            text.text = StringStore.TranslateText(text.text);
    }

    [HarmonyPatch(nameof(TravelStoreWindow.UpdateButtonText)), HarmonyPostfix]
    private static void UpdateButtonText(TravelStoreWindow __instance)
    {
        foreach (var text in __instance.buttonText)
            text.text = StringStore.TranslateText(text.text);
    }

    public static string TranslateAffinities(string originalText)
    {
        List<string> translatedAffinities = [];
        var lines = originalText.Split('\n');

        foreach (var line in lines)
        {
            if (string.IsNullOrEmpty(line))
                continue;

            var fStr = StringStore.TranslationStringRegex.GetValueOrDefault("【([^\\s]+)】_IV", "[{0}]");

            // Extract dynamic parts from the original text
            var regex = new Regex("【([^\\s]+)】");
            var match = regex.Match(line);
            var groupCount = match.Groups.Count;

            // List to hold formatted dynamic parts
            List<string> dynamicParts = [];

            // Loop through each group and determine its translation
            for (var i = 1; i < groupCount; i++)
            {
                var groupValue = match.Groups[i].Value;
                var translatedValue = StringStore.TranslationString.GetValueOrDefault(groupValue, groupValue);
                dynamicParts.Add(translatedValue);
            }

            // Format the output string with dynamic parts
            var translatedAffinity = string.Format(fStr, [..dynamicParts]);
            translatedAffinities.Add(translatedAffinity);
        }

        return $"\n<color=red>{string.Join("\n", translatedAffinities)}</color>";
    }
}
