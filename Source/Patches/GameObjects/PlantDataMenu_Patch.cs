using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(PlantDataMenu))]
public static class PlantDataMenu_Patch
{
    [HarmonyPatch(nameof(PlantDataMenu.Start)), HarmonyPostfix]
    public static void Post_Start(PlantDataMenu __instance) => TranslatePlantDataMenu(__instance);
#if false
    [HarmonyPatch(nameof(PlantDataMenu.Update)), HarmonyPostfix]
    public static void Post_Update(PlantDataMenu __instance) => TranslatePlantDataMenu(__instance);
#endif
    [HarmonyPatch(nameof(PlantDataMenu.InitDataFromPlant)), HarmonyPostfix]
    public static void Post_InitDataFromPlant(PlantDataMenu __instance) => TranslatePlantDataMenu(__instance);

    public static void TranslatePlantDataMenu(PlantDataMenu __instance)
    {
        if (!__instance)
            return;

        var thePlantType = __instance.plant.thePlantType;
        var plantName = Utils.GetPlantNameFromAlmanac(thePlantType);

        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var text in __instance.nameText)
        {
            text.text = plantName;
            text.font = fontAsset;
        }

        foreach (var text in __instance.infoText)
        {
            var toTranslate = text.text;
            var startColorTag = "";

            const string ColorPattern = "(<color=[^>]+>)(.*?)(</color>)";
            var match = Regex.Match(toTranslate, ColorPattern);

            if (match.Success)
            {
                startColorTag = match.Groups[1].Value;
                toTranslate = match.Groups[2].Value;
            }

            var parts = toTranslate.Split("\n");
            var translatedParts = parts.Select(part => StringStore.TranslateText(part)).ToList();

            var joinedTranslation = string.Join("\n", translatedParts);

            if (startColorTag != "")
                text.text = startColorTag + joinedTranslation + "</color>";
            else
                text.text = joinedTranslation;

            text.font = fontAsset;
        }

        foreach (var text in __instance.toggles.transform.Find("Viewport/Content/Toggles")
           .GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText(text.text);
    }
}
