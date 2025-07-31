using HarmonyLib;
using TMPro;
using System.Collections.Generic;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(DrawCardManager))]
    public static class DrawCardManager_Patch
    {
        // Dùng chung xử lý cập nhật text
        private static void TranslateAndApplyFont(Il2CppSystem.Collections.Generic.List<TextMeshProUGUI> texts)
            {
                if (texts == null || texts.Count == 0) return;

                TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

                foreach (var textComponent in texts)
                {
                    if (textComponent == null) continue;

                    string translatedText = StringStore.TranslateText(textComponent.text);
                    textComponent.text = translatedText;
                    textComponent.font = fontAsset;
                }
            }

        [HarmonyPostfix]
        [HarmonyPatch(nameof(DrawCardManager.UpdateText))]
        private static void Postfix_UpdateText(DrawCardManager __instance)
        {
            __instance.upName = StringStore.TranslateText(__instance.upName);
            TranslateAndApplyFont(__instance.texts);
        }

        [HarmonyPostfix]
        [HarmonyPatch(nameof(DrawCardManager.Update))]
        private static void Postfix_Update(DrawCardManager __instance)
        {
            __instance.upName = StringStore.TranslateText(__instance.upName);
            TranslateAndApplyFont(__instance.texts);
        }
    }
}
