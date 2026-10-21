using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(UIZombieNum))]
public static class UIZombieNum_Patch
{
    [HarmonyPatch(nameof(UIZombieNum.Update)), HarmonyPostfix]
    private static void Update(UIZombieNum __instance)
    {
        TMP_FontAsset fontAsset;

        if (ModFeatures.IsMultiLanguage)
        {
            fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            __instance.t.text = StringStore.TranslateText(__instance.t.text);
        }
        else
        {
            fontAsset = FontStore.LoadTMPFont();

            __instance.t.text = string.Format(
                StringStore.PatchesStore["Zombies"]["Spanish"] + " {0}",
                Board.Instance.enermyCount
            );
        }

        __instance.t.font = fontAsset;
    }
}
