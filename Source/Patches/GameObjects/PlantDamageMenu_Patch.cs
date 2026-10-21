using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(PlantDamageMenu))]
public static class PlantDamageMenu_Patch
{
    public static void Awake(BaseMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            var originalKey = StringStore.TranslationString.FirstOrDefault(x => x.Value == text.text).Key;

            text.text = StringStore.TranslationString.ContainsKey(originalKey + "_RM")
                ? StringStore.TranslateText(originalKey + "_RM")
                : StringStore.TranslateText(text.text);

            text.font = fontAsset;
        }
    }

    [HarmonyPatch(nameof(PlantDamageMenu.Awake)), HarmonyPatch(nameof(PlantDamageMenu.InitCards)), HarmonyPostfix]
    public static void InitCards(PlantDamageMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            var originalKey = StringStore.TranslationString.FirstOrDefault(x => x.Value == text.text).Key;

            text.text = StringStore.TranslationString.ContainsKey(originalKey + "_RM")
                ? StringStore.TranslateText(originalKey + "_RM")
                : StringStore.TranslateText(text.text);

            text.font = fontAsset;
        }
    }
}
