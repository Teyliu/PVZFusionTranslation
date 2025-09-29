using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
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

            foreach (Text txt in __instance.GetComponentsInChildren<Text>())
            {
                GameObject newTxtObj = Utils.ConvertToTextMeshProUGUI(txt.gameObject, txt.transform.parent, "text");
                TextMeshProUGUI newTxt = newTxtObj.GetComponent<TextMeshProUGUI>();
                newTxt.text = StringStore.TranslateText("植物商店");
                newTxt.autoSizeTextContainer = true;
                newTxt.color = new Color(0, 0, 0.3922f, 1);
            }
        }
    }
}