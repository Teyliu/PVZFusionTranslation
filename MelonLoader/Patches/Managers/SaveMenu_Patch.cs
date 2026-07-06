using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Managers
{
    [HarmonyPatch(typeof(SaveMenu))]
    public static class SaveMenu_Patch
    {
        [HarmonyPatch(nameof(SaveMenu.Start))]
        [HarmonyPatch(nameof(SaveMenu.CreateLevelEnter))]
        [HarmonyPatch(nameof(SaveMenu.InitLevelSaveEnters))]
        [HarmonyPostfix]
        private static void Start(SaveMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            __instance.menuTitle.text = StringStore.TranslateText(__instance.menuTitle.text);
            __instance.menuTitle.font = fontAsset;

            foreach(LevelSaveEnter enter in __instance.GetComponentsInChildren<LevelSaveEnter>())
            {
                LevelSaveEnter_Patch.TranslateEnter(enter);
            }
        }

        [HarmonyPatch(nameof(SaveMenu.OnEditSelectedButtonClicked))]
        [HarmonyPostfix]
        private static void OnEditSelectedButtonClicked(SaveMenu __instance)
        {
            
        }
    }
}
