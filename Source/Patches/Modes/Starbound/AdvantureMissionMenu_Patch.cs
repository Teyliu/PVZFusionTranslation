using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Starbound;

[HarmonyPatch(typeof(AdvantureMissionMenu))]
public static class AdvantureMissionMenu_Patch
{
    [HarmonyPatch(nameof(AdvantureMissionMenu.Awake)), HarmonyPostfix]
    private static void Awake(AdvantureMissionMenu __instance)
    {
        foreach (var text in __instance.contant.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateColorText(text.text);
#if false
        foreach (var text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText(text.text);
#endif
    }

    [HarmonyPatch(nameof(AdvantureMissionMenu.InitText)), HarmonyPostfix]
    private static void InitText(AdvantureMissionMenu __instance)
    {
        foreach (var text in __instance.contant.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateColorText(text.text);
#if false
        foreach (var text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText(text.text);
#endif
    }

    [HarmonyPatch(nameof(AdvantureMissionMenu.SwitchAward)), HarmonyPostfix]
    private static void SwitchAward(AdvantureMissionMenu __instance)
    {
        foreach (var text in __instance.contant.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateColorText(text.text);
#if false
        foreach (var text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText(text.text);
#endif
    }
}
