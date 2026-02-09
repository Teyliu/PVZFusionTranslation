using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;
using System.Linq;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    public static class TravelStore_Patch
    {
        [HarmonyPatch(nameof(TravelStore.Update))]
        [HarmonyPostfix]
        private static void Update(TravelStore __instance)
        {
            if (__instance.pointText != null)
            {
                foreach (var textMesh in __instance.pointText)
                {
                    textMesh.text = StringStore.TranslateText(textMesh.text);
                }
            }
            
            if (__instance.refreshText != null)
            {
                foreach (var textMesh in __instance.refreshText)
                {
                    textMesh.text = StringStore.TranslateText(textMesh.text);
                }
            }
        }

        [HarmonyPatch(nameof(TravelStore.RefreshBuff))]
        [HarmonyPostfix]
        private static void RefreshBuff(TravelStore __instance)
        {
            if (__instance.buyBuffWindows != null)
            {
                foreach (TravelStoreWindow window in __instance.buyBuffWindows)
                {
                    if (window.set)
                    {
                        string originalText = TravelMgr.Instance.GetText((int)window.buffType, window.buffIndex);
                        string translatedText = Managers.TravelMgr_Patch.MatchTravelBuff(originalText);
                        
                        if (!string.IsNullOrEmpty(translatedText) && translatedText != originalText)
                        {
                            foreach (var textMesh in window.buttonText)
                            {
                                if (textMesh != null)
                                {
                                    textMesh.text = translatedText;
                                }
                            }
                        }
                    }
                }
            }
            
            if (__instance.buyPlantWindows != null)
            {
                foreach (TravelStoreWindow window in __instance.buyPlantWindows)
                {
                    if (window.set)
                    {
                        string originalText = TravelMgr.Instance.GetText((int)window.buffType, window.buffIndex);
                        string translatedText = Managers.TravelMgr_Patch.MatchTravelBuff(originalText);
                        
                        if (!string.IsNullOrEmpty(translatedText) && translatedText != originalText)
                        {
                            foreach (var textMesh in window.buttonText)
                            {
                                if (textMesh != null)
                                {
                                    textMesh.text = translatedText;
                                }
                            }
                        }
                    }
                }
            }
            
            if (__instance.pointText != null)
            {
                foreach (var textMesh in __instance.pointText)
                {
                    textMesh.text = StringStore.TranslateText(textMesh.text);
                }
            }
            
            if (__instance.refreshText != null)
            {
                foreach (var textMesh in __instance.refreshText)
                {
                    textMesh.text = StringStore.TranslateText(textMesh.text);
                }
            }
        }

        [HarmonyPatch(typeof(TravelStoreWindow), nameof(TravelStoreWindow.SetType))]
        [HarmonyPostfix]
        private static void SetType(TravelStoreWindow __instance, int index, BuffType buffType)
        {
            if (__instance.set && __instance.buttonText != null)
            {
                string originalText = TravelMgr.Instance.GetText((int)buffType, index);
                string translatedText = Managers.TravelMgr_Patch.MatchTravelBuff(originalText);
                
                if (!string.IsNullOrEmpty(translatedText) && translatedText != originalText)
                {
                    foreach (var textMesh in __instance.buttonText)
                    {
                        if (textMesh != null)
                        {
                            textMesh.text = translatedText;
                        }
                    }
                }
            }
        }
    }
}
