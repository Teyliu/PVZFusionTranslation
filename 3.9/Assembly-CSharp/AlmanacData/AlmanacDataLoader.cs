using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using UnityEngine;

namespace AlmanacData
{
	// Token: 0x02000A82 RID: 2690
	[Token(Token = "0x2000A82")]
	public static class AlmanacDataLoader
	{
		// Token: 0x06003747 RID: 14151 RVA: 0x001285EC File Offset: 0x001267EC
		[Token(Token = "0x6003747")]
		[Address(RVA = "0x7B2300", Offset = "0x7B0900", VA = "0x1807B2300")]
		public static PlantInfo GetPlantData(PlantType type)
		{
			Dictionary<PlantType, PlantInfo> dictionary = AlmanacDataLoader.plantDatas;
			throw new NullReferenceException();
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x00128608 File Offset: 0x00126808
		[Token(Token = "0x6003748")]
		[Address(RVA = "0x7B23A0", Offset = "0x7B09A0", VA = "0x1807B23A0")]
		public static ZombieInfo GetZombieData(ZombieType type)
		{
			Dictionary<ZombieType, ZombieInfo> dictionary = AlmanacDataLoader.zombieDatas;
			throw new NullReferenceException();
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00128624 File Offset: 0x00126824
		[Token(Token = "0x6003749")]
		[Address(RVA = "0x7B2D30", Offset = "0x7B1330", VA = "0x1807B2D30")]
		static AlmanacDataLoader()
		{
			AlmanacDataLoader.LoadPlantData();
			AlmanacDataLoader.LoadZombieData();
			AlmanacDataLoader.LoadDetailsData();
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x00128668 File Offset: 0x00126868
		[Token(Token = "0x600374A")]
		[Address(RVA = "0x7B2C20", Offset = "0x7B1220", VA = "0x1807B2C20")]
		public static void Reload()
		{
			AlmanacDataLoader.almanacData = new AlmanacData();
			AlmanacDataLoader.plantDatas.Clear();
			AlmanacDataLoader.zombieDatas.Clear();
			AlmanacDataLoader.LoadPlantData();
			AlmanacDataLoader.LoadZombieData();
			AlmanacDataLoader.LoadDetailsData();
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x001286B0 File Offset: 0x001268B0
		[Token(Token = "0x600374B")]
		[Address(RVA = "0x7B2600", Offset = "0x7B0C00", VA = "0x1807B2600")]
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

		// Token: 0x0600374C RID: 14156 RVA: 0x00128744 File Offset: 0x00126944
		[Token(Token = "0x600374C")]
		[Address(RVA = "0x7B2910", Offset = "0x7B0F10", VA = "0x1807B2910")]
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

		// Token: 0x0600374D RID: 14157 RVA: 0x001287D8 File Offset: 0x001269D8
		[Token(Token = "0x600374D")]
		[Address(RVA = "0x7B2440", Offset = "0x7B0A40", VA = "0x1807B2440")]
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

		// Token: 0x04002AC3 RID: 10947
		[Token(Token = "0x4002AC3")]
		public static AlmanacData almanacData = new AlmanacData();

		// Token: 0x04002AC4 RID: 10948
		[Token(Token = "0x4002AC4")]
		private static readonly Dictionary<PlantType, PlantInfo> plantDatas = new Dictionary();

		// Token: 0x04002AC5 RID: 10949
		[Token(Token = "0x4002AC5")]
		public static readonly Dictionary<ZombieType, ZombieInfo> zombieDatas = new Dictionary();
	}
}
