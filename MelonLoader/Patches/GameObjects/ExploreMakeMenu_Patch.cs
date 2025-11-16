using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
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
                txt.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(ExploreMakeMenu.InitMenu))]
        [HarmonyPostfix]
        private static void InitMenu(ExploreMakeMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                if(txt.text.Contains("关卡制作中："))
                {
                    string plantName = Utils.GetPlantNameFromAlmanac(txt.text.Split("：")[1]);
                    txt.text = String.Format(StringStore.translationStringRegex["关卡制作中：([^\\s]+)"], plantName);
                }
                else
                {
                    txt.text = StringStore.TranslateText(txt.text);
                }
            }
        }

        [HarmonyPatch(nameof(ExploreMakeMenu.ViewScene))]
        [HarmonyPostfix]
        private static void ViewScene(ExploreMakeMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(ExploreMakeMenu.InitZombieButtons))]
        [HarmonyPostfix]
        private static void InitZombieButtons(ExploreMakeMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }
    }
}