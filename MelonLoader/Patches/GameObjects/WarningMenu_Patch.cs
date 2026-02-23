using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(WarningMenu))]
    public static class WarningMenu_Patch
    {
        [HarmonyPatch(nameof(WarningMenu.Start))]
        [HarmonyPostfix]
        private static void Start(WarningMenu __instance)
        {
            TranslateInvestmentWarning(__instance);
        }

        [HarmonyPatch(nameof(WarningMenu.EnableChallengeMode))]
        [HarmonyPostfix]
        private static void EnableChallengeMode(WarningMenu __instance)
        {
            TranslateInvestmentWarning(__instance);
        }

        [HarmonyPatch(nameof(WarningMenu.Cancel))]
        [HarmonyPostfix]
        private static void Cancel(WarningMenu __instance)
        {
            TranslateInvestmentWarning(__instance);
        }

        public static void TranslateInvestmentWarning(WarningMenu __instance)
        {
            Transform normalModeTransform = __instance.transform.Find("Normal");
            Transform challengeModeTransform = __instance.transform.Find("Challenge");

            if (normalModeTransform != null)
            {
                TextMeshProUGUI text = normalModeTransform.Find("text").GetComponent<TextMeshProUGUI>();
                TextMeshProUGUI textShadow = normalModeTransform.Find("text (1)").GetComponent<TextMeshProUGUI>();

                text.text = StringStore.translationString.ContainsKey("普通模式_IV") ? StringStore.TranslateText("普通模式_IV") : Utils.RemoveColorTags(StringStore.TranslateText(text.text));
                text.alignment = TextAlignmentOptions.Center;
                text.autoSizeTextContainer = true;
                textShadow.text = Utils.RemoveColorTags(text.text);
                textShadow.alignment = TextAlignmentOptions.Center;
                textShadow.autoSizeTextContainer = true;
            }

            if (challengeModeTransform != null)
            {
                TextMeshProUGUI text = challengeModeTransform.Find("text").GetComponent<TextMeshProUGUI>();
                TextMeshProUGUI textShadow = challengeModeTransform.Find("text (1)").GetComponent<TextMeshProUGUI>();

                text.text = StringStore.translationString.ContainsKey("诅咒模式_IV") ? StringStore.TranslateText("诅咒模式_IV") : Utils.RemoveColorTags(StringStore.TranslateText(text.text));
                text.alignment = TextAlignmentOptions.Center;
                text.autoSizeTextContainer = true;
                textShadow.text = Utils.RemoveColorTags(text.text);
                textShadow.alignment = TextAlignmentOptions.Center;
                textShadow.autoSizeTextContainer = true;
            }

            if (__instance.tutor != null)
            {
                foreach (TextMeshProUGUI text in __instance.tutor.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    if (text.gameObject.name == "text1")
                    {
                        text.text = StringStore.TranslateText(text.text);
                        if (text.transform.parent.Find("text").TryGetComponent<TextMeshProUGUI>(out TextMeshProUGUI textShadow))
                        {
                            textShadow.text = Utils.RemoveColorTags(text.text);
                        }
                    }
                }
            }

            if (__instance.challenge != null)
            {
                foreach (TextMeshProUGUI text in __instance.challenge.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    if (text.gameObject.name == "text1")
                    {
                        text.text = StringStore.TranslateText(text.text);
                        if (text.transform.parent.Find("text").TryGetComponent<TextMeshProUGUI>(out TextMeshProUGUI textShadow))
                        {
                            textShadow.text = Utils.RemoveColorTags(text.text);
                        }
                    }
                }
            }
        }
    }
}
