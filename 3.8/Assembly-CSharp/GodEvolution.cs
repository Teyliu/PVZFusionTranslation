using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using PlantEvolution;
using UnityEngine;

// Token: 0x020000C0 RID: 192
[Token(Token = "0x20000C0")]
public static class GodEvolution
{
	// Token: 0x1700004B RID: 75
	// (get) Token: 0x0600036A RID: 874 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
	// (set) Token: 0x0600036B RID: 875 RVA: 0x0000FE20 File Offset: 0x0000E020
	[Token(Token = "0x1700004B")]
	public static Dictionary<PlantType, PlantEvolutionData> Evolutions
	{
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x4B1AE0", Offset = "0x4B00E0", VA = "0x1804B1AE0")]
		get
		{
			GodManager instance = GodManager.Instance;
			int num = 0;
			if (instance != num && GodManager.Instance.custom)
			{
				return GodEvolution.currentPlantEvolutions;
			}
			return GodEvolution.originalPlantEvolutions;
		}
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x4B1C10", Offset = "0x4B0210", VA = "0x1804B1C10")]
		set
		{
			GodEvolution.currentPlantEvolutions = value;
		}
	}

	// Token: 0x0600036C RID: 876 RVA: 0x0000FE34 File Offset: 0x0000E034
	[Token(Token = "0x600036C")]
	[Address(RVA = "0x4B19D0", Offset = "0x4AFFD0", VA = "0x1804B19D0")]
	static GodEvolution()
	{
		GodEvolution.LoadFromJson();
	}

	// Token: 0x0600036D RID: 877 RVA: 0x0000FE60 File Offset: 0x0000E060
	[Token(Token = "0x600036D")]
	[Address(RVA = "0x4B1250", Offset = "0x4AF850", VA = "0x1804B1250")]
	private static void InitEvolutionData()
	{
		GodEvolution.LoadFromJson();
	}

	// Token: 0x0600036E RID: 878 RVA: 0x0000FE74 File Offset: 0x0000E074
	[Token(Token = "0x600036E")]
	[Address(RVA = "0x4B1290", Offset = "0x4AF890", VA = "0x1804B1290")]
	public static void LoadDynamicFromConfig(PlantEvolutionConfigLoader.EvolutionConfig config)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			if (config == 0 || config.plants == num)
			{
				break;
			}
			GodEvolution.currentPlantEvolutions.Clear();
			List<PlantEvolutionConfigLoader.PlantConfigEntry> plants = config.plants;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				DynamicPlantEvolutionData dynamicPlantEvolutionData;
				GodEvolution.currentPlantEvolutions[num2] = dynamicPlantEvolutionData;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x0600036F RID: 879 RVA: 0x0000FED4 File Offset: 0x0000E0D4
	[Token(Token = "0x600036F")]
	[Address(RVA = "0x4B1530", Offset = "0x4AFB30", VA = "0x1804B1530")]
	private static void LoadFromJson()
	{
		int num;
		do
		{
			num = 0;
			PlantEvolutionConfigLoader.EvolutionConfig evolutionConfig = PlantEvolutionConfigLoader.LoadConfig();
			if (evolutionConfig == 0 || evolutionConfig.plants == num)
			{
				goto IL_006C;
			}
			bool flag;
			if (flag)
			{
				bool flag2;
				if (!flag2)
				{
					Debug.LogWarning("无法解析植物类型: " + num);
				}
				DynamicPlantEvolutionData dynamicPlantEvolutionData;
				GodEvolution.currentPlantEvolutions[num] = dynamicPlantEvolutionData;
				DynamicPlantEvolutionData dynamicPlantEvolutionData2;
				GodEvolution.originalPlantEvolutions[num] = dynamicPlantEvolutionData2;
				num++;
			}
		}
		while (num != 0);
		int num2;
		Debug.Log(string.Format("从 JSON 加载了 {0} 个植物的进化数据", num2));
		return;
		IL_006C:
		Debug.LogError("无法加载植物进化配置文件！请检查 Assets/Resources/PlantEvolutionData.json");
	}

	// Token: 0x06000370 RID: 880 RVA: 0x0000FF70 File Offset: 0x0000E170
	[Token(Token = "0x6000370")]
	[Address(RVA = "0x4B18F0", Offset = "0x4AFEF0", VA = "0x1804B18F0")]
	public static void ReloadConfig()
	{
		GodEvolution.Evolutions.Clear();
		PlantEvolutionConfigLoader.ReloadConfig();
		GodEvolution.LoadFromJson();
		Debug.Log("植物进化配置已重新加载");
	}

	// Token: 0x06000371 RID: 881 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
	[Token(Token = "0x6000371")]
	[Address(RVA = "0x4B0EA0", Offset = "0x4AF4A0", VA = "0x1804B0EA0")]
	public static PlantEvolutionData GetPlantEvolution(PlantType plantType)
	{
		int num;
		do
		{
			Dictionary<PlantType, PlantEvolutionData> evolutions = GodEvolution.Evolutions;
			num = 0;
			bool flag;
			if (flag)
			{
				bool flag2;
				if (flag2)
				{
					bool flag3;
					while (!flag3)
					{
					}
				}
				if (num != 0)
				{
					goto IL_0056;
				}
			}
		}
		while (num != 0);
		Dictionary<PlantType, PlantEvolutionData> evolutions2 = GodEvolution.Evolutions;
		bool flag4;
		if (!flag4)
		{
		}
		Dictionary<PlantType, PlantEvolutionData> evolutions3 = GodEvolution.Evolutions;
		throw new NullReferenceException();
		IL_0056:
		throw new NullReferenceException();
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00010018 File Offset: 0x0000E218
	[Token(Token = "0x6000372")]
	[Address(RVA = "0x4B0B60", Offset = "0x4AF160", VA = "0x1804B0B60")]
	public static PlantType GetBasePlant(PlantType plantType)
	{
		int num;
		do
		{
			Dictionary<PlantType, PlantEvolutionData> evolutions = GodEvolution.Evolutions;
			num = 0;
			bool flag;
			if (flag)
			{
				bool flag2;
				if (flag2)
				{
					bool flag3;
					while (!flag3)
					{
					}
				}
				if (num != 0)
				{
					goto IL_004A;
				}
			}
		}
		while (num != 0);
		throw new NullReferenceException();
		IL_004A:
		throw new NullReferenceException();
	}

	// Token: 0x040001CF RID: 463
	[Token(Token = "0x40001CF")]
	private static Dictionary<PlantType, PlantEvolutionData> currentPlantEvolutions = new Dictionary();

	// Token: 0x040001D0 RID: 464
	[Token(Token = "0x40001D0")]
	private static readonly Dictionary<PlantType, PlantEvolutionData> originalPlantEvolutions = new Dictionary();
}
