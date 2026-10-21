using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(GodShootingMenu))]
public static class GodShootingMenu_Patch
{
    [HarmonyPatch(nameof(GodShootingMenu.Start)), HarmonyPostfix]
    private static void Start(GodShootingMenu __instance)
    {
        foreach (var text in __instance.transform.Find("Background").GetComponentsInChildren<TextMeshProUGUI>())
        {
            text.autoSizeTextContainer = true;
            text.text = StringStore.TranslateText(text.text);
        }

        foreach (var text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText(text.text);
    }

    [HarmonyPatch(nameof(GodShootingMenu.ShowRoutes)), HarmonyPostfix]
    private static void ShowRoutes(GodShootingMenu __instance)
    {
        foreach (var route in __instance.routes)
        {
            if (route.Value == null)
                continue;

            foreach (var text in route.Value.GetComponentsInChildren<TextMeshProUGUI>())
                text.text = StringStore.TranslateText(text.text);
        }
    }
}
