using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey;

[HarmonyPatch(typeof(TravelBuffMenu))]
public static class TravelBuffMenu_Patch
{
    [HarmonyPatch(nameof(TravelBuffMenu.RefeshOptions)), HarmonyPostfix]
    public static void RefeshOptions(TravelBuffMenu __instance)
    {
        foreach (var button in __instance.options)
            TravelBuffOptionButton_Patch.TranslateOptionButton(button);
    }

    [HarmonyPatch(nameof(TravelBuffMenu.Awake)), HarmonyPostfix]
    public static void Awake(TravelBuffMenu __instance)
    {
        var refreshTransform = __instance.transform.Find("Refresh");

        foreach (var text in refreshTransform.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText(text.text);
    }
}
