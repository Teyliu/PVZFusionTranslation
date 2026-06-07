using System;
using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(HealthSliderManager))]
    public static class HealthSliderManager_Patch
    {
        [HarmonyPatch(nameof(HealthSliderManager.Awake))]
        [HarmonyPostfix]
        private static void Post_Awake(HealthSliderManager __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = fontAsset;
            }
        }
    }
}

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(BoardHealthSlider))]
    public static class BoardHealthSlider_Patch
    {
        [HarmonyPatch(nameof(BoardHealthSlider.SetZombieType))]
        [HarmonyPostfix]
        private static void Post_SetZombieType(BoardHealthSlider __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = fontAsset;
            }
        }
    }
}

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(HealthSlider))]
    public static class HealthSlider_Patch
    {
        private static System.Collections.Generic.Dictionary<HealthSlider, System.Collections.Generic.HashSet<TextMeshProUGUI>> translatedBySlider = new System.Collections.Generic.Dictionary<HealthSlider, System.Collections.Generic.HashSet<TextMeshProUGUI>>();

        [HarmonyPatch(nameof(HealthSlider.UpdateText))]
        [HarmonyPostfix]
        private static void Post_UpdateText(HealthSlider __instance)
        {
            if (__instance == null || __instance.healthTextContainer == null) return;

            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (!translatedBySlider.TryGetValue(__instance, out var translated))
            {
                translated = new System.Collections.Generic.HashSet<TextMeshProUGUI>();
                translatedBySlider[__instance] = translated;
            }

            foreach (TextMeshProUGUI txt in __instance.healthTextContainer.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                if (txt != null && !string.IsNullOrEmpty(txt.text) && !translated.Contains(txt))
                {
                    txt.text = StringStore.TranslateText(txt.text);
                    txt.font = fontAsset;
                    translated.Add(txt);
                }
            }
        }

        [HarmonyPatch(nameof(HealthSlider.Update))]
        [HarmonyPostfix]
        private static void Post_Update(HealthSlider __instance)
        {
            if (__instance == null) return;
            if (__instance.follow == null && translatedBySlider.ContainsKey(__instance))
            {
                translatedBySlider.Remove(__instance);
            }
        }
    }
}
