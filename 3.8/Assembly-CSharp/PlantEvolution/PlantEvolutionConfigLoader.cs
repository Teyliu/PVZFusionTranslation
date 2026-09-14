using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace PlantEvolution
{
	// Token: 0x02000A61 RID: 2657
	[Token(Token = "0x2000A61")]
	public class PlantEvolutionConfigLoader
	{
		// Token: 0x060036A0 RID: 13984 RVA: 0x00126878 File Offset: 0x00124A78
		[Token(Token = "0x60036A0")]
		[Address(RVA = "0x76FED0", Offset = "0x76E4D0", VA = "0x18076FED0")]
		public static PlantEvolutionConfigLoader.EvolutionConfig LoadConfig()
		{
			TextAsset textAsset = Resources.Load<TextAsset>("PlantEvolutionData");
			int num = 0;
			if (!(textAsset == num))
			{
				PlantEvolutionConfigLoader._cachedConfig = JsonUtility.FromJson<PlantEvolutionConfigLoader.EvolutionConfig>(textAsset.text);
				PlantEvolutionConfigLoader.EvolutionConfig cachedConfig = PlantEvolutionConfigLoader._cachedConfig;
				if (cachedConfig.plants != (ulong)0L)
				{
					List<PlantEvolutionConfigLoader.PlantConfigEntry> plants = cachedConfig.plants;
					int size = plants._size;
					Debug.Log(string.Format("成功加载植物进化配置，包含 {0} 个植物", plants));
				}
				return PlantEvolutionConfigLoader._cachedConfig;
			}
			Debug.LogWarning("未找到 PlantEvolutionData.json，将使用硬编码数据");
			throw new NullReferenceException();
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x001268F8 File Offset: 0x00124AF8
		[Token(Token = "0x60036A1")]
		[Address(RVA = "0x7700D0", Offset = "0x76E6D0", VA = "0x1807700D0")]
		public static void ReloadConfig()
		{
			AsyncOperation asyncOperation = Resources.UnloadUnusedAssets();
			Debug.Log("植物进化配置缓存已清除");
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x00126918 File Offset: 0x00124B18
		[Token(Token = "0x60036A2")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public PlantEvolutionConfigLoader()
		{
		}

		// Token: 0x040029F5 RID: 10741
		[Token(Token = "0x40029F5")]
		private static PlantEvolutionConfigLoader.EvolutionConfig _cachedConfig;

		// Token: 0x02000A62 RID: 2658
		[Token(Token = "0x2000A62")]
		[Serializable]
		public class EvolutionConfig
		{
			// Token: 0x060036A3 RID: 13987 RVA: 0x0012692C File Offset: 0x00124B2C
			[Token(Token = "0x60036A3")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public EvolutionConfig()
			{
			}

			// Token: 0x040029F6 RID: 10742
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40029F6")]
			public List<PlantEvolutionConfigLoader.PlantConfigEntry> plants;
		}

		// Token: 0x02000A63 RID: 2659
		[Token(Token = "0x2000A63")]
		[Serializable]
		public class PlantConfigEntry
		{
			// Token: 0x060036A4 RID: 13988 RVA: 0x00126940 File Offset: 0x00124B40
			[Token(Token = "0x60036A4")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public PlantConfigEntry()
			{
			}

			// Token: 0x040029F7 RID: 10743
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40029F7")]
			public string key;

			// Token: 0x040029F8 RID: 10744
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40029F8")]
			public PlantEvolutionConfigLoader.PlantEvolutionConfig value;
		}

		// Token: 0x02000A64 RID: 2660
		[Token(Token = "0x2000A64")]
		[Serializable]
		public class PlantEvolutionConfig
		{
			// Token: 0x060036A5 RID: 13989 RVA: 0x00126954 File Offset: 0x00124B54
			[Token(Token = "0x60036A5")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public PlantEvolutionConfig()
			{
			}

			// Token: 0x040029F9 RID: 10745
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40029F9")]
			public string basePlant;

			// Token: 0x040029FA RID: 10746
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40029FA")]
			public List<PlantEvolutionConfigLoader.RouteConfig> routes;
		}

		// Token: 0x02000A65 RID: 2661
		[Token(Token = "0x2000A65")]
		[Serializable]
		public class RouteConfig
		{
			// Token: 0x060036A6 RID: 13990 RVA: 0x00126968 File Offset: 0x00124B68
			[Token(Token = "0x60036A6")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public RouteConfig()
			{
			}

			// Token: 0x040029FB RID: 10747
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40029FB")]
			public string routeName;

			// Token: 0x040029FC RID: 10748
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40029FC")]
			public List<PlantEvolutionConfigLoader.StageConfig> stages;

			// Token: 0x040029FD RID: 10749
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40029FD")]
			public List<int> stageCost;
		}

		// Token: 0x02000A66 RID: 2662
		[Token(Token = "0x2000A66")]
		[Serializable]
		public class StageConfig
		{
			// Token: 0x060036A7 RID: 13991 RVA: 0x0012697C File Offset: 0x00124B7C
			[Token(Token = "0x60036A7")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public StageConfig()
			{
			}

			// Token: 0x040029FE RID: 10750
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40029FE")]
			public string plantType;

			// Token: 0x040029FF RID: 10751
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40029FF")]
			public int attackDamage;

			// Token: 0x04002A00 RID: 10752
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4002A00")]
			public float attackInterval;

			// Token: 0x04002A01 RID: 10753
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4002A01")]
			public int maxHealth;

			// Token: 0x04002A02 RID: 10754
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x4002A02")]
			public int attackSpeedAdder;
		}
	}
}
