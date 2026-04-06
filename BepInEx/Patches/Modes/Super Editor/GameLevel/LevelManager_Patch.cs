using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Super_Editor.GameLevel
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
