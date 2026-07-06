using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2Cpp;
using HarmonyLib;
using UnityEngine;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using Unity.VisualScripting;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(HealthSlider))]
    public static class HealthSlider_Patch
    {
        public static TMP_FontAsset fontAsset = null;

        [HarmonyPatch(nameof(HealthSlider.Start))]
        [HarmonyPostfix]
        public static void Post_Start(HealthSlider __instance)
        {
            if(!fontAsset)
            {
                fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }

        [HarmonyPatch(nameof(HealthSlider.UpdateText))]
        [HarmonyPostfix]
        public static void Post_UpdateText(HealthSlider __instance)
        {
            if(!fontAsset) fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (__instance.healthText.font != fontAsset) __instance.healthText.font = fontAsset;

            foreach(TextMeshProUGUI txt in __instance.healthTextContainer.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }
    }
}
