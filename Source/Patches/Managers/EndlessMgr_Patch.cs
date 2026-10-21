using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Managers;

[HarmonyPatch(typeof(EndlessMgr))]
public static class EndlessMgr_Patch
{
    [HarmonyPatch(nameof(EndlessMgr.Awake)), HarmonyPostfix]
    private static void Awake(EndlessMgr __instance)
    {
        var textTransform = __instance.transform.GetChild(2);

        if (textTransform == null || !textTransform.gameObject.activeSelf)
            return;

        var textTMP = textTransform.GetComponent<TextMeshProUGUI>();

        if (textTMP != null)
            StringStore.TranslateText(textTMP);
    }
}
