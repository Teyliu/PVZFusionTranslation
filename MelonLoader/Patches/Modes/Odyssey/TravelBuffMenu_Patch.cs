using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.Patches.Modes.Odyssey.TravelMgr_Patch;
using UnityEngine;
using MelonLoader;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(TravelBuffMenu))]
    public static class TravelBuffMenu_Patch
    {
        [HarmonyPatch(nameof(TravelBuffMenu.RefeshOptions))]
        [HarmonyPostfix]
        public static void RefeshOptions(TravelBuffMenu __instance)
        {
            foreach (TravelBuffOptionButton button in __instance.options)
            {
                TravelBuffOptionButton_Patch.TranslateOptionButton(button);
            }
        }

        [HarmonyPatch(nameof(TravelBuffMenu.Awake))]
        [HarmonyPostfix]
        public static void Awake(TravelBuffMenu __instance)
        {
            Transform refreshTransform = __instance.transform.Find("Refresh");
            foreach (TextMeshProUGUI text in refreshTransform.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }
    }
}