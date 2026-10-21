using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Harvest;

[HarmonyPatch(typeof(TreasureManager))]
public static class TreasureManager_Patch
{
    [HarmonyPatch(nameof(TreasureManager.Update)), HarmonyPostfix]
    private static void Update(TreasureManager __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.evaText)
        {
            txt.autoSizeTextContainer = false;

            if (txt.text == "Evacuate")
                continue;

            txt.text = StringStore.TranslateText(txt.text);
            txt.name = txt.text + "_EVACUATE";
            txt.font = fontAsset;
        }
    }
}
