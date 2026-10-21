#if false
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Managers;

[HarmonyPatch(typeof(CustomLevelShower))]
public static class CustomLevelShower_Patch
{
    [HarmonyPatch(nameof(CustomLevelShower.Show)), HarmonyPostfix]
    private static void Show(CustomLevelShower __instance)
    {
        foreach (var transform in __instance.pages)
            StringStore.TranslateTextTransform(transform);
    }
}
#endif
