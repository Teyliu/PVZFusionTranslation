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
                intr.text = StringStore.TranslateText(intr.text);
            foreach (var textMesh in __instance.points)
                textMesh.text = StringStore.TranslateText(textMesh.text);
        }

        [HarmonyPatch(nameof(TravelStore.RefreshBuff))]
        [HarmonyPostfix]
        private static void RefreshBuff(TravelStore __instance)
        {
            foreach (TravelBuff buff in __instance.travelBuffs)
            {
                TextMeshProUGUI cost = buff.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
                cost.text = StringStore.TranslateText(cost.text);
                cost.font = FontStore.LoadTMPFont(Utils.Language.ToString());
                FileLoader.DumpUntranslatedStrings(cost.text);
            }
            foreach (TextMeshProUGUI intr in __instance.introduces)
                intr.text = StringStore.TranslateText(intr.text);
            foreach (var textMesh in __instance.points)
                textMesh.text = StringStore.TranslateText(textMesh.text);
        }
    }
}
