using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using System.Linq;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(CustomLevelEnter))]
    public static class CustomLevelEnter_Patch
    {
        [HarmonyPatch(nameof(CustomLevelEnter.Start))]
        [HarmonyPostfix]
        private static void Start(CustomLevelEnter __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
               string originalKey = StringStore.translationString.FirstOrDefault(x => x.Value == txt.text).Key;
				txt.text = (StringStore.translationString.ContainsKey(originalKey + "_IZ")) ? StringStore.TranslateText(originalKey + "_IZ") : StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }
    }
}
