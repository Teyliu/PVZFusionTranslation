using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(TravelAdvantureMenu))]
    public static class TravelAdvantureMenu_Patch
    {
        [HarmonyPatch(nameof(TravelAdvantureMenu.Awake))]
        [HarmonyPostfix]
        public static void Awake(TravelAdvantureMenu __instance)
        {
            foreach(CustomButton_enterGame button in __instance.GetComponentsInChildren<CustomButton_enterGame>())
            {
                string plantName = Utils.GetPlantNameFromAlmanac(button.levelName.text);
                button.levelName.text = (plantName != "") ? plantName : StringStore.TranslateText(button.levelName.text);
            }
        }

        [HarmonyPatch(nameof(TravelAdvantureMenu.LookWeak))]
        [HarmonyPostfix]
        public static void LookWeak(TravelAdvantureMenu __instance)
        {
            Awake(__instance);
        }

        [HarmonyPatch(nameof(TravelAdvantureMenu.LookUlti))]
        [HarmonyPostfix]
        public static void LookUlti(TravelAdvantureMenu __instance)
        {
            Awake(__instance);
        }
    }
}
