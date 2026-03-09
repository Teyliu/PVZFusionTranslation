using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelSynergyMenu))]
    public static class TravelSynergyMenu_Patch
    {
        [HarmonyPatch(nameof(TravelSynergyMenu.Awake))]
        [HarmonyPostfix]
        public static void Awake(TravelSynergyMenu __instance)
        {
            Transform background = __instance.transform.Find("Background");
            Transform tip = __instance.transform.Find("Text (TMP)");

            foreach(TextMeshProUGUI text in background.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }

            foreach (TextMeshProUGUI text in tip.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }
    }
}
