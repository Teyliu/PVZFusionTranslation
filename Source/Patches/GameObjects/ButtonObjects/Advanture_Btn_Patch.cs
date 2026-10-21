using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;

[HarmonyPatch(typeof(Advanture_Btn))]
public static class Advanture_Btn_Patch
{
    [HarmonyPatch(nameof(Advanture_Btn.Start)), HarmonyPostfix]
    private static void Start(Advanture_Btn __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            var originalKey = StringStore.TranslationString.FirstOrDefault(x => x.Value == txt.text).Key;

            txt.text = StringStore.TranslationString.ContainsKey(originalKey + "_MG")
                ? StringStore.TranslateText(originalKey + "_MG")
                : StringStore.TranslateText(txt.text);

            txt.font = fontAsset;
        }
    }
}
