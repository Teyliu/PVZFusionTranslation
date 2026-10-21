using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor;

[HarmonyPatch(typeof(CustomMenuPage_initZombies))]
public static class CustomMenuPageInitZombiesPatch
{
    [HarmonyPatch(nameof(CustomMenuPage_initZombies.SubWave)), HarmonyPostfix]
    public static void SubWave(CustomMenuPage_initZombies __instance) =>
        __instance.currentWaveText.text = StringStore.TranslateText(__instance.currentWaveText.text);

    [HarmonyPatch(nameof(CustomMenuPage_initZombies.AddWave)), HarmonyPostfix]
    public static void AddWave(CustomMenuPage_initZombies __instance) =>
        __instance.currentWaveText.text = StringStore.TranslateText(__instance.currentWaveText.text);
}
