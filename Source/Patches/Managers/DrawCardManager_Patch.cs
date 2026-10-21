using System.Text.RegularExpressions;
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Managers;

[HarmonyPatch(typeof(DrawCardManager))]
public static class DrawCardManager_Patch
{
#pragma warning disable CA2211
    public static TMP_FontAsset FontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
#pragma warning restore CA2211
    [HarmonyPatch(nameof(DrawCardManager.Awake)), HarmonyPostfix]
    private static void Awake(DrawCardManager __instance) =>
        FontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

    [HarmonyPatch(nameof(DrawCardManager.UpdateText)), HarmonyPostfix]
    private static void Postfix_UpdateText(DrawCardManager __instance)
    {
        var regexPair = new KeyValuePair<string, string>(
            "抽取次数：\n(\\d+)/(\\d+)\n当前up植物：\n([^\\s]+)\nup刷新倒计时：\n(\\d+)",
            "Draw Count:\n{0}/{1}\nCurrent Up:\n{2}\nNext Up in: \n{3}s"
        );

        foreach (var txt in __instance.texts)
            if (Regex.IsMatch(txt.text, regexPair.Key))
            {
                txt.text = TranslateGashaponText(txt.text, regexPair.Key, regexPair.Value, __instance.up);
                txt.font = FontAsset;
            }
    }

    public static string TranslateGashaponText(string originalText, string pattern, string fallback, PlantType up)
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

            var translatedGroup = i == 3 && up != PlantType.Peashooter
                ? Utils.GetPlantNameFromAlmanac(up)
                : StringStore.TranslateText(group);

            dynamicParts.Add(translatedGroup);
        }

        res = string.Format(fStr, [..dynamicParts]);

        return res;
    }
#if false
    [HarmonyPatch(nameof(DrawCardManager.Update)), HarmonyPostfix]
    private static void Postfix_Update(DrawCardManager __instance) => Postfix_UpdateText(__instance);
#endif
}
