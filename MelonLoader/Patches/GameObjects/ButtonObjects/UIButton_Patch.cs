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
    }
}
