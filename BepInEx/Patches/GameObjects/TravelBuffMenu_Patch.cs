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
        [HarmonyPatch(nameof(TravelBuffMenu.RefeshOptions))]
        [HarmonyPostfix]
        private static void RefeshOptions(TravelBuffMenu __instance)
        {
            foreach (TravelBuffOptionButton button in __instance.options)
            {
                TravelBuffOptionButton_Patch.TranslateOptionButton(button);
            }
        }

        [HarmonyPatch(nameof(TravelBuffMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(TravelBuffMenu __instance)
        {
            Transform refreshTransform = __instance.transform.Find("Refresh");
            if (refreshTransform != null)
            {
                foreach (TextMeshProUGUI text in refreshTransform.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    text.text = StringStore.TranslateText(text.text);
                }
            }
        }
    }
}
