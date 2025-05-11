#if FIX
using System.Text.RegularExpressions;
using HarmonyLib;

using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;


namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(AbyssBuffButton))]
    public static class AbyssBuffButton_Patch
    {
        [HarmonyPatch(nameof(AbyssBuffButton.SetType))]
        [HarmonyPostfix]
        private static void SetType(AbyssBuffButton __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            Regex regex = new Regex("([^\\s]+)\n价格：(\\d+)");

            if (regex.IsMatch(__instance.description.text))
            {
                Match match = regex.Match(__instance.description.text);
                int groupCount = match.Groups.Count;

                List<string> dynamicParts = [];

                for (int i = 1; i < groupCount; i++)
                {
                    string groupValue = match.Groups[i].Value;
                    string translatedValue = StringStore.translationString.ContainsKey(groupValue) ? StringStore.translationString[groupValue] : groupValue;
                    dynamicParts.Add(translatedValue);
                    MelonLogger.Msg(translatedValue);
                }

                __instance.description.text = string.Format(StringStore.translationStringRegex["([^\\s]+)\n价格：(\\d+)"], [.. dynamicParts]);
                __instance.description.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(AbyssBuffButton.SetSold))]
        [HarmonyPostfix]
        private static void SetSold(AbyssBuffButton __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            __instance.description.text = StringStore.TranslateText(__instance.description.text);
            __instance.description.font = fontAsset;
        }
    }
}
#endif