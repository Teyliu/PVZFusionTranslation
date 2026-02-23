using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(SeedLibrary))]
    public static class SeedLibrary_Patch
    {
        [HarmonyPatch(nameof(SeedLibrary.ChangeSafeMode))]
        [HarmonyPostfix]
        private static void ChangeSafeMode(SeedLibrary __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            //foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            //{
            //    txt.text = StringStore.TranslateText(txt.text);
            //    txt.font = fontAsset;
            //}

            Transform safetyBoxButtonTransform = __instance.transform.Find("SafeBox").Find("StartSafeMode");

            if (__instance.safeMode == false && safetyBoxButtonTransform != null)
            {
                foreach (TextMeshProUGUI txt in safetyBoxButtonTransform.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    txt.text = StringStore.TranslateText("合上");
                }
            }
        }
    }
}

