using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using PlantEvolution;
using UnityEngine;

// Token: 0x020000C5 RID: 197
[Token(Token = "0x20000C5")]
public static class GodEvolution
{
	// Token: 0x17000088 RID: 136
	// (get) Token: 0x06000385 RID: 901 RVA: 0x00010150 File Offset: 0x0000E350
	// (set) Token: 0x06000386 RID: 902 RVA: 0x00010190 File Offset: 0x0000E390
	[Token(Token = "0x17000088")]
	public static Dictionary<PlantType, PlantEvolutionData> Evolutions
	{
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x4F1170", Offset = "0x4EF770", VA = "0x1804F1170")]
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
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x4F12A0", Offset = "0x4EF8A0", VA = "0x1804F12A0")]
		set
		{
			GodEvolution.currentPlantEvolutions = value;
		}
	}

	// Token: 0x06000387 RID: 903 RVA: 0x000101A4 File Offset: 0x0000E3A4
	[Token(Token = "0x6000387")]
	[Address(RVA = "0x4F1060", Offset = "0x4EF660", VA = "0x1804F1060")]
	static GodEvolution()
	{
		GodEvolution.LoadFromJson();
	}

	// Token: 0x06000388 RID: 904 RVA: 0x000101D0 File Offset: 0x0000E3D0
	[Token(Token = "0x6000388")]
	[Address(RVA = "0x4F08E0", Offset = "0x4EEEE0", VA = "0x1804F08E0")]
	private static void InitEvolutionData()
	{
		GodEvolution.LoadFromJson();
	}

	// Token: 0x06000389 RID: 905 RVA: 0x000101E4 File Offset: 0x0000E3E4
	[Token(Token = "0x6000389")]
	[Address(RVA = "0x4F0920", Offset = "0x4EEF20", VA = "0x1804F0920")]
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

	// Token: 0x0600038A RID: 906 RVA: 0x00010244 File Offset: 0x0000E444
	[Token(Token = "0x600038A")]
	[Address(RVA = "0x4F0BC0", Offset = "0x4EF1C0", VA = "0x1804F0BC0")]
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

	// Token: 0x0600038B RID: 907 RVA: 0x000102E0 File Offset: 0x0000E4E0
	[Token(Token = "0x600038B")]
	[Address(RVA = "0x4F0F80", Offset = "0x4EF580", VA = "0x1804F0F80")]
	public static void ReloadConfig()
	{
		GodEvolution.Evolutions.Clear();
		PlantEvolutionConfigLoader.ReloadConfig();
		GodEvolution.LoadFromJson();
		Debug.Log("植物进化配置已重新加载");
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00010318 File Offset: 0x0000E518
	[Token(Token = "0x600038C")]
	[Address(RVA = "0x4F0530", Offset = "0x4EEB30", VA = "0x1804F0530")]
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

	// Token: 0x0600038D RID: 909 RVA: 0x00010388 File Offset: 0x0000E588
	[Token(Token = "0x600038D")]
	[Address(RVA = "0x4F01F0", Offset = "0x4EE7F0", VA = "0x1804F01F0")]
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

	// Token: 0x040001DC RID: 476
	[Token(Token = "0x40001DC")]
	private static Dictionary<PlantType, PlantEvolutionData> currentPlantEvolutions = new Dictionary();

	// Token: 0x040001DD RID: 477
	[Token(Token = "0x40001DD")]
	private static readonly Dictionary<PlantType, PlantEvolutionData> originalPlantEvolutions = new Dictionary();
}
