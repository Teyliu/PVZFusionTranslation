using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Super_Editor
{
    [HarmonyPatch(typeof(CustomMenu_page3))]
    public static class CustomMenuPage_page3_Patch
    {
        [HarmonyPatch(nameof(CustomMenu_page3.UpdateCardsText))]
        [HarmonyPostfix]
        public static void UpdateCardsText(CustomMenu_page3 __instance)
        {
            string plantName = Utils.GetPlantNameFromAlmanac(__instance.nameText.text);
            __instance.nameText.text = (plantName != "") ? (plantName) : StringStore.TranslateText(__instance.nameText.text);
        }

        [HarmonyPatch(nameof(CustomMenu_page3.UpdateAdvancedInfo))]
        [HarmonyPostfix]
        public static void UpdateAdvancedInfo(CustomMenu_page3 __instance)
        {
            string plantName = Utils.GetPlantNameFromAlmanac(__instance.nameText.text);
            __instance.nameText.text = (plantName != "") ? (plantName) : StringStore.TranslateText(__instance.nameText.text);
        }
    }
}
