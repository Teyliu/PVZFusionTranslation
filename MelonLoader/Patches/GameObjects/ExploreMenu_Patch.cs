using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(ExploreMenu))]
    public static class ExploreMenu_Patch
    {
        [HarmonyPatch(nameof(ExploreMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(ExploreMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                if(txt.name.Contains("Text (TMP)"))
                {
                    txt.autoSizeTextContainer = true;
                    if(txt.name == "Text (TMP)")
                    {
                        txt.transform.localPosition = new Vector3(94.4225f, -45.1565f, 0f);
                    }
                }
            }
        }

        [HarmonyPatch(nameof(ExploreMenu.UpdateWindows))]
        [HarmonyPostfix]
        private static void UpdateWindows(ExploreMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
            }
        }
    }
}