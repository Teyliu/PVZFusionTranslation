using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor;

[HarmonyPatch(typeof(CustomButton_enterGame))]
public static class CustomButtonEnterGamePatch
{
    [HarmonyPatch(nameof(CustomButton_enterGame.LoadOnlineLevelAsync)), HarmonyPostfix]
    public static void LoadOnlineLevelAsync(CustomButton_enterGame __instance)
    {
        var dumpPath = Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Dumps), "custom_level_data.json");
        var dumpData = new Dictionary<string, TranslatedLevelData>();

        if (!File.Exists(dumpPath))
            File.WriteAllText(
                dumpPath,
                JsonSerializer.Serialize(
                    dumpData,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    }
                )
            );

        dumpData = JsonSerializer.Deserialize<Dictionary<string, TranslatedLevelData>>(File.ReadAllText(dumpPath));

        var dumpStringsPath = Path.Combine(
            FileLoader.GetAssetDir(FileLoader.AssetType.Dumps),
            "custom_level_strings.json"
        );

        var dumpStringsData = new Dictionary<string, string>();

        if (!File.Exists(dumpStringsPath))
            File.WriteAllText(
                dumpStringsPath,
                JsonSerializer.Serialize(
                    dumpStringsData,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    }
                )
            );

        dumpStringsData = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(dumpStringsPath));

        if (__instance.onlineLevelInfo != null)
        {
            var levelId = __instance.onlineLevelInfo.levelId;

            if (levelId != null)
            {
                var serializedLevel = __instance.serializedLevel;

                if (CustomLevelMenu_Patch.TranslatedLevelData.TryGetValue(levelId, out var levelData))
                {
                    __instance.levelName.text = levelData.Name;
                    serializedLevel.name = levelData.Name;
                    serializedLevel.boardConfig.startTip = levelData.StartTip;
                }
                else
                {
                    var dumpedLevelData = new TranslatedLevelData(
                        __instance.onlineLevelInfo.levelName,
                        serializedLevel.boardConfig.startTip
                    );

                    dumpData[levelId] = dumpedLevelData;
                }

                // foreach(var _ in level.levelData.SerializedLevelData)
            }
        }
        else
            __instance.levelName.text = StringStore.TranslateText(__instance.levelName.text);

        File.WriteAllText(
            dumpPath,
            JsonSerializer.Serialize(
                dumpData,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                }
            )
        );

        File.WriteAllText(
            dumpStringsPath,
            JsonSerializer.Serialize(
                dumpStringsData,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                }
            )
        );
    }
}
