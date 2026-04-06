using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Harvest
{
    [HarmonyPatch(typeof(TreasureManager))]
    public static class TreasureManager_Patch
    {
        [HarmonyPatch(nameof(TreasureManager.Update))]
        [HarmonyPostfix]
        private static void Update(TreasureManager __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach(TextMeshProUGUI txt in __instance.evaText)
            {
                txt.autoSizeTextContainer = false;

                if (txt.text != "Evacuate")
                {
                    txt.text = StringStore.TranslateText(txt.text);
                    txt.name = txt.text + "_EVACUATE";
                    txt.font = fontAsset;
                }
            }
        }
    }
}
