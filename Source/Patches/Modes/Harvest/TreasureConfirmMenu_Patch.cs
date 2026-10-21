using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Harvest;

[HarmonyPatch(typeof(TreasureConfirmMenu))]
public static class TreasureConfirmMenu_Patch
{
    [HarmonyPatch(nameof(TreasureConfirmMenu.SetText)), HarmonyPostfix]
    private static void SetText(TreasureConfirmMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }
    }
}
