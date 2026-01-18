using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AdvantureMenu))]
    public static class AdvantureMenu_Patch
    {
        [HarmonyPatch(nameof(AdvantureMenu.Start))]
        [HarmonyPostfix]
        private static void Start(AdvantureMenu __instance)
        {
            foreach (TextMeshProUGUI titleText in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                titleText.text = StringStore.TranslateText(titleText.text);
            }
            __instance.difficulty.text = StringStore.TranslateText(__instance.difficulty.text);
            __instance.chapterDifficulty.text = StringStore.TranslateText(__instance.chapterDifficulty.text, pattern: "章节难度：([^\\s]+)");
            __instance.starCount.text = StringStore.TranslateText(__instance.starCount.text);
        }

        [HarmonyPatch(nameof(AdvantureMenu.ChangeDifficulty))]
        [HarmonyPostfix]
        private static void ChangeDifficulty(AdvantureMenu __instance)
        {
            __instance.difficulty.text = StringStore.TranslateText(__instance.difficulty.text);
        }

        [HarmonyPatch(nameof(AdvantureMenu.GetChapterDifficulty))]
        [HarmonyPostfix]
        private static void GetChapterDifficulty(AdvantureMenu __instance)
        {
            __instance.chapterDifficulty.text = StringStore.TranslateText(__instance.chapterDifficulty.text, pattern: "章节难度：([^\\s]+)");
        }

        [HarmonyPatch(nameof(AdvantureMenu.UpdateChapterDifficulty))]
        [HarmonyPostfix]
        private static void UpdateChapterDifficulty(AdvantureMenu __instance)
        {
            __instance.chapterDifficulty.text = StringStore.TranslateText(__instance.chapterDifficulty.text, pattern: "章节难度：([^\\s]+)");
        }

        [HarmonyPatch(nameof(AdvantureMenu.UpdateStarCount))]
        [HarmonyPostfix]
        private static void UpdateStarCount(AdvantureMenu __instance)
        {
            __instance.starCount.text = StringStore.TranslateText(__instance.starCount.text);
        }
    }
}
