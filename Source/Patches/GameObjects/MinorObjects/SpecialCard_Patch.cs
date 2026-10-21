using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects;

[HarmonyPatch(typeof(SpecialCard))]
public static class SpecialCard_Patch
{
    [HarmonyPatch(nameof(SpecialCard.Awake)), HarmonyPatch(nameof(SpecialCard.Start)),
     HarmonyPatch(nameof(SpecialCard.ClickedEvent)), HarmonyPostfix]
    public static void Post_Awake(SpecialCard __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }
    }
}
