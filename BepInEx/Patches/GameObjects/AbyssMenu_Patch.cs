using HarmonyLib;

using TMPro;
using System;
using System.Collections.Generic;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using Unity.VisualScripting;
using UnityEngine;
using System.Text.RegularExpressions;
using UnityEngine.UI;


namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AbyssMenu))]
    public static class AbyssMenu_Patch
    {
        [HarmonyPatch(nameof(AbyssMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(AbyssMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.levelInfo)
            {
                txt.text = StringStore.TranslateText(txt.text, false);
                txt.font = fontAsset;
            }

            Utils.ConvertButtonText(__instance.transform, "Goback");
        }

        [HarmonyPatch(nameof(AbyssMenu.UpdateLevelInfo))]
        [HarmonyPostfix]
        private static void UpdateLevelInfo(AbyssMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.levelInfo)
            {
                string regexStr = "第(\\d+)关\n场景：([^\\s]+)\n总波数：(\\d+)波\n特殊环境：([^\\s：]+)\n减伤强度：(\\d+)";

                Regex regex = new Regex(regexStr);

                if(regex.IsMatch(txt.text))
                {   
                    Match match = regex.Match(txt.text);
                    int groupCount = match.Groups.Count;

                    List<string> dynamicParts = [];

                    for (int i = 1; i < groupCount; i++)
                    {
                        string groupValue = match.Groups[i].Value;
                        string translatedValue = StringStore.translationString.ContainsKey(groupValue) ? StringStore.translationString[groupValue] : groupValue;
                        dynamicParts.Add(translatedValue);
                    }

                    txt.text = string.Format(StringStore.translationStringRegex[regexStr], [.. dynamicParts]);
                    txt.font = fontAsset;
                }
            }
        }
    }
}
