using HarmonyLib;
using System;
using System.Collections.Generic;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using static PvZ_Fusion_Translator__BepInEx_.Patches.Managers.TravelMgr_Patch;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelLookBuff))]
    public static class TravelLookBuff_Patch
    {
        [HarmonyPatch(nameof(TravelLookBuff.Clear))]
        [HarmonyPostfix]
        public static void Post_Clear(TravelLookBuff __instance)
        {
             __instance.introduce.text = StringStore.TranslateText("无");
            __instance.set = false;

            foreach (TextMeshProUGUI text in __instance.transform.FindChild("Images").FindChild("Button").GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        [HarmonyPatch(nameof(TravelLookBuff.OnMouseUpAsButton))]
        [HarmonyPostfix]
        public static void Post_OnMouseUpAsButton(TravelLookBuff __instance)
        {
            foreach (TextMeshProUGUI text in __instance.transform.FindChild("Images").FindChild("Button").GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        [HarmonyPatch(nameof(TravelLookBuff.SetBuff))]
        [HarmonyPostfix]
        public static void Post_SetBuff(TravelLookBuff __instance)
        {
            List<string> buffSet = translatedTravelBuffs[buffLinks[__instance.buffType]];
            string buffText = (__instance.buffIndex < buffSet.Count) ? buffSet[__instance.buffIndex] : StringStore.TranslateText(__instance.introduce.text);
            __instance.introduce.text = buffText;
#if DEBUG
            if (__instance.introduce.text != null)   
            {
                Log.LogInfo($"BuffType: {__instance.buffType}, BuffIndex: {__instance.buffIndex}, BuffIntroduce: {__instance.introduce.text}");
                if (__instance.introduce.text != buffText)
                {
                    FileLoader.DumpUntranslatedStrings(__instance.introduce.text);
                    //Log.LogInfo($"Mapped BuffIntroduce: {buffText}");
                }
            }
            
#endif

            foreach (TextMeshProUGUI text in __instance.transform.FindChild("Images").FindChild("Button").GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }
    }
}