using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor.GameLevel;

[HarmonyPatch(typeof(LevelManager))]
public static class LevelManager_Patch
{
    [HarmonyPatch(nameof(LevelManager.SaveLevelData)), HarmonyPrefix]
    public static void Pre_SaveLevelData(LevelManager __instance, ref SerializedLevelData serializedLevelData)
    {
        if (serializedLevelData.name == "未命名关卡")
            serializedLevelData.name = StringStore.TranslationString.ContainsKey("LEVEL_UNNAMED")
                ? StringStore.TranslateText("LEVEL_UNNAMED")
                : "Unnamed";
    }

    public static void ExportLevelStrings(SerializedLevelData serializedLevelData)
    {
        var levelDataString = JsonUtility.ToJson(serializedLevelData);
        var referenceLevelData = Newtonsoft.Json.JsonConvert.DeserializeObject<ReferenceLevelData>(levelDataString);
        var eventNodeGraph = serializedLevelData.eventNodeGraph;
        eventNodeGraph.BuildCache();

        var stringValueNodeIds = new List<string>();
        var stringConcatNodeIds = new List<string>();
        var showTextNodeIds = new List<string>();
        var addOptionNodeIds = new List<string>();

        foreach (var reference in referenceLevelData.References.RefIds)
        {
            var nodeType = reference.Data.NodeType;
            var nodeId = reference.Data.NodeId;

            switch (nodeType)
            {
                case "ShowTextNode":
                    if (!showTextNodeIds.Contains(nodeId))
                        showTextNodeIds.Add(nodeId);

                    break;
                case "AddMultipleChoiceOptionNode":
                    if (!addOptionNodeIds.Contains(nodeId))
                        addOptionNodeIds.Add(nodeId);

                    break;
            }
        }

        foreach (var reference in referenceLevelData.References.RefIds)
        {
            var nodeType = reference.Data.NodeType;
            var nodeId = reference.Data.NodeId;

            switch (nodeType)
            {
                case "StringValueNode":
                case "FloatToStringNode":
                case "StringConcatNode":
                    stringValueNodeIds.Add(nodeId);

                    if (nodeType == "StringConcatNode")
                        stringConcatNodeIds.Add(nodeId);

                    break;
            }
        }

        Dictionary<string, ValueTuple<string, string>> stringConcatNodePairs = new();

        foreach (var connection in eventNodeGraph.connections)
        {
            var sourceNodeId = connection.sourceNodeId;
            _ = connection.sourcePortName;
            var targetNodeId = connection.targetNodeId;
            var targetPortName = connection.targetPortName;

            if (!stringValueNodeIds.Contains(sourceNodeId))
                continue;

            if (!stringConcatNodeIds.Contains(targetNodeId))
                continue;

            if (stringConcatNodePairs.ContainsKey(targetNodeId))
            {
                var temp = stringConcatNodePairs[targetNodeId];

                switch (targetPortName)
                {
                    case "A":
                        temp.Item1 = sourceNodeId;
                        stringConcatNodePairs[targetNodeId] = temp;
                        break;
                    case "B":
                        temp.Item2 = sourceNodeId;
                        stringConcatNodePairs[targetNodeId] = temp;
                        break;
                }
            }
            else
            {
                stringConcatNodePairs.Add(targetNodeId, new());
                var temp = stringConcatNodePairs[targetNodeId];

                switch (targetPortName)
                {
                    case "A":
                        temp.Item1 = sourceNodeId;
                        stringConcatNodePairs[targetNodeId] = temp;
                        break;
                    case "B":
                        temp.Item2 = sourceNodeId;
                        stringConcatNodePairs[targetNodeId] = temp;
                        break;
                }
            }
        }

        string GetStringNodeValue(EventNodeBase eventNodeBase)
        {
            var stringValue = "";

            switch (eventNodeBase.nodeType)
            {
                case "StringValueNode":
                    var stringNode = eventNodeBase.Cast<StringValueNode>();
                    stringValue = stringNode.value;
                    break;
                case "FloatToStringNode":
                    stringValue = "([^\\s]+)";
                    break;
                case "StringConcatNode":
                    var stringConcatNode = eventNodeBase.Cast<StringConcatNode>();
                    stringConcatNode.InitializeConnections(eventNodeGraph);

                    stringValue = GetStringNodeValue(stringConcatNode.aSourceNode) +
                        GetStringNodeValue(stringConcatNode.bSourceNode);

                    break;
            }

            return stringValue;
        }

        var baseDumpDir = FileLoader.GetAssetDir(FileLoader.AssetType.Dumps);
        var levelDumpDir = Path.Combine(baseDumpDir, "CustomLevels.json");

        if (!File.Exists(levelDumpDir))
            File.WriteAllText(levelDumpDir, "{}");

        var dump = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(levelDumpDir));

        foreach (var showTextNode in showTextNodeIds
           .Select(showTextNodeId => eventNodeGraph.GetNodeById(showTextNodeId).Cast<ShowTextNode>()))
        {
            showTextNode.InitializeConnections(eventNodeGraph);
            var value = GetStringNodeValue(showTextNode.textSourceNode);
            dump.TryAdd(value, value);
        }

        foreach (var addOptionNode in addOptionNodeIds.Select(
            addOptionId => eventNodeGraph.GetNodeById(addOptionId).Cast<AddMultipleChoiceOptionNode>()
        ))
        {
            addOptionNode.InitializeConnections(eventNodeGraph);
            var titleValue = GetStringNodeValue(addOptionNode.titleSourceNode);
            dump.TryAdd(titleValue, titleValue);
            var descriptionValue = GetStringNodeValue(addOptionNode.descriptionSourceNode);
            dump.TryAdd(descriptionValue, descriptionValue);
        }

        File.WriteAllText(
            levelDumpDir,
            JsonSerializer.Serialize(
                dump,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                }
            )
        );
    }

    // Reference level data classes.
    public sealed class ReferenceLevelData
    {
        public References References { get; set; }
    }

    // ReSharper disable once ClassNeverInstantiated.Global
    public sealed class Data
    {
        public string NodeId { get; set; }

        public string NodeType { get; set; }

        public Position Position { get; set; }

        public string NodeName { get; set; }

        public string PlantPortName { get; set; }

        public string ColumnPortName { get; set; }

        public string RowPortName { get; set; }

        public string PlantTypePortName { get; set; }

        public object Value { get; set; }

        public string ValuePortName { get; set; }

        public string PlantTypeAPortName { get; set; }

        public string PlantTypeBPortName { get; set; }

        public string EqualPortName { get; set; }

        public string TriggerPortName { get; set; }

        public string CountPortName { get; set; }

        public string OutputPortName { get; set; }

        public string IndexPortName { get; set; }

        public string PlantsPortName { get; set; }

        public string PlantListPortName { get; set; }

        public string LoopBodyPortName { get; set; }

        public string CurrentPlantPortName { get; set; }

        public string CurrentIndexPortName { get; set; }

        public string OnCompletedPortName { get; set; }

        public string ConditionPortName { get; set; }

        public string ThenPortName { get; set; }

        public string ElsePortName { get; set; }

        public string APortName { get; set; }

        public string BPortName { get; set; }

        public string ResultPortName { get; set; }

        public string ShouldResetPortName { get; set; }

        public string OnCountPortName { get; set; }

        public int? StartValue { get; set; }

        public string ValueAPortName { get; set; }

        public string ValueBPortName { get; set; }

        public string GreaterPortName { get; set; }

        public string LessPortName { get; set; }

        public string DisplayText { get; set; }

        public double? Duration { get; set; }

        public string TextPortName { get; set; }

        public string DurationPortName { get; set; }

        public string INTPortName { get; set; }

        public string FloatPortName { get; set; }
    }

    // ReSharper disable once ClassNeverInstantiated.Global
    public sealed class Position
    {
        public double X { get; set; }

        public double Y { get; set; }
    }

    // ReSharper disable once ClassNeverInstantiated.Global
    public sealed class References
    {
        public int Version { get; set; }

        // ReSharper disable once CollectionNeverUpdated.Global
        public List<RefId> RefIds { get; set; }
    }

    // ReSharper disable once ClassNeverInstantiated.Global
    public sealed class RefId
    {
        public int Rid { get; set; }

        public Type Type { get; set; }

        public Data Data { get; set; }
    }

    // ReSharper disable once ClassNeverInstantiated.Global
    public sealed class Type
    {
        public string Class { get; set; }

        public string Ns { get; set; }

        public string ASM { get; set; }
    }
}
