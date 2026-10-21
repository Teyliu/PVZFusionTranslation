#if false
using System.Text.RegularExpressions;
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Abyss;

[HarmonyPatch(typeof(AbyssBuffButton))]
public static class AbyssBuffButton_Patch
{
    [HarmonyPatch(nameof(AbyssBuffButton.SetType)), HarmonyPostfix]
    private static void SetType(AbyssBuffButton __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        var regex = new Regex("([^\\s]+)\n价格：(\\d+)");

        if (!regex.IsMatch(__instance.description.text))
            return;

        var match = regex.Match(__instance.description.text);
        var groupCount = match.Groups.Count;

        List<string> dynamicParts = [];

        for (var i = 1; i < groupCount; i++)
        {
            var groupValue = match.Groups[i].Value;

            var translatedValue = StringStore.translationString.ContainsKey(groupValue)
                ? StringStore.translationString[groupValue]
                : groupValue;

            dynamicParts.Add(translatedValue);
            MelonLogger.Msg(translatedValue);
        }

        __instance.description.text = string.Format(
            StringStore.translationStringRegex["([^\\s]+)\n价格：(\\d+)"],
            [..dynamicParts]
        );

        __instance.description.font = fontAsset;
    }

    [HarmonyPatch(nameof(AbyssBuffButton.SetSold)), HarmonyPostfix]
    private static void SetSold(AbyssBuffButton __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        __instance.description.text = StringStore.TranslateText(__instance.description.text);
        __instance.description.font = fontAsset;
    }
}
#endif
