using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(TreasureUpgradeMenu))]
    public static class TreasureUpgradeMenu_Patch
    {
        [HarmonyPatch(nameof(TreasureUpgradeMenu.Start))]
        [HarmonyPostfix]
        private static void Start(TreasureUpgradeMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(TreasureUpgradeMenu.UpgradeWareHouse))]
        [HarmonyPostfix]
        private static void UpgradeWareHouse(TreasureUpgradeMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(TreasureUpgradeMenu.InitWareHouseUpgrade))]
        [HarmonyPostfix]
        private static void InitWareHouseUpgrade(TreasureUpgradeMenu __instance)
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