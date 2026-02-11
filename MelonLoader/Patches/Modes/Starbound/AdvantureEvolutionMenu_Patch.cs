using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Starbound
{
    [HarmonyPatch(typeof(AdvantureEvolutionMenu))]
    public static class AdvantureEvolutionMenu_Patch
    {
        [HarmonyPatch(nameof(AdvantureMenu.Awake))]
        [HarmonyPostfix]
        public static void Awake(AdvantureEvolutionMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateColorText(text.text);
            }

            Transform baseWindow = __instance.transform.Find("BaseWindow");
            Transform advancedWindow = __instance.transform.Find("AdvancedWindow");

            if(baseWindow != null)
            {
                foreach(TextMeshProUGUI text in baseWindow.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    if(text.gameObject.name.Contains("Name"))
                    {
                        text.text = Utils.GetPlantNameFromAlmanac(__instance.thePlantType);
                    }
                }
            }

            if (advancedWindow != null)
            {
                foreach (TextMeshProUGUI text in advancedWindow.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    if (text.gameObject.name.Contains("Name"))
                    {
                        text.text = Utils.GetPlantNameFromAlmanac(__instance.thePlantType);
                    }
                }
            }
        }

        [HarmonyPatch(nameof(AdvantureEvolutionMenu.UpdateText))]
        [HarmonyPostfix]
        public static void UpdateText(AdvantureEvolutionMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                FileLoader.DumpUntranslatedStrings(text.text);
                text.text = StringStore.TranslateColorText(text.text);
            }
        }

        [HarmonyPatch(nameof(AdvantureEvolutionMenu.RollEvolution))]
        [HarmonyPostfix]
        public static void RollEvolution(AdvantureEvolutionMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                FileLoader.DumpUntranslatedStrings(text.text);
                text.text = StringStore.TranslateColorText(text.text);
            }
        }

        [HarmonyPatch(nameof(AdvantureEvolutionMenu.RollEvolutionGood))]
        [HarmonyPostfix]
        public static void RollEvolutionGood(AdvantureEvolutionMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                FileLoader.DumpUntranslatedStrings(text.text);
                text.text = StringStore.TranslateColorText(text.text);
            }
        }
    }
}
