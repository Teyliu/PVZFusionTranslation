#if false
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(TowerOption))]
public static class TowerOption_Patch
{
    [HarmonyPatch(nameof(TowerOption.Start)), HarmonyPostfix]
    private static void Postfix_Start(TowerOption __instance)
    {
        //TextMeshProUGUI[] allTexts = __instance.GetComponentsInChildren<TextMeshProUGUI>(true);
        __instance.introduce.text = StringStore.TranslateText(__instance.introduce.text);
        __instance.introduce.font = FontStore.LoadTMPFont(Utils.Language.ToString());
    }
}
#endif
