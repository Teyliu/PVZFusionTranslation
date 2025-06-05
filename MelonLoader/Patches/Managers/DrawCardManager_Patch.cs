using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using Il2CppSystem.Collections.Generic;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using UnityEngine.TextCore.Text;
using static MelonLoader.MelonLogger;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(DrawCardManager))]
    public static class DrawCardManager_Patch
    {
        [HarmonyPatch(nameof(DrawCardManager.UpdateText))]
        [HarmonyPostfix]
        private static void Postfix_UpdateText(DrawCardManager __instance)
        {
            Il2CppSystem.Collections.Generic.List<TextMeshProUGUI> texts = __instance.texts;

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
