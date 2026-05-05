using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Il2Cpp;
using Il2CppRhythmGame;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor.RhythmGameEditor
{
    [HarmonyPatch(typeof(RhythmGameManager))]
    public static class RhythmGameManager_Patch
    {
        [HarmonyPatch(nameof(RhythmGameManager.Awake))]
        [HarmonyPatch(nameof(RhythmGameManager.ComboUpdate))]
        [HarmonyPostfix]
        public static void Awake(RhythmGameManager __instance)
        {
            if(__instance.comboText)
            {
                __instance.comboText.autoSizeTextContainer = false;
                __instance.comboText.ForceMeshUpdate();
            }
        }

        [HarmonyPatch(nameof(RhythmGameManager.OnNoteClicked))]
        [HarmonyPostfix]
        public static void OnNoteClicked(RhythmGameManager __instance)
        {
            if (!__instance.particle) return;

            TextParticle txtParticle = __instance.particle.GetComponent<TextParticle>();
            if(txtParticle)
            {
                TextMeshPro txt = txtParticle.text.GetComponent<TextMeshPro>();

                if(txt)
                {
                    string originalKey = StringStore.translationString.FirstOrDefault(x => x.Value == txt.text).Key;
                    txt.text = StringStore.translationString.ContainsKey(originalKey + "_RG") ? StringStore.TranslateText(originalKey + "_RG") : StringStore.TranslateText(txt.text);
                    txt.autoSizeTextContainer = false;
                    txt.ForceMeshUpdate();
                }
            }
        }
    }
}
