using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Managers;

[HarmonyPatch(typeof(CanvasUpUI))]
public static class CanvasUpUI_Patch
{
    [HarmonyPatch(nameof(CanvasUpUI.Start)), HarmonyPostfix]
    public static void Start(CanvasUpUI __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            var originalKey = StringStore.TranslationString
               .FirstOrDefault(x => x.Value == text.text || x.Value.Replace("\n", "") == text.text)
               .Key;

            text.text = StringStore.TranslationString.ContainsKey(originalKey + "_MG")
                ? StringStore.TranslateText(originalKey + "_MG")
                : StringStore.TranslateText(text.text);

            if (text.gameObject.name.Contains("LevelName"))
                text.text = text.text.Replace("\n", " ");

            text.font = fontAsset;
        }
    }
}
