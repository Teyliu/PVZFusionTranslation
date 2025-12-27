using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(UIButton))]
    public static class UIButton_Patch
    {
        [HarmonyPatch(typeof(UIButton), nameof(UIButton.Start))]
        [HarmonyPostfix]
        public static void Start(UIButton __instance)
        {
            if(__instance.transform.childCount >= 2)
            {
                TMP_FontAsset font = FontStore.LoadTMPFont(Utils.Language.ToString());

                foreach (TextMeshProUGUI text in __instance.transform.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    if (__instance.transform.name == "Goback")
                    {
                        text.text = "合上";
                    }
                    text.text = StringStore.TranslateText(text.text);
                    text.font = font;
                }
            }
            else
            {
                StringStore.TranslateTextTransform(__instance.transform);
                if(__instance.transform.name == "Goback")
                {
                    foreach(TextMeshProUGUI text in __instance.transform.GetComponentsInChildren<TextMeshProUGUI>())
                    {
                        text.text = StringStore.TranslateText("合上");
                    }
                }
            }
        }

        [HarmonyPatch(nameof(UIButton.OnMouseUpAsButton))]
        [HarmonyPostfix]
        public static void Postfix_OnMouseUpAsButton(UIButton __instance)
        {
            try
            {
                if (__instance.transform.childCount >= 2)
                {
                    if (__instance.name == "EditMode")
                    {
                        TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

                        TextMeshProUGUI text = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                        TextMeshProUGUI[] extraTexts = __instance.transform.GetChild(1).GetComponentsInChildren<TextMeshProUGUI>();

                        text.text = StringStore.TranslateText(text.text, false);
                        text.font = fontAsset;

                        foreach (TextMeshProUGUI extraText in extraTexts)
                        {
                            extraText.text = StringStore.TranslateText(extraText.text, false);
                            extraText.font = fontAsset;
                        }
                    }
                    else
                    {
                        TextMeshProUGUI text = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                        TextMeshProUGUI textShadow = __instance.transform.GetChild(1).GetComponent<TextMeshProUGUI>();

                        text.text = StringStore.TranslateText(text.text, false);
                        textShadow.text = StringStore.TranslateText(textShadow.text, false);

                        text.font = FontStore.LoadTMPFont(Utils.Language.ToString());
                        textShadow.font = FontStore.LoadTMPFont(Utils.Language.ToString());
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
