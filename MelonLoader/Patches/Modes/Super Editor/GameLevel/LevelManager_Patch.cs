using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Il2Cpp;
using Il2CppGameLevel;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor.GameLevel
{
    [HarmonyPatch(typeof(LevelManager))]
    public static class LevelManager_Patch
    {
        [HarmonyPatch(nameof(LevelManager.SaveLevelData))]
        [HarmonyPrefix]
        public static void Pre_SaveLevelData(LevelManager __instance, ref SerializedLevelData serializedLevelData)
        {
            if(serializedLevelData.name == "未命名关卡")
            {
                serializedLevelData.name = StringStore.translationString.ContainsKey("LEVEL_UNNAMED") ? StringStore.TranslateText("LEVEL_UNNAMED") : "Unnamed";
            }
        }
    }
}
