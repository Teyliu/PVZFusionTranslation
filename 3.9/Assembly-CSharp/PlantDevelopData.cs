using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

// Token: 0x020000DE RID: 222
[Token(Token = "0x20000DE")]
[Serializable]
public class PlantDevelopData
{
	// Token: 0x0600043F RID: 1087 RVA: 0x00015820 File Offset: 0x00013A20
	[Token(Token = "0x600043F")]
	[Address(RVA = "0x503690", Offset = "0x501C90", VA = "0x180503690")]
	public void CustomizePlant(CustomizedPlant plant)
	{
		Predicate<CustomizedPlant> predicate;
		int num = this.plants.FindIndex(predicate);
		List<CustomizedPlant> list = this.plants;
		if (num == -1)
		{
			CustomizedPlant plant2 = plant;
			int num2 = list._size + 1;
			list._size = num2;
		}
		CustomizedPlant plant3 = plant;
		list[num] = plant3;
		CustomizedPlant plant4 = plant;
		this.UpdateDic(plant4);
		PlantDataManager.ApplyModify(plant);
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x000158A0 File Offset: 0x00013AA0
	[Token(Token = "0x6000440")]
	[Address(RVA = "0x503860", Offset = "0x501E60", VA = "0x180503860")]
	public bool TryGetCustomizedPlantInGame(PlantType thePlantType, [Out] CustomizedPlant data)
	{
		Dictionary<PlantType, CustomizedPlant> dictionary = this.plantDic;
		bool flag;
		if (!flag)
		{
			return flag;
		}
		return "{il2cpp field on {'constant14' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x9C}" == (ulong)10L;
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x000158D0 File Offset: 0x00013AD0
	[Token(Token = "0x6000441")]
	[Address(RVA = "0x503920", Offset = "0x501F20", VA = "0x180503920")]
	public bool TryGetCustomizedPlant(PlantType thePlantType, [Out] CustomizedPlant data)
	{
		Dictionary<PlantType, CustomizedPlant> dictionary = this.plantDic;
		bool flag;
		return flag;
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x000158F0 File Offset: 0x00013AF0
	[Token(Token = "0x6000442")]
	[Address(RVA = "0x503A50", Offset = "0x502050", VA = "0x180503A50")]
	public void UpdateDics()
	{
		ulong num;
		do
		{
			List<CustomizedPlant> list = this.plants;
			bool flag;
			if (flag)
			{
				Dictionary<PlantType, CustomizedPlant> dictionary = this.plantDic;
				Dictionary<PlantType, CustomizedPlant> dictionary2 = this.plantDic;
				bool flag2;
				if (!flag2)
				{
				}
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00015944 File Offset: 0x00013B44
	[Token(Token = "0x6000443")]
	[Address(RVA = "0x503990", Offset = "0x501F90", VA = "0x180503990")]
	public void UpdateDic(CustomizedPlant data)
	{
		Dictionary<PlantType, CustomizedPlant> dictionary = this.plantDic;
		PlantType thePlantType = data.thePlantType;
		bool flag = dictionary.ContainsKey(thePlantType);
		Dictionary<PlantType, CustomizedPlant> dictionary2 = this.plantDic;
		if (!flag)
		{
			PlantType thePlantType2 = data.thePlantType;
			dictionary2.Add(thePlantType2, data);
			return;
		}
		PlantType thePlantType3 = data.thePlantType;
		dictionary2[thePlantType3] = data;
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x0001599C File Offset: 0x00013B9C
	[Token(Token = "0x6000444")]
	[Address(RVA = "0x503C20", Offset = "0x502220", VA = "0x180503C20")]
	public PlantDevelopData()
	{
		List<CustomizedPlant> list = new List();
		this.plants = list;
		Dictionary<PlantType, CustomizedPlant> dictionary = new Dictionary();
		this.plantDic = dictionary;
		base..ctor();
	}

	// Token: 0x04000250 RID: 592
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000250")]
	public List<CustomizedPlant> plants;

	// Token: 0x04000251 RID: 593
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000251")]
	private readonly Dictionary<PlantType, CustomizedPlant> plantDic;
}
