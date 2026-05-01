/*using MelonLoader;
using MelonLoader.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZ_Fusion_Translator.AssetStore
{
    public static class DllStore
    {
		public static Dictionary<string, byte[]> dllData = new Dictionary<string, byte[]>()
		{
			{ "Blooms_QOL.dll", null },
			{ "PvZ_Fusion_Translator.dll", null }
		};
		public static bool updateOnClose = false;

		public static void Init(string gameVersion) => TryGetNewDll(gameVersion);

        public static void TryGetNewDll(string gameVersion)
		{
			bool ableToUpdate = true;
			string unableReason = "";
			string getGameVersionRequest = Utils.GetDataFromWeb("https://raw.githubusercontent.com/SillyStar-Github/PvZF-Translation-DLLs/refs/heads/main/CURRENT_GAME_VER").Result;
			if(getGameVersionRequest != null)
			{
				Log.LogDebug($"Requst game version: {getGameVersionRequest} -> {Utils.CalculateGameVersion(getGameVersionRequest)}");
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
				foreach(var key in dllData.Keys)
				{
					byte[] newDllRequest = Utils.GetByteDataFromWeb($"https://raw.githubusercontent.com/SillyStar-Github/PvZF-Translation-DLLs/refs/heads/main/{key}").Result;
					if(newDllRequest != null)
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
			if(newDllData != null)
			{
				string basePath = MelonEnvironment.ModsDirectory;
				string toSavePath = Path.Combine(basePath, name + ".update");
				File.WriteAllBytes(toSavePath, newDllData);
			}
		}

		public static void UpdateNewDll()
		{
			foreach(var pair in dllData)
			{
				if(pair.Value != null)
				{
					updateOnClose = true;
				}
			}

			if(updateOnClose)
			{
				int processId = (Process.GetCurrentProcess().Id);

				var assembly = Core.Instance.MelonAssembly.Assembly;
				string programName = "PvZ_Fusion_Translator.Resources.ModUpdateUtil.exe";

				using var exeResourceStream = assembly.GetManifestResourceStream(programName);
				string tempPath = Path.Combine(MelonEnvironment.ModsDirectory, "ModUpdateUtil.exe");
				using (var fileStream = File.Create(tempPath))
				{
					exeResourceStream.CopyTo(fileStream);
				}

				Process.Start(new ProcessStartInfo
				{
					FileName = tempPath,
					Arguments = $"{processId.ToString()} {string.Join(",", dllData.Keys)} \"{MelonEnvironment.ModsDirectory}\"",
					UseShellExecute = true
				});
			}
			else
			{
				Log.LogError("Cannot update on close! All .dll data is null!");
			}
		}
    }
}
*/