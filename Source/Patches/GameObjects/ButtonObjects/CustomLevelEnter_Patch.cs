using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;

[HarmonyPatch(typeof(CustomLevelEnter))]
public static class CustomLevelEnter_Patch
{
    [HarmonyPatch(nameof(CustomLevelEnter.Start)), HarmonyPostfix]
    private static void Start(CustomLevelEnter __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            var originalKey = StringStore.TranslationString.FirstOrDefault(x => x.Value == txt.text).Key;

            txt.text = StringStore.TranslationString.ContainsKey(originalKey + "_IZ")
                ? StringStore.TranslateText(originalKey + "_IZ")
                : StringStore.TranslateText(txt.text);

            txt.font = fontAsset;
        }
    }
}
