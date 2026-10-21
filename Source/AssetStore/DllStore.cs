#if false
using System.Diagnostics;

namespace PvZ_Fusion_Translator.AssetStore;

public static class DllStore
{
    public static readonly Dictionary<string, byte[]> DLLData = new()
    {
        { "Blooms_QOL.dll", null },
        { "PvZ_Fusion_Translator.dll", null },
    };

    public static bool UpdateOnClose { get; set; }

    public static void Init(string gameVersion) => TryGetNewDll(gameVersion);

    public static void TryGetNewDll(string gameVersion)
    {
        var ableToUpdate = true;
        var unableReason = "";

        var getGameVersionRequest = Utils.GetDataFromWeb(
                "https://raw.githubusercontent.com/SillyStar-Github/PvZF-Translation-DLLs/refs/heads/main/CURRENT_GAME_VER"
            )
           .Result;

        if (getGameVersionRequest != null)
        {
            Log.LogDebug(
                $"Requst game version: {getGameVersionRequest} -> {Utils.CalculateGameVersion(getGameVersionRequest)}"
            );

            Log.LogDebug($"This game version: {gameVersion} -> {Utils.CalculateGameVersion(gameVersion)}");

            if (Utils.CalculateGameVersion(getGameVersionRequest) != Utils.CalculateGameVersion(gameVersion))
            {
                ableToUpdate = false;
                unableReason = "Incorrect game version...";
            }
        }
        else
        {
            ableToUpdate = false;
            unableReason = "Couldn't get latest game version info...";
        }

        if (ableToUpdate)
            foreach (var key in DLLData.Keys)
            {
                var newDllRequest = Utils.GetByteDataFromWeb(
                        $"https://raw.githubusercontent.com/SillyStar-Github/PvZF-Translation-DLLs/refs/heads/main/{key}"
                    )
                   .Result;

                if (newDllRequest != null)
                {
                    DLLData[key] = newDllRequest;
                    SaveNewDll(key);
                }
                else
                    Log.LogError($"Couldn't get latest {key} data!");
            }
        else
            Log.LogError($"Unable to update! {unableReason}");
    }

    public static void SaveNewDll(string name)
    {
        var newDllData = DLLData[name];

        if (newDllData == null)
            return;

        var basePath = MelonEnvironment.ModsDirectory;
        var toSavePath = Path.Combine(basePath, name + ".update");
        File.WriteAllBytes(toSavePath, newDllData);
    }

    public static void UpdateNewDll()
    {
        UpdateOnClose = DLLData.Any(pair => pair.Value is not null);

        if (!UpdateOnClose)
        {
            Log.LogError("Cannot update on close! All .dll data is null!");
            return;
        }

        var assembly = Core.Instance.MelonAssembly.Assembly;
        const string ProgramName = "PvZ_Fusion_Translator.Resources.ModUpdateUtil.exe";

        using var exeResourceStream = assembly.GetManifestResourceStream(ProgramName);
        var tempPath = Path.Combine(MelonEnvironment.ModsDirectory, "ModUpdateUtil.exe");

        // ReSharper disable once PossibleNullReferenceException
        using (var fileStream = File.Create(tempPath))
            exeResourceStream.CopyTo(fileStream);

        Process.Start(
            new ProcessStartInfo
            {
                FileName = tempPath,
                Arguments =
                    $"{Environment.ProcessId} {string.Join(",", DLLData.Keys)} \"{MelonEnvironment.ModsDirectory}\"",
                UseShellExecute = true,
            }
        );
    }
}
#endif
