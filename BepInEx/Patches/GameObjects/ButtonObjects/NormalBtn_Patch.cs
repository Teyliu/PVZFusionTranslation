using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(NormalBtn))]
    public class NormalBtn_Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch(nameof(NormalBtn.OnMouseUpAsButton))]
        public static void OnMouseUpAsButton(NormalBtn __instance)
        {
            foreach (TextMeshPro textMeshPro in __instance.GetComponentsInChildren<TextMeshPro>())
            {
                textMeshPro.text = StringStore.TranslateText(textMeshPro.text);
            }
        }
    }
}
