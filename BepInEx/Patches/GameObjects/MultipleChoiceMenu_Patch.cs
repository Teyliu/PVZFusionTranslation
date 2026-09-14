using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(MultipleChoiceMenu))]
    public static class MultipleChoiceMenu_Patch
    {
        [HarmonyPatch(nameof(MultipleChoiceMenu.Awake))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.UpdateWindow))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.Refresh))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.Cancel))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.ShowCurrentPage))]
        [HarmonyPostfix]
        public static void Post_All(MultipleChoiceMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                if (txt == null || string.IsNullOrEmpty(txt.text)) continue;

                string original = txt.text;
                if (txt.transform.parent != null
                    && txt.transform.parent.name == "TurnPage"
                    && original.Contains("(")
                    && original.EndsWith(")"))
                {
                    txt.text = TranslateTurnPageText(original);
                }
                else
                {
                    txt.text = StringStore.translationString.ContainsKey(original + "_MC")
                        ? StringStore.TranslateText(original + "_MC")
                        : StringStore.TranslateText(original);
                    txt.text = StringStore.ReplaceOppositeBuffBut(txt.text);
                }

                txt.font = fontAsset;
            }
        }

        private static string TranslateTurnPageText(string original)
        {
            int open = original.LastIndexOf('(');
            if (open <= 0) return StringStore.TranslateText(original);

            string prefix = original.Substring(0, open);
            string pagePart = original.Substring(open + 1, original.Length - open - 2);

            string translatedPrefix = StringStore.TranslateText(prefix);
            return $"{translatedPrefix}({pagePart})";
        }
    }
}
