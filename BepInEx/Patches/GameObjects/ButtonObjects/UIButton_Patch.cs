using HarmonyLib;
using TMPro;
using System;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(UIButton))]
    public static class UIButton_Patch
    {
        [HarmonyPatch(typeof(UIButton), nameof(UIButton.Start))]
        [HarmonyPostfix]
        public static void Start(UIButton __instance)
        {
            if (__instance.transform.childCount >= 2)
            {
                TMP_FontAsset font = FontStore.LoadTMPFont(Utils.Language.ToString());

                foreach (TextMeshProUGUI text in __instance.transform.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    if (__instance.transform.name == "Goback")
                    {
                        text.text = "合上";
                    }
                    text.text = TravelMgr_Patch.TranslateTravelText(text.text);
                    text.font = font;
                }
            }
            else
            {
                StringStore.TranslateTextTransform(__instance.transform);
                if (__instance.transform.name == "Goback")
                {
                    foreach (TextMeshProUGUI text in __instance.transform.GetComponentsInChildren<TextMeshProUGUI>())
                    {
                        text.text = TravelMgr_Patch.TranslateTravelText("合上");
                    }
                }
            }
        }

        [HarmonyPatch(nameof(UIButton.OnMouseUpAsButton))]
        [HarmonyPostfix]
        public static void Postfix_OnMouseUpAsButton(UIButton __instance)
        {
            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = TravelMgr_Patch.TranslateTravelText(txt.text);
                txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }
    }
}
