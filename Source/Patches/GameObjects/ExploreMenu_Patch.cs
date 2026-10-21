using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(ExploreMenu))]
public static class ExploreMenu_Patch
{
    [HarmonyPatch(nameof(ExploreMenu.Awake)),HarmonyPostfix]
    private static void Awake(ExploreMenu __instance)
    {
        _ = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            txt.text = StringStore.TranslateText(txt.text);

        // var randomLevelTextTransform = __instance.transform.FindChild("RandomLevel");
    }

    [HarmonyPatch(nameof(ExploreMenu.UpdateWindows)),HarmonyPostfix]
    private static void UpdateWindows(ExploreMenu __instance)
    {
        _ = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            txt.text = StringStore.TranslateText(txt.text);
    }
}
