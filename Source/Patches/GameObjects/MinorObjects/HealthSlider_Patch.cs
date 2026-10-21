using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects;

[HarmonyPatch(typeof(HealthSlider))]
public static class HealthSlider_Patch
{
#pragma warning disable CA2211
    public static TMP_FontAsset FontAsset;
#pragma warning restore CA2211
    [HarmonyPatch(nameof(HealthSlider.Start)), HarmonyPostfix]
    public static void Post_Start(HealthSlider __instance)
    {
        if (!FontAsset)
            FontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
    }

    [HarmonyPatch(nameof(HealthSlider.UpdateText)), HarmonyPostfix]
    public static void Post_UpdateText(HealthSlider __instance)
    {
        if (!FontAsset)
            FontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        if (__instance.healthText.font != FontAsset)
            __instance.healthText.font = FontAsset;

        foreach (var txt in __instance.healthTextContainer.GetComponentsInChildren<TextMeshProUGUI>(true))
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = FontAsset;
        }
    }
}
