using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(SpecialCard))]
    public static class SpecialCard_Patch
    {
        [HarmonyPatch(nameof(SpecialCard.Awake))]
        [HarmonyPatch(nameof(SpecialCard.Start))]
        [HarmonyPatch(nameof(SpecialCard.ClickedEvent))]
        [HarmonyPostfix]
        public static void Post_Awake(SpecialCard __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach(TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }
    }
}
