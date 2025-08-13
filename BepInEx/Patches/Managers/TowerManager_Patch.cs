using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;
using BepInEx.Unity.IL2CPP;
using System.Collections.Generic;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(TowerManager))]
    public static class TowerManager_Patch
    {
        public static List<Transform> updatedText = [];

        public static void UpdateText()
        {
            foreach (Transform transform in updatedText)
            {
                if (transform != null)
                {
                    transform.GetComponent<TextMeshProUGUI>().text = StringStore.TranslateText(transform.GetComponent<TextMeshProUGUI>().text);
                }
            }
        }

        [HarmonyPatch(nameof(TowerManager.Update))]
        [HarmonyPostfix]
        public static void Update(TowerManager __instance)
        {

        }
    }
}