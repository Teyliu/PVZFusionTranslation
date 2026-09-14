using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A77 RID: 2679
	[Token(Token = "0x2000A77")]
	public class GardenData
	{
		// Token: 0x0600372A RID: 14122 RVA: 0x00127DB4 File Offset: 0x00125FB4
		[Token(Token = "0x600372A")]
		[Address(RVA = "0x7B6DF0", Offset = "0x7B53F0", VA = "0x1807B6DF0")]
		public static string GetUnifiedPath()
		{
			return Path.Combine(SaveInfo.GetDataPath(), "GardenUnifiedData.json");
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x00127DD4 File Offset: 0x00125FD4
		[Token(Token = "0x600372B")]
		[Address(RVA = "0x7B6D00", Offset = "0x7B5300", VA = "0x1807B6D00")]
		public static string GetPath(int page)
		{
			if (page == 0)
			{
				return Path.Combine(SaveInfo.GetDataPath(), "GardenData.json");
			}
			string dataPath = SaveInfo.GetDataPath();
			string text = string.Format("GardenData{0}.json", dataPath);
			return Path.Combine(dataPath, text);
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00127E10 File Offset: 0x00126010
		[Token(Token = "0x600372C")]
		[Address(RVA = "0x7B6E60", Offset = "0x7B5460", VA = "0x1807B6E60")]
		public static void MigrateToUnifiedData()
		{
			int num = 0;
			string text = Path.Combine(SaveInfo.GetDataPath(), "GardenUnifiedData.json");
			if (File.Exists(text))
			{
				string text2 = text + ".backup";
				File.Copy(text, text2, true);
				Debug.Log("备份现有统一存档: " + text2);
			}
			GardenUnifiedData gardenUnifiedData = new GardenUnifiedData();
			List<GardenPlantData> list = new List();
			gardenUnifiedData.allPlants = list;
			gardenUnifiedData.totalPages = (int)((ulong)64L);
			string path = GardenData.GetPath(num);
			if (File.Exists(path))
			{
				GardenAllData gardenAllData = JsonUtility.FromJson<GardenAllData>(File.ReadAllText(path));
				string text3;
				if (gardenAllData != 0 && gardenAllData.plantData != (ulong)0L)
				{
					List<GardenPlantData> allPlants = gardenUnifiedData.allPlants;
					List<GardenPlantData> plantData = gardenAllData.plantData;
					allPlants.AddRange(plantData);
					num++;
					int size = gardenAllData.plantData._size;
					int num2;
					text3 = string.Format("成功迁移第{0}页数据，植物数量: {1}", num2, num2);
					Debug.Log(text3);
				}
				Debug.LogError(string.Format(text3, text3, text3));
			}
			num++;
			string text4 = JsonUtility.ToJson(gardenUnifiedData, true);
			DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(text));
			File.WriteAllText(text, text4);
			int size2 = gardenUnifiedData.allPlants._size;
			int num3;
			Debug.Log(string.Format("禅境花园数据迁移完成！共迁移 {0} 页数据，总植物数量: {1}", num3, num3));
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00127F64 File Offset: 0x00126164
		[Token(Token = "0x600372D")]
		[Address(RVA = "0x7B7320", Offset = "0x7B5920", VA = "0x1807B7320")]
		private static bool NeedsMigration()
		{
			if (File.Exists(Path.Combine(SaveInfo.GetDataPath(), "GardenUnifiedData.json")))
			{
			}
			return File.Exists(Path.Combine(SaveInfo.GetDataPath(), "GardenData.json"));
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00127FA4 File Offset: 0x001261A4
		[Token(Token = "0x600372E")]
		[Address(RVA = "0x7B69A0", Offset = "0x7B4FA0", VA = "0x1807B69A0")]
		public static GardenUnifiedData GetData()
		{
			if (!File.Exists(Path.Combine(SaveInfo.GetDataPath(), "GardenUnifiedData.json")) && File.Exists(Path.Combine(SaveInfo.GetDataPath(), "GardenData.json")))
			{
				GardenData.MigrateToUnifiedData();
			}
			string text = Path.Combine(SaveInfo.GetDataPath(), "GardenUnifiedData.json");
			if (File.Exists(text))
			{
				return JsonUtility.FromJson<GardenUnifiedData>(File.ReadAllText(text));
			}
			GardenUnifiedData gardenUnifiedData = new GardenUnifiedData();
			List<GardenPlantData> list = new List();
			gardenUnifiedData.allPlants = list;
			gardenUnifiedData.totalPages = (int)((ulong)64L);
			Inventory inventory = new Inventory();
			List<ShopItemData> list2 = new List();
			inventory.items = list2;
			gardenUnifiedData.inventory = inventory;
			gardenUnifiedData.Save("首次运行创建初始存档");
			return gardenUnifiedData;
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x00128074 File Offset: 0x00126274
		[Token(Token = "0x600372F")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public GardenData()
		{
		}

		// Token: 0x04002AB1 RID: 10929
		[Token(Token = "0x4002AB1")]
		public const int MaxPageCount = 64;

		// Token: 0x04002AB2 RID: 10930
		[Token(Token = "0x4002AB2")]
		public const int PageColumn = 8;

		// Token: 0x04002AB3 RID: 10931
		[Token(Token = "0x4002AB3")]
		public const int PageRow = 4;
	}
}
