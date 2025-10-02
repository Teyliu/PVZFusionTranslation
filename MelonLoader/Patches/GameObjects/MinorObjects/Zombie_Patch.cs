using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using UnityEngine;
using Il2CppTMPro;
using System.Reflection.Metadata.Ecma335;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(Zombie))]
    public static class Zombie_Patch
    {
        private static Dictionary<string, string> HPStrings = new Dictionary<string, string>()
        {
            { "最后一击：(\\d+)\nDPS：([^\\s]+)\n总伤害：(\\d+)", "Last Damage: {0}\nDPS: {1}\nTotal: {2}" },
            { "^HP：(\\d+)/(\\d+)\n一类：(\\d+)/(\\d+)\n二类：(\\d+)/(\\d+)$", "HP: {0}/{1}\nType 1 armor: {2}/{3}\nType 2 armor: {4}/{5}" },
            { "^HP：(\\d+)/(\\d+)\n一类：(\\d+)/(\\d+)$", "HP: {0}/{1}\nType 1 armor: {2}/{3}" },
            { "^HP：(\\d+)/(\\d+)\n二类：(\\d+)/(\\d+)$", "HP: {0}/{1}\nType 2 armor: {2}/{3}" },
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
            TranslateHpUI(__instance.healthText, __instance);
            TranslateHpUI(__instance.healthTextShadow, __instance);

            if (__instance.healthText.transform.rotation != Quaternion.Euler(0, 0, 0))
                __instance.healthText.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        [HarmonyPatch(nameof(Zombie.Update))]
        [HarmonyPrefix]
        public static void Update(Zombie __instance)
        {
            if (__instance.theZombieType == ZombieType.TrainingDummy || !Board.Instance.showZombieHealth)
                return;
            TranslateHpUI(__instance.healthText, __instance);
            TranslateHpUI(__instance.healthTextShadow, __instance);

            if (__instance.healthText.transform.rotation != Quaternion.Euler(0f, 0f, 0f))
                __instance.healthText.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        public static void TranslateHpUI(TextMeshPro textTMP, Zombie __instance)
        {
            if (textTMP)
            {
                string origText = textTMP.text;
                string translatedText = TranslateHPText(origText, __instance);
                textTMP.text = translatedText == origText ? origText : translatedText;
                textTMP.autoSizeTextContainer = false;
                if (translatedText != origText)
                    textTMP.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }

        public static void TranslateHpUI_T(TextMeshPro textTMP, TrainingDummy __instance)
        {
            if (textTMP)
            {
                string origText = textTMP.text;
                string translatedText = TranslateHPText_T(origText, __instance);
                textTMP.text = translatedText == origText ? origText : translatedText;
                textTMP.autoSizeTextContainer = false;
                if (translatedText != origText)
                    textTMP.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }

        public static string TranslateHPText(string originalText, Zombie __instance)
        {
            string finalText = __instance.healthText.text;
            int fIndex = -1;
            bool found = false;

            for(int i = 0; i < HPStrings.Count; i++)
            {
                var hp = HPStrings.ElementAt(i);
                Regex regex = new Regex(hp.Key);
                if(regex.IsMatch(originalText))
                {
                    fIndex = i;
                    found = true;
                }
            }

            if(fIndex > -1 && found)
            {
                string fStr = HPStrings.ElementAt(fIndex).Value;

                switch (fIndex)
                {
                    case 1:
                        finalText = string.Format(fStr, __instance.theHealth, __instance.theMaxHealth, __instance.theFirstArmorHealth, __instance.theFirstArmorMaxHealth, __instance.theSecondArmorHealth, __instance.theSecondArmorMaxHealth);
                        break;
                    case 2:
                        finalText = string.Format(fStr, __instance.theHealth, __instance.theMaxHealth, __instance.theFirstArmorHealth, __instance.theFirstArmorMaxHealth);
                        break;
                    case 3:
                        finalText = string.Format(fStr, __instance.theHealth, __instance.theMaxHealth, __instance.theSecondArmorHealth, __instance.theSecondArmorMaxHealth);
                        break;
                    case 4:
                        finalText = string.Format(fStr, __instance.theHealth, __instance.theMaxHealth);
                        break;
                    default:
                        break;
                }
            }

            return finalText;
        }

        public static string TranslateHPText_T(string originalText, TrainingDummy __instance)
        {
            string finalText = __instance.healthText.text;
            int fIndex = -1;
            bool found = false;

            for (int i = 0; i < HPStrings.Count; i++)
            {
                var hp = HPStrings.ElementAt(i);
                Regex regex = new Regex(hp.Key);
                if (regex.IsMatch(originalText))
                {
                    fIndex = i;
                    found = true;
                }
            }

            if (fIndex > -1 && found)
            {
                string fStr = HPStrings.ElementAt(fIndex).Value;
                string DPS = originalText.Split("\n")[1].Replace("DPS：", "");

                switch (fIndex)
                {
                    case 0:
                        finalText = string.Format(fStr, __instance.lastDamage, DPS, __instance.totalDamage);
                        break;
                    default:
                        break;
                }
            }

            return finalText;
        }
    }
}