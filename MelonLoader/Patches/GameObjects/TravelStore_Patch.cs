using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
	[HarmonyPatch(typeof(TravelStore))]
    public static class TravelStore_Patch
    {
        [HarmonyPatch(nameof(TravelStore.Update))]
		[HarmonyPostfix]
		private static void Update(TravelStore __instance)
        {
            foreach (TextMeshProUGUI intr in __instance.introduces)
                StringStore.TranslateTextUI(intr);
            foreach (var textMesh in __instance.points)
                StringStore.TranslateTextUI(textMesh);
        }

        [HarmonyPatch(nameof(TravelStore.RefreshBuff))]
        [HarmonyPostfix]
        private static void RefreshBuff(TravelStore __instance)
        {
            foreach (TravelBuff buff in __instance.travelBuffs)
            {
                TextMeshProUGUI cost = buff.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
                if (!cost.text.Contains('0'))
                    StringStore.TranslateTextUI(cost);
                cost.font = Resources.Load<TMP_FontAsset>("fonts/Dynamic");
            }
            foreach (TextMeshProUGUI intr in __instance.introduces)
                StringStore.TranslateTextUI(intr);
            foreach (var textMesh in __instance.points)
                StringStore.TranslateTextUI(textMesh);
        }
    }
}
