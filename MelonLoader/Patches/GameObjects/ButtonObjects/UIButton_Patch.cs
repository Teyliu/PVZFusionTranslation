using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(UIButton))]
    public static class UIButton_Patch
    {
        [HarmonyPatch(nameof(UIButton.Start))]
        [HarmonyPostfix]
        public static void Start(UIButton __instance)
        {
            try
            {
                TextMeshProUGUI text = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                TextMeshProUGUI textShadow = __instance.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
                StringStore.TranslateTextUI(text, false);
                StringStore.TranslateTextUI(textShadow, false);
                text.autoSizeTextContainer = textShadow.autoSizeTextContainer = true;
            }
            catch (Exception) { }
        }

        [HarmonyPatch(nameof(UIButton.OnMouseUpAsButton))]
        [HarmonyPostfix]
        public static void OnMouseUpAsButton(UIButton __instance)
        {
            try
            {
                TextMeshProUGUI text = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                TextMeshProUGUI textShadow = __instance.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
                StringStore.TranslateTextUI(text, false);
                StringStore.TranslateTextUI(textShadow, false);
                text.autoSizeTextContainer = textShadow.autoSizeTextContainer = true;
            }
            catch (Exception) { }
        }
    }
}
