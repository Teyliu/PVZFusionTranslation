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
                button.introduce.text = translatedTravelBuffs[buffLinks[button.buffType]][button.buffIndex];
                List<string> buffSet = translatedTravelBuffs[buffLinks[button.buffType]];
                string buffText = (button.buffIndex < buffSet.Count && button.show != null) ? buffSet[button.buffIndex] : StringStore.TranslateText(button.introduce.text);
                button.introduce.text = buffText;
            }
        }
    }
}