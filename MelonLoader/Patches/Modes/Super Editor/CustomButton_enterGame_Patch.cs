using HarmonyLib;
using Il2Cpp;
using Il2CppGameLevel;
using Il2CppGameLevel.EventNodes;
using PvZ_Fusion_Translator.AssetStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UIElements;

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

                    /*level.levelData.SerializedLevelData
                    foreach()*/
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

    /*[HarmonyPatch(typeof(LevelManager))]
    public static class Test
    {
        [HarmonyPatch(nameof(LevelManager.SaveLevelData))]
        [HarmonyPostfix]
        public static void SaveLevelData(LevelManager __instance, ref SerializedLevelData serializedLevelData)
        {
            Log.LogDebug("hi 2");
            string json = JsonUtility.ToJson(serializedLevelData);
            ReferenceLevelData references = Newtonsoft.Json.JsonConvert.DeserializeObject<ReferenceLevelData>(json);
            foreach(var reference in references.references.RefIds)
            {
                ReferenceLevelData.Data nodeData = reference.data;
                string nodeType = nodeData.nodeType;

                if(nodeType == "StringConcatNode")
                {
                    Log.LogDebug(nodeData.value.ToString());
                }

                if(nodeType == "StringValueNode")
                {
                    Log.LogDebug(nodeData.value.ToString());
                }
            }
        }
    }

    

    public class ReferenceLevelData
    {
        public class Data
        {
            public string nodeId { get; set; }
            public string nodeType { get; set; }
            public Position position { get; set; }
            public string nodeName { get; set; }
            public string plant_PortName { get; set; }
            public string column_PortName { get; set; }
            public string row_PortName { get; set; }
            public string plantType_PortName { get; set; }
            public object value { get; set; }
            public string value_PortName { get; set; }
            public string plantTypeA_PortName { get; set; }
            public string plantTypeB_PortName { get; set; }
            public string equal_PortName { get; set; }
            public string trigger_PortName { get; set; }
            public string count_PortName { get; set; }
            public string output_PortName { get; set; }
            public string index_PortName { get; set; }
            public string plants_PortName { get; set; }
            public string plantList_PortName { get; set; }
            public string loopBody_PortName { get; set; }
            public string currentPlant_PortName { get; set; }
            public string currentIndex_PortName { get; set; }
            public string onCompleted_PortName { get; set; }
            public string condition_PortName { get; set; }
            public string then_PortName { get; set; }
            public string else_PortName { get; set; }
            public string a_PortName { get; set; }
            public string b_PortName { get; set; }
            public string result_PortName { get; set; }
            public string shouldReset_PortName { get; set; }
            public string onCount_PortName { get; set; }
            public int? startValue { get; set; }
            public string valueA_PortName { get; set; }
            public string valueB_PortName { get; set; }
            public string greater_PortName { get; set; }
            public string less_PortName { get; set; }
            public string displayText { get; set; }
            public double? duration { get; set; }
            public string text_PortName { get; set; }
            public string duration_PortName { get; set; }
            public string int_PortName { get; set; }
            public string float_PortName { get; set; }
        }

        public class GodShootingConfig
        {
            public List<object> plants { get; set; }
        }

        public class Position
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class References
        {
            public int version { get; set; }
            public List<RefId> RefIds { get; set; }
        }

        public class RefId
        {
            public int rid { get; set; }
            public Type type { get; set; }
            public Data data { get; set; }
        }

        public class Type
        {
            public string @class { get; set; }
            public string ns { get; set; }
            public string asm { get; set; }
        }

        public class ZombiesWithRow
        {
            public int zombieType { get; set; }
            public int row { get; set; }
        }

        public EventNodeGraph eventNodeGraph { get; set; }
        public References references { get; set; }
    }*/
}