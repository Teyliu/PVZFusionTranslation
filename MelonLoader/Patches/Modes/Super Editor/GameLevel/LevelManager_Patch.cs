using HarmonyLib;
using Il2Cpp;
using Il2CppGameLevel;
using Il2CppGameLevel.EventNodes;
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

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor.GameLevel
{
    [HarmonyPatch(typeof(LevelManager))]
    public static class LevelManager_Patch
    {
        [HarmonyPatch(nameof(LevelManager.SaveLevelData))]
        [HarmonyPrefix]
        public static void Pre_SaveLevelData(LevelManager __instance, ref SerializedLevelData serializedLevelData)
        {
            if (serializedLevelData.name == "未命名关卡")
            {
                serializedLevelData.name = StringStore.translationString.ContainsKey("LEVEL_UNNAMED") ? StringStore.TranslateText("LEVEL_UNNAMED") : "Unnamed";
            }
        }
        
        public static void ExportLevelStrings(SerializedLevelData serializedLevelData)
        {
            string levelDataString = JsonUtility.ToJson(serializedLevelData);
            ReferenceLevelData referenceLevelData = Newtonsoft.Json.JsonConvert.DeserializeObject<ReferenceLevelData>(levelDataString);
            EventNodeGraph eventNodeGraph = serializedLevelData.eventNodeGraph;
            eventNodeGraph.BuildCache();
            
            List<string> stringValueNodeIds = new List<string>();
            List<string> stringConcatNodeIds = new List<string>();
            List<string> showTextNodeIds = new List<string>();
            List<string> addOptionNodeIds = new List<string>();

            foreach (var reference in referenceLevelData.references.RefIds)
            {
                string nodeType = reference.data.nodeType;
                string nodeId = reference.data.nodeId;

                if (nodeType == "ShowTextNode")
                {
                    if(!showTextNodeIds.Contains(nodeId))
                    {
                        showTextNodeIds.Add(nodeId);
                    }
                }
                else if (nodeType == "AddMultipleChoiceOptionNode")
                {
                    if(!addOptionNodeIds.Contains(nodeId))
                    {
                        addOptionNodeIds.Add(nodeId);
                    }
                }
            }

            foreach (var reference in referenceLevelData.references.RefIds)
            {
                string nodeType = reference.data.nodeType;
                string nodeId = reference.data.nodeId;

                switch(nodeType)
                {
                    case "StringValueNode":
                    case "FloatToStringNode":
                    case "StringConcatNode":
                        stringValueNodeIds.Add(nodeId);
                        if(nodeType == "StringConcatNode")
                        {
                            stringConcatNodeIds.Add(nodeId);
                        }
                        break;
                    default:
                        break;
                }
            }

            Dictionary<string, ValueTuple<string, string>> stringConcatNodePairs = new();

            foreach(var connection in eventNodeGraph.connections)
            {
                string sourceNodeId = connection.sourceNodeId;
                string sourcePortName = connection.sourcePortName;
                string targetNodeId = connection.targetNodeId;
                string targetPortName = connection.targetPortName;

                if(stringValueNodeIds.Contains(sourceNodeId))
                {
                    if(stringConcatNodeIds.Contains(targetNodeId))
                    {
                        if(stringConcatNodePairs.ContainsKey(targetNodeId))
                        {
                            ValueTuple<string, string> temp = stringConcatNodePairs[targetNodeId];
                            switch(targetPortName)
                            {
                                case "A":
                                    temp.Item1 = sourceNodeId;
                                    stringConcatNodePairs[targetNodeId] = temp;
                                    break;
                                case "B":
                                    temp.Item2 = sourceNodeId;
                                    stringConcatNodePairs[targetNodeId] = temp;
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            stringConcatNodePairs.Add(targetNodeId, new ValueTuple<string, string>());
                            ValueTuple<string, string> temp = stringConcatNodePairs[targetNodeId];
                            switch(targetPortName)
                            {
                                case "A":
                                    temp.Item1 = sourceNodeId;
                                    stringConcatNodePairs[targetNodeId] = temp;
                                    break;
                                case "B":
                                    temp.Item2 = sourceNodeId;
                                    stringConcatNodePairs[targetNodeId] = temp;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }

            string GetStringNodeValue(EventNodeBase eventNodeBase)
            {
                string stringValue = "";

                switch(eventNodeBase.nodeType)
                {
                    case "StringValueNode":
                        StringValueNode stringNode = eventNodeBase.TryCast<StringValueNode>();
                        stringValue = stringNode.value;
                        break;
                    case "FloatToStringNode":
                        stringValue = "([^\\s]+)";
                        break;
                    case "StringConcatNode":
                        StringConcatNode stringConcatNode = eventNodeBase.TryCast<StringConcatNode>();
                        stringConcatNode.InitializeConnections(eventNodeGraph);
                        stringValue = GetStringNodeValue(stringConcatNode.aSourceNode) + GetStringNodeValue(stringConcatNode.bSourceNode);
                        break;
                    default:
                        break;
                }

                return stringValue;
            }

            string baseDumpDir = FileLoader.GetAssetDir(FileLoader.AssetType.Dumps);
            string levelDumpDir = Path.Combine(baseDumpDir, "CustomLevels.json");
            if (!File.Exists(levelDumpDir)) File.WriteAllText(levelDumpDir, "{}");
            Dictionary<string, string> dump = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(levelDumpDir));

            foreach(string showTextNodeId in showTextNodeIds)
            {
                ShowTextNode showTextNode = eventNodeGraph.GetNodeById(showTextNodeId).TryCast<ShowTextNode>();
                showTextNode.InitializeConnections(eventNodeGraph);
                string value = GetStringNodeValue(showTextNode.textSourceNode);
                if (!dump.ContainsKey(value))
                {
                    dump.Add(value, value);
                }
            }

            foreach(string addOptionId in addOptionNodeIds)
            {
                AddMultipleChoiceOptionNode addOptionNode = eventNodeGraph.GetNodeById(addOptionId).TryCast<AddMultipleChoiceOptionNode>();
                addOptionNode.InitializeConnections(eventNodeGraph);
                string titleValue = GetStringNodeValue(addOptionNode.titleSourceNode);
                if (!dump.ContainsKey(titleValue))
                {
                    dump.Add(titleValue, titleValue);
                }
                string descriptionValue = GetStringNodeValue(addOptionNode.descriptionSourceNode);
                if (!dump.ContainsKey(descriptionValue))
                {
                    dump.Add(descriptionValue, descriptionValue);
                }
            }

            File.WriteAllText(levelDumpDir, JsonSerializer.Serialize(dump, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            }));
        }

        // reference level data classes

        public class ReferenceLevelData
        {
            public References references { get; set; }
        }

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
    }
}
