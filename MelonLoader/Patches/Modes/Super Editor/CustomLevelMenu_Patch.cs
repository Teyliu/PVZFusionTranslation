using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using Newtonsoft.Json;
using PvZ_Fusion_Translator.AssetStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading.Tasks;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor
{
    [HarmonyPatch(typeof(CustomLevelMenu))]
    public static class CustomLevelMenu_Patch
    {
        public static Dictionary<string, TranslatedLevelData> translatedLevelData = new Dictionary<string, TranslatedLevelData>();
        public static float requestTimer = 0f;
        public static bool useLocal = false;

        [HarmonyPatch(nameof(CustomLevelMenu.LoadOnlineFiles))]
        [HarmonyPostfix]
        public static void LoadOnlineFiles(CustomLevelMenu __instance)
        {
            translatedLevelData = new Dictionary<string, TranslatedLevelData>();

            if (!useLocal)
            {
                LoadOnlineData();
            }
            else
            {
                LoadLocalData();
            }
        }

        [HarmonyPatch(nameof(CustomLevelMenu.InitWindows))]
        [HarmonyPostfix]
        public static void InitWindows(CustomLevelMenu __instance)
        {
            TranslateLevelButtons(__instance);
        }

        [HarmonyPatch(nameof(CustomLevelMenu.ReloadFiles))]
        [HarmonyPostfix]
        public static void ReloadFiles(CustomLevelMenu __instance)
        {
            TranslateLevelButtons(__instance);
        }

        public static void TranslateLevelButtons(CustomLevelMenu __instance)
        {
            Dictionary<string, TranslatedLevelData> dumpData = new Dictionary<string, TranslatedLevelData>();

            foreach(CustomButton_enterGame level in __instance.levels)
            {
                string levelId = level.levelData.levelId;
                if(levelId != null)
                {
                    if(translatedLevelData.ContainsKey(levelId))
                    {
                        TranslatedLevelData levelData = translatedLevelData[levelId];
                        level.levelName.text = levelData.name;
                        level.levelData.Name = levelData.name;
                        level.serializedLevel.boardConfig.startTip = levelData.startTip;
                    }
                    else
                    {
                        TranslatedLevelData dumpedLevelData = new TranslatedLevelData(level.levelData.Name, level.serializedLevel.boardConfig.startTip);
                        dumpData.Add(levelId, dumpedLevelData);
                    }
                }
                else
                {
                    level.levelName.text = StringStore.TranslateText(level.levelData.Name);
                }
            }

            string dumpPath = Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Dumps), "custom_level_data.json");
            File.WriteAllText(dumpPath, System.Text.Json.JsonSerializer.Serialize(dumpData, new JsonSerializerOptions
			{
				WriteIndented = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			}));
        }

        public static async System.Threading.Tasks.Task<Dictionary<string, TranslatedLevelData>> GetTranslatedLevelData()
        {
            var levelDataRequest = await new HttpClient().GetAsync($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Strings/custom_level_data.json");
            if(levelDataRequest.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string levelDataString = await levelDataRequest.Content.ReadAsStringAsync();
                Dictionary<string, TranslatedLevelData> levelDataJson = JsonConvert.DeserializeObject<Dictionary<string, TranslatedLevelData>>(levelDataString);
                return levelDataJson;
            }
            else
            {
                new CancellationTokenSource().Cancel();
                return null;
            }
        }

        public static void LoadOnlineData()
        {
            if (requestTimer <= 0)
                {
                    requestTimer = 5f; // 5 seconds in between request attempts to prevent any issues with github

                    var translatedLevelDataRequest = System.Threading.Tasks.Task.Run(() => GetTranslatedLevelData());

                    if (translatedLevelDataRequest.Result != null)
                    {
                        translatedLevelData = translatedLevelDataRequest.Result;
                        Log.LogInfo($"Successfully loaded level data for {Utils.Language.ToString()}!");
                    }
                    else
                    {
                        Log.LogError($"Couldn't find level data for {Utils.Language.ToString()}!");
                    }
                }
                else
                {
                    Log.LogInfo($"Please wait before requesting levels again! Current cooldown: {Math.Round(requestTimer, 3)}s");
                }
        }

        public static void LoadLocalData()
        {
            string assetDir = Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language), "custom_level_data.json");
            if (!File.Exists(assetDir))
            {
                File.CreateText(assetDir);
                File.WriteAllText(assetDir, "{}");
            }
            string levelDataString = File.ReadAllText(assetDir);
            Dictionary<string, TranslatedLevelData> levelDataJson = JsonConvert.DeserializeObject<Dictionary<string, TranslatedLevelData>>(levelDataString);
            translatedLevelData = levelDataJson;
        }

        public static void SwapLevelData()
        {
            useLocal = !useLocal;
        }
    }

    public class TranslatedLevelData
    {
        public string name { get; set; }
        public string startTip { get; set; }

        public TranslatedLevelData(string name, string startTip)
        {
            this.name = name;
            this.startTip = startTip;
        }
    }
}
