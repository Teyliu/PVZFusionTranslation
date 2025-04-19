#if FIX
using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.OtherManagers
{
    [HarmonyPatch(typeof(MenuText))]
    public static class MenuText_Patch
    {
        [HarmonyPatch(nameof(MenuText.UpdateText), new Type[] { typeof(string) })]
        [HarmonyPostfix]
        private static void UpdateTextPatch(MenuText __instance)
        {
            TextMeshProUGUI text_1 = __instance.transform.GetChild(0).Find("text1").GetComponent<TextMeshProUGUI>();
            text_1.text = StringStore.TranslateText(text_1.text);
            TextMeshProUGUI text = __instance.transform.GetChild(0).Find("text").GetComponent<TextMeshProUGUI>();
            text.text = StringStore.TranslateText(text_1.text);
        }
    }
}
#endif