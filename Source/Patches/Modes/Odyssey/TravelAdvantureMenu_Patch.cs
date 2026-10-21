using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey;

[HarmonyPatch(typeof(TravelAdvantureMenu))]
public static class TravelAdvantureMenu_Patch
{
    [HarmonyPatch(nameof(TravelAdvantureMenu.Awake)), HarmonyPostfix]
    public static void Awake(TravelAdvantureMenu __instance)
    {
        foreach (var button in __instance.GetComponentsInChildren<CustomButton_enterGame>())
        {
            var plantName = Utils.GetPlantNameFromAlmanac(button.levelName.text);

            if (Utils.Language == Utils.LanguageEnum.Arabic)
                button.levelName.text = StringStore.TranslateText(button.levelName.text);
            else
                button.levelName.text = plantName != "" ? plantName : StringStore.TranslateText(button.levelName.text);
        }
    }

    [HarmonyPatch(nameof(TravelAdvantureMenu.LookWeak)), HarmonyPostfix]
    public static void LookWeak(TravelAdvantureMenu __instance) => Awake(__instance);

    [HarmonyPatch(nameof(TravelAdvantureMenu.LookUlti)), HarmonyPostfix]
    public static void LookUlti(TravelAdvantureMenu __instance) => Awake(__instance);
}
