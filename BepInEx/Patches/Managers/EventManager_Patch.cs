using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(EventManager))]
    public static class EventManager_Patch
    {
        [HarmonyPatch(typeof(EventManager), "ShowText", new Type[] { typeof(string), typeof(float) })]
        [HarmonyPrefix]
        private static void Prefix_ShowText(ref string text)
        {
            text = StringStore.TranslateText(text);
        }

        [HarmonyPatch(typeof(EventManager), "ShowText", new Type[] { typeof(string), typeof(float), typeof(bool) })]
        [HarmonyPostfix]
        private static void Post_ShowText()
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            var eventManager = EventManager.Instance;
            if (eventManager != null)
            {
                foreach (TextMeshProUGUI text in eventManager.GetComponentsInChildren<TextMeshProUGUI>(true))
                {
                    text.text = StringStore.TranslateText(text.text);
                    text.font = fontAsset;
                }
            }
        }
    }
}
