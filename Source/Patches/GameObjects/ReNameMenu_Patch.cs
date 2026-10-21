using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(ReNameMenu))]
public static class ReNameMenu_Patch
{
    [HarmonyPatch(nameof(ReNameMenu.SetTitle)), HarmonyPostfix]
    public static void SetTitle(ReNameMenu __instance) =>
        __instance.title.text = StringStore.TranslateText(__instance.title.text);

    [HarmonyPatch(nameof(ReNameMenu.SetInputText)), HarmonyPostfix]
    public static void SetInputText(ReNameMenu __instance) =>
        __instance.input.text = StringStore.TranslateText(__instance.input.text);
}
