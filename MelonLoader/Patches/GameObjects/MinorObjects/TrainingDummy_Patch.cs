using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(TrainingDummy), nameof(TrainingDummy.UpdateHealthText))]
    public static class TrainingDummy_Patch
    {
        [HarmonyPostfix]
        public static void UpdateHealthText(TrainingDummy __instance)
        {
            StringStore.TranslateText(__instance.healthText);
            StringStore.TranslateText(__instance.healthTextShadow);
        }
    }
}