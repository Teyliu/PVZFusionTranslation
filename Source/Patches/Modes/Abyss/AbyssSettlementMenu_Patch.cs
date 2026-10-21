#if false
using System.Text.RegularExpressions;
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Abyss;

[HarmonyPatch(typeof(AbyssSettlementMenu))]
public static class AbyssSettlementMenu_Patch
{
    [HarmonyPatch(nameof(AbyssSettlementMenu.InitSettle)), HarmonyPostfix]
    private static void InitSettle(AbyssSettlementMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        string[] regexStrList =
        [
            "第(\\d+)关\n通关用时：(\\d+)分(\\d+)秒\n杀敌数量：(\\d+)\n关卡叶绿素产出：(\\d+)\n极限模式产出：(\\d+)\n非首胜无额外产出\n产出叶绿素总计：(\\d+)",
            "第(\\d+)关\n通关用时：(\\d+)分(\\d+)秒\n杀敌数量：(\\d+)\n关卡叶绿素产出：(\\d+)\n极限模式产出：(\\d+)\n首胜产出：(\\d+)\n剩余小推车数量：(\\d+)，获得叶绿素：(\\d+)\n产出叶绿素总计：(\\d+)",
            "第(\\d+)关\n通关用时：(\\d+)分(\\d+)秒\n杀敌数量：(\\d+)\n关卡叶绿素产出：(\\d+)\n首胜产出：(\\d+)\n剩余小推车数量：(\\d+)，获得叶绿素：(\\d+)\n产出叶绿素总计：(\\d+)",
            "第(\\d+)关\n通关用时：(\\d+)分(\\d+)秒\n杀敌数量：(\\d+)\n关卡叶绿素产出：(\\d+)\n困难模式产出：(\\d+)\n首胜产出：(\\d+)\n剩余小推车数量：(\\d+)，获得叶绿素：(\\d+)\n产出叶绿素总计：(\\d+)",
            "第(\\d+)关\n通关用时：(\\d+)分(\\d+)秒\n杀敌数量：(\\d+)\n关卡叶绿素产出：(\\d+)\n非首胜无额外产出\n产出叶绿素总计：(\\d+)",
            "第(\\d+)关\n通关用时：(\\d+)分(\\d+)秒\n杀敌数量：(\\d+)\n关卡叶绿素产出：(\\d+)\n困难模式产出：(\\d+)\n非首胜无额外产出\n产出叶绿素总计：(\\d+)",
        ];

        foreach (var regexStr in regexStrList)
        {
            var regex = new Regex(regexStr);

            if (!regex.IsMatch(__instance.settleInfo.text))
                continue;

            var match = regex.Match(__instance.settleInfo.text);
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

            __instance.settleInfo.text = string.Format(
                StringStore.translationStringRegex[regexStr],
                [..dynamicParts]
            );

            __instance.settleInfo.font = fontAsset;
        }
    }
}
#endif
