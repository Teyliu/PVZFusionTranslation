using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(PlayerShootingMenu))]
public static class PlayerShootingMenu_Patch
{
    [HarmonyPatch(nameof(PlayerShootingMenu.Update)), HarmonyPostfix]
    private static void Update(PlayerShootingMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }
    }

    [HarmonyPatch(nameof(PlayerShootingMenu.Refresh)), HarmonyPostfix]
    private static void Refresh(PlayerShootingMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        var refreshTransform = __instance.transform.FindChild("Button");

        foreach (var text in refreshTransform.GetComponentsInChildren<TextMeshProUGUI>())
        {
            text.text = StringStore.TranslateText(text.text);
            text.font = fontAsset;
            text.autoSizeTextContainer = false;
        }
    }
}
