using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;
using Unity.VisualScripting;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(Almanac))]
    public static class Almanac_Patch
    {
        [HarmonyPatch(nameof(Almanac.Awake))]
        [HarmonyPostfix]
        private static void Awake(Almanac __instance)
        {
            TranslateAlmanacMenu(__instance);
        }

        [HarmonyPatch(nameof(Almanac.OldAlmanac))]
        [HarmonyPostfix]
        private static void OldAlmanac(Almanac __instance)
        {
            TranslateAlmanacMenu(__instance);
        }

        [HarmonyPatch(nameof(Almanac.AnimSwitch))]
        [HarmonyPostfix]
        private static void AnimSwitch(Almanac __instance)
        {
            TranslateAlmanacMenu(__instance);
        }

        public static void TranslateAlmanacMenu(Almanac __instance)
        {
            TMP_FontAsset font = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                if(text.text == "关闭")
                {
                    text.text = StringStore.TranslateText("合上");
                }
                else
                {
                    text.text = StringStore.TranslateText(text.text);
                }
                text.font = font;
            }
        }
    }
}
