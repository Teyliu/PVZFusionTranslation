using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(CrisisZombieWindow))]
    public static class CrisisZombieWindow_Patch
    {
        [HarmonyPatch(nameof(CrisisZombieWindow.Start))]
        [HarmonyPostfix]
        private static void Start(CrisisZombieWindow __instance)
        {
            Transform introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
            TextMeshProUGUI introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            introduceText.text = StringStore.TranslateText(introduceText.text);
            introduceText.font = fontAsset;
        }

        [HarmonyPatch(nameof(CrisisZombieWindow.SetZombieType))]
        [HarmonyPostfix]
        private static void SetZombieType(CrisisZombieWindow __instance)
        {
            Transform introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
            TextMeshProUGUI introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            introduceText.text = StringStore.TranslateText(introduceText.text);
            introduceText.font = fontAsset;
        }
    }
}
