using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(AlmanacPlantWindow))]
public static class AlmanacPlantWindow_Patch
{
    [HarmonyPatch(nameof(AlmanacPlantWindow.UpdateText)), HarmonyPostfix]
    private static void UpdateText(AlmanacPlantWindow __instance)
    {
        var currentLanguage = Utils.Language.ToString();
        // var almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
        // var path = Path.Combine(almanacDir, "LawnStringsTranslate.json");
        // var moddedPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");

        var hasAlmanacFont = false;

        if (FontStore.FontAssetDictSecondary.ContainsKey((currentLanguage + "_almanac").ToLower()) ||
            FontStore.FontAssetDictSecondary.ContainsKey(currentLanguage.ToLower()))
        {
            _ = FontStore.LoadTMPFontAlmanac(currentLanguage);
            hasAlmanacFont = true;
        }

        var fontAsset = hasAlmanacFont
            ? FontStore.LoadTMPFontAlmanac(Utils.Language.ToString())
            : FontStore.LoadTMPFont(Utils.Language.ToString());

        // var plantData = JsonUtility.FromJson<Il2CppAlmanacDataClass>(AlmanacPlantMenu_Patch.AlmanacJson);

        if (!AlmanacPlantMenu_Patch.PlantInfoDict.ContainsKey((int)__instance.currentPlantType))
            return;

        var plantInfo = AlmanacPlantMenu_Patch.PlantInfoDict[(int)__instance.currentPlantType];

        foreach (var text in __instance.showedPlantName)
        {
            text.autoSizeTextContainer = false;
            text.text = $"{Utils.RemoveSizeTags(plantInfo.name)} ({plantInfo.seedType})";
            text.font = fontAsset;
            text.fontSizeMax = 21;
        }

        var toTrim = Environment.NewLine.ToCharArray();

        __instance.showedPlantIntroduce.text =
            $"""
             {Utils.RemoveSizeTags(plantInfo.info)}

             {Utils.RemoveSizeTags(plantInfo.introduce)}

             {Utils.RemoveSizeTags(plantInfo.cost).TrimStart(toTrim)}


             """;

        __instance.showedPlantIntroduce.font = fontAsset;
        __instance.showedPlantIntroduce.fontSizeMax = 21;
        __instance.showedPlantIntroduce.margin = new(6, 2, 12, 0);

        __instance.showedPlantIntroduce.enableWordWrapping = true;
        __instance.showedPlantIntroduce.overflowMode = TextOverflowModes.ScrollRect;

        Canvas.ForceUpdateCanvases();
        __instance.showedPlantIntroduce.ForceMeshUpdate();

        var textHeight = __instance.showedPlantIntroduce.preferredHeight;
        __instance.plantTextContent.sizeDelta = new(__instance.plantTextContent.sizeDelta.x, textHeight);
    }
}
