using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelAdvantureMenu))]
    public static class TravelAdvantureMenu_Patch
    {
        [HarmonyPatch(nameof(TravelAdvantureMenu.Awake))]
        [HarmonyPostfix]
        public static void Awake(TravelAdvantureMenu __instance)
        {
            Log.LogInfo("==== [TravelAdvantureMenu.Awake] ====");
            foreach (CustomButton_enterGame button in __instance.GetComponentsInChildren<CustomButton_enterGame>())
            {
                string original = button.levelName.text;
                string plantName = Utils.GetPlantNameFromAlmanac(button.levelName.text);
                button.levelName.text = (plantName != "") ? plantName : StringStore.TranslateText(button.levelName.text);
                Log.LogInfo($"[TravelAdvantureMenu] levelName: \"{original}\" -> \"{button.levelName.text}\" (almanac: {plantName != ""})");
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