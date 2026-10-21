using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(PlayerShootingWindow))]
public static class PlayerShootingWindow_Patch
{
    [HarmonyPatch(nameof(PlayerShootingWindow.SetType)), HarmonyPostfix]
    private static void SetType(PlayerShootingWindow __instance)
    {
        var introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
        var introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        introduceText.text = StringStore.TranslateText(introduceText.text);
        introduceText.font = fontAsset;
    }

    [HarmonyPatch(nameof(PlayerShootingWindow.OnAnimOver)), HarmonyPostfix]
    private static void OnAnimOver(PlayerShootingWindow __instance)
    {
        var introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
        var introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        introduceText.text = StringStore.TranslateText(introduceText.text);
        introduceText.font = fontAsset;
    }
}
