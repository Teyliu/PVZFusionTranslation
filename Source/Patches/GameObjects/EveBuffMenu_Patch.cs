using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(EveBuffMenu))]
public static class EveBuffMenu_Patch
{
    [HarmonyPatch(nameof(EveBuffMenu.Start)), HarmonyPostfix]
    private static void Start(EveBuffMenu __instance)
    {
        foreach (var window in __instance.windows)
            EveOptionWindow_Patch.TranslateEveOptionWindow(window);

        foreach (var text in __instance.quitButton.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText("合上");
    }

    [HarmonyPatch(nameof(EveBuffMenu.InitWindows)), HarmonyPostfix]
    private static void InitWindows(EveBuffMenu __instance)
    {
        foreach (var window in __instance.windows)
            EveOptionWindow_Patch.TranslateEveOptionWindow(window);
    }
}
