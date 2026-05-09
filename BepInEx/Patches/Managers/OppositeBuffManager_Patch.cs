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
        public static string badPattern = @"^但(.*)";
        public static string badFormat = StringStore.translationStringRegex != null && StringStore.translationStringRegex.ContainsKey(badPattern) ? StringStore.translationStringRegex[badPattern] : "But, {0}";
        public static TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        [HarmonyPatch(nameof(OppositeBuffManager.Awake))]
        [HarmonyPostfix]
        private static void Awake(OppositeBuffManager __instance)
        {
            Log.LogInfo("==== [OppositeBuffManager.Awake] ====");
            Log.LogInfo("[OppositeBuffManager] Awake called");

            if (__instance.textA_good != null && __instance.textA_good.Count > 0)
            {
                string goodBuffA = TravelMgr.Instance.GetText(__instance.buffA.goodBuff);
                Log.LogInfo($"[OppositeBuffManager] buffA.goodBuff GetText: \"{goodBuffA}\"");
                TranslateOppositeText(__instance.textA_good, goodBuffA, false);
            }
            if (__instance.textA_bad != null && __instance.textA_bad.Count > 0)
            {
                string badBuffA = TravelMgr.Instance.GetText(__instance.buffA.badBuff);
                Log.LogInfo($"[OppositeBuffManager] buffA.badBuff GetText: \"{badBuffA}\"");
                TranslateOppositeText(__instance.textA_bad, badBuffA, true);
            }
            if (__instance.textB_good != null && __instance.textB_good.Count > 0)
            {
                string goodBuffB = TravelMgr.Instance.GetText(__instance.buffB.goodBuff);
                Log.LogInfo($"[OppositeBuffManager] buffB.goodBuff GetText: \"{goodBuffB}\"");
                TranslateOppositeText(__instance.textB_good, goodBuffB, false);
            }
            if (__instance.textB_bad != null && __instance.textB_bad.Count > 0)
            {
                string badBuffB = TravelMgr.Instance.GetText(__instance.buffB.badBuff);
                Log.LogInfo($"[OppositeBuffManager] buffB.badBuff GetText: \"{badBuffB}\"");
                TranslateOppositeText(__instance.textB_bad, badBuffB, true);
            }
        }

        public static void TranslateOppositeText(List<TextMeshProUGUI> textList, string buffText, bool isBad = false)
        {
            if (textList == null || textList.Count == 0) return;

            foreach (var text in textList)
            {
                if (text == null) continue;

                string finalText;
                if (isBad && !string.IsNullOrEmpty(badFormat) && !string.IsNullOrEmpty(buffText))
                {
                    try
                    {
                        finalText = string.Format(badFormat, buffText);
                    }
                    catch
                    {
                        finalText = buffText;
                    }
                }
                else
                {
                    finalText = buffText;
                }

                Log.LogInfo($"[OppositeBuffManager] TranslateOppositeText: isBad={isBad}, buffText=\"{buffText}\" -> final=\"{finalText}\"");
                text.text = finalText;
                text.font = fontAsset;
            }
        }
    }
}