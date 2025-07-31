using HarmonyLib;
using System;
using TMPro;
using Il2CppSystem.Collections.Generic;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(DrawCardManager))]
    public static class DrawCardManager_Patch
    {
        [HarmonyPatch(nameof(DrawCardManager.UpdateText))]
        [HarmonyPostfix]
        private static void Postfix_UpdateText(DrawCardManager __instance)
        {
            Il2CppSystem.Collections.Generic.List<TextMeshProUGUI> texts = __instance.texts;
            __instance.upName = StringStore.TranslateText(__instance.upName);
            if (texts != null && texts.Count > 0)
            {
                foreach (TextMeshProUGUI textComponent in texts)
                {
                    if (textComponent != null)
                    {
                        string translatedText = StringStore.TranslateText(textComponent.text);
                        TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
                        textComponent.text = translatedText;
                        textComponent.font = fontAsset;
                    }
                }
            }
        }



        [HarmonyPatch(nameof(DrawCardManager.Update))]
        [HarmonyPostfix]
        private static void Postfix_Update(DrawCardManager __instance)
        {
            Il2CppSystem.Collections.Generic.List<TextMeshProUGUI> texts = __instance.texts;
            __instance.upName = StringStore.TranslateText(__instance.upName);

            if (texts != null && texts.Count > 0)
            {
                foreach (TextMeshProUGUI textComponent in texts)
                {
                    if (textComponent != null)
                    {
                        string translatedText = StringStore.TranslateText(textComponent.text);
                        TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
                        textComponent.text = translatedText;
                        textComponent.font = fontAsset;
                    }
                }
            }

        }
    }
}

