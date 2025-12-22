using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static PvZ_Fusion_Translator.FileLoader;
using static PvZ_Fusion_Translator.Utils;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacZombieMenu))]
    public static class AlmanacZombieMenu_Patch
    {
        [HarmonyPatch(nameof(AlmanacZombieMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(AlmanacZombieMenu __instance)
        {
            TMP_FontAsset font = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                bool isZombieName = text.gameObject.name.Contains("Name") && text.transform.parent.name != "Background";
                if (text.gameObject.name != "Description" && !isZombieName)
                {
                    text.text = StringStore.TranslateText(text.text);
                    text.font = font;
                    text.autoSizeTextContainer = true;
                }
            }
        }
    }
}
