using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(ExploreMakeMenu))]
    public static class ExploreMakeMenu_Patch
    {
        [HarmonyPatch(nameof(ExploreMakeMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(ExploreMakeMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
            }
        }
    }
}