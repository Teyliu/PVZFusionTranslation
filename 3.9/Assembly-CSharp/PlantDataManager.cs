using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;

// Token: 0x02000776 RID: 1910
[Token(Token = "0x2000776")]
public class PlantDataManager
{
	// Token: 0x060026D9 RID: 9945 RVA: 0x000CBA0C File Offset: 0x000C9C0C
	[Token(Token = "0x60026D9")]
	[Address(RVA = "0x62AF90", Offset = "0x629590", VA = "0x18062AF90")]
	public static PlantDataManager.PlantData GetPlantData(PlantType plantType)
	{
		int num = 0;
		if (LevelManager.TryGetLevelData(num))
		{
			Func<PlantDataManager.PlantData, bool> func = delegate(PlantDataManager.PlantData p)
			{
				PlantType plantType5 = plantType;
				return p.thePlantType == plantType5;
			};
			PlantDataManager.PlantData plantData;
			if (plantData != 0)
			{
				goto IL_0040;
			}
		}
		Dictionary<PlantType, PlantDataManager.PlantData> plantData_Modified = PlantDataManager.PlantData_Modified;
		PlantType plantType2 = plantType;
		bool flag;
		if (flag)
		{
		}
		IL_0040:
		Dictionary<PlantType, PlantDataManager.PlantData> plantData_Default = PlantDataManager.PlantData_Default;
		PlantType plantType3 = plantType;
		bool flag2 = plantData_Default.TryGetValue(plantType3, num);
		if (!flag2)
		{
			PlantType plantType4 = plantType;
			if (flag2 > true && flag2 > true)
			{
				Debug.LogError(string.Format("未找到植物类型 {0} 的数据", flag2));
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060026DA RID: 9946 RVA: 0x000CBAA8 File Offset: 0x000C9CA8
	[Token(Token = "0x60026DA")]
	[Address(RVA = "0x62B250", Offset = "0x629850", VA = "0x18062B250")]
	public static PlantDataManager.PlantData GetPlantOriginalData(PlantType plantType)
	{
		Dictionary<PlantType, PlantDataManager.PlantData> plantData_Default = PlantDataManager.PlantData_Default;
		bool flag;
		if (!flag)
		{
			Debug.LogError(string.Format("未找到植物类型 {0} 的数据", flag));
		}
		throw new NullReferenceException();
	}

	// Token: 0x060026DB RID: 9947 RVA: 0x000CBADC File Offset: 0x000C9CDC
	[Token(Token = "0x60026DB")]
	[Address(RVA = "0x62B710", Offset = "0x629D10", VA = "0x18062B710")]
	public static void ModifyPlant(CustomizedPlant plant)
	{
		Dictionary<PlantType, PlantDataManager.PlantData> plantData_Modified = PlantDataManager.PlantData_Modified;
		PlantType thePlantType = plant.thePlantType;
		PlantDataManager.PlantData plantData = plantData_Modified[thePlantType];
		int attackDamage = plant.attackDamage;
		plantData.attackDamage = attackDamage;
		Dictionary<PlantType, PlantDataManager.PlantData> plantData_Modified2 = PlantDataManager.PlantData_Modified;
		PlantType thePlantType2 = plant.thePlantType;
		PlantDataManager.PlantData plantData2 = plantData_Modified2[thePlantType2];
		float attackInterval = plant.attackInterval;
		plantData2.attackInterval = attackInterval;
		Dictionary<PlantType, PlantDataManager.PlantData> plantData_Modified3 = PlantDataManager.PlantData_Modified;
		PlantType thePlantType3 = plant.thePlantType;
		PlantDataManager.PlantData plantData3 = plantData_Modified3[thePlantType3];
		int theHealth = plant.theHealth;
		plantData3.maxHealth = theHealth;
		Dictionary<PlantType, PlantDataManager.PlantData> plantData_Modified4 = PlantDataManager.PlantData_Modified;
		PlantType thePlantType4 = plant.thePlantType;
		PlantDataManager.PlantData plantData4 = plantData_Modified4[thePlantType4];
		float cd = plant.cd;
		plantData4.cd = cd;
		Dictionary<PlantType, PlantDataManager.PlantData> plantData_Modified5 = PlantDataManager.PlantData_Modified;
		PlantType thePlantType5 = plant.thePlantType;
		PlantDataManager.PlantData plantData5 = plantData_Modified5[thePlantType5];
		int cost = plant.cost;
		plantData5.cost = cost;
	}

	// Token: 0x060026DC RID: 9948 RVA: 0x000CBBC0 File Offset: 0x000C9DC0
	[Token(Token = "0x60026DC")]
	[Address(RVA = "0x62B360", Offset = "0x629960", VA = "0x18062B360")]
	public static void Init()
	{
		string text = Resources.Load<TextAsset>("plant_data").text;
		char[] array = new char[2];
		array[0] = (char)((ulong)10L);
		array[0] = (char)((ulong)13L);
		uint num;
		string[] array2;
		if (num < (uint)array2.Length)
		{
			PlantDataManager.PlantData plantData = new PlantDataManager.PlantData();
			string[] array3;
			int num2 = int.Parse(array3[0]);
			plantData.thePlantType = (PlantType)num2;
			float num3 = float.Parse(array3[1]);
			plantData.attackInterval = num3;
			float num4 = float.Parse(array3[2]);
			plantData.produceInterval = num4;
			int num5 = int.Parse(array3[3]);
			plantData.attackDamage = num5;
			int num6 = int.Parse(array3[4]);
			plantData.maxHealth = num6;
			float num7 = float.Parse(array3[5]);
			plantData.cd = num7;
			int num8 = int.Parse(array3[6]);
			plantData.cost = num8;
			PlantDataManager.PlantData plantData2 = new PlantDataManager.PlantData();
			int num9 = int.Parse(array3[0]);
			plantData2.thePlantType = (PlantType)num9;
			float num10 = float.Parse(array3[1]);
			plantData2.attackInterval = num10;
			float num11 = float.Parse(array3[2]);
			plantData2.produceInterval = num11;
			int num12 = int.Parse(array3[3]);
			plantData2.attackDamage = num12;
			int num13 = int.Parse(array3[4]);
			plantData2.maxHealth = num13;
			float num14 = float.Parse(array3[5]);
			plantData2.cd = num14;
			int num15 = int.Parse(array3[6]);
			plantData2.cost = num15;
			Dictionary<PlantType, PlantDataManager.PlantData> plantData_Default = PlantDataManager.PlantData_Default;
			PlantType thePlantType = plantData.thePlantType;
			plantData_Default.Add(thePlantType, plantData);
			Dictionary<PlantType, PlantDataManager.PlantData> plantData_Modified = PlantDataManager.PlantData_Modified;
			PlantType thePlantType2 = plantData2.thePlantType;
			plantData_Modified.Add(thePlantType2, plantData2);
			num += (uint)1;
		}
		PlantDataManager.ApplyModify();
	}

	// Token: 0x060026DD RID: 9949 RVA: 0x000CBDB4 File Offset: 0x000C9FB4
	[Token(Token = "0x60026DD")]
	[Address(RVA = "0x62AD60", Offset = "0x629360", VA = "0x18062AD60")]
	public static void ApplyModify()
	{
		int num = 0;
		List<CustomizedPlant> plants = AdvantureConfig.data.plantDevelopData.plants;
		bool flag;
		if (flag)
		{
			PlantDataManager.ModifyPlant(num);
		}
		AdvantureConfig.data.plantDevelopData.UpdateDics();
		ulong num2;
		if (num2 == (ulong)0L)
		{
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060026DE RID: 9950 RVA: 0x000CBE18 File Offset: 0x000CA018
	[Token(Token = "0x60026DE")]
	[Address(RVA = "0x62AF40", Offset = "0x629540", VA = "0x18062AF40")]
	public static void ApplyModify(CustomizedPlant plant)
	{
		PlantDataManager.ModifyPlant(plant);
	}

	// Token: 0x060026DF RID: 9951 RVA: 0x000CBE2C File Offset: 0x000CA02C
	[Token(Token = "0x60026DF")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PlantDataManager()
	{
	}

	// Token: 0x040013DE RID: 5086
	[Token(Token = "0x40013DE")]
	private static readonly Dictionary<PlantType, PlantDataManager.PlantData> PlantData_Default = new Dictionary();

	// Token: 0x040013DF RID: 5087
	[Token(Token = "0x40013DF")]
	private static readonly Dictionary<PlantType, PlantDataManager.PlantData> PlantData_Modified = new Dictionary();

	// Token: 0x02000777 RID: 1911
	[Token(Token = "0x2000777")]
	[Serializable]
	public class PlantData
	{
		// Token: 0x060026E1 RID: 9953 RVA: 0x000CBE64 File Offset: 0x000CA064
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public PlantData()
		{
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x000CBE78 File Offset: 0x000CA078
		[Token(Token = "0x60026E2")]
		[Address(RVA = "0x62B950", Offset = "0x629F50", VA = "0x18062B950")]
		public PlantData(PlantDataManager.PlantData plantData)
		{
			PlantType plantType = plantData.thePlantType;
			this.thePlantType = plantType;
			float num = plantData.attackInterval;
			this.attackInterval = num;
			float num2 = plantData.produceInterval;
			this.produceInterval = num2;
			int num3 = plantData.attackDamage;
			this.attackDamage = num3;
			int num4 = plantData.maxHealth;
			this.maxHealth = num4;
			float num5 = plantData.cd;
			this.cd = num5;
			int num6 = plantData.cost;
			this.cost = num6;
		}

		// Token: 0x040013E0 RID: 5088
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40013E0")]
		public PlantType thePlantType;

		// Token: 0x040013E1 RID: 5089
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40013E1")]
		public float attackInterval;

		// Token: 0x040013E2 RID: 5090
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40013E2")]
		public float produceInterval;

		// Token: 0x040013E3 RID: 5091
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40013E3")]
		public int attackDamage;

		// Token: 0x040013E4 RID: 5092
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40013E4")]
		public int maxHealth;

		// Token: 0x040013E5 RID: 5093
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40013E5")]
		public float cd;

		// Token: 0x040013E6 RID: 5094
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40013E6")]
		public int cost;
	}
}
