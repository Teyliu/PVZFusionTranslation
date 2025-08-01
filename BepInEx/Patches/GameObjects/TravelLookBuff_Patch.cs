using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelLookBuff))]
    public static class TravelLookBuff_Patch
    {
        private static void TranslateTexts(TravelLookBuff instance)
        {
            instance.introduce.text = StringStore.TranslateText(instance.introduce.text);

            Transform transform = instance.rectTransform.transform;
            var component1 = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            var component2 = transform.GetChild(1).GetComponent<TextMeshProUGUI>();

            if (component1 != null) component1.text = StringStore.TranslateText(component1.text);
            if (component2 != null) component2.text = StringStore.TranslateText(component2.text);
        }

        [HarmonyPatch(nameof(TravelLookBuff.SetBuff))]
        [HarmonyPostfix]
        private static void SetBuff(TravelLookBuff __instance) => TranslateTexts(__instance);

        [HarmonyPatch(nameof(TravelLookBuff.OnMouseUpAsButton))]
        [HarmonyPostfix]
        private static void OnMouseUpAsButton(TravelLookBuff __instance) => TranslateTexts(__instance);

        [HarmonyPatch(nameof(TravelLookBuff.Clear))]
        [HarmonyPostfix]
        private static void Clear(TravelLookBuff __instance) => TranslateTexts(__instance);

        [HarmonyPatch(nameof(TravelLookBuff.SetText), new Type[] { typeof(string) })]
        [HarmonyPostfix]
        private static void SetText_String(TravelLookBuff __instance) => TranslateTexts(__instance);

        [HarmonyPatch(nameof(TravelLookBuff.SetText), new Type[] { typeof(bool), typeof(int) })]
        [HarmonyPostfix]
        private static void SetText_Bool(TravelLookBuff __instance) => TranslateTexts(__instance);
    }
}