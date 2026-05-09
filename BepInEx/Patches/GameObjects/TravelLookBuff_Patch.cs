using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelLookBuff))]
    public static class TravelLookBuff_Patch
    {
        private static void TranslateAllText(TravelLookBuff instance)
        {
            if (instance == null)
                return;

            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (TextMeshProUGUI text in instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                if (text == null || string.IsNullOrEmpty(text.text))
                    continue;

                text.text = TravelMgr_Patch.TranslateTravelText(text.text);
                text.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(TravelLookBuff.Clear))]
        [HarmonyPostfix]
        public static void Post_Clear(TravelLookBuff __instance)
        {
            Log.LogInfo("==== [TravelLookBuff.Clear] ====");
            __instance.introduce.text = TravelMgr_Patch.TranslateTravelText("无");
            __instance.set = false;

            TranslateAllText(__instance);
        }

        [HarmonyPatch(nameof(TravelLookBuff.OnMouseUpAsButton))]
        [HarmonyPostfix]
        public static void Post_OnMouseUpAsButton(TravelLookBuff __instance)
        {
            TranslateAllText(__instance);
        }

        [HarmonyPatch(nameof(TravelLookBuff.SetBuff))]
        [HarmonyPostfix]
        public static void Post_SetBuff(TravelLookBuff __instance, object buff)
        {
            if (__instance != null
                && __instance.introduce != null
                && TravelMgr_Patch.TryGetTranslatedBuff(buff, out string translatedBuff))
            {
                __instance.introduce.text = translatedBuff;
            }

            TranslateAllText(__instance);
        }
    }
}