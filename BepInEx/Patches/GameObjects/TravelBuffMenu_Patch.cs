using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

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
                button.introduce.text = StringStore.TranslateText(button.introduce.text);
            }
        }
    }
}