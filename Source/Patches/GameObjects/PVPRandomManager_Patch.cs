using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(PVPRandomManager))] // ReSharper disable once InconsistentNaming
public static class PVPRandomManager_Patch
{
    [HarmonyPatch(nameof(PVPRandomManager.Start)), HarmonyPostfix]
    private static void Start(PVPRandomManager __instance)
    {
        foreach (var text in __instance.texts)
            text.text = StringStore.TranslateText(text.text);
    }

    [HarmonyPatch(nameof(PVPRandomManager.Update)), HarmonyPostfix]
    private static void ZombieEnterHouse(PVPRandomManager __instance)
    {
        foreach (var text in __instance.texts)
            text.text = StringStore.TranslateText(text.text);
    }
}
