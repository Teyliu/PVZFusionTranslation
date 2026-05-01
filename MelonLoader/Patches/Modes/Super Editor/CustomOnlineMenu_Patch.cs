using HarmonyLib;
using Il2Cpp;
using Il2CppGameLevel;
using Il2CppTMPro;
using MelonLoader;
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

            TranslateLevelData(__instance.levelData);
        }
        
        public static void TranslateLevelData(CustomLevelData levelData)
        {
            Dictionary<string, TranslatedLevelData> dumpData = new Dictionary<string, TranslatedLevelData>();

            if(levelData != null)
            {
                string levelId = levelData.levelId;
                if(levelId != null)
                {
                    if(CustomLevelMenu_Patch.translatedLevelData.ContainsKey(levelId))
                    {
                        TranslatedLevelData translatedLevelData = CustomLevelMenu_Patch.translatedLevelData[levelId];
                        levelData.Name = translatedLevelData.name;
                        levelData.SerializedLevelData.name = translatedLevelData.name;
                        levelData.SerializedLevelData.boardConfig.startTip = translatedLevelData.startTip;
                    }
                    else
                    {
                        TranslatedLevelData dumpedLevelData = new TranslatedLevelData(levelData.Name, levelData.SerializedLevelData.boardConfig.startTip);
                        dumpData.Add(levelId, dumpedLevelData);
                    }
                }
            }
            else
            {
                levelData.Name = StringStore.TranslateText(levelData.Name);
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
