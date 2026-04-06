using MelonLoader;
using HarmonyLib;
using UnityEngine;
using Il2Cpp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor
{
    [HarmonyPatch(typeof(CustomOnlineMenu))]
    public static class CustomOnlineMenu_Patch
    {
        [HarmonyPatch(nameof(CustomOnlineMenu.EditLevel))]
        [HarmonyPostfix]
        public static void EditLevel(CustomOnlineMenu __instance)
        {
            TranslateLevelName(__instance);
        }

        [HarmonyPatch(nameof(CustomOnlineMenu.Start))]
        [HarmonyPostfix]
        public static void Start(CustomOnlineMenu __instance)
        {
            TranslateLevelName(__instance);
        }

        public static void TranslateLevelName(CustomOnlineMenu __instance)
        {
            string translatedText = StringStore.TranslateText(__instance.title.text);
            __instance.title.text = translatedText;
            __instance.title2.text = translatedText;
        }
    }
}
