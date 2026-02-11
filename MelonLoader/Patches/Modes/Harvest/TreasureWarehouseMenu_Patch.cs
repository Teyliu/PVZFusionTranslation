using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Harvest
{
    [HarmonyPatch(typeof(TreasureWarehouseMenu))]
    public static class TreasureWarehouseMenu_Patch
    {
        [HarmonyPatch(nameof(TreasureWarehouseMenu.InitCards))]
        [HarmonyPostfix]
        private static void InitCards(TreasureWarehouseMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(TreasureWarehouseMenu.QuickSell))]
        [HarmonyPostfix]
        private static void QuickSell(TreasureWarehouseMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(TreasureWarehouseMenu.FastSell))]
        [HarmonyPostfix]
        private static void FastSell(TreasureWarehouseMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(TreasureWarehouseMenu.EnterStore))]
        [HarmonyPostfix]
        private static void EnterStore(TreasureWarehouseMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }
    }
}