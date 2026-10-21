using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Harvest;

[HarmonyPatch(typeof(TreasureStoreMenu))]
public static class TreasureStoreMenu_Patch
{
    [HarmonyPatch(nameof(TreasureStoreMenu.InitCards)), HarmonyPostfix]
    private static void InitCards(TreasureStoreMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }
    }
}
