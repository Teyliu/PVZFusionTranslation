using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(UIButton))]
    public static class UIButton_Patch
    {
        [HarmonyPatch(nameof(UIButton.Start))]
        [HarmonyPostfix]
        private static void Postfix_Start(UIButton __instance)
        {
            try
            {
                // Convert and translate legacy Text components
                Text[] textComponents = __instance.GetComponentsInChildren<Text>(true);
                TextMeshProUGUI[] textMeshComponents = __instance.GetComponentsInChildren<TextMeshProUGUI>(true);
                foreach (Text textComponent in textComponents)
                {
                    if (textComponent != null && !string.IsNullOrEmpty(textComponent.text))
                    {
                        string translatedText = StringStore.TranslateText(textComponent.text);
                        if (!string.IsNullOrEmpty(translatedText) && translatedText != textComponent.text)
                        {
                            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
                            TextMeshProUGUI newTMP = StringStore.ConvertToTextMeshPro(textComponent, fontAsset, true);

                            if (newTMP != null)
                            {
                                newTMP.text = translatedText;
                            } 
                        }
                    }
                }

                // Also handle TMP components directly under the button
                if (__instance.transform.childCount >= 2)
                {
                    TextMeshProUGUI text = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                    TextMeshProUGUI textShadow = __instance.transform.GetChild(1).GetComponent<TextMeshProUGUI>();

                    StringStore.TranslateTextUI(text, false);
                    StringStore.TranslateTextUI(textShadow, false);
                    text.autoSizeTextContainer = textShadow.autoSizeTextContainer = true;
                }
            }
            catch (Exception) { }
        }

        [HarmonyPatch(nameof(UIButton.OnMouseUpAsButton))]
        [HarmonyPostfix]
        public static void Postfix_OnMouseUpAsButton(UIButton __instance)
        {
            try
            {
                if (__instance.transform.childCount >= 2)
                {
                    TextMeshProUGUI text = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                    TextMeshProUGUI textShadow = __instance.transform.GetChild(1).GetComponent<TextMeshProUGUI>();

                    StringStore.TranslateTextUI(text, false);
                    StringStore.TranslateTextUI(textShadow, false);
                    text.autoSizeTextContainer = textShadow.autoSizeTextContainer = true;
                }
            }
            catch (Exception) { }
        }
    }
}
