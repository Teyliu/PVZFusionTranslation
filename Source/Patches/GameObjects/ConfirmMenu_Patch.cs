using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(ConfirmMenu))]
public static class ConfirmMenu_Patch
{
    [HarmonyPatch(nameof(ConfirmMenu.SetTitle)), HarmonyPostfix]
    private static void SetTitle(ConfirmMenu __instance)
    {
        foreach (var title in __instance.title)
        {
            title.text = StringStore.TranslateText(title.text);
            title.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }
    }
}
