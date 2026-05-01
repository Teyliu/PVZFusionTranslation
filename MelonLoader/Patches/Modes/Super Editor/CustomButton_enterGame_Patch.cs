using HarmonyLib;
using Il2Cpp;
using Il2CppGameLevel;
using PvZ_Fusion_Translator.AssetStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor
{
    [HarmonyPatch(typeof(CustomButton_enterGame))]
    public static class CustomButton_enterGame_Patch
    {
        [HarmonyPatch(nameof(CustomButton_enterGame.LoadOnlineLevelAsync))]
        [HarmonyPostfix]
        public static void LoadOnlineLevelAsync(CustomButton_enterGame __instance)
        {
            Dictionary<string, TranslatedLevelData> dumpData = new Dictionary<string, TranslatedLevelData>();

            var level = __instance;

            if(level.onlineLevelInfo != null)
            {
                string levelId = level.onlineLevelInfo.levelId;
                if(levelId != null)
                {
                    if(CustomLevelMenu_Patch.translatedLevelData.ContainsKey(levelId))
                    {
                        TranslatedLevelData levelData = CustomLevelMenu_Patch.translatedLevelData[levelId];
                        level.levelName.text = levelData.name;
                        level.serializedLevel.name = levelData.name;
                        level.serializedLevel.boardConfig.startTip = levelData.startTip;
                    }
                    else
                    {
                        TranslatedLevelData dumpedLevelData = new TranslatedLevelData(level.levelData.Name, level.serializedLevel.boardConfig.startTip);
                        dumpData.Add(levelId, dumpedLevelData);
                    }
                }
            }
            else
            {
                level.levelName.text = StringStore.TranslateText(level.levelData.Name);
            }

            string dumpPath = Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Dumps), "custom_level_data.json");
            File.WriteAllText(dumpPath, System.Text.Json.JsonSerializer.Serialize(dumpData, new JsonSerializerOptions
			{
				WriteIndented = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			}));
        }
    }
}
