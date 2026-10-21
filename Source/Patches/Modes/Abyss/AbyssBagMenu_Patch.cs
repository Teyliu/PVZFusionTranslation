#if false
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Abyss;

[HarmonyPatch(typeof(AbyssBagMenu))]
public static class AbyssBagMenu_Patch
{
    [HarmonyPatch(nameof(AbyssBagMenu.Awake)), HarmonyPostfix]
    private static void Awake_Post(AbyssCheckInBag __instance)
    {
        foreach (TextMeshProUGUI text in __instance.transform.FindChild("Background")
           .GetComponentsInChildren<TextMeshProUGUI>())
        {
            text.text += "_深渊";
            text.text = StringStore.TranslateText("背包_深渊");
            text.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }

        AbyssMenu2.Instance.UpdateIcons();
    }
}
#endif
