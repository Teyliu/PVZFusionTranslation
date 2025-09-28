using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(ExploreEnterWindow))]
    public static class ExploreEnterWindow_Patch
    {
        [HarmonyPatch(nameof(ExploreEnterWindow.Awake))]
        [HarmonyPostfix]
        private static void Awake(ExploreEnterWindow __instance)
        {
            PlantType thePlantType = (PlantType)__instance.selfType;

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                StringStore.TranslateText(txt);
            }

            __instance.nameText.text = Utils.GetPlantNameFromAlmanac(thePlantType);
        }

        [HarmonyPatch(nameof(ExploreEnterWindow.SetInfo))]
        [HarmonyPostfix]
        private static void SetInfo(ExploreEnterWindow __instance)
        {
            PlantType thePlantType = (PlantType)__instance.selfType;

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                StringStore.TranslateText(txt);
            }

            __instance.nameText.text = Utils.GetPlantNameFromAlmanac(thePlantType);
        }
    }
}
