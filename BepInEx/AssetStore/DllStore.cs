using BepInEx;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace PvZ_Fusion_Translator__BepInEx_.AssetStore
{
    public static class DllStore
    {
        public static Dictionary<string, byte[]> dllData = new Dictionary<string, byte[]>()
        {
            // TODO: Add your DLL names here
            // { "YourMod.dll", null }
            {"PvZ_Fusion_Translator__BepInEx_.dll", null},
            {"AudioImportLib.BepInEx.dll", null }
        };
        public static bool updateOnClose = false;

        // TODO: Add your DLL repository URL here
        private const string DLL_REPO_BASE_URL = "https://raw.githubusercontent.com/TuanAnh2901/PvZF-Translation-DLLs/refs/heads/main"; // e.g., "https://raw.githubusercontent.com/YourName/YourRepo/main"
        private const string GAME_VERSION_URL = "https://raw.githubusercontent.com/TuanAnh2901/PvZF-Translation-DLLs/refs/heads/main/CURRENT_GAME_VER"; // e.g., "https://raw.githubusercontent.com/YourName/YourRepo/main/CURRENT_GAME_VER"

        public static void Init(string gameVersion) => TryGetNewDll(gameVersion);

        public static void TryGetNewDll(string gameVersion)
        {
            if (string.IsNullOrEmpty(DLL_REPO_BASE_URL))
            {
                Log.LogDebug("DllStore: DLL_REPO_BASE_URL not configured, skipping update check");
                return;
            }

            bool ableToUpdate = true;
            string unableReason = "";

            string getGameVersionRequest = null;
            try {
                getGameVersionRequest = Utils.GetDataFromWeb(GAME_VERSION_URL).Result;
            }
            catch (Exception ex)
            {
                Log.LogError($"DllStore: Couldn't get game version info - {ex.Message}");
            }

            if (getGameVersionRequest != null)
            {
                Log.LogDebug($"Request game version: {getGameVersionRequest} -> {Utils.CalculateGameVersion(getGameVersionRequest)}");
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
            {
                foreach (var key in dllData.Keys)
                {
                    byte[] newDllRequest = Utils.GetByteDataFromWeb($"{DLL_REPO_BASE_URL}/{key}").Result;
                    if (newDllRequest != null)
                    {
                        dllData[key] = newDllRequest;
                        SaveNewDll(key);
                    }
                    else
                    {
                        Log.LogError($"Couldn't get latest {key} data!");
                    }
                }
            }
            else
            {
                Log.LogError($"Unable to update! {unableReason}");
            }
        }

        public static void SaveNewDll(string name)
        {
            byte[] newDllData = dllData[name];
            if (newDllData != null)
            {
                // Save to BepInEx plugins folder with .update extension
                string basePath = Paths.PluginPath;
                string toSavePath = Path.Combine(basePath, name + ".update");
                File.WriteAllBytes(toSavePath, newDllData);
                Log.LogInfo($"DllStore: Saved {name} to {toSavePath}");
            }
        }

        public static void UpdateNewDll()
        {
            foreach (var pair in dllData)
            {
                if (pair.Value != null)
                {
                    updateOnClose = true;
                }
            }

            if (updateOnClose)
            {
                int processId = Process.GetCurrentProcess().Id;

                // Get the mod assembly to extract embedded resource
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                string programName = "PvZ_Fusion_Translator__BepInEx_.Resources.ModUpdateUtil.exe";

                // Try to get embedded resource
                using var exeResourceStream = assembly.GetManifestResourceStream(programName);
                
                string tempPath = Path.Combine(Path.GetTempPath(), "ModUpdateUtil.exe");
                
                // If resource exists, extract it
                if (exeResourceStream != null)
                {
                    using (var fileStream = File.Create(tempPath))
                    {
                        exeResourceStream.CopyTo(fileStream);
                    }
                    
                    Log.LogInfo("DllStore: Starting ModUpdateUtil to apply new DLLs...");
                    
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = tempPath,
                        Arguments = $"{processId.ToString()} {string.Join(",", dllData.Keys)} {Paths.PluginPath}",
                        UseShellExecute = true
                    });
                }
                else
                {
                    Log.LogWarning("DllStore: ModUpdateUtil.exe not found as embedded resource. DLL updates will be applied manually.");
                    // Alternative: Just log the update is available for manual application
                    Log.LogInfo("DllStore: New DLLs available! Please restart the game to apply updates.");
                }
            }
        }

        public static void CheckForUpdates(string gameVersion)
        {
            // Public method to manually check for updates
            TryGetNewDll(gameVersion);
        }
    }
}
