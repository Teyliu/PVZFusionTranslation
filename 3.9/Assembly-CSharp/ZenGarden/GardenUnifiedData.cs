using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A78 RID: 2680
	[Token(Token = "0x2000A78")]
	[Serializable]
	public class GardenUnifiedData
	{
		// Token: 0x06003730 RID: 14128 RVA: 0x00128088 File Offset: 0x00126288
		[Token(Token = "0x6003730")]
		[Address(RVA = "0x7C0CF0", Offset = "0x7BF2F0", VA = "0x1807C0CF0")]
		public List<GardenPlantData> GetPlants(int page)
		{
			List<GardenPlantData> list = this.allPlants;
			Func<GardenPlantData, bool> func = delegate(GardenPlantData a)
			{
				int page2 = page;
				return a.page == page2;
			};
			return Enumerable.ToList<GardenPlantData>(Enumerable.Where<GardenPlantData>(list, func));
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x001280D4 File Offset: 0x001262D4
		[Token(Token = "0x6003731")]
		[Address(RVA = "0x7C0CB0", Offset = "0x7BF2B0", VA = "0x1807C0CB0")]
		public GardenPlant CreatePlantObject(PlantType thePlantType, int theColumn, int theRow, int page, GardenUI manager)
		{
			GardenPlant gardenPlant;
			return gardenPlant;
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x001280EC File Offset: 0x001262EC
		[Token(Token = "0x6003732")]
		[Address(RVA = "0x7C0BA0", Offset = "0x7BF1A0", VA = "0x1807C0BA0")]
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

		// Token: 0x06003733 RID: 14131 RVA: 0x00128140 File Offset: 0x00126340
		[Token(Token = "0x6003733")]
		[Address(RVA = "0x7C1180", Offset = "0x7BF780", VA = "0x1807C1180")]
		public bool TryAddPlantData([Out] GardenPlantData data, [Optional] PlantType? wishType, [Optional] int? wishPage)
		{
			List<Vector2Int> list = new List();
			int num = 0;
			int num2;
			if (num2 < 64)
			{
				int num3;
				int targetPage = num3;
				List<GardenPlantData> list2 = this.allPlants;
				Func<GardenPlantData, bool> func = delegate(GardenPlantData p)
				{
					if (p == 0)
					{
					}
					int targetPage2 = targetPage;
					return p.page == targetPage2;
				};
				List<GardenPlantData> list3 = Enumerable.ToList<GardenPlantData>(Enumerable.Where<GardenPlantData>(list2, func));
				int n;
				if (n < 8)
				{
					int m = (int)((ulong)0L);
					if (m < 4)
					{
						Func<GardenPlantData, bool> func2 = delegate(GardenPlantData a)
						{
							int i3 = n;
							if (a.thePlantColumn != i3)
							{
							}
							int j3 = m;
							return a.thePlantRow == j3;
						};
						if (!Enumerable.Any<GardenPlantData>(list3, func2))
						{
							int l = n;
							int k = m;
						}
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
				List<GardenPlantData> list4 = this.allPlants;
				Func<GardenPlantData, bool> func3 = delegate(GardenPlantData p)
				{
					if (p == 0)
					{
					}
					int page2 = page;
					return p.page == page2;
				};
				List<GardenPlantData> list5 = Enumerable.ToList<GardenPlantData>(Enumerable.Where<GardenPlantData>(list4, func3));
				int i;
				if (i < 8)
				{
					int j = (int)((ulong)0L);
					if (j < 4)
					{
						Func<GardenPlantData, bool> func4 = delegate(GardenPlantData a)
						{
							int i4 = i;
							if (a.thePlantColumn != i4)
							{
							}
							int j4 = j;
							return a.thePlantRow == j4;
						};
						if (!Enumerable.Any<GardenPlantData>(list5, func4))
						{
							int i2 = i;
							int j2 = j;
						}
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

		// Token: 0x06003734 RID: 14132 RVA: 0x001282FC File Offset: 0x001264FC
		[Token(Token = "0x6003734")]
		[Address(RVA = "0x7C0DD0", Offset = "0x7BF3D0", VA = "0x1807C0DD0")]
		public void LoadPlants(GardenUI manager, int page)
		{
			int num;
			do
			{
				num = 0;
				List<GardenPlantData> list = this.allPlants;
				bool flag;
				if (flag)
				{
					List<GardenPlant> gardenPlants = manager.gardenPlants;
					num++;
				}
			}
			while (num != 0);
			GardenPlant gardenPlant;
			int num2;
			Debug.Log(string.Format("加载第{0}页数据，植物数量: {1}", gardenPlant, num2));
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x00128358 File Offset: 0x00126558
		[Token(Token = "0x6003735")]
		[Address(RVA = "0x7C1000", Offset = "0x7BF600", VA = "0x1807C1000")]
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

		// Token: 0x06003736 RID: 14134 RVA: 0x001283B8 File Offset: 0x001265B8
		[Token(Token = "0x6003736")]
		[Address(RVA = "0x7C17A0", Offset = "0x7BFDA0", VA = "0x1807C17A0")]
		public GardenUnifiedData()
		{
			List<GardenPlantData> list = new List();
			this.allPlants = list;
			base..ctor();
		}

		// Token: 0x04002AB4 RID: 10932
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002AB4")]
		public int totalPages;

		// Token: 0x04002AB5 RID: 10933
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002AB5")]
		public int coinCount;

		// Token: 0x04002AB6 RID: 10934
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002AB6")]
		public Inventory inventory;

		// Token: 0x04002AB7 RID: 10935
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002AB7")]
		public List<GardenPlantData> allPlants;
	}
}
