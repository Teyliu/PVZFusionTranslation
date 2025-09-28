using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(GardenBagMenu))]
    public static class GardenBagMenu_Patch
    {
        [HarmonyPatch(nameof(GardenBagMenu.SetTreasureCards))]
        [HarmonyPostfix]
        private static void SetTreasureCards(GardenBagMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                FileLoader.DumpUntranslatedStrings(txt.text);
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(GardenBagMenu.SetTreasureCard))]
        [HarmonyPostfix]
        private static void SetTreasureCard(GardenBagMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                FileLoader.DumpUntranslatedStrings(txt.text);
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }
    }
}