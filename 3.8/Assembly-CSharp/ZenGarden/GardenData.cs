using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A37 RID: 2615
	[Token(Token = "0x2000A37")]
	public class GardenData
	{
		// Token: 0x060035E6 RID: 13798 RVA: 0x00122B94 File Offset: 0x00120D94
		[Token(Token = "0x60035E6")]
		[Address(RVA = "0x750430", Offset = "0x74EA30", VA = "0x180750430")]
		public static string GetUnifiedPath()
		{
			return Path.Combine(SaveInfo.GetDataPath(), "GardenUnifiedData.json");
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x00122BB4 File Offset: 0x00120DB4
		[Token(Token = "0x60035E7")]
		[Address(RVA = "0x750340", Offset = "0x74E940", VA = "0x180750340")]
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

		// Token: 0x060035E8 RID: 13800 RVA: 0x00122BF0 File Offset: 0x00120DF0
		[Token(Token = "0x60035E8")]
		[Address(RVA = "0x7504A0", Offset = "0x74EAA0", VA = "0x1807504A0")]
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

		// Token: 0x060035E9 RID: 13801 RVA: 0x00122D44 File Offset: 0x00120F44
		[Token(Token = "0x60035E9")]
		[Address(RVA = "0x750960", Offset = "0x74EF60", VA = "0x180750960")]
		private static bool NeedsMigration()
		{
			if (File.Exists(Path.Combine(SaveInfo.GetDataPath(), "GardenUnifiedData.json")))
			{
			}
			return File.Exists(Path.Combine(SaveInfo.GetDataPath(), "GardenData.json"));
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x00122D84 File Offset: 0x00120F84
		[Token(Token = "0x60035EA")]
		[Address(RVA = "0x74FFE0", Offset = "0x74E5E0", VA = "0x18074FFE0")]
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

		// Token: 0x060035EB RID: 13803 RVA: 0x00122E54 File Offset: 0x00121054
		[Token(Token = "0x60035EB")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public GardenData()
		{
		}

		// Token: 0x0400293E RID: 10558
		[Token(Token = "0x400293E")]
		public const int MaxPageCount = 64;

		// Token: 0x0400293F RID: 10559
		[Token(Token = "0x400293F")]
		public const int PageColumn = 8;

		// Token: 0x04002940 RID: 10560
		[Token(Token = "0x4002940")]
		public const int PageRow = 4;
	}
}
