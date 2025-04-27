using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using Unity.VisualScripting;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AbyssSettlementMenu))]
    public static class AbyssSettlementMenu_Patch
    {

        [HarmonyPatch(nameof(AbyssSettlementMenu.InitSettle))]
        [HarmonyPostfix]
        private static void InitSettle(AbyssSettlementMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            string regexStr1 = "第(\\d+)关\n通关用时：(\\d+)分(\\d+)秒\n杀敌数量：(\\d+)\n关卡叶绿素产出：(\\d+)\n极限模式产出：(\\d+)\n非首胜无额外产出\n产出叶绿素总计：(\\d+)\n";
            string regexStr2 = "第(\\d+)关\n通关用时：(\\d+)分(\\d+)秒\n杀敌数量：(\\d+)\n关卡叶绿素产出：(\\d+)\n极限模式产出：(\\d+)\n首胜产出：(\\d+)\n剩余小推车数量：(\\d+)，获得叶绿素：(\\d+)\n产出叶绿素总计：(\\d+)";

            Regex regex1 = new Regex(regexStr1);
            Regex regex2 = new Regex(regexStr2);

            if (regex1.IsMatch(__instance.settleInfo.text))
            {
                Match match = regex1.Match(__instance.settleInfo.text);
                int groupCount = match.Groups.Count;

                List<string> dynamicParts = [];

                for (int i = 1; i < groupCount; i++)
                {
                    string groupValue = match.Groups[i].Value;
                    string translatedValue = StringStore.translationString.ContainsKey(groupValue) ? StringStore.translationString[groupValue] : groupValue;
                    dynamicParts.Add(translatedValue);
                }

                __instance.settleInfo.text = string.Format(StringStore.translationStringRegex[regexStr1], [.. dynamicParts]);
                __instance.settleInfo.font = fontAsset;
            } 
            else if (regex2.IsMatch(__instance.settleInfo.text))
            {
                Match match = regex2.Match(__instance.settleInfo.text);
                int groupCount = match.Groups.Count;

                List<string> dynamicParts = [];

                for (int i = 1; i < groupCount; i++)
                {
                    string groupValue = match.Groups[i].Value;
                    string translatedValue = StringStore.translationString.ContainsKey(groupValue) ? StringStore.translationString[groupValue] : groupValue;
                    dynamicParts.Add(translatedValue);
                }

                __instance.settleInfo.text = string.Format(StringStore.translationStringRegex[regexStr2], [.. dynamicParts]);
                __instance.settleInfo.font = fontAsset;
            }
        }
    }
}
