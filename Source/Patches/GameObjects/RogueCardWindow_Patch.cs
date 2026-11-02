#if false // TODO: 4.1 breaking change
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(RogueCardWindow))]
public static class RogueCardWindow_Patch
{
    [HarmonyPatch(nameof(RogueCardWindow.InitCard)), HarmonyPostfix]
    private static void InitCard(RogueCardWindow __instance)
    {
        var introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
        var introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        introduceText.text = StringStore.TranslateText(introduceText.text);
        introduceText.font = fontAsset;
    }

    [HarmonyPatch(nameof(RogueCardWindow.OnAnimOver)), HarmonyPostfix]
    private static void OnAnimOver(RogueCardWindow __instance)
    {
        var introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
        var introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        introduceText.text = StringStore.TranslateText(introduceText.text);
        introduceText.font = fontAsset;
    }
}
#endif
