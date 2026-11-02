#if false // TODO: 4.1 breaking change
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(RogueStartMenu))]
public static class RogueStartMenu_Patch
{
    [HarmonyPatch(nameof(RogueStartMenu.SetLeader)), HarmonyPostfix]
    private static void SetLeader(RogueStartMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }
    }

    [HarmonyPatch(nameof(RogueStartMenu.EnterGame)), HarmonyPostfix]
    private static void EnterGame(RogueStartMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }
    }
}
#endif
