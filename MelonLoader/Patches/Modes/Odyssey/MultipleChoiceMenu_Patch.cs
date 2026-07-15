using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(MultipleChoiceMenu))]
    public static class MultipleChoiceMenu_Patch
    {
        public static TMP_FontAsset fontAsset => FontStore.LoadTMPFont(Utils.Language.ToString());

        [HarmonyPatch(nameof(MultipleChoiceMenu.Awake))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.Cancel))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.Refresh))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.TurnPage))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.UpdateWindow))]
        [HarmonyPostfix]
        public static void Awake(MultipleChoiceMenu __instance)
        {
            foreach(BaseWindow window in __instance.windows)
            {
                TranslateWindowText(window.title);
                TranslateWindowText(window.introduce);
            }

            foreach(TheButton button in __instance.GetComponentsInChildren<TheButton>())
            {
                foreach(TextMeshProUGUI txt in button.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    txt.text = StringStore.translationString.ContainsKey(txt.text + "_MC") ? StringStore.TranslateText(txt.text + "_MC") : StringStore.TranslateText(txt.text);
                    txt.font = fontAsset;
                }
            }
        }

        public static void TranslateWindowText(TextMeshProUGUI txt)
        {
            txt.font = fontAsset;
            if(StringStore.customLevelString.ContainsKey(txt.text))
            {
                txt.text = StringStore.customLevelString[txt.text];
            }
            else if(Utils.GetPlantNameFromAlmanac(txt.text) != "")
            {
                txt.text = Utils.GetPlantNameFromAlmanac(txt.text);
            }
            else
            {
                txt.text = StringStore.translationString.ContainsKey(txt.text + "_MC") ? StringStore.TranslateText(txt.text + "_MC") : StringStore.TranslateText(txt.text);
            }
        }
    }
}
