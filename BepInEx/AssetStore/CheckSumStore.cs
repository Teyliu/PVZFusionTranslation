using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text.Encodings.Web;
using System.Text.Json;
using static PvZ_Fusion_Translator__BepInEx_.FileLoader;

namespace PvZ_Fusion_Translator__BepInEx_.AssetStore
{
	public static class CheckSumStore
	{
		private static Dictionary<string, string> modifiedCheckSums = new Dictionary<string, string>();
		
		private static Dictionary<string, string> checkSums = new Dictionary<string, string>() 
		{
		};

		static string GetCheckSum(string filename)
		{
			using (var md5 = SHA256.Create())
			{
				byte[] bytes = md5.ComputeHash(File.ReadAllBytes(filename));
				return Convert.ToBase64String(bytes);
			}
		}

		public static void SaveCheckSum()
		{
			string stringDir = GetAssetDir(AssetType.Dumps);
			if (!Directory.Exists(stringDir))
			{
				Directory.CreateDirectory(stringDir);
			}
			string checkSumString = JsonSerializer.Serialize(checkSums, new JsonSerializerOptions
			{
				WriteIndented = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			});
			File.WriteAllText(Path.Combine(stringDir, "MD5.json"), checkSumString);
		}

		public static void SaveModifiedChecksum()
		{
			string stringDir = GetAssetDir(AssetType.Dumps);
			if (!Directory.Exists(stringDir))
			{
				Directory.CreateDirectory(stringDir);
			}
			string modifiedCheckSumString = JsonSerializer.Serialize(modifiedCheckSums, new JsonSerializerOptions
			{
				WriteIndented = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			});
			File.WriteAllText(Path.Combine(stringDir, "Modified_MD5.json"), modifiedCheckSumString);
		}

		public static bool IsModified(string filepath)
		{
			string fileName = Path.GetFileNameWithoutExtension(filepath);
			string directory = Path.GetDirectoryName(filepath);
			string slicedFilePath = directory.Substring(directory.IndexOf("PvZ_Fusion_Translator\\") + "PvZ_Fusion_Translator\\".Length);
			string slicedKey = Path.Combine(slicedFilePath, fileName);

			#if DEBUG
			if (!checkSums.ContainsKey(slicedKey))
			{
				checkSums.Add(slicedKey, GetCheckSum(filepath));
				SaveCheckSum();
				modifiedCheckSums.Add(slicedKey, GetCheckSum(filepath));
				SaveModifiedChecksum();
			}
			else
			{
				if ((checkSums[slicedKey] != GetCheckSum(filepath)))
				{
					checkSums[slicedKey] = GetCheckSum(filepath);
					modifiedCheckSums.Add(slicedKey, GetCheckSum(filepath));
					SaveModifiedChecksum();
				}
			}
			#elif RELEASE
			if (!checkSums.ContainsKey(slicedKey) | (checkSums[slicedKey] != GetCheckSum(filepath)))
			{
				return true;
			}
			#endif
			return false;
		}

		#if MELON
		public static void ConvertMD5Json()
		{
			string stringDir = GetAssetDir(AssetType.Dumps);
			if (!Directory.Exists(stringDir))
			{
				Directory.CreateDirectory(stringDir);
			}
			string checksumDumpPath = Path.Combine(stringDir, "MD5.json");
			string checksumConvertPath = Path.Combine(stringDir, "MD5Convert.txt");
			string json = File.ReadAllText(checksumDumpPath);
			Dictionary<string, string> dictionary = DeserializeObject<Dictionary<string, string>>(json);

			using StreamWriter writer = new StreamWriter(checksumConvertPath);
			foreach (var kvp in dictionary)
			{
				string checksumKey = kvp.Key.Replace("\\", "\\\\");
				writer.WriteLine($"{{ \"{kvp.Key}\" , \"{kvp.Value}\" }},");
			}

			Log.LogDebug($"MD5.json converted to MD5Convert.json at {checksumConvertPath}");
		}
		#endif
	}
}
