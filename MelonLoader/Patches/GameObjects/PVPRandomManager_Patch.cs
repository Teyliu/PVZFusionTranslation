using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using static MelonLoader.MelonLogger;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(PVPRandomManager))]
    public static class PVPRandomManager_Patch
    {
        [HarmonyPatch(nameof(PVPRandomManager.Start))]
        [HarmonyPostfix]
        private static void Start(PVPRandomManager __instance)
        {
            foreach(TextMeshPro text in __instance.texts)
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        [HarmonyPatch(nameof(PVPRandomManager.Update))]
        [HarmonyPostfix]
        private static void ZombieEnterHouse(PVPRandomManager __instance)
        {
            foreach(TextMeshPro text in __instance.texts)
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }
    }
}
