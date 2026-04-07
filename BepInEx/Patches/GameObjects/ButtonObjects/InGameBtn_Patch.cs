using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(InGameBtn))]
    public static class InGameBtn_Patch
    {
        [HarmonyPatch(nameof(InGameBtn.Start))]
        [HarmonyPostfix]
        private static void Start(InGameBtn __instance)
        {
            TranslateSceneText(__instance);
            
            foreach(TextMeshProUGUI text in __instance.transform.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        [HarmonyPatch(nameof(InGameBtn.ChangeStrings))]
        [HarmonyPostfix]
        private static void ChangeStrings(InGameBtn __instance)
        {
            TranslateSceneText(__instance);
        }

        private static void TranslateSceneText(InGameBtn __instance)
        {
            Transform sceneText = __instance.transform.FindChild("SceneText");
            if(sceneText != null)
            {
                TextMeshProUGUI sceneTextTMP = sceneText.transform.GetComponent<TextMeshProUGUI>();
                if(sceneTextTMP != null)
                {
                    sceneTextTMP.text = StringStore.TranslateText(sceneTextTMP.text);
                }
                Transform sceneTextShadow = sceneText.transform.FindChild("SceneText");
                if(sceneTextShadow != null)
                {
                    TextMeshProUGUI sceneTextShadowTMP = sceneTextShadow.transform.GetComponent<TextMeshProUGUI>();
                    if (sceneTextShadowTMP != null)
                    {
                        sceneTextShadowTMP.text = StringStore.TranslateText(sceneTextShadowTMP.text);
                    }
                }
            }
        }
    }
}
