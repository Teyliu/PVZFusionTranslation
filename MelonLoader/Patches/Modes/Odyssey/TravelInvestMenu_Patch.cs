using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(TravelInvestMenu))]
    public static class TravelInvestMenu_Patch
    {
        [HarmonyPatch(nameof(TravelInvestMenu.Start))]
        [HarmonyPostfix]
        private static void Start(TravelInvestMenu __instance)
        {
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
