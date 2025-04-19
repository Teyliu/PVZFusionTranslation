using HarmonyLib;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.BaseTextObjects
{
    [HarmonyPatch(typeof(TMP_InputField))]
    public static class TMP_InputField_Patch
    {
        [HarmonyPatch(nameof(TMP_InputField.OnEnable))]
        [HarmonyPostfix]
        private static void OnEnable(TMP_InputField __instance)
        {
            if (!string.IsNullOrEmpty(__instance.text))
            {
                string text = StringStore.TranslateText(__instance.text);
                __instance.m_Text = StringStore.TranslateText(text);
                __instance.m_OriginalText = StringStore.TranslateText(text);
                __instance.m_TextComponent.text = StringStore.TranslateText(text);
            }
        }
    }
}
