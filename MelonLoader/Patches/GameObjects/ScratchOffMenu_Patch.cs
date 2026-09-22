using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(ScratchOffMenu))]
    public static class ScratchOffMenu_Patch
    {
        [HarmonyPatch(nameof(ScratchOffMenu.Awake))]
        [HarmonyPatch(nameof(ScratchOffMenu.Refresh))]
        [HarmonyPatch(nameof(ScratchOffMenu.UpdateCell))]
        [HarmonyPatch(nameof(ScratchOffMenu.Start))]
        [HarmonyPostfix]
        public static void Awake(ScratchOffMenu __instance)
        {
            TMP_FontAsset font = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = font;
            }
        }
    }
}
