#if false
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;

[HarmonyPatch(typeof(BackToIndex))]
public class BackToIndex_Patch
{
    [HarmonyPostfix, HarmonyPatch(nameof(BackToIndex.Awake))]
    public static void Awake(BackToIndex __instance) =>
        StringStore.TranslateTextTransform(__instance.transform.GetChild(0));
}
#endif
