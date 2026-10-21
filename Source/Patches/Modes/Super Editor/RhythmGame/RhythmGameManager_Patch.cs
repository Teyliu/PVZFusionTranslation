using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor.RhythmGame;

[HarmonyPatch(typeof(RhythmGameManager))]
public static class RhythmGameManager_Patch
{
    [HarmonyPatch(nameof(RhythmGameManager.Awake)), HarmonyPatch(nameof(RhythmGameManager.ComboUpdate)), HarmonyPostfix]
    public static void Awake(RhythmGameManager __instance)
    {
        if (!__instance.comboText)
            return;

        __instance.comboText.autoSizeTextContainer = false;
        __instance.comboText.ForceMeshUpdate();
    }

    [HarmonyPatch(nameof(RhythmGameManager.OnNoteClicked)), HarmonyPostfix]
    public static void OnNoteClicked(RhythmGameManager __instance)
    {
        if (!__instance.particle)
            return;

        var txtParticle = __instance.particle.GetComponent<TextParticle>();

        if (!txtParticle)
            return;

        var txt = txtParticle.text.GetComponent<TextMeshPro>();

        if (!txt)
            return;

        var originalKey = StringStore.TranslationString.FirstOrDefault(x => x.Value == txt.text).Key;

        txt.text = StringStore.TranslationString.ContainsKey(originalKey + "_RG")
            ? StringStore.TranslateText(originalKey + "_RG")
            : StringStore.TranslateText(txt.text);

        txt.autoSizeTextContainer = false;
        txt.ForceMeshUpdate();
    }
}
