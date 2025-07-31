using HarmonyLib;
// using Il2Cpp;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;


namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(JigsawClip))]
    public static class JigsawClip_Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch(nameof(JigsawClip.Awake))]
        private static void Postfix_Awake(JigsawClip __instance)
        {
            if (!__instance || !__instance.description) return;

            StringStore.TranslateTextUI(__instance.description);
        }
        [HarmonyPostfix]
        [HarmonyPatch(nameof(JigsawClip.Update))]
        private static void Postfix_Update(JigsawClip __instance)
        {
            if (!__instance || !__instance.description) return;

            if (__instance.description.text != StringStore.TranslateText(__instance.description.text))
            {
                StringStore.TranslateTextUI(__instance.description);
            }
        }
    }
}