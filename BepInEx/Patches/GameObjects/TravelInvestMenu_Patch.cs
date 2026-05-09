using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using static PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.TravelBuffOptionButton_Patch;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelInvestMenu))]
    public static class TravelInvestMenu_Patch
    {
        [HarmonyPatch(nameof(TravelInvestMenu.Start))]
        [HarmonyPostfix]
        private static void Start(TravelInvestMenu __instance)
        {
            Log.LogInfo("==== [TravelInvestMenu.Start] ====");
            
            Transform titleText = __instance.transform.Find("Title");
            TextMeshProUGUI shadowText = titleText.GetComponent<TextMeshProUGUI>();

            TextMeshProUGUI regularText = titleText.transform.Find("Title2").GetComponent<TextMeshProUGUI>();
            regularText.text = StringStore.TranslateText(regularText.text);

            shadowText.text = Utils.RemoveColorTags(regularText.text);
        }

        [HarmonyPatch(nameof(TravelInvestMenu.RefreshBuff))]
        [HarmonyPostfix]
        private static void RefreshBuff(TravelInvestMenu __instance, ref TravelBuffOptionButton option)
        {
            TravelBuffOptionButton_Patch.TranslateOptionButton(option);
        }
    }
}