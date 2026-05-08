using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using AlmanacData;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static PvZ_Fusion_Translator__BepInEx_.Utils;
using static PvZ_Fusion_Translator__BepInEx_.FileLoader;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacSelectMenu))]
    public static class AlmanacSelectMenu_Patch
    {
        public static Dictionary<string, string> detailStrings = new Dictionary<string, string>();
        public static Dictionary<string, string> detailTranslateStrings = new Dictionary<string, string>();

        [HarmonyPatch(nameof(AlmanacSelectMenu.Awake))]
        [HarmonyPostfix]
        public static void Awake(AlmanacSelectMenu __instance)
        {
            TranslateAlmanacSelectMenu(__instance);

            foreach (UIButton uiButton in __instance.GetComponentsInChildren<UIButton>())
            {
                if (uiButton.gameObject.name.Contains("Selection(Clone)"))
                {
                    uiButton.clickEvent.AddListener(new Action(() => { TranslateAlmanacSelectMenu(__instance); }));
                }
            }
        }

        [HarmonyPatch(nameof(AlmanacSelectMenu.InitMenu))]
        [HarmonyPostfix]
        public static void InitMenu(AlmanacSelectMenu __instance)
        {
            TranslateAlmanacSelectMenu(__instance);
        }

        public static void TranslateAlmanacSelectMenu(AlmanacSelectMenu __instance)
        {
            TMP_FontAsset font = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = detailTranslateStrings.ContainsKey(txt.text) ? detailTranslateStrings[txt.text] : StringStore.TranslateText(txt.text);
                txt.font = font;
            }
        }
    }
}