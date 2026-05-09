using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using static PvZ_Fusion_Translator__BepInEx_.Patches.Managers.TravelMgr_Patch;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelLookBuff))]
    public static class TravelLookBuff_Patch
    {
        [HarmonyPatch(nameof(TravelLookBuff.Clear))]
        [HarmonyPostfix]
        public static void Post_Clear(TravelLookBuff __instance)
        {
            Log.LogInfo("==== [TravelLookBuff.Clear] ====");
            Log.LogInfo("[TravelLookBuff] Clear called");
            __instance.introduce.text = StringStore.TranslateText("无");
            __instance.set = false;

            foreach (TextMeshProUGUI text in __instance.transform.Find("Images").Find("Button").GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        [HarmonyPatch(nameof(TravelLookBuff.OnMouseUpAsButton))]
        [HarmonyPostfix]
        public static void Post_OnMouseUpAsButton(TravelLookBuff __instance)
        {
            foreach (TextMeshProUGUI text in __instance.transform.Find("Images").Find("Button").GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }

        [HarmonyPatch(nameof(TravelLookBuff.SetBuff))]
        [HarmonyPostfix]
        public static void Post_SetBuff(TravelLookBuff __instance)
        {
            string introduceText = __instance.introduce != null ? __instance.introduce.text : "(null)";
            Log.LogInfo("==== [TravelLookBuff.SetBuff] ====");

            foreach (TextMeshProUGUI text in __instance.transform.Find("Images").Find("Introduce").GetComponentsInChildren<TextMeshProUGUI>())
            {
                string original = text.text;
                if (string.IsNullOrEmpty(original)) continue;

                if (travelBuffString.ContainsKey(original))
                {
                    text.text = travelBuffString[original];
                    Log.LogInfo($"[TravelLookBuff.SetBuff] travelBuffString HIT: \"{original}\" -> \"{text.text}\"");
                }
                else if (travelBuffString.ContainsKey(RemoveBuffName(original)))
                {
                    text.text = travelBuffString[RemoveBuffName(original)];
                    Log.LogInfo($"[TravelLookBuff.SetBuff] travelBuffString (RemoveBuffName) HIT: \"{original}\" -> \"{text.text}\"");
                }
                else if (Utils.CheckForUntranslatedText(original))
                {
                    string translated = StringStore.TranslateColorText(original);
                    if (translated != original)
                    {
                        text.text = translated;
                        Log.LogInfo($"[TravelLookBuff.SetBuff] TranslateColorText fallback HIT: \"{original}\" -> \"{translated}\"");
                    }
                    else
                    {
                        translated = StringStore.TranslateText(original);
                        text.text = translated;
                        if (translated != original)
                            Log.LogInfo($"[TravelLookBuff.SetBuff] TranslateText fallback HIT: \"{original}\" -> \"{translated}\"");
                        else
                            Log.LogInfo($"[TravelLookBuff.SetBuff] NO TRANSLATION: \"{original}\"");
                    }
                }
            }

            foreach (TextMeshProUGUI text in __instance.transform.Find("Images").Find("Button").GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }

            Log.LogInfo($"[TravelLookBuff.SetBuff] introduce.text = \"{introduceText}\" -> \"{__instance.introduce?.text}\"");
        }
    }
}