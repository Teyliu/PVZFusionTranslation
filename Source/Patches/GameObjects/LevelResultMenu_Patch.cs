using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(LevelResultMenu))]
public static class LevelResultMenu_Patch
{
    [HarmonyPatch(nameof(LevelResultMenu.Start)), HarmonyPatch(nameof(LevelResultMenu.ShowResult)), HarmonyPostfix]
    public static void Awake(LevelResultMenu __instance)
    {
        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            txt.text = StringStore.TranslateText(txt.text);
    }
}
