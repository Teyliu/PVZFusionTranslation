using System.Text.RegularExpressions;
using HarmonyLib;
using System.Collections.Generic;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine.TextCore.Text;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AbyssDevelopMenu))]
    public static class AbyssDevelopMenu_Patch
    {

        [HarmonyPatch(nameof(AbyssDevelopMenu.UpdateInfo))]
        [HarmonyPostfix]
        private static void UpdateInfo(AbyssDevelopMenu __instance)
        {
            __instance.currentMoney.text = StringStore.TranslateText(__instance.currentMoney.text);
            __instance.upgradeTextInfo.text = StringStore.TranslateText(__instance.upgradeTextInfo.text);
            
            TextMeshProUGUI upgradeCostText = __instance.transform.FindChild("UpgradeCost").GetComponent<TextMeshProUGUI>();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            string regexStr = "([^\\s]+)\n当前等级：([^\\s]+)\n\n升级条件：\n([^\\s]+)\n\n升级消耗：([^\\s]+)";

            Regex regex = new Regex(regexStr);

            if (regex.IsMatch(upgradeCostText.text))
            {
                Match match = regex.Match(upgradeCostText.text);
                int groupCount = match.Groups.Count;

                List<string> dynamicParts = [];

                for (int i = 1; i < groupCount; i++)
                {
                    string groupValue = match.Groups[i].Value;
                    string translatedValue = StringStore.translationString.ContainsKey(groupValue) ? StringStore.translationString[groupValue] : groupValue;
                    dynamicParts.Add(translatedValue);
                }

                upgradeCostText.text = string.Format(StringStore.translationStringRegex[regexStr], [.. dynamicParts]);
                upgradeCostText.font = fontAsset;
            }
        }
    }
}
