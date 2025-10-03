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
            TextMeshProUGUI[] array =
            [
                __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>(),
                __instance.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>(),
            ];
            for (int i = 0; i < array.Length; i++)
            {
                string pattern = "([^\\s]+)，推荐难度：(\\d+)";
                string[] parts = array[i].text.Split("，推荐难度：");

                if (new Regex(pattern).IsMatch(array[i].text))
                {
                    if (StringStore.translationStringRegex.TryGetValue(pattern, out string fmt))
                    {
                        array[i].text = string.Format(fmt, StringStore.TranslateText(parts[0]), parts[1]);
                    }
                }

                array[i] = StringStore.TranslateText(array[i]);
                array[i].text = array[i].text.Replace("\n", " ");
            }
        }

        [HarmonyPatch(nameof(IZBottomMenu.SetLevelName))]
        [HarmonyPostfix]
        public static void SetLevelName(IZBottomMenu __instance)
        {
            TextMeshProUGUI[] array =
            [
                __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>(),
                __instance.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>(),
            ];
            for (int i = 0; i < array.Length; i++)
            {
                string pattern = "([^\\s]+)，推荐难度：(\\d+)";
                string[] parts = array[i].text.Split("，推荐难度：");

                if (new Regex(pattern).IsMatch(array[i].text))
                {
                    if (StringStore.translationStringRegex.TryGetValue(pattern, out string fmt))
                    {
                        array[i].text = string.Format(fmt, StringStore.TranslateText(parts[0]), parts[1]);
                    }
                }

                array[i] = StringStore.TranslateText(array[i]);
                array[i].text = array[i].text.Replace("\n", " ");
            }
        }
    }
}


