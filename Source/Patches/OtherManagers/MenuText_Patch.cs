#if false
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.OtherManagers;

[HarmonyPatch(typeof(MenuText))]
public static class MenuText_Patch
{
    [HarmonyPatch(nameof(MenuText.UpdateText), typeof(string)), HarmonyPostfix]
    private static void UpdateTextPatch(MenuText __instance)
    {
        var text1 = __instance.transform.GetChild(0).Find("text1").GetComponent<TextMeshProUGUI>();
        text1.text = StringStore.TranslateText(text1.text);
        var text = __instance.transform.GetChild(0).Find("text").GetComponent<TextMeshProUGUI>();
        text.text = StringStore.TranslateText(text1.text);
    }
}
#endif
