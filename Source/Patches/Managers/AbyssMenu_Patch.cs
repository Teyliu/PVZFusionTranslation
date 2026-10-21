#if false
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Managers;

[HarmonyPatch(typeof(AbyssMenu))]
public static class AbyssMenu_Patch
{
    [HarmonyPatch(nameof(AbyssMenu.Awake)), HarmonyPostfix]
    private static void Awake(AbyssMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.rukous)
        {
            txt.text = StringStore.TranslateText(txt.text, false);
            txt.font = fontAsset;
        }
    }
}
#endif
