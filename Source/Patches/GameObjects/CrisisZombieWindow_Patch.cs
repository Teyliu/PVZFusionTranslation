using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(CrisisZombieWindow))]
public static class CrisisZombieWindow_Patch
{
    [HarmonyPatch(nameof(CrisisZombieWindow.Start)), HarmonyPostfix]
    private static void Start(CrisisZombieWindow __instance)
    {
        var introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
        var introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        introduceText.text = StringStore.TranslateText(introduceText.text);
        introduceText.font = fontAsset;
    }

    [HarmonyPatch(nameof(CrisisZombieWindow.SetZombieType)), HarmonyPostfix]
    private static void SetZombieType(CrisisZombieWindow __instance)
    {
        var introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
        var introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        introduceText.text = StringStore.TranslateText(introduceText.text);
        introduceText.font = fontAsset;
    }
}
