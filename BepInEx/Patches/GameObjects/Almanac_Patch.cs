using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
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
                if (text.text == "关闭")
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

