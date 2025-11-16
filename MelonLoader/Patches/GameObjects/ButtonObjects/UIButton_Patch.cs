using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator.Patches.GameObjects
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
                // Also handle TMP components directly under the button
                if (__instance.transform.childCount >= 2)
                {
                    TextMeshProUGUI text = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                    TextMeshProUGUI textShadow = __instance.transform.GetChild(1).GetComponent<TextMeshProUGUI>();

                    text.text = StringStore.TranslateText(text.text, false);
                    textShadow.text = StringStore.TranslateText(textShadow.text, false);

                    text.font = FontStore.LoadTMPFont(Utils.Language.ToString());
                    textShadow.font = FontStore.LoadTMPFont(Utils.Language.ToString());
                }
                else
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
                    if(__instance.name == "EditMode")
                    {
                        TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

                        TextMeshProUGUI text = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                        TextMeshProUGUI[] extraTexts = __instance.transform.GetChild(1).GetComponentsInChildren<TextMeshProUGUI>();

                        text.text = StringStore.TranslateText(text.text, false);
                        text.font = fontAsset;

                        foreach(TextMeshProUGUI extraText in extraTexts)
                        {
                            extraText.text = StringStore.TranslateText(extraText.text, false);
                            extraText.font = fontAsset;
                        }
                    }
                    else
                    {
                        TextMeshProUGUI text = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                        TextMeshProUGUI textShadow = __instance.transform.GetChild(1).GetComponent<TextMeshProUGUI>();

                        text.text = StringStore.TranslateText(text.text, false);
                        textShadow.text = StringStore.TranslateText(textShadow.text, false);

                        text.font = FontStore.LoadTMPFont(Utils.Language.ToString());
                        textShadow.font = FontStore.LoadTMPFont(Utils.Language.ToString());
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
