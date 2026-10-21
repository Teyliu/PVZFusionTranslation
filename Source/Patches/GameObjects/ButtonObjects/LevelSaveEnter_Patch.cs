using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;

public static class LevelSaveEnter_Patch
{
    public static void TranslateEnter(LevelSaveEnter __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        __instance.text.text = StringStore.TranslateText(__instance.text.text);
        __instance.text.font = fontAsset;
    }
}
