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
            Text[] textComponents = __instance.GetComponentsInChildren<Text>(true);

            foreach (Text textComponent in textComponents)
            {
                if (textComponent != null && !string.IsNullOrEmpty(textComponent.text))
                {
                    string translatedText = StringStore.TranslateText(textComponent.text);

                    if (!string.IsNullOrEmpty(translatedText) && translatedText != textComponent.text)
                    {
                        textComponent.text = translatedText;
                        // TODO: Add a new font handler for UnityEngine.Font
                    }
                }
            }
        }
    }
}
