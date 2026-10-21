#if false
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Abyss;

[HarmonyPatch(typeof(AbyssMenu))]
public static class AbyssMenu_Patch
{
    [HarmonyPatch(nameof(AbyssMenu.Awake)), HarmonyPostfix]
    private static void Awake(AbyssMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.levelInfo)
        {
            txt.text = StringStore.TranslateText(
                txt.text,
                "第(\\d+)关\n场景：([^\\s]+)\n总波数：(\\d+)波\n特殊环境：([^\\s]+)\n难度：(\\d+)"
            );

            txt.font = fontAsset;
        }

        foreach (var text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            text.text = StringStore.TranslateText(text.text);
            text.font = fontAsset;
        }
    }

    [HarmonyPatch(nameof(AbyssMenu.UpdateLevelInfo)), HarmonyPostfix]
    private static void UpdateLevelInfo(AbyssMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (TextMeshProUGUI txt in __instance.levelInfo)
        {
            txt.text = StringStore.TranslateText(
                txt.text,
                "第(\\d+)关\n场景：([^\\s]+)\n总波数：(\\d+)波\n特殊环境：([^\\s]+)\n难度：(\\d+)"
            );

            txt.font = fontAsset;
        }
    }
}
#endif
