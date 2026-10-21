using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using Object = UnityEngine.Object;

namespace PvZ_Fusion_Translator.Patches.Managers;

[HarmonyPatch(typeof(UIMgr))]
public class UIMgr_Patch
{
    [HarmonyPatch(nameof(UIMgr.EnterLoseMenu)), HarmonyPostfix]
    private static void EnterLoseMenu(UIMgr __instance)
    {
        var loseMenu = Object.FindObjectOfType<LoseMenu>();
        loseMenu.title.text = StringStore.TranslateText(loseMenu.title.text);
    }
}
