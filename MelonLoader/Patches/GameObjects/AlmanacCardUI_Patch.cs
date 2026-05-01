using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;
using Unity.VisualScripting;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacCardUI))]
    public static class AlmanacCardUI_Patch
    {
        [HarmonyPatch(nameof(AlmanacCardUI.Awake))]
        [HarmonyPostfix]
        public static void Awake(AlmanacCardUI __instance)
        {
            if (!Utils.CheckForUntranslatedText(__instance.cost.text)) return;
            __instance.cost.text = StringStore.TranslateText(__instance.cost.text);
        }

        [HarmonyPatch(nameof(AlmanacCardUI.OnPointerDown))]
        [HarmonyPostfix]
        public static void OnPointerDown(AlmanacCardUI __instance)
        {
            foreach(AlmanacCardUI almanacCardUI in __instance.menu.GetComponentsInChildren<AlmanacCardUI>())
            {
                AlmanacCardUI_Patch.Awake(almanacCardUI);
            }
        }
    }
}
