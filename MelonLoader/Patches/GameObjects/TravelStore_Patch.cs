using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.Patches.Managers.TravelMgr_Patch;
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
            foreach(TextMeshProUGUI text in __instance.introduces)
            {
                if(__instance.currentSelect != null)
                {
                    var buffList = translatedTravelBuffs[buffLinks[(BuffType)__instance.currentSelect.theBuffType]];
                    if(__instance.currentSelect.theBuffNumber < buffList.Count && __instance.currentSelect.theBuffNumber > -1)
                    {
                        text.text = buffList[__instance.currentSelect.theBuffNumber];
                    }
                    else
                    {
                        text.text = StringStore.TranslateText(text.text);
                    }
                }
            }
            foreach (var textMesh in __instance.points)
            {
                textMesh.text = StringStore.TranslateText(textMesh.text);
            }
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
            }

            foreach (TextMeshProUGUI text in __instance.introduces)
            {
                if (__instance.currentSelect != null)
                {
                    var buffList = translatedTravelBuffs[buffLinks[(BuffType)__instance.currentSelect.theBuffType]];
                    if (__instance.currentSelect.theBuffNumber < buffList.Count && __instance.currentSelect.theBuffNumber > -1)
                    {
                        text.text = buffList[__instance.currentSelect.theBuffNumber];
                    }
                    else
                    {
                        text.text = StringStore.TranslateText(text.text);
                    }
                }
            }
            foreach (var textMesh in __instance.points)
            {
                textMesh.text = StringStore.TranslateText(textMesh.text);
            }
        }
    }
}
