using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AdvantureStarMenu))]
    public static class AdvantureStarMenu_Patch
    {
        [HarmonyPatch(nameof(AdvantureStarMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(AdvantureStarMenu __instance)
        {
            foreach(TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        [HarmonyPatch(nameof(AdvantureStarMenu.GetNodes))]
        [HarmonyPostfix]
        private static void GetNodes(AdvantureStarMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        [HarmonyPatch(nameof(AdvantureStarMenu.UpdateStarText))]
        [HarmonyPostfix]
        private static void UpdateStarText(AdvantureStarMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        [HarmonyPatch(nameof(AdvantureStarMenu.InitTalents))]
        [HarmonyPostfix]
        private static void InitTalents(AdvantureStarMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        [HarmonyPatch(nameof(AdvantureStarMenu.ResetAward))]
        [HarmonyPostfix]
        private static void ResetAward(AdvantureStarMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }
    }
}
