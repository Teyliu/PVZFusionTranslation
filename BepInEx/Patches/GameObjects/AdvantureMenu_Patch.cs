using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AdvantureMenu))]
    public static class AdvantureMenu_Patch
    {
        [HarmonyPatch(nameof(AdvantureMenu.Start))]
        [HarmonyPostfix]
        private static void Start(AdvantureMenu __instance)
        {
            TranslateAdvantureMenu(__instance);
        }

        [HarmonyPatch(nameof(AdvantureMenu.ChangeDifficulty))]
        [HarmonyPostfix]
        private static void ChangeDifficulty(AdvantureMenu __instance)
        {
            TranslateAdvantureMenu(__instance);
        }

        [HarmonyPatch(nameof(AdvantureMenu.GetChapterDifficulty))]
        [HarmonyPostfix]
        private static void GetChapterDifficulty(AdvantureMenu __instance)
        {
            TranslateAdvantureMenu(__instance);
        }

        [HarmonyPatch(nameof(AdvantureMenu.UpdateChapterDifficulty))]
        [HarmonyPostfix]
        private static void UpdateChapterDifficulty(AdvantureMenu __instance)
        {
            TranslateAdvantureMenu(__instance);
        }

        [HarmonyPatch(nameof(AdvantureMenu.UpdateStarCount))]
        [HarmonyPostfix]
        private static void UpdateStarCount(AdvantureMenu __instance)
        {
            TranslateAdvantureMenu(__instance);
        }

        public static void TranslateAdvantureMenu(AdvantureMenu __instance)
        {
            bool hasSBString = StringStore.translationString.ContainsKey(__instance.difficulty.text + "_SB");
            __instance.difficulty.text = Utils.RemoveSizeTags(hasSBString ? StringStore.TranslateText(__instance.difficulty.text + "_SB") : StringStore.TranslateText(__instance.difficulty.text));
            __instance.chapterDifficulty.text = StringStore.TranslateText(__instance.chapterDifficulty.text);
            __instance.starCount.text = StringStore.TranslateText(__instance.starCount.text);

            foreach (TextMeshProUGUI text in __instance.title)
            {
                text.text = StringStore.TranslateText(text.text);
            }

            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }
    }
}
