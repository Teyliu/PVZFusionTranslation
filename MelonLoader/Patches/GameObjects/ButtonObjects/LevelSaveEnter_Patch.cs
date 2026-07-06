using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
    public static class LevelSaveEnter_Patch
    {
        public static void TranslateEnter(LevelSaveEnter __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            __instance.text.text = StringStore.TranslateText(__instance.text.text);
            __instance.text.font = fontAsset;
        }
    }
}
