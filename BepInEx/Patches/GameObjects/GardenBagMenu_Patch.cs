using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(GardenBagMenu))]
    public static class GardenBagMenu_Patch
    {
        [HarmonyPatch(nameof(GardenBagMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(GardenBagMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            Transform closeButtonTransform = __instance.transform.Find("Close");
            foreach(TextMeshProUGUI text in closeButtonTransform.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText("合上");
            }
        }
    }
}
