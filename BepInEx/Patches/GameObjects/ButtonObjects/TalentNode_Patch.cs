using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(TalentNode))]
    public static class TalentNode_Patch
    {
        [HarmonyPatch(nameof(TalentNode.Init))]
        [HarmonyPostfix]
        private static void Post_Init(TalentNode __instance)
        {
            if (__instance != null && __instance.nametextMesh != null)
            {
                StringStore.TranslateTextUI(__instance.nametextMesh);
            }
        }
    }
}
