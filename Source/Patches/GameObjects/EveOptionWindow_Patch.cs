using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(EveOptionWindow))]
public static class EveOptionWindow_Patch
{
    [HarmonyPatch(nameof(EveOptionWindow.SetType)), HarmonyPostfix]
    private static void SetType(EveOptionWindow __instance) => TranslateEveOptionWindow(__instance);

    [HarmonyPatch(nameof(EveOptionWindow.OnAnimOver)), HarmonyPostfix]
    private static void OnAnimOver(EveOptionWindow __instance) => TranslateEveOptionWindow(__instance);

    [HarmonyPatch(nameof(EveOptionWindow.SelectedByRow)), HarmonyPostfix]
    private static void SelectedByRow(EveOptionWindow __instance) => TranslateEveOptionWindow(__instance);

    public static void TranslateEveOptionWindow(EveOptionWindow __instance)
    {
        var introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
        var introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        introduceText.text = StringStore.TranslateText(introduceText.text);
        introduceText.font = fontAsset;

        foreach (var text in __instance.buttonText)
        {
            text.text = StringStore.TranslateText(text.text);
            text.font = fontAsset;
        }
    }
}
