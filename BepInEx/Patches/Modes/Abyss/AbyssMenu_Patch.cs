using GameLevel.Abyss;
using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Abyss
{
    [HarmonyPatch(typeof(AbyssMenu))]
    public static class AbyssMenu_Patch
    {
        [HarmonyPatch("Awake")]
        [HarmonyPostfix]
        private static void Awake(AbyssMenu __instance)
        {
            TranslateAllText(__instance);
        }

        [HarmonyPatch("InitEntrance")]
        [HarmonyPostfix]
        private static void InitEntrance(AbyssMenu __instance)
        {
            TranslateAllText(__instance);
        }

        private static void TranslateAllText(AbyssMenu menu)
        {
            if (menu == null)
            {
                return;
            }

            TMP_FontAsset font = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (TextMeshProUGUI text in menu.GetComponentsInChildren<TextMeshProUGUI>())
            {
                TranslateText(text, font);
            }
        }

        private static void TranslateText(TextMeshProUGUI text, TMP_FontAsset font)
        {
            if (text == null)
            {
                return;
            }

            if (!string.IsNullOrEmpty(text.text))
            {
                text.text = StringStore.TranslateText(text.text);
            }

            text.font = font;
        }
    }
}
