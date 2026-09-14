using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A38 RID: 2616
	[Token(Token = "0x2000A38")]
	[Serializable]
	public class GardenUnifiedData
	{
		// Token: 0x060035EC RID: 13804 RVA: 0x00122E68 File Offset: 0x00121068
		[Token(Token = "0x60035EC")]
		[Address(RVA = "0x75A090", Offset = "0x758690", VA = "0x18075A090")]
		public List<GardenPlantData> GetPlants(int page)
		{
			new GardenUnifiedData.<>c__DisplayClass4_0().page = page;
			Func<GardenPlantData, bool> func;
			return Enumerable.ToList<GardenPlantData>(Enumerable.Where<GardenPlantData>(this.allPlants, func));
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x00122EA4 File Offset: 0x001210A4
		[Token(Token = "0x60035ED")]
		[Address(RVA = "0x75A050", Offset = "0x758650", VA = "0x18075A050")]
		public GardenPlant CreatePlantObject(PlantType thePlantType, int theColumn, int theRow, int page, GardenUI manager)
		{
			GardenPlant gardenPlant;
			return gardenPlant;
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x00122EBC File Offset: 0x001210BC
		[Token(Token = "0x60035EE")]
		[Address(RVA = "0x759F40", Offset = "0x758540", VA = "0x180759F40")]
		public GardenPlantData CreatePlantData(PlantType thePlantType, int theColumn, int theRow, int page)
		{
			GardenPlantData gardenPlantData;
			gardenPlantData.needTool = (GardenToolType)((ulong)1L);
			gardenPlantData.page = 0;
			gardenPlantData.thePlantColumn = theColumn;
			gardenPlantData.thePlantRow = theRow;
			gardenPlantData.thePlantType = thePlantType;
			List<GardenPlantData> list = this.allPlants;
			int size = list._size;
			list._size = gardenPlantData;
			return gardenPlantData;
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x00122F10 File Offset: 0x00121110
		[Token(Token = "0x60035EF")]
		[Address(RVA = "0x75A520", Offset = "0x758B20", VA = "0x18075A520")]
		public bool TryAddPlantData([Out] GardenPlantData data, [Optional] PlantType? wishType, [Optional] int? wishPage)
		{
			List<Vector2Int> list = new List();
			int num = 0;
			int num2;
			if (num2 < 64)
			{
				int num3;
				new GardenUnifiedData.<>c__DisplayClass7_0().targetPage = num3;
				Func<GardenPlantData, bool> func;
				List<GardenPlantData> list2 = Enumerable.ToList<GardenPlantData>(Enumerable.Where<GardenPlantData>(this.allPlants, func));
				int n;
				if (n < 8)
				{
					int m = (int)((ulong)0L);
					Func<GardenPlantData, bool> func2;
					if (m < 4 && !Enumerable.Any<GardenPlantData>(list2, func2))
					{
						int l = n;
						int k = m;
					}
				}
				if (num != 0)
				{
				}
			}
			int page = (int)((ulong)0L);
			int num4;
			if (page < 64 && page != num4)
			{
				Func<GardenPlantData, bool> func3;
				List<GardenPlantData> list3 = Enumerable.ToList<GardenPlantData>(Enumerable.Where<GardenPlantData>(this.allPlants, func3));
				int i;
				if (i < 8)
				{
					int j = (int)((ulong)0L);
					Func<GardenPlantData, bool> func4;
					if (j < 4 && !Enumerable.Any<GardenPlantData>(list3, func4))
					{
						int i2 = i;
						int j2 = j;
					}
				}
				while (num != 0)
				{
				}
			}
			if (num != 0)
			{
				int num5 = list._size;
				num5 = global::UnityEngine.Random.Range(0, num5);
				Vector2Int vector2Int = list[num5];
				int num6 = global::UnityEngine.Random.Range(0, 33);
				bool flag;
				while (flag)
				{
				}
				return true;
			}
			throw new NullReferenceException();
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x00123080 File Offset: 0x00121280
		[Token(Token = "0x60035F0")]
		[Address(RVA = "0x75A170", Offset = "0x758770", VA = "0x18075A170")]
		public void LoadPlants(GardenUI manager, int page)
		{
			int num;
			bool flag;
			do
			{
				num = 0;
				List<GardenPlantData> list = this.allPlants;
				if (flag)
				{
					List<GardenPlant> gardenPlants = manager.gardenPlants;
					num++;
				}
			}
			while (num != 0);
			int num2;
			Debug.Log(string.Format("加载第{0}页数据，植物数量: {1}", flag, num2));
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x001230DC File Offset: 0x001212DC
		[Token(Token = "0x60035F1")]
		[Address(RVA = "0x75A3A0", Offset = "0x7589A0", VA = "0x18075A3A0")]
		public void Save([Optional] string reason)
		{
			string text = Path.Combine(SaveInfo.GetDataPath(), "GardenUnifiedData.json");
			string text2 = JsonUtility.ToJson(this, true);
			DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(text));
			File.WriteAllText(text, text2);
			if (GameAPP.config.debug)
			{
				Debug.Log("保存花园数据：" + reason);
			}
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x0012313C File Offset: 0x0012133C
		[Token(Token = "0x60035F2")]
		[Address(RVA = "0x75AB40", Offset = "0x759140", VA = "0x18075AB40")]
		public GardenUnifiedData()
		{
			List<GardenPlantData> list = new List();
			this.allPlants = list;
			base..ctor();
		}

		// Token: 0x04002941 RID: 10561
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002941")]
		public int totalPages;

		// Token: 0x04002942 RID: 10562
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002942")]
		public int coinCount;

		// Token: 0x04002943 RID: 10563
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002943")]
		public Inventory inventory;

		// Token: 0x04002944 RID: 10564
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002944")]
		public List<GardenPlantData> allPlants;
	}
}
