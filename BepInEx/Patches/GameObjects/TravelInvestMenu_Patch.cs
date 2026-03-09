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
            Log.LogInfo("[TravelInvestMenu_Patch] Start called");
            
            Transform titleText = __instance.transform.Find("Title");
            if (titleText == null)
            {
                Log.LogWarning("[TravelInvestMenu_Patch] Title transform not found!");
                return;
            }
            
            TextMeshProUGUI shadowText = titleText.GetComponent<TextMeshProUGUI>();
            if (shadowText == null)
            {
                Log.LogWarning("[TravelInvestMenu_Patch] shadowText not found!");
                return;
            }

            Transform title2Transform = titleText.transform.Find("Title2");
            if (title2Transform == null)
            {
                Log.LogWarning("[TravelInvestMenu_Patch] Title2 transform not found!");
                return;
            }
            
            TextMeshProUGUI regularText = title2Transform.GetComponent<TextMeshProUGUI>();
            if (regularText == null)
            {
                Log.LogWarning("[TravelInvestMenu_Patch] regularText not found!");
                return;
            }

            string originalText = regularText.text;
            regularText.text = StringStore.TranslateText(regularText.text);
            Log.LogInfo($"[TravelInvestMenu_Patch] Title translated: '{originalText}' -> '{regularText.text}'");

            shadowText.text = Utils.RemoveColorTags(regularText.text);
#if DEBUG
            if (regularText.text != originalText)
            {
                FileLoader.DumpUntranslatedStrings(originalText);
            }
#endif
        }

        [HarmonyPatch(nameof(TravelInvestMenu.RefreshBuff))]
        [HarmonyPostfix]
        private static void RefreshBuff(TravelInvestMenu __instance, ref TravelBuffOptionButton option)
        {
            Log.LogInfo($"[TravelInvestMenu_Patch] RefreshBuff called. option: {option != null}");
            TranslateOptionButton(option);
        }
    }
}
