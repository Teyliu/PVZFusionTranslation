using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;

[HarmonyPatch(typeof(GodShootingLevelButton))]
public static class GodShootingLevelButton_Patch
{
    [HarmonyPatch(nameof(GodShootingLevelButton.Awake)), HarmonyPostfix]
    private static void Awake(GodShootingLevelButton __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            var originalKey = StringStore.TranslationString.FirstOrDefault(x => x.Value == txt.text).Key;

            txt.text = StringStore.TranslationString.ContainsKey(originalKey + "_GS")
                ? StringStore.TranslateText(originalKey + "_GS")
                : StringStore.TranslateText(txt.text);

            txt.font = fontAsset;
        }
    }
}
