using HarmonyLib;
using System;
using System.Collections.Generic;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelLookMenu))]
    public static class TravelLookMenu_Patch
    {
        private static readonly Dictionary<IntPtr, string> _assetCache = new();

        [HarmonyPatch(nameof(TravelLookMenu.Start))]
        [HarmonyPostfix]
        private static void Postfix_Start(TravelLookMenu __instance)
        {
            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = TravelMgr_Patch.TranslateTravelText(txt.text);
                txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }

            Transform quitButtonTransform = __instance.transform.Find("Quit");
            if (quitButtonTransform != null)
            {
                foreach (TextMeshProUGUI txt in quitButtonTransform.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    txt.text = StringStore.TranslateText("合上");
                    txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
                }
            }

            if (__instance.treasureText != null)
            {
                __instance.treasureText.text = TravelMgr_Patch.TranslateTravelText(__instance.treasureText.text);
                _assetCache[__instance.Pointer] = __instance.treasureText.text;
            }
        }

        [HarmonyPatch(nameof(TravelLookMenu.Update))]
        [HarmonyPostfix]
        private static void Update(TravelLookMenu __instance)
        {
            if (__instance == null || __instance.treasureText == null)
                return;

            IntPtr key = __instance.Pointer;
            string current = __instance.treasureText.text;

            if (_assetCache.TryGetValue(key, out string cached) && cached == current)
                return;

            __instance.treasureText.text = TravelMgr_Patch.TranslateTravelText(current);
            _assetCache[key] = __instance.treasureText.text;
        }
    }
}
