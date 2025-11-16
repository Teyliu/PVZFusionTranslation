using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.Patches.Managers.TravelMgr_Patch;
using UnityEngine;
using MelonLoader;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelLookBuff))]
    public static class TravelLookBuff_Patch
    {
        [HarmonyPatch(nameof(TravelLookBuff.Clear))]
        [HarmonyPostfix]
        public static void Post_Clear(TravelLookBuff __instance)
        {
            __instance.introduce.text = StringStore.TranslateText("无");
            __instance.set = false;

            foreach (TextMeshProUGUI text in __instance.transform.FindChild("Images").FindChild("Button").GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        [HarmonyPatch(nameof(TravelLookBuff.OnMouseUpAsButton))]
        [HarmonyPostfix]
        public static void Post_OnMouseUpAsButton(TravelLookBuff __instance)
        {
            foreach (TextMeshProUGUI text in __instance.transform.FindChild("Images").FindChild("Button").GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        [HarmonyPatch(nameof(TravelLookBuff.SetBuff))]
        [HarmonyPostfix]
        public static void Post_SetBuff(TravelLookBuff __instance)
        {
            List<string> buffSet = translatedTravelBuffs[buffLinks[__instance.buffType]];
            string buffText = (__instance.buffIndex < buffSet.Count) ? buffSet[__instance.buffIndex] : StringStore.TranslateText(__instance.introduce.text);
            __instance.introduce.text = buffText;

            foreach (TextMeshProUGUI text in __instance.transform.FindChild("Images").FindChild("Button").GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }
    }
}