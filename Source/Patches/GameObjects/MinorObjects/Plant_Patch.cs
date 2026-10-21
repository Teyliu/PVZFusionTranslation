#if false
using System.Text.RegularExpressions;
using HarmonyLib;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects;

[HarmonyPatch(typeof(Plant))]
public static class Plant_Patch
{
    [HarmonyPostfix, HarmonyPatch(nameof(Plant.Awake))]
    private static void Awake(Plant __instance)
    {
        if (__instance.thePlantType is not (PlantType.SuperMachineNut or PlantType.MachineNut))
            return;

        __instance.healthSlider.healthText.text = __instance.healthSlider.healthTextShadow.text =
            ChangeHPText(__instance.healthSlider.healthTextShadow.text);
    }

    [HarmonyPostfix, HarmonyPatch(nameof(Plant.UpdateText))]
    private static void Update(Plant __instance)
    {
        if (__instance.thePlantType is not (PlantType.SuperMachineNut or PlantType.MachineNut))
            return;

        if (__instance.thePlantHealth < __instance.thePlantMaxHealth)
            return;

        __instance.healthSlider.healthText.text = __instance.healthSlider.healthTextShadow.text =
            ChangeHPText(__instance.healthSlider.healthTextShadow.text);
    }

    private static string ChangeHPText(string originalText)
    {
        var regex = new Regex(@"(\d+)\d\d\d/(\d)000");

        if (!regex.IsMatch(originalText))
            return originalText;

        var match = regex.Match(originalText);
        var groupCount = match.Groups.Count;

        var dynamicParts = new List<string>();

        for (var i = 1; i < groupCount; i++)
            dynamicParts.Add(match.Groups[i].Value);

        return string.Format("{0}k/{1}k", [..dynamicParts]);
    }
}
#endif
