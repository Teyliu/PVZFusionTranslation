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
            foreach(TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
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

        [HarmonyPatch(nameof(InGameUI.Update))]
        [HarmonyPostfix]
        private static void Update(InGameUI __instance)
        {
            foreach (TextMeshProUGUI txt in __instance.ShovelBank.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }
    }

    [HarmonyPatch(typeof(InGameUI_IZ))]
    public static class InGameUI_IZ_Patch
    {
        [HarmonyPatch(nameof(InGameUI_IZ.Update))]
        [HarmonyPostfix]
        private static void Update(InGameUI_IZ __instance)
        {
            foreach (TextMeshProUGUI txt in __instance.shovel.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }
    }
}
