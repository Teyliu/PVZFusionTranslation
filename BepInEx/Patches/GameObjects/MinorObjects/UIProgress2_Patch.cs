using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(UIProgress2))]
    public static class UIProgress2_Patch
    {
        [HarmonyPatch(nameof(UIProgress2.Update))]
        [HarmonyPostfix]
        private static void Update(UIProgress2 __instance)
        {
            __instance.t.text = StringStore.TranslateText(__instance.t.text);
        }
    }
}