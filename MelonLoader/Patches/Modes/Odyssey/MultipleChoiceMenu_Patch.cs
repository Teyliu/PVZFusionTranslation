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

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(MultipleChoiceMenu))]
    public static class MultipleChoiceMenu_Patch
    {
        [HarmonyPatch(nameof(MultipleChoiceMenu.Awake))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.UpdateWindow))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.Refresh))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.Cancel))]
        [HarmonyPostfix]
        public static void Awake(MultipleChoiceMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach(BaseWindow window in __instance.windows)
            {
                foreach(TextMeshProUGUI txt in window.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    txt.font = fontAsset;
                    txt.text = StringStore.TranslateText(txt.text);
                }
            }
        }
    }
}
