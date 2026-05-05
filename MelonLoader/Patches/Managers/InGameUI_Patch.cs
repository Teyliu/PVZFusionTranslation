using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.BaseTextObjects;
using System.Text.RegularExpressions;
using Unity.Collections;

namespace PvZ_Fusion_Translator.Patches.Managers
{
    [HarmonyPatch(typeof(InGameUI))]
    public static class InGameUI_Patch
    {
        public static string travelAdventurePattern = "^旅行冒险 ([^\\s:]+)";
        public static string travelAdventureFallback = "Odyssey Adventure: {0}";

        [HarmonyPatch(nameof(InGameUI.Start))]
        [HarmonyPostfix]
        private static void Start(InGameUI __instance)
        {
            SetLevelName(__instance);
        }

        [HarmonyPatch(nameof(InGameUI.SetUniqueText))]
        [HarmonyPostfix]
        private static void SetUniqueText(InGameUI __instance)
        {
            SetLevelName(__instance);
        }

        [HarmonyPatch(nameof(InGameUI.SetLevelName))]
        [HarmonyPostfix]
        private static void SetLevelName(InGameUI __instance)
        {
            foreach (TextMeshProUGUI text in __instance.levelNameText)
            {
                if (text.text == null) continue;

                string originalText = text.text;
                text.text = text.text.Replace("\n", " ");
                
                Regex checkFusionChallenge = new Regex("^超级([^\\s：]+)(：?挑战1?)");
                Regex checkTravelAdv = new Regex(travelAdventurePattern);

                if(checkTravelAdv.IsMatch(originalText))
                {
                    text.text = InGameText_Patch.TranslatePlantNameParts(originalText, travelAdventurePattern, travelAdventureFallback);
                }
                else if (text.text.Contains("配方：") && !checkFusionChallenge.IsMatch(text.text))
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

        /*[HarmonyPatch(nameof(InGameUI.Update))]
        [HarmonyPostfix]
        private static void Update(InGameUI __instance)
        {
            if (!__instance.board.boardTag.isDrawCards) return;

            KeyValuePair<string, string> regexPair = new KeyValuePair<string, string>("抽取次数：\n(\\d+)/(\\d+)\n当前up植物：\n([^\\s]+)\nup刷新倒计时：\n(\\d+)", "Draw Count:\n{0}/{1}\nCurrent Up:\n{2}\nNext Up in: \n{3}s");

            foreach(TextMeshProUGUI txt in __instance.DrawCardsHead.GetComponentsInChildren<TextMeshProUGUI>())
            {
                if(Regex.IsMatch(txt.text, regexPair.Key))
                {
                    txt.text = InGameText_Patch.TranslatePlantNameParts(txt.text, regexPair.Key, regexPair.Value);
                }
            }
        }*/
    }
}
