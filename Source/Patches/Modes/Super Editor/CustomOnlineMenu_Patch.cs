using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor;

[HarmonyPatch(typeof(CustomOnlineMenu))]
public static class CustomOnlineMenu_Patch
{
    [HarmonyPatch(nameof(CustomOnlineMenu.EditLevel)), HarmonyPostfix]
    public static void EditLevel(CustomOnlineMenu __instance) => TranslateLevelName(__instance);

    [HarmonyPatch(nameof(CustomOnlineMenu.Start)), HarmonyPostfix]
    public static void Start(CustomOnlineMenu __instance) => TranslateLevelName(__instance);

    public static void TranslateLevelName(CustomOnlineMenu __instance)
    {
        var translatedText = StringStore.TranslateText(__instance.title.text);
        __instance.title.text = translatedText;
        __instance.title2.text = translatedText;

        TranslateLevelData(__instance.levelData);
    }

    public static void TranslateLevelData(CustomLevelData levelData)
    {
        var dumpData = new Dictionary<string, TranslatedLevelData>();

        if (levelData != null)
        {
            var levelId = levelData.levelId;

            if (levelId != null)
            {
                if (CustomLevelMenu_Patch.TranslatedLevelData.TryGetValue(levelId, out var translatedLevelData))
                {
                    levelData.Name = translatedLevelData.Name;
                    levelData.SerializedLevelData.name = translatedLevelData.Name;
                    levelData.SerializedLevelData.boardConfig.startTip = translatedLevelData.StartTip;
                }
                else
                {
                    var dumpedLevelData = new TranslatedLevelData(
                        levelData.Name,
                        levelData.SerializedLevelData.boardConfig.startTip
                    );

                    dumpData.Add(levelId, dumpedLevelData);
                }
            }
        }
        else
            levelData.Name = StringStore.TranslateText(levelData.Name);

        var dumpPath = Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Dumps), "custom_level_data.json");

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
    }
}
