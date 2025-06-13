using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(Zombie))]
    public static class Zombie_Patch
    {
        [HarmonyPatch(nameof(Zombie.Start))]
        [HarmonyPostfix]
        public static void Start(Zombie __instance)
        {
            StringStore.TranslateText(__instance.healthText);
            StringStore.TranslateText(__instance.healthTextShadow);
            if (__instance.healthText.transform.rotation != Quaternion.Euler(0, 0, 0))
                __instance.healthText.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        [HarmonyPatch(nameof(Zombie.Update))]
        [HarmonyPrefix]
        public static void Update(Zombie __instance)
        {
            if (__instance.theZombieType == ZombieType.TrainingDummy || !Board.Instance.showZombieHealth)
                return;
            StringStore.TranslateText(__instance.healthText);
            StringStore.TranslateText(__instance.healthTextShadow);
            if (__instance.healthText.transform.rotation != Quaternion.Euler(0f, 0f, 0f))
                __instance.healthText.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}