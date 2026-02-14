using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(OppositeBuffManager))]
    public static class OppositeBuffManager_Patch
    {
        public static Dictionary<BuffType, string> buffLinks = TravelMgr_Patch.buffLinks;
        public static Dictionary<string, SortedDictionary<int, string>> translatedTravelBuffs = TravelMgr_Patch.translatedTravelBuffs;
        public static string badPattern = @"^但(.*)";
        public static string badFormat = StringStore.translationStringRegex != null && StringStore.translationStringRegex.ContainsKey(badPattern) ? StringStore.translationStringRegex[badPattern] : "But, {0}";
        public static TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        [HarmonyPatch(nameof(OppositeBuffManager.Awake))]
        [HarmonyPostfix]
        private static void Awake(OppositeBuffManager __instance)
        {
            if (__instance.textA_bad != null && __instance.textA_bad.Count > 0)
            {
                string originalText = __instance.textA_bad[0].text;
                TranslateOppositeText(__instance.textA_bad, originalText, BuffType.Debuff, __instance.buffA.theDebuffID, true);
            }
            if (__instance.textA_good != null && __instance.textA_good.Count > 0)
            {
                string originalText = __instance.textA_good[0].text;
                TranslateOppositeText(__instance.textA_good, originalText, __instance.buffA.theOptionType, __instance.buffA.theOptionID, false);
            }
            if (__instance.textB_bad != null && __instance.textB_bad.Count > 0)
            {
                string originalText = __instance.textB_bad[0].text;
                TranslateOppositeText(__instance.textB_bad, originalText, BuffType.Debuff, __instance.buffB.theDebuffID, true);
            }
            if (__instance.textB_good != null && __instance.textB_good.Count > 0)
            {
                string originalText = __instance.textB_good[0].text;
                TranslateOppositeText(__instance.textB_good, originalText, __instance.buffB.theOptionType, __instance.buffB.theOptionID, false);
            }
        }

        public static void TranslateOppositeText(Il2CppSystem.Collections.Generic.List<TextMeshProUGUI> textList, string originalText, BuffType buffType, int buffIndex, bool isBad = false)
        {
            if (textList == null || textList.Count == 0) return;

            string buff = "";
            bool translationFound = false;

            try
            {
                if (buffLinks != null && buffLinks.TryGetValue(buffType, out string category))
                    {
                    if (translatedTravelBuffs != null && translatedTravelBuffs.TryGetValue(category, out SortedDictionary<int, string> buffSet) && buffSet != null)
                        {
                            if (buffSet.ContainsKey(buffIndex))
                            {
                                buff = buffSet[buffIndex];
                                if (!string.IsNullOrEmpty(buff))
                                {
                                    translationFound = true;
                                }
                            }
                        }
                    }
                }
            catch
            {
            }

            if (!translationFound && !string.IsNullOrEmpty(originalText))
            {
                try
                {
                    string translated = StringStore.TranslateText(originalText);
                    if (!string.IsNullOrEmpty(translated) && translated != originalText)
                    {
                        buff = translated;
                        translationFound = true;
                    }
                }
                catch
                {
                }
            }

            if (!translationFound)
            {
                buff = originalText;
            }

            foreach (var text in textList)
            {
                if (text == null) continue;

                string finalText = buff;
                if (isBad && !string.IsNullOrEmpty(badFormat) && !string.IsNullOrEmpty(buff))
                {
                    try
                    {
                        finalText = string.Format(badFormat, buff);
                    }
                    catch
                    {
                        finalText = buff;
                    }
                }

                text.text = finalText;
                text.font = fontAsset;
            }
        }
    }
}
