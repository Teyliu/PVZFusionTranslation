using GameLevel.Abyss;
using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Abyss
{
    [HarmonyPatch(typeof(AbyssLotteryMenu))]
    public static class AbyssLotteryMenu_Patch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Start(AbyssLotteryMenu __instance)
        {
            TranslateMenuText(__instance);
        }

        [HarmonyPatch("Single")]
        [HarmonyPostfix]
        private static void Single(AbyssLotteryMenu __instance)
        {
            TranslateMenuText(__instance);
        }

        [HarmonyPatch("Tengle")]
        [HarmonyPostfix]
        private static void Tengle(AbyssLotteryMenu __instance)
        {
            TranslateMenuText(__instance);
        }

        [HarmonyPatch("UpdateText")]
        [HarmonyPostfix]
        private static void UpdateText(AbyssLotteryMenu __instance)
        {
            TranslateMenuText(__instance);
        }

        [HarmonyPatch("CreateButton")]
        [HarmonyPostfix]
        private static void CreateButton(AbyssLotteryMenu __instance)
        {
            TranslateMenuText(__instance);
        }

        [HarmonyPatch("UpdateButtonSelectedState")]
        [HarmonyPostfix]
        private static void UpdateButtonSelectedState(AbyssLotteryMenu __instance)
        {
            TranslateMenuText(__instance);
        }

        [HarmonyPatch("OnMixedPoolButtonClicked")]
        [HarmonyPostfix]
        private static void OnMixedPoolButtonClicked(AbyssLotteryMenu __instance)
        {
            TranslateMenuText(__instance);
        }

        [HarmonyPatch("EnterMixedPoolMode")]
        [HarmonyPostfix]
        private static void EnterMixedPoolMode(AbyssLotteryMenu __instance)
        {
            TranslateMenuText(__instance);
        }

        [HarmonyPatch("ExitMixedPoolMode")]
        [HarmonyPostfix]
        private static void ExitMixedPoolMode(AbyssLotteryMenu __instance)
        {
            TranslateMenuText(__instance);
        }

        [HarmonyPatch("UpdateMixedPoolButtonsState")]
        [HarmonyPostfix]
        private static void UpdateMixedPoolButtonsState(AbyssLotteryMenu __instance)
        {
            TranslateMenuText(__instance);
        }

        private static void TranslateMenuText(AbyssLotteryMenu menu)
        {
            if (menu == null)
            {
                return;
            }

            TMP_FontAsset font = FontStore.LoadTMPFont(Utils.Language.ToString());
            TranslateText(menu.singleText, font);
            TranslateText(menu.tengleText, font);
            TranslateText(menu.ticketText, font);
            TranslateText(menu.infoText, font);

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
