using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System.Text.RegularExpressions;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(IZBottomMenu))]
    public static class IZBottomMenu_Patch
    {
        [HarmonyPatch(nameof(IZBottomMenu.ChangeString))]
        [HarmonyPostfix]
        public static void ChangeStringz(IZBottomMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.levelName)
            {
                string fStr = StringStore.translationStringRegex["([^\\s]+)，推荐难度：(\\d+)"];
                string[] parts = text.text.Split("，推荐难度：");

                if (new Regex("([^\\s]+)，推荐难度：(\\d+)").IsMatch(text.text))
                {
                    string customName = (StringStore.translationString.ContainsKey(parts[0] + "_IZ")) ? parts[0] + "_IZ" : parts[0];
                    text.text = string.Format(fStr, StringStore.TranslateText(customName), parts[1]);
                }

                text.text = StringStore.TranslateText(text.text);
                text.text = text.text.Replace("\n", " ");
            }
        }

        [HarmonyPatch(nameof(IZBottomMenu.SetLevelName))]
        [HarmonyPostfix]
        public static void SetLevelName(IZBottomMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.levelName)
            {
                string fStr = StringStore.translationStringRegex["([^\\s]+)，推荐难度：(\\d+)"];
                string[] parts = text.text.Split("，推荐难度：");

                if (new Regex("([^\\s]+)，推荐难度：(\\d+)").IsMatch(text.text))
                {
                    text.text = string.Format(fStr, StringStore.TranslateText(parts[0]), parts[1]);
                }

                text.text = StringStore.TranslateText(text.text);
                text.text = text.text.Replace("\n", " ");
            }
        }
    }
}


