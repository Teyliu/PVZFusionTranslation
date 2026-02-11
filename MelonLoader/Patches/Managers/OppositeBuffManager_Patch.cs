using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
//using PvZ_Fusion_Translator.Patches.Modes.Odyssey;
using System.Text.RegularExpressions;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Managers
{
    [HarmonyPatch(typeof(OppositeBuffManager))]
    public static class OppositeBuffManager_Patch
    {
        //public static Dictionary<BuffType, string> buffLinks = TravelMgr_Patch.buffLinks;
        //public static Dictionary<string, List<string>> translatedTravelBuffs = TravelMgr_Patch.translatedTravelBuffs;
        //public static string badPattern = @"^但(.*)";
        //public static string badFormat = StringStore.translationStringRegex.ContainsKey(badPattern) ? StringStore.translationStringRegex[badPattern] : "But, {0}";
        //public static TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        [HarmonyPatch(nameof(OppositeBuffManager.Awake))]
        [HarmonyPostfix]
        private static void Awake(OppositeBuffManager __instance)
        {
            TranslateOppositeText(__instance.textA_bad, BuffType.Debuff, __instance.buffA.theDebuffID, true);
            TranslateOppositeText(__instance.textA_good, __instance.buffA.theOptionType, __instance.buffA.theOptionID);
            TranslateOppositeText(__instance.textB_bad, BuffType.Debuff, __instance.buffB.theDebuffID, true);
            TranslateOppositeText(__instance.textB_good, __instance.buffB.theOptionType, __instance.buffB.theOptionID);
        }

        public static void TranslateOppositeText(Il2CppSystem.Collections.Generic.List<TextMeshProUGUI> textList, BuffType buffType, int buffIndex, bool isBad = false)
        {
            //string buff = translatedTravelBuffs[buffLinks[buffType]][buffIndex];

            //foreach(var text in textList)
            //{
            //    if(isBad)
            //    {
            //        text.text = string.Format(badFormat, buff);
            //    }
            //    else
            //    {
            //        text.text = buff;
            //    }

            //    text.font = fontAsset;
            //}
        }
    }
}
