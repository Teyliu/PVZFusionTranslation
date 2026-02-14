using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using static PvZ_Fusion_Translator__BepInEx_.Patches.Managers.TravelMgr_Patch;
using UnityEngine;
using System.Collections.Generic;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelBuffOptionButton))]
    public static class TravelBuffOptionButton_Patch
    {
        [HarmonyPatch(nameof(TravelBuffOptionButton.Awake))]
        [HarmonyPostfix]
        public static void Awake(TravelBuffOptionButton __instance)
        {
            TranslateOptionButton(__instance);
        }

        [HarmonyPatch(nameof(TravelBuffOptionButton.OnAnimOver))]
        [HarmonyPostfix]
        public static void OnAnimOver(TravelBuffOptionButton __instance)
        {
            TranslateOptionButton(__instance);
        }

        public static void TranslateOptionButton(TravelBuffOptionButton button)
        {
            if (button.introduce == null)
                return;

            SortedDictionary<int, string> buffSet = translatedTravelBuffs[buffLinks[button.buffType]];

            string buffText = (button.show != null && buffSet.ContainsKey(button.buffIndex)) ? buffSet[button.buffIndex] : StringStore.TranslateText(button.introduce.text);

            if (button.introduce.text == "词条已选完")
            {
                button.introduce.text = StringStore.TranslateText("词条已选完");
            }
            else
            {
                button.introduce.text = buffText;
            }
        }
    }
}

