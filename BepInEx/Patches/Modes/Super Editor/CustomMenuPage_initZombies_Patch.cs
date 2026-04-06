using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Super_Editor
{
    [HarmonyPatch(typeof(CustomMenuPage_initZombies))]
    public static class CustomMenuPage_initZombies_Patch
    {
        [HarmonyPatch(nameof(CustomMenuPage_initZombies.SubWave))]
        [HarmonyPostfix]
        public static void SubWave(CustomMenuPage_initZombies __instance)
        {
            __instance.currentWaveText.text = StringStore.TranslateText(__instance.currentWaveText.text);
        }

        [HarmonyPatch(nameof(CustomMenuPage_initZombies.AddWave))]
        [HarmonyPostfix]
        public static void AddWave(CustomMenuPage_initZombies __instance)
        {
            __instance.currentWaveText.text = StringStore.TranslateText(__instance.currentWaveText.text);
        }
    }
}
