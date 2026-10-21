using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(PlantInfoWindow))]
public static class PlantInfoWindow_Patch
{
    [HarmonyPatch(nameof(PlantInfoWindow.InitText)), HarmonyPostfix]
    private static void InitText(PlantInfoWindow __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        var thePlant = __instance.plant;

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            if (txt.name.Contains("Introduce") && thePlant != null)
            {
                var thePlantType = thePlant.thePlantType;
                txt.text = StringStore.TranslateText(txt.text);

                var text = txt.text;
                var lines = text.Split("\n");

                lines[0] = Utils.GetPlantNameFromAlmanac(thePlantType);
                var updatedText = string.Join("\n", lines);

                txt.text = updatedText;
            }
            else
                txt.text = StringStore.TranslateText(txt.text);

            txt.font = fontAsset;
        }

        var parentWindowTransform = __instance.transform.parent;
        var returnPlantTransform = parentWindowTransform.FindChild("Close");

        foreach (var txt in returnPlantTransform.GetComponentsInChildren<TextMeshProUGUI>())
            txt.text = StringStore.TranslateText("合上");
    }
}
