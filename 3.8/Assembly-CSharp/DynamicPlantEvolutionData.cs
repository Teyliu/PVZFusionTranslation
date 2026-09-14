using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using PlantEvolution;
using UnityEngine;

// Token: 0x020000BA RID: 186
[Token(Token = "0x20000BA")]
public class DynamicPlantEvolutionData : PlantEvolutionData
{
	// Token: 0x0600035B RID: 859 RVA: 0x0000FA08 File Offset: 0x0000DC08
	[Token(Token = "0x600035B")]
	[Address(RVA = "0x4B00C0", Offset = "0x4AE6C0", VA = "0x1804B00C0")]
	public DynamicPlantEvolutionData(string basePlantStr, List<PlantEvolutionConfigLoader.RouteConfig> routes)
	{
		this.basePlantStr = basePlantStr;
		this.routes = routes;
		Dictionary<PlantType, PlantEvolutionConfigLoader.StageConfig> dictionary = new Dictionary();
		this.stageProperties = dictionary;
		this.ParseStageProperties();
	}

	// Token: 0x0600035C RID: 860 RVA: 0x0000FA3C File Offset: 0x0000DC3C
	[Token(Token = "0x600035C")]
	[Address(RVA = "0x4AFAC0", Offset = "0x4AE0C0", VA = "0x1804AFAC0")]
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

	// Token: 0x0600035D RID: 861 RVA: 0x0000FAB4 File Offset: 0x0000DCB4
	[Token(Token = "0x600035D")]
	[Address(RVA = "0x4AF630", Offset = "0x4ADC30", VA = "0x1804AF630", Slot = "4")]
	public override PlantType GetBasePlant()
	{
		int num = 0;
		bool flag = Enum.TryParse<PlantType>(this.basePlantStr, (PlantType)num);
		return PlantType.Peashooter;
	}

	// Token: 0x0600035E RID: 862 RVA: 0x0000FADC File Offset: 0x0000DCDC
	[Token(Token = "0x600035E")]
	[Address(RVA = "0x4AF6B0", Offset = "0x4ADCB0", VA = "0x1804AF6B0", Slot = "5")]
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

	// Token: 0x0600035F RID: 863 RVA: 0x0000FB80 File Offset: 0x0000DD80
	[Token(Token = "0x600035F")]
	[Address(RVA = "0x4AFE80", Offset = "0x4AE480", VA = "0x1804AFE80", Slot = "6")]
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

	// Token: 0x040001C3 RID: 451
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C3")]
	private string basePlantStr;

	// Token: 0x040001C4 RID: 452
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C4")]
	private List<PlantEvolutionConfigLoader.RouteConfig> routes;

	// Token: 0x040001C5 RID: 453
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C5")]
	private Dictionary<PlantType, PlantEvolutionConfigLoader.StageConfig> stageProperties;
}
