using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2Cpp;
using UnityEngine;
using HarmonyLib;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(LevelResultMenu))]
    public static class LevelResultMenu_Patch
    {
        [HarmonyPatch(nameof(LevelResultMenu.Awake))]
        [HarmonyPatch(nameof(LevelResultMenu.Start))]
        [HarmonyPatch(nameof(LevelResultMenu.ShowResult))]
        [HarmonyPostfix]
        public static void Awake(LevelResultMenu __instance)
        {
            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
            }
        }
    }
}
