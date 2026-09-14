using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

// Token: 0x020000D9 RID: 217
[Token(Token = "0x20000D9")]
[Serializable]
public class PlantDevelopData
{
	// Token: 0x06000424 RID: 1060 RVA: 0x00015388 File Offset: 0x00013588
	[Token(Token = "0x6000424")]
	[Address(RVA = "0x4C38B0", Offset = "0x4C1EB0", VA = "0x1804C38B0")]
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

	// Token: 0x06000425 RID: 1061 RVA: 0x00015408 File Offset: 0x00013608
	[Token(Token = "0x6000425")]
	[Address(RVA = "0x4C3A80", Offset = "0x4C2080", VA = "0x1804C3A80")]
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

	// Token: 0x06000426 RID: 1062 RVA: 0x00015438 File Offset: 0x00013638
	[Token(Token = "0x6000426")]
	[Address(RVA = "0x4C3B40", Offset = "0x4C2140", VA = "0x1804C3B40")]
	public bool TryGetCustomizedPlant(PlantType thePlantType, [Out] CustomizedPlant data)
	{
		Dictionary<PlantType, CustomizedPlant> dictionary = this.plantDic;
		bool flag;
		return flag;
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00015458 File Offset: 0x00013658
	[Token(Token = "0x6000427")]
	[Address(RVA = "0x4C3C70", Offset = "0x4C2270", VA = "0x1804C3C70")]
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

	// Token: 0x06000428 RID: 1064 RVA: 0x000154AC File Offset: 0x000136AC
	[Token(Token = "0x6000428")]
	[Address(RVA = "0x4C3BB0", Offset = "0x4C21B0", VA = "0x1804C3BB0")]
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

	// Token: 0x06000429 RID: 1065 RVA: 0x00015504 File Offset: 0x00013704
	[Token(Token = "0x6000429")]
	[Address(RVA = "0x4C3E40", Offset = "0x4C2440", VA = "0x1804C3E40")]
	public PlantDevelopData()
	{
		List<CustomizedPlant> list = new List();
		this.plants = list;
		Dictionary<PlantType, CustomizedPlant> dictionary = new Dictionary();
		this.plantDic = dictionary;
		base..ctor();
	}

	// Token: 0x04000242 RID: 578
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000242")]
	public List<CustomizedPlant> plants;

	// Token: 0x04000243 RID: 579
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000243")]
	private readonly Dictionary<PlantType, CustomizedPlant> plantDic;
}
