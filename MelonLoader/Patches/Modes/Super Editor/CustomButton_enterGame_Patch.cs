using HarmonyLib;
using Il2Cpp;
using Il2CppGameLevel;
using PvZ_Fusion_Translator.AssetStore;
using System;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Json;
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
            string dumpPath = Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Dumps), "custom_level_data.json");
            Dictionary<string, TranslatedLevelData> dumpData = new Dictionary<string, TranslatedLevelData>();

            if (!File.Exists(dumpPath))
            {
                File.WriteAllText(dumpPath, System.Text.Json.JsonSerializer.Serialize(dumpData, new JsonSerializerOptions
			    {
				    WriteIndented = true,
				    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			    }));
            }

            dumpData = JsonSerializer.Deserialize<Dictionary<string, TranslatedLevelData>>(File.ReadAllText(dumpPath));

            string dumpStringsPath = Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Dumps), "custom_level_strings.json");
            Dictionary<string, string> dumpStringsData = new Dictionary<string, string>();

            if (!File.Exists(dumpStringsPath))
            {
                File.WriteAllText(dumpStringsPath, System.Text.Json.JsonSerializer.Serialize(dumpStringsData, new JsonSerializerOptions
			    {
				    WriteIndented = true,
				    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			    }));
            }

            dumpStringsData = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(dumpStringsPath));

            var level = __instance;

            if(level.onlineLevelInfo != null)
            {
                string levelId = level.onlineLevelInfo.levelId;
                if(levelId != null)
                {
                    SerializedLevelData serializedLevel = level.serializedLevel;
                    if(CustomLevelMenu_Patch.translatedLevelData.ContainsKey(levelId))
                    {
                        TranslatedLevelData levelData = CustomLevelMenu_Patch.translatedLevelData[levelId];
                        level.levelName.text = levelData.name;
                        serializedLevel.name = levelData.name;
                        serializedLevel.boardConfig.startTip = levelData.startTip;
                    }
                    else
                    {
                        TranslatedLevelData dumpedLevelData = new TranslatedLevelData(level.onlineLevelInfo.levelName, serializedLevel.boardConfig.startTip);
                        dumpData.Add(levelId, dumpedLevelData);
                    }
                }
            }
            else
            {
                level.levelName.text = StringStore.TranslateText(level.levelName.text);
            }

            File.WriteAllText(dumpPath, System.Text.Json.JsonSerializer.Serialize(dumpData, new JsonSerializerOptions
			{
				WriteIndented = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			}));
            File.WriteAllText(dumpStringsPath, System.Text.Json.JsonSerializer.Serialize(dumpStringsData, new JsonSerializerOptions
			{
				WriteIndented = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			}));
        }
    }
}
