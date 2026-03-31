using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using Unity.Collections;

namespace PvZ_Fusion_Translator.Patches.Managers
{
    [HarmonyPatch(typeof(InGameUI))]
    public static class InGameUI_Patch
    {
        [HarmonyPatch(nameof(InGameUI.Start))]
        [HarmonyPostfix]
        private static void Start(InGameUI __instance)
        {
            foreach(TextMeshProUGUI text in __instance.T)
            {
                if (text.text == null) continue;
                
                string originalText = text.text;
                text.text = text.text.Replace("\n", " ");
                Regex checkFusionChallenge = new Regex("^超级([^\\s：]+)(：?挑战1?)");

                if (text.text.Contains("配方：") && !checkFusionChallenge.IsMatch(text.text))
                {
                    string[] lines = text.text.Split("：");
                    lines[1] = Utils.GetPlantNameFromAlmanac(lines[1]);
                    if (lines[1] == "")
                    {
                        Log.LogError("Couldn't find plant! (Fusion Showcase)");
                        lines[1] = StringStore.TranslateText(lines[1]);
                    }
                    text.text = StringStore.TranslateText("配方：") + lines[1];
                    text.autoSizeTextContainer = true;
                }
                else
                {
                    text.text = (StringStore.translationString.ContainsKey(text.text + "_MG")) ? StringStore.TranslateText(text.text + "_MG") : StringStore.TranslateText(text.text);
                    text.text = text.text.Replace("\n", " ");
                }
            }
        }

        [HarmonyPatch(nameof(InGameUI.SetUniqueText))]
        [HarmonyPostfix]
        private static void SetUniqueText(InGameUI __instance)
        {
            foreach(TextMeshProUGUI text in __instance.T)
            {
                if (text.text == null) continue;
                
                string originalText = text.text;
                text.text = text.text.Replace("\n", " ");
                Regex checkFusionChallenge = new Regex("^超级([^\\s：]+)(：?挑战1?)");

                if (text.text.Contains("配方：") && !checkFusionChallenge.IsMatch(text.text))
                {
                    string[] lines = text.text.Split("：");
                    lines[1] = Utils.GetPlantNameFromAlmanac(lines[1]);
                    if (lines[1] == "")
                    {
                        Log.LogError("Couldn't find plant! (Fusion Showcase)");
                        lines[1] = StringStore.TranslateText(lines[1]);
                    }
                    text.text = StringStore.TranslateText("配方：") + lines[1];
                    text.autoSizeTextContainer = true;
                }
                else
                {
                    text.text = (StringStore.translationString.ContainsKey(text.text + "_MG")) ? StringStore.TranslateText(text.text + "_MG") : StringStore.TranslateText(text.text);
                    text.text = text.text.Replace("\n", " ");
                }
            }
        }

        [HarmonyPatch(nameof(InGameUI.SetLevelName))]
        [HarmonyPostfix]
        private static void SetLevelName(InGameUI __instance)
        {
            foreach(TextMeshProUGUI text in __instance.T)
            {
                if (text.text == null) continue;
                
                string originalText = text.text;
                text.text = text.text.Replace("\n", " ");
                Regex checkFusionChallenge = new Regex("^超级([^\\s：]+)(：?挑战1?)");

                if (text.text.Contains("配方：") && !checkFusionChallenge.IsMatch(text.text))
                {
                    string[] lines = text.text.Split("：");
                    lines[1] = Utils.GetPlantNameFromAlmanac(lines[1]);
                    if (lines[1] == "")
                    {
                        Log.LogError("Couldn't find plant! (Fusion Showcase)");
                        lines[1] = StringStore.TranslateText(lines[1]);
                    }
                    text.text = StringStore.TranslateText("配方：") + lines[1];
                    text.autoSizeTextContainer = true;
                }
                else
                {
                    text.text = (StringStore.translationString.ContainsKey(text.text + "_MG")) ? StringStore.TranslateText(text.text + "_MG") : StringStore.TranslateText(text.text);
                    text.text = text.text.Replace("\n", " ");
                }
            }
        }
    }
}
