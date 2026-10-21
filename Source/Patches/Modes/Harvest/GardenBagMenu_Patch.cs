using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Harvest;

[HarmonyPatch(typeof(GardenBagMenu))]
public static class GardenBagMenu_Patch
{
    [HarmonyPatch(nameof(GardenBagMenu.Awake)), HarmonyPostfix]
    private static void Awake(GardenBagMenu __instance)
    {
        _ = FontStore.LoadTMPFont(Utils.Language.ToString());

        var closeButtonTransform = __instance.transform.Find("Close");

        foreach (var text in closeButtonTransform.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText("合上");
    }
}
