using HarmonyLib;
using Newtonsoft.Json;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor;

[HarmonyPatch(typeof(CustomLevelMenu))]
public static class CustomLevelMenu_Patch
{
#pragma warning disable CA2211
    public static float RequestTimer;

    public static Dictionary<string, TranslatedLevelData> TranslatedLevelData = new();
#pragma warning restore CA2211
    [HarmonyPatch(nameof(CustomLevelMenu.LoadOnlineFiles)), HarmonyPostfix]
    public static void LoadOnlineFiles(CustomLevelMenu __instance)
    {
        if (!Core.Instance.ConfigUseLocal.Value)
            LoadOnlineData();
        else
            LoadLocalData();
    }

    [HarmonyPatch(nameof(CustomLevelMenu.InitLocalWindows)), HarmonyPostfix]
    public static void InitWindows(CustomLevelMenu __instance) => TranslateLevelButtons(__instance);

    [HarmonyPatch(nameof(CustomLevelMenu.InitOnlineWindow)), HarmonyPostfix]
    public static void InitOnlineWindow(CustomLevelMenu __instance) => TranslateLevelButtons(__instance);

    [HarmonyPatch(nameof(CustomLevelMenu.ReloadFiles)), HarmonyPostfix]
    public static void ReloadFiles(CustomLevelMenu __instance) => TranslateLevelButtons(__instance);

    public static void TranslateLevelButtons(CustomLevelMenu __instance)
    {
        var dumpPath = Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Dumps), "custom_level_data.json");
        var dumpData = new Dictionary<string, TranslatedLevelData>();

        if (!File.Exists(dumpPath))
            File.WriteAllText(
                dumpPath,
                System.Text.Json.JsonSerializer.Serialize(
                    dumpData,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    }
                )
            );

        foreach (var level in __instance.levels)
            if (level.onlineLevelInfo != null)
            {
                var levelId = level.onlineLevelInfo.levelId;

                if (levelId == null)
                    continue;

                if (TranslatedLevelData.TryGetValue(levelId, out var levelData))
                {
                    level.levelName.text = levelData.Name;
                    level.serializedLevel.name = levelData.Name;
                    level.serializedLevel.boardConfig.startTip = levelData.StartTip;
                }
                else
                {
                    var dumpedLevelData = new TranslatedLevelData(
                        level.onlineLevelInfo.levelName,
                        level.serializedLevel.boardConfig.startTip
                    );

                    dumpData.Add(levelId, dumpedLevelData);
                }
            }
            else
                level.levelName.text = StringStore.TranslateText(level.levelName.text);

        File.WriteAllText(
            dumpPath,
            System.Text.Json.JsonSerializer.Serialize(
                dumpData,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                }
            )
        );
    }

    public static async Task<Dictionary<string, TranslatedLevelData>> GetTranslatedLevelData()
    {
        var levelDataString = await Utils.GetDataFromWeb(
            $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Strings/custom_level_data.json"
        );

        if (levelDataString != null)
        {
            var levelDataJson = JsonConvert.DeserializeObject<Dictionary<string, TranslatedLevelData>>(levelDataString);
            return levelDataJson;
        }

        new CancellationTokenSource().Cancel();
        return null;
    }

    public static void LoadOnlineData()
    {
        if (RequestTimer > 0)
        {
            Log.LogInfo(
                $"Please wait before requesting levels again! Current cooldown: {Math.Round(RequestTimer, 3)}s"
            );

            return;
        }

        // 5 seconds between request attempts to prevent any issues with GitHub
        RequestTimer = 5f;
        TranslatedLevelData = new();

        var translatedLevelDataRequest = Task.Run(GetTranslatedLevelData);

        if (translatedLevelDataRequest.Result == null)
        {
            Log.LogError($"Couldn't find level data for {Utils.Language}!");
            return;
        }

        TranslatedLevelData = translatedLevelDataRequest.Result;
        Log.LogInfo($"Successfully loaded level data for {Utils.Language}!");
    }

    public static void LoadLocalData()
    {
        TranslatedLevelData = new();

        var assetDir = Path.Combine(
            FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language),
            "custom_level_data.json"
        );

        if (!File.Exists(assetDir))
        {
            File.CreateText(assetDir);
            File.WriteAllText(assetDir, "{}");
        }

        var levelDataString = File.ReadAllText(assetDir);
        var levelDataJson = JsonConvert.DeserializeObject<Dictionary<string, TranslatedLevelData>>(levelDataString);
        TranslatedLevelData = levelDataJson;
    }
}

public sealed class TranslatedLevelData(string name, string startTip)
{
    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public string Name { get; set; } = name;

    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public string StartTip { get; set; } = startTip;
}
