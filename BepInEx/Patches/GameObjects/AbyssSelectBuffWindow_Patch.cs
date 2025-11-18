using System.Text.RegularExpressions;
using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_;
using TMPro;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AbyssSelectBuffWindow))]
    public static class AbyssSelectBuffWindow_Patch
    {
        [HarmonyPatch(nameof(AbyssSelectBuffWindow.OnAnimOver))]
        [HarmonyPostfix]
        private static void OnAnimOver(AbyssSelectBuffWindow __instance)
        {
            TranslateBuffWindow(__instance);
        }

        [HarmonyPatch(nameof(AbyssSelectBuffWindow.SetBuff))]
        [HarmonyPostfix]
        private static void SetBuff(AbyssSelectBuffWindow __instance)
        {
            TranslateBuffWindow(__instance);
        }

        public static void TranslateBuffWindow(AbyssSelectBuffWindow __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            AbyssBuffMenu_Patch.LoadAbyssBuffData();

            foreach (TextMeshProUGUI titleText in __instance.titleText)
            {
                if (AbyssBuffMenu_Patch.abyssBuffData.ContainsKey(titleText.text))
                {
                    if (titleText.name.Contains("shadow"))
                    {
                        titleText.text = Utils.RemoveColorTags(AbyssBuffMenu_Patch.abyssBuffData[titleText.text]);
                    }
                    else
                    {
                        titleText.text = AbyssBuffMenu_Patch.abyssBuffData[titleText.text];
                    }
                }
                titleText.font = fontAsset;
            }

            string translatedIntroduceText = (AbyssBuffMenu_Patch.abyssBuffData.ContainsKey(__instance.introduce.text)) ? AbyssBuffMenu_Patch.abyssBuffData[__instance.introduce.text] : AbyssBuffMenu_Patch.TranslateAbyssBuffRegex(__instance.introduce.text);

            if (translatedIntroduceText != null)
            {
                __instance.introduce.text = translatedIntroduceText;
                __instance.introduce.font = fontAsset;
            }
        }
    }
}