using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using UnityEngine;

namespace AlmanacData
{
	// Token: 0x02000A42 RID: 2626
	[Token(Token = "0x2000A42")]
	public static class AlmanacDataLoader
	{
		// Token: 0x06003603 RID: 13827 RVA: 0x00123370 File Offset: 0x00121570
		[Token(Token = "0x6003603")]
		[Address(RVA = "0x74B940", Offset = "0x749F40", VA = "0x18074B940")]
		public static PlantInfo GetPlantData(PlantType type)
		{
			Dictionary<PlantType, PlantInfo> dictionary = AlmanacDataLoader.plantDatas;
			throw new NullReferenceException();
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x0012338C File Offset: 0x0012158C
		[Token(Token = "0x6003604")]
		[Address(RVA = "0x74B9E0", Offset = "0x749FE0", VA = "0x18074B9E0")]
		public static ZombieInfo GetZombieData(ZombieType type)
		{
			Dictionary<ZombieType, ZombieInfo> dictionary = AlmanacDataLoader.zombieDatas;
			throw new NullReferenceException();
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x001233A8 File Offset: 0x001215A8
		[Token(Token = "0x6003605")]
		[Address(RVA = "0x74C370", Offset = "0x74A970", VA = "0x18074C370")]
		static AlmanacDataLoader()
		{
			AlmanacDataLoader.LoadPlantData();
			AlmanacDataLoader.LoadZombieData();
			AlmanacDataLoader.LoadDetailsData();
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x001233EC File Offset: 0x001215EC
		[Token(Token = "0x6003606")]
		[Address(RVA = "0x74C260", Offset = "0x74A860", VA = "0x18074C260")]
		public static void Reload()
		{
			AlmanacDataLoader.almanacData = new AlmanacData();
			AlmanacDataLoader.plantDatas.Clear();
			AlmanacDataLoader.zombieDatas.Clear();
			AlmanacDataLoader.LoadPlantData();
			AlmanacDataLoader.LoadZombieData();
			AlmanacDataLoader.LoadDetailsData();
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x00123434 File Offset: 0x00121634
		[Token(Token = "0x6003607")]
		[Address(RVA = "0x74BC40", Offset = "0x74A240", VA = "0x18074BC40")]
		private static void LoadPlantData()
		{
			ulong num;
			do
			{
				string text = Path.Combine(SaveInfo.GetDataPath(), "LawnStrings.json");
				if (File.Exists(text))
				{
					string text2 = File.ReadAllText(text);
				}
				AlmanacData almanacData = JsonUtility.FromJson<AlmanacData>(Resources.Load<TextAsset>("LawnStrings").text);
				AlmanacData almanacData2 = AlmanacDataLoader.almanacData;
				List<PlantInfo> list = new List(almanacData.plants);
				almanacData2.plants = list;
				List<PlantInfo> plants = almanacData.plants;
				bool flag;
				if (flag)
				{
					Dictionary<PlantType, PlantInfo> dictionary = AlmanacDataLoader.plantDatas;
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x001234C8 File Offset: 0x001216C8
		[Token(Token = "0x6003608")]
		[Address(RVA = "0x74BF50", Offset = "0x74A550", VA = "0x18074BF50")]
		private static void LoadZombieData()
		{
			ulong num;
			do
			{
				string text = Path.Combine(SaveInfo.GetDataPath(), "ZombieStrings.json");
				if (File.Exists(text))
				{
					string text2 = File.ReadAllText(text);
				}
				AlmanacData almanacData = JsonUtility.FromJson<AlmanacData>(Resources.Load<TextAsset>("ZombieStrings").text);
				AlmanacData almanacData2 = AlmanacDataLoader.almanacData;
				List<ZombieInfo> list = new List(almanacData.zombies);
				almanacData2.zombies = list;
				List<ZombieInfo> zombies = almanacData.zombies;
				bool flag;
				if (flag)
				{
					Dictionary<ZombieType, ZombieInfo> dictionary = AlmanacDataLoader.zombieDatas;
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x0012355C File Offset: 0x0012175C
		[Token(Token = "0x6003609")]
		[Address(RVA = "0x74BA80", Offset = "0x74A080", VA = "0x18074BA80")]
		private static void LoadDetailsData()
		{
			string text = Path.Combine(SaveInfo.GetDataPath(), "DetailStrings.json");
			if (File.Exists(text))
			{
				string text2 = File.ReadAllText(text);
			}
			AlmanacData almanacData = JsonUtility.FromJson<AlmanacData>(Resources.Load<TextAsset>("DetailStrings").text);
			AlmanacData almanacData2 = AlmanacDataLoader.almanacData;
			List<Details> list = new List(almanacData.details);
			almanacData2.details = list;
			throw new NullReferenceException();
		}

		// Token: 0x04002950 RID: 10576
		[Token(Token = "0x4002950")]
		public static AlmanacData almanacData = new AlmanacData();

		// Token: 0x04002951 RID: 10577
		[Token(Token = "0x4002951")]
		private static readonly Dictionary<PlantType, PlantInfo> plantDatas = new Dictionary();

		// Token: 0x04002952 RID: 10578
		[Token(Token = "0x4002952")]
		private static readonly Dictionary<ZombieType, ZombieInfo> zombieDatas = new Dictionary();
	}
}
