#if false
using HarmonyLib;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;

[HarmonyPatch(typeof(UIBtn))]
public static class UIBtn_Patch
{
    [HarmonyPatch(nameof(UIBtn.Awake)), HarmonyPostfix]
    private static void Postfix_Awake(UIBtn __instance)
    {
        if (__instance.TryGetComponent(out BackToIndex component))
            Utils.ConvertButtonText(__instance.transform.parent, component.name);
    }
}
#endif
