using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using Unity.VisualScripting;
using UnityEngine;
using static MelonLoader.MelonLogger;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AbyssMenu))]
    public static class AbyssMenu_Patch
    {

        [HarmonyPatch(nameof(AbyssMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(AbyssMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.levelInfo)
            {
                txt.text = StringStore.TranslateText(txt.text, false);
                txt.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(AbyssMenu.UpdateLevelInfo))]
        [HarmonyPostfix]
        private static void UpdateLevelInfo(AbyssMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.levelInfo)
            {

            }
        }
    }
}
