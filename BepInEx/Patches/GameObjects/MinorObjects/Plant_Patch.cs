#if FIX
using HarmonyLib;

using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(Plant))]
    public static class Plant_Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch(nameof(Plant.Awake))]
        private static void Awake(Plant __instance)
        {
            if (!(__instance.thePlantType == PlantType.SuperMachineNut || __instance.thePlantType == PlantType.MachineNut))
                return;
            __instance.healthSlider.healthText.text = __instance.healthSlider.healthTextShadow.text = ChangeHPText(__instance.healthSlider.healthTextShadow.text);
        }

        [HarmonyPostfix]
        [HarmonyPatch(nameof(Plant.UpdateText))]
        private static void Update(Plant __instance)
        {
            if (!(__instance.thePlantType == PlantType.SuperMachineNut || __instance.thePlantType == PlantType.MachineNut))
                return;
            if (__instance.thePlantHealth < __instance.thePlantMaxHealth)
                return;
            __instance.healthSlider.healthText.text = __instance.healthSlider.healthTextShadow.text = ChangeHPText(__instance.healthSlider.healthTextShadow.text);
        }

        static string ChangeHPText(string originalText)
        {
            var regex = new Regex(@"(\d+)\d\d\d/(\d)000");
            if (regex.IsMatch(originalText))
            {
                var match = regex.Match(originalText);
                int groupCount = match.Groups.Count;

                List<string> dynamicParts = new List<string>();

                for (int i = 1; i < groupCount; i++)
                    dynamicParts.Add(match.Groups[i].Value);
                return originalText = string.Format("{0}k/{1}k", [.. dynamicParts]);
            }
            return originalText;
        }
    }
}
#endif