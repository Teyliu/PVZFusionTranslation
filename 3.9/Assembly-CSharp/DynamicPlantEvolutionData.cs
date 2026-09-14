using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using PlantEvolution;
using UnityEngine;

// Token: 0x020000BF RID: 191
[Token(Token = "0x20000BF")]
public class DynamicPlantEvolutionData : PlantEvolutionData
{
	// Token: 0x06000376 RID: 886 RVA: 0x0000FD78 File Offset: 0x0000DF78
	[Token(Token = "0x6000376")]
	[Address(RVA = "0x4EF750", Offset = "0x4EDD50", VA = "0x1804EF750")]
	public DynamicPlantEvolutionData(string basePlantStr, List<PlantEvolutionConfigLoader.RouteConfig> routes)
	{
		this.basePlantStr = basePlantStr;
		this.routes = routes;
		Dictionary<PlantType, PlantEvolutionConfigLoader.StageConfig> dictionary = new Dictionary();
		this.stageProperties = dictionary;
		this.ParseStageProperties();
	}

	// Token: 0x06000377 RID: 887 RVA: 0x0000FDAC File Offset: 0x0000DFAC
	[Token(Token = "0x6000377")]
	[Address(RVA = "0x4EF150", Offset = "0x4ED750", VA = "0x1804EF150")]
	private void ParseStageProperties()
	{
		int num;
		do
		{
			num = 0;
			List<PlantEvolutionConfigLoader.RouteConfig> list = this.routes;
			bool flag;
			if (flag)
			{
				bool flag2;
				if (flag2)
				{
					bool flag3;
					if (!flag3)
					{
						Debug.LogWarning("无法解析植物类型: " + num);
					}
					Dictionary<PlantType, PlantEvolutionConfigLoader.StageConfig> dictionary = this.stageProperties;
				}
				if (num != 0)
				{
					goto IL_0063;
				}
			}
		}
		while (num != 0);
		int num2;
		Debug.Log(string.Format("[DynamicPlantEvolutionData] 解析了 {0} 个阶段的属性配置", num2));
		return;
		IL_0063:
		throw new NullReferenceException();
	}

	// Token: 0x06000378 RID: 888 RVA: 0x0000FE24 File Offset: 0x0000E024
	[Token(Token = "0x6000378")]
	[Address(RVA = "0x4EECC0", Offset = "0x4ED2C0", VA = "0x1804EECC0", Slot = "4")]
	public override PlantType GetBasePlant()
	{
		int num = 0;
		bool flag = Enum.TryParse<PlantType>(this.basePlantStr, (PlantType)num);
		return PlantType.Peashooter;
	}

	// Token: 0x06000379 RID: 889 RVA: 0x0000FE4C File Offset: 0x0000E04C
	[Token(Token = "0x6000379")]
	[Address(RVA = "0x4EED40", Offset = "0x4ED340", VA = "0x1804EED40", Slot = "5")]
	public override List<PlantEvolutionRoute> GetRoutes()
	{
		int num;
		List<PlantEvolutionRoute> list;
		do
		{
			num = 0;
			list = new List();
			List<PlantEvolutionConfigLoader.RouteConfig> list2 = this.routes;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				PlantEvolutionRoute plantEvolutionRoute;
				plantEvolutionRoute.routeName = num2;
				List<PlantType> list3 = new List();
				plantEvolutionRoute.stages = list3;
				List<int> list4 = new List(list3);
				plantEvolutionRoute.stageCost = list4;
				bool flag2;
				if (flag2)
				{
					bool flag3;
					while (!flag3)
					{
					}
					List<PlantType> stages = plantEvolutionRoute.stages;
				}
				if (num != 0)
				{
					goto IL_007A;
				}
			}
		}
		while (num != 0);
		return list;
		IL_007A:
		throw new NullReferenceException();
	}

	// Token: 0x0600037A RID: 890 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
	[Token(Token = "0x600037A")]
	[Address(RVA = "0x4EF510", Offset = "0x4EDB10", VA = "0x1804EF510", Slot = "6")]
	public override void ReinforcePlant(Plant plant)
	{
		Dictionary<PlantType, PlantEvolutionConfigLoader.StageConfig> dictionary = this.stageProperties;
		PlantType thePlantType = plant.thePlantType;
		bool flag;
		if (!flag)
		{
			Debug.LogWarning(string.Format("[ReinforcePlant] 未找到植物 {0} 的属性配置", flag));
			return;
		}
		plant.attackDamage = (flag ? 1 : 0);
		int num = 0;
		plant.thePlantAttackInterval = flag;
		plant.thePlantMaxHealth = (flag ? 1 : 0);
		plant.attackSpeedAdder = (float)num;
		ulong num2;
		num2 += (ulong)1L;
		float num3 = (float)(num * (int)plant.thePlantSpeed);
		plant.thePlantSpeed = num3;
		int thePlantMaxHealth = plant.thePlantMaxHealth;
		plant.thePlantHealth = thePlantMaxHealth;
		int thePlantMaxHealth2 = plant.thePlantMaxHealth;
		int attackDamage = plant.attackDamage;
		Debug.Log(string.Format("[ReinforcePlant] 应用 JSON 配置属性: {0} - HP:{1} DMG:{2}", thePlantMaxHealth, thePlantMaxHealth, thePlantMaxHealth));
	}

	// Token: 0x040001D0 RID: 464
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D0")]
	private string basePlantStr;

	// Token: 0x040001D1 RID: 465
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001D1")]
	private List<PlantEvolutionConfigLoader.RouteConfig> routes;

	// Token: 0x040001D2 RID: 466
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D2")]
	private Dictionary<PlantType, PlantEvolutionConfigLoader.StageConfig> stageProperties;
}
