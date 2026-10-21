using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator.Patches.Modes.Harvest;

[HarmonyPatch(typeof(TreasureUpgradeMenu))]
public static class TreasureUpgradeMenu_Patch
{
    [HarmonyPatch(nameof(TreasureUpgradeMenu.Start)), HarmonyPostfix]
    private static void Start(TreasureUpgradeMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }
    }

    [HarmonyPatch(nameof(TreasureUpgradeMenu.UpgradeWareHouse)), HarmonyPostfix]
    private static void UpgradeWareHouse(TreasureUpgradeMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }
    }

    [HarmonyPatch(nameof(TreasureUpgradeMenu.InitWareHouseUpgrade)), HarmonyPostfix]
    private static void InitWareHouseUpgrade(TreasureUpgradeMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }

        foreach (var txt in __instance.GetComponentsInChildren<Text>())
        {
            var newTxtObj = Utils.ConvertToTextMeshProUGUI(txt.gameObject, txt.transform.parent, "text");
            var newTxt = newTxtObj.GetComponent<TextMeshProUGUI>();
            newTxt.text = StringStore.TranslateText("植物商店");
            newTxt.autoSizeTextContainer = true;
            newTxt.color = new(0, 0, 0.3922f, 1);
        }
    }
}
