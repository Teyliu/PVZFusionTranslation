using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(Almanac))]
public static class Almanac_Patch
{
    [HarmonyPatch(nameof(Almanac.Awake)), HarmonyPostfix]
    private static void Awake(Almanac __instance) => TranslateAlmanacMenu(__instance);
#if false
    [HarmonyPatch(nameof(Almanac.OldAlmanac)), HarmonyPostfix]
    private static void OldAlmanac(Almanac __instance) => TranslateAlmanacMenu(__instance);
#endif
    [HarmonyPatch(nameof(Almanac.AnimSwitch)), HarmonyPostfix]
    private static void AnimSwitch(Almanac __instance) => TranslateAlmanacMenu(__instance);

    public static void TranslateAlmanacMenu(Almanac __instance)
    {
        var font = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var text in __instance
           .GetComponentsInChildren<TextMeshProUGUI>()
           .Where(text => !text.gameObject.name.Contains("Cost")))
        {
            text.text = StringStore.TranslateText(text.text == "关闭" ? "合上" : text.text);
            text.font = font;
        }
    }
}
