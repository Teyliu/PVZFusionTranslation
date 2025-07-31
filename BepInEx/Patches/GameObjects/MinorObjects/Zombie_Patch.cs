using HarmonyLib;

using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System.Text.RegularExpressions;
using UnityEngine;
using TMPro;
using System.Collections.Generic;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(Zombie))]
    public static class Zombie_Patch
    {
        private static Dictionary<string, string> HPStrings = new Dictionary<string, string>()
        {
            { "最后一击：(\\d+)\nDPS：(.+)$", "Last damage: {0}\nDPS: {1}" },
            { "^HP：(\\d+)/(\\d+)\n\\D+(\\d+)/(\\d+)\n\\D+(\\d+)/(\\d+)$", "HP: {0}/{1}\nType 1 armor: {2}/{3}\nType 2 armor: {4}/{5}" },
            { "^HP：(\\d+)/(\\d+)\n\\D+(\\d+)/(\\d+)$", "HP: {0}/{1}\nType 1 armor: {2}/{3}" },
            { "^HP：(\\d+)/(\\d+)$", "HP: {0}/{1}" },
        };

        public static void LoadHPStrings()
        {
            foreach (var hp in HPStrings)
                if (StringStore.translationStringRegex.ContainsKey(hp.Key))
                    HPStrings[hp.Key] = StringStore.translationStringRegex[hp.Key];
        }

        [HarmonyPatch(nameof(Zombie.Start))]
        [HarmonyPostfix]
        public static void Start(Zombie __instance)
        {
            TranslateHpUI(__instance.healthText);
            TranslateHpUI(__instance.healthTextShadow);
            if (__instance.theFirstArmorHealth == 0 && __instance.theSecondArmorHealth != 0)
            {
                __instance.healthText.text = __instance.healthText.text.Replace("Type 1", "Type 2");
                __instance.healthTextShadow.text = __instance.healthText.text.Replace("Type 1", "Type 2");
            }
            if (__instance.healthText.transform.rotation != Quaternion.Euler(0, 0, 0))
                __instance.healthText.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        [HarmonyPatch(nameof(Zombie.Update))]
        [HarmonyPrefix]
        public static void Update(Zombie __instance)
        {
            if (__instance.theZombieType == ZombieType.TrainingDummy || !Board.Instance.showZombieHealth)
                return;
            TranslateHpUI(__instance.healthText);
            TranslateHpUI(__instance.healthTextShadow);
            if (__instance.theFirstArmorHealth == 0 && __instance.theSecondArmorHealth != 0)
            {
                __instance.healthText.text = __instance.healthText.text.Replace("Type 1", "Type 2");
                __instance.healthTextShadow.text = __instance.healthText.text.Replace("Type 1", "Type 2");
            }
            if (__instance.healthText.transform.rotation != Quaternion.Euler(0f, 0f, 0f))
                __instance.healthText.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        public static void TranslateHpUI(TextMeshPro textTMP)
        {
            if (textTMP)
            {
                string origText = textTMP.text;
                string translatedText = TranslateHPText(origText);
                textTMP.text = translatedText == origText ? origText : translatedText;
                textTMP.autoSizeTextContainer = false;
                if (translatedText != origText)
                    textTMP.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }

        public static string TranslateHPText(string originalText)
        {
            foreach (var entry in HPStrings)
            {
                var regex = new Regex(entry.Key);
                if (regex.IsMatch(originalText))
                {
                    var match = regex.Match(originalText);
                    int groupCount = match.Groups.Count;

                    List<string> dynamicParts = new List<string>();

                    for (int i = 1; i < groupCount; i++)
                    {
                        string groupValue = match.Groups[i].Value;
                        string translatedValue = StringStore.translationString.ContainsKey(groupValue)
                            ? StringStore.translationString[groupValue]
                            : groupValue;
                        dynamicParts.Add(translatedValue);
                    }
                    return originalText = string.Format(entry.Value, [.. dynamicParts]);
                }
            }
            return originalText;
        }
    }
}