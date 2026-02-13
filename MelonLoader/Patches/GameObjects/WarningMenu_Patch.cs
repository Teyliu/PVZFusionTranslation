using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using UnityEngine;

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

                text.text = Utils.RemoveColorTags(StringStore.TranslateText(text.text));
                textShadow.text = Utils.RemoveColorTags(textShadow.text);
            }

            if (challengeModeTransform != null)
            {
                TextMeshProUGUI text = challengeModeTransform.Find("text").GetComponent<TextMeshProUGUI>();
                TextMeshProUGUI textShadow = challengeModeTransform.Find("text (1)").GetComponent<TextMeshProUGUI>();

                text.text = Utils.RemoveColorTags(StringStore.TranslateText(text.text));
                textShadow.text = Utils.RemoveColorTags(textShadow.text);
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