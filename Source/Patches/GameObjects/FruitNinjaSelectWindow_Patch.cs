using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(FruitNinjaSelectWindow))]
public static class FruitNinjaSelectWindow_Patch
{
    [HarmonyPatch(nameof(FruitNinjaSelectWindow.SetType)), HarmonyPostfix]
    private static void SetType(FruitNinjaSelectWindow __instance)
    {
        var introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
        var introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        introduceText.text = StringStore.TranslateText(introduceText.text);
        introduceText.font = fontAsset;
    }

    [HarmonyPatch(nameof(FruitNinjaSelectWindow.OnAnimOver)), HarmonyPostfix]
    private static void OnAnimOver(FruitNinjaSelectWindow __instance)
    {
        var introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
        var introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        introduceText.text = StringStore.TranslateText(introduceText.text);
        introduceText.font = fontAsset;
    }
}
