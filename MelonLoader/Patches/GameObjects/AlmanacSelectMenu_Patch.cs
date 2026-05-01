using HarmonyLib;
using Il2Cpp;
using Il2CppAlmanacData;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static PvZ_Fusion_Translator.FileLoader;
using static PvZ_Fusion_Translator.Utils;

namespace PvZ_Fusion_Translator.Patches.GameObjects
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

            foreach(UIButton uiButton in __instance.GetComponentsInChildren<UIButton>())
            {
                if(uiButton.gameObject.name.Contains("Selection(Clone)"))
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
            
            foreach(TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = detailTranslateStrings.ContainsKey(txt.text) ? detailTranslateStrings[txt.text] : StringStore.TranslateText(txt.text);
                txt.font = font;
            }
        }
    }
}
