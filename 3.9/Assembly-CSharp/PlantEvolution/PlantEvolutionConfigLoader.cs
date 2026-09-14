using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace PlantEvolution
{
	// Token: 0x02000AA1 RID: 2721
	[Token(Token = "0x2000AA1")]
	public class PlantEvolutionConfigLoader
	{
		// Token: 0x060037E4 RID: 14308 RVA: 0x0012BAA8 File Offset: 0x00129CA8
		[Token(Token = "0x60037E4")]
		[Address(RVA = "0x7D6D40", Offset = "0x7D5340", VA = "0x1807D6D40")]
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

		// Token: 0x060037E5 RID: 14309 RVA: 0x0012BB28 File Offset: 0x00129D28
		[Token(Token = "0x60037E5")]
		[Address(RVA = "0x7D6F40", Offset = "0x7D5540", VA = "0x1807D6F40")]
		public static void ReloadConfig()
		{
			AsyncOperation asyncOperation = Resources.UnloadUnusedAssets();
			Debug.Log("植物进化配置缓存已清除");
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x0012BB48 File Offset: 0x00129D48
		[Token(Token = "0x60037E6")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public PlantEvolutionConfigLoader()
		{
		}

		// Token: 0x04002B68 RID: 11112
		[Token(Token = "0x4002B68")]
		private static PlantEvolutionConfigLoader.EvolutionConfig _cachedConfig;

		// Token: 0x02000AA2 RID: 2722
		[Token(Token = "0x2000AA2")]
		[Serializable]
		public class EvolutionConfig
		{
			// Token: 0x060037E7 RID: 14311 RVA: 0x0012BB5C File Offset: 0x00129D5C
			[Token(Token = "0x60037E7")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public EvolutionConfig()
			{
			}

			// Token: 0x04002B69 RID: 11113
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002B69")]
			public List<PlantEvolutionConfigLoader.PlantConfigEntry> plants;
		}

		// Token: 0x02000AA3 RID: 2723
		[Token(Token = "0x2000AA3")]
		[Serializable]
		public class PlantConfigEntry
		{
			// Token: 0x060037E8 RID: 14312 RVA: 0x0012BB70 File Offset: 0x00129D70
			[Token(Token = "0x60037E8")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public PlantConfigEntry()
			{
			}

			// Token: 0x04002B6A RID: 11114
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002B6A")]
			public string key;

			// Token: 0x04002B6B RID: 11115
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002B6B")]
			public PlantEvolutionConfigLoader.PlantEvolutionConfig value;
		}

		// Token: 0x02000AA4 RID: 2724
		[Token(Token = "0x2000AA4")]
		[Serializable]
		public class PlantEvolutionConfig
		{
			// Token: 0x060037E9 RID: 14313 RVA: 0x0012BB84 File Offset: 0x00129D84
			[Token(Token = "0x60037E9")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public PlantEvolutionConfig()
			{
			}

			// Token: 0x04002B6C RID: 11116
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002B6C")]
			public string basePlant;

			// Token: 0x04002B6D RID: 11117
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002B6D")]
			public List<PlantEvolutionConfigLoader.RouteConfig> routes;
		}

		// Token: 0x02000AA5 RID: 2725
		[Token(Token = "0x2000AA5")]
		[Serializable]
		public class RouteConfig
		{
			// Token: 0x060037EA RID: 14314 RVA: 0x0012BB98 File Offset: 0x00129D98
			[Token(Token = "0x60037EA")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public RouteConfig()
			{
			}

			// Token: 0x04002B6E RID: 11118
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002B6E")]
			public string routeName;

			// Token: 0x04002B6F RID: 11119
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002B6F")]
			public List<PlantEvolutionConfigLoader.StageConfig> stages;

			// Token: 0x04002B70 RID: 11120
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4002B70")]
			public List<int> stageCost;
		}

		// Token: 0x02000AA6 RID: 2726
		[Token(Token = "0x2000AA6")]
		[Serializable]
		public class StageConfig
		{
			// Token: 0x060037EB RID: 14315 RVA: 0x0012BBAC File Offset: 0x00129DAC
			[Token(Token = "0x60037EB")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public StageConfig()
			{
			}

			// Token: 0x04002B71 RID: 11121
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002B71")]
			public string plantType;

			// Token: 0x04002B72 RID: 11122
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002B72")]
			public int attackDamage;

			// Token: 0x04002B73 RID: 11123
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4002B73")]
			public float attackInterval;

			// Token: 0x04002B74 RID: 11124
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4002B74")]
			public int maxHealth;

			// Token: 0x04002B75 RID: 11125
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x4002B75")]
			public int attackSpeedAdder;
		}
	}
}
