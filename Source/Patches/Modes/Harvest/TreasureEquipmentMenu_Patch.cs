using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Harvest;

[HarmonyPatch(typeof(TreasureEquipmentMenu))]
public static class TreasureEquipmentMenu_Patch
{
    [HarmonyPatch(nameof(TreasureEquipmentMenu.Awake)), HarmonyPostfix]
    private static void Awake(TreasureEquipmentMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }
    }

    [HarmonyPatch(nameof(TreasureEquipmentMenu.UpdateCards)), HarmonyPostfix]
    private static void UpdateCards(TreasureEquipmentMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }
    }
}
