using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.BaseTextObjects;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.TextCore.Text;
using static MelonLoader.MelonLogger;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(DrawCardManager))]
    public static class DrawCardManager_Patch
    {
        public static TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        [HarmonyPatch(nameof(DrawCardManager.Awake))]
        [HarmonyPostfix]
        private static void Awake(DrawCardManager __instance)
        {
            fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
        }

        [HarmonyPatch(nameof(DrawCardManager.UpdateText))]
        [HarmonyPostfix]
        private static void Postfix_UpdateText(DrawCardManager __instance)
        {
            KeyValuePair<string, string> regexPair = new KeyValuePair<string, string>("抽取次数：\n(\\d+)/(\\d+)\n当前up植物：\n([^\\s]+)\nup刷新倒计时：\n(\\d+)", "Draw Count:\n{0}/{1}\nCurrent Up:\n{2}\nNext Up in: \n{3}s");

            foreach(TextMeshProUGUI txt in __instance.texts)
            {
                if(Regex.IsMatch(txt.text, regexPair.Key))
                {
                    txt.text = TranslateGashaponText(txt.text, regexPair.Key, regexPair.Value, __instance.up);
                    txt.font = fontAsset;
                }
            }
        }

        public static string TranslateGashaponText(string originalText, string pattern, string fallback, PlantType up)
        {
            string res = "";
            string fStr = "";
            Match match = Regex.Match(originalText, pattern);
            if(match.Success)
            {
                GroupCollection groups = match.Groups;
                fStr = StringStore.translationStringRegex.ContainsKey(pattern) ? StringStore.translationStringRegex[pattern] : fallback;
                List<string> dynamicParts = [];
                for(int i = 1; i < groups.Count; i++)
                {
                    string group = groups[i].Value;
                    string translatedGroup = "";
                    if(i == 3 && up != PlantType.Peashooter)
                    {
                        translatedGroup = Utils.GetPlantNameFromAlmanac(up);
                    }
                    else
                    {
                        translatedGroup = StringStore.TranslateText(group);
                    }
                    dynamicParts.Add(translatedGroup);
                }
                res = string.Format(fStr, [.. dynamicParts]);
            }
            return res;
        }

        /*[HarmonyPatch(nameof(DrawCardManager.Update))]
        [HarmonyPostfix]
        private static void Postfix_Update(DrawCardManager __instance)
        {
            Postfix_UpdateText(__instance);
        }*/
    }
}

