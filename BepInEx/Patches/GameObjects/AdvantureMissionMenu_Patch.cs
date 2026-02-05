using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AdvantureMissionMenu))]
    public static class AdvantureMissionMenu_Patch
    {
        [HarmonyPatch(nameof(AdvantureMissionMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(AdvantureMissionMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.contant.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateColorText(text.text);
            }

            //foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            //{
            //    text.text = StringStore.TranslateText(text.text);
            //}
        }

        [HarmonyPatch(nameof(AdvantureMissionMenu.InitText))]
        [HarmonyPostfix]
        private static void InitText(AdvantureMissionMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.contant.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateColorText(text.text);
            }

            //foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            //{
            //    text.text = StringStore.TranslateText(text.text);
            //}
        }

        [HarmonyPatch(nameof(AdvantureMissionMenu.SwitchAward))]
        [HarmonyPostfix]
        private static void SwitchAward(AdvantureMissionMenu __instance)
        {
            foreach(TextMeshProUGUI text in __instance.contant.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateColorText(text.text);
            }

            //foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            //{
            //    text.text = StringStore.TranslateText(text.text);
            //}
        }
    }
}
