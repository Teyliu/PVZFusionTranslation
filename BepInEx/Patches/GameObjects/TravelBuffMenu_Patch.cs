using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using static PvZ_Fusion_Translator__BepInEx_.Patches.Managers.TravelMgr_Patch;
using UnityEngine;
using System.Collections.Generic;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelBuffMenu))]
    public static class TravelBuffMenu_Patch
    {
        private static void TranslateMenuText(TravelBuffMenu instance)
        {
            if (instance == null)
                return;

            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (TextMeshProUGUI text in instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                if (text == null || string.IsNullOrEmpty(text.text))
                    continue;

                text.text = PvZ_Fusion_Translator__BepInEx_.Patches.Managers.TravelMgr_Patch.TranslateTravelText(text.text);
                text.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(TravelBuffMenu.RefeshOptions))]
        [HarmonyPostfix]
        private static void RefeshOptions(TravelBuffMenu __instance)
        {
            Log.LogInfo("==== [TravelBuffMenu.RefeshOptions] ====");
            Log.LogInfo($"[TravelBuffMenu] RefeshOptions called, options count: {(__instance.options != null ? __instance.options.Count : 0)}");
            foreach (TravelBuffOptionButton button in __instance.options)
            {
                TravelBuffOptionButton_Patch.TranslateOptionButton(button);
            }
            TranslateMenuText(__instance);
        }

        [HarmonyPatch(nameof(TravelBuffMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(TravelBuffMenu __instance)
        {
            TranslateMenuText(__instance);
        }
    }
}
