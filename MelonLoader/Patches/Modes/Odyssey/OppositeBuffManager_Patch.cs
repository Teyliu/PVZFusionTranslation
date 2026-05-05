using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(OppositeBuffManager))]
    public static class OppositeBuffManager_Patch
    {
        public static Dictionary<BuffType, string> buffLinks = TravelMgr_Patch.buffLinks;
        public static Dictionary<string, SortedDictionary<int, string>> translatedTravelBuffs = TravelMgr_Patch.translatedTravelBuffs;
        public static string badPattern = @"^但(.*)";
        public static string badFormat = StringStore.translationStringRegex.ContainsKey(badPattern) ? StringStore.translationStringRegex[badPattern] : "But, {0}";
        public static TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        [HarmonyPatch(nameof(OppositeBuffManager.SetText))]
        [HarmonyPostfix]
        private static void SetText(OppositeBuffManager __instance)
        {
            /*if (TravelMgr_Patch.travelBuffString.ContainsKey(__result))
            { 
                __result = TravelMgr_Patch.travelBuffString[__result]; 
            }
            else if(TravelMgr_Patch.travelBuffString.ContainsKey(TravelMgr_Patch.RemoveBuffName(__result)))
            {
                __result = TravelMgr_Patch.travelBuffString[TravelMgr_Patch.RemoveBuffName(__result)];
            }*/
        }

        public static void TranslateOppositeText(Il2CppSystem.Collections.Generic.List<TextMeshProUGUI> textList, Il2CppSystem.Object buff, bool isBad = false)
        {
            string buffText = TravelMgr.Instance.GetText(buff);

            foreach (var text in textList)
            {
                if (isBad)
                {
                    text.text = string.Format(badFormat, buffText);
                }
                else
                {
                    text.text = buffText;
                }

                text.font = fontAsset;
            }
        }
    }
}
