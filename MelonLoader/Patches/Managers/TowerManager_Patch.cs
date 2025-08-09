using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Managers
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
