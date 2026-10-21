using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(UIDifficulty))]
public static class UIDifficulty_Patch
{
    [HarmonyPatch(nameof(UIDifficulty.Update)), HarmonyPostfix]
    private static void Update(UIDifficulty __instance)
    {
        if (!Utils.CheckForUntranslatedText(__instance.t.text))
            return;

        __instance.t.text = StringStore.TranslateText(__instance.t.text);
    }
}
