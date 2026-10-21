using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Harvest;

[HarmonyPatch(typeof(TreasureEvacuateMenu))]
public static class TreasureEvacuateMenu_Patch
{
    [HarmonyPatch(nameof(TreasureEvacuateMenu.Start)), HarmonyPostfix]
    private static void Start(TreasureEvacuateMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;

            if (txt.name.Contains("text (1)"))
                txt.name += "_EVACUATE";
        }
    }
}
