using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(TreasureEvacuateMenu))]
    public static class TreasureEvacuateMenu_Patch
    {
        [HarmonyPatch(nameof(TreasureEvacuateMenu.Start))]
        [HarmonyPostfix]
        private static void Start(TreasureEvacuateMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
                if(txt.name.Contains("text (1)"))
                {
                    txt.name = txt.name + "_EVACUATE";
                }
            }
        }
    }
}