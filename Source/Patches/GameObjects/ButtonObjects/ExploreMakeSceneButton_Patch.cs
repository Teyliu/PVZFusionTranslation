using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;

[HarmonyPatch(typeof(ExploreMakeSceneButton))]
public class ExploreMakeSceneButton_Patch
{
    [HarmonyPostfix, HarmonyPatch(nameof(ExploreMakeSceneButton.Start))]
    public static void Start(ExploreMakeSceneButton __instance)
    {
        __instance.sceneText.text = StringStore.TranslationString.ContainsKey(__instance.sceneText.text + "_FS")
            ? StringStore.TranslateText(__instance.sceneText.text + "_FS")
            : StringStore.TranslateText(__instance.sceneText.text);

        __instance.sceneText.font = FontStore.LoadTMPFont(Utils.Language.ToString());
    }
}
