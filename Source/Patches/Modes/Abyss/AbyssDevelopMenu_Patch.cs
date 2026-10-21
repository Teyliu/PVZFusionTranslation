#if false
using System.Text.RegularExpressions;
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Abyss;

[HarmonyPatch(typeof(AbyssDevelopMenu))]
public static class AbyssDevelopMenu_Patch
{
    [HarmonyPatch(nameof(AbyssDevelopMenu.UpdateInfo)), HarmonyPostfix]
    private static void UpdateInfo(AbyssDevelopMenu __instance)
    {
        __instance.currentMoney.text = StringStore.TranslateText(__instance.currentMoney.text);
        __instance.upgradeTextInfo.text = StringStore.TranslateText(__instance.upgradeTextInfo.text);

        TextMeshProUGUI upgradeCostText =
            __instance.transform.FindChild("UpgradeCost").GetComponent<TextMeshProUGUI>();

        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        const string RegexStr = "([^\\s]+)\n当前等级：([^\\s]+)\n\n升级条件：\n([^\\s]+)\n\n升级消耗：([^\\s]+)";
        var regex = new Regex(RegexStr);

        if (!regex.IsMatch(upgradeCostText.text))
            return;

        var match = regex.Match(upgradeCostText.text);
        var groupCount = match.Groups.Count;

        List<string> dynamicParts = [];

        for (var i = 1; i < groupCount; i++)
        {
            var groupValue = match.Groups[i].Value;

            var translatedValue = StringStore.translationString.ContainsKey(groupValue)
                ? StringStore.translationString[groupValue]
                : groupValue;

            dynamicParts.Add(translatedValue);
        }

        upgradeCostText.text = string.Format(StringStore.translationStringRegex[RegexStr], [..dynamicParts]);
        upgradeCostText.font = fontAsset;
    }
}
#endif
