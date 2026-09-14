using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;

// Token: 0x0200073D RID: 1853
[Token(Token = "0x200073D")]
public class PlantDataManager
{
	// Token: 0x060025B4 RID: 9652 RVA: 0x000C6B28 File Offset: 0x000C4D28
	[Token(Token = "0x60025B4")]
	[Address(RVA = "0x5C9BD0", Offset = "0x5C81D0", VA = "0x1805C9BD0")]
	public static PlantDataManager.PlantData GetPlantData(PlantType plantType)
	{
		int num = 0;
		PlantDataManager.PlantData plantData;
		if (!LevelManager.TryGetLevelData(num) || plantData == 0)
		{
			Dictionary<PlantType, PlantDataManager.PlantData> plantData_Modified = PlantDataManager.PlantData_Modified;
			PlantType plantType2 = plantType;
			bool flag;
			if (flag)
			{
			}
		}
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

	// Token: 0x060025B5 RID: 9653 RVA: 0x000C6BB8 File Offset: 0x000C4DB8
	[Token(Token = "0x60025B5")]
	[Address(RVA = "0x5C9E90", Offset = "0x5C8490", VA = "0x1805C9E90")]
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

	// Token: 0x060025B6 RID: 9654 RVA: 0x000C6BEC File Offset: 0x000C4DEC
	[Token(Token = "0x60025B6")]
	[Address(RVA = "0x5CA350", Offset = "0x5C8950", VA = "0x1805CA350")]
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

	// Token: 0x060025B7 RID: 9655 RVA: 0x000C6CD0 File Offset: 0x000C4ED0
	[Token(Token = "0x60025B7")]
	[Address(RVA = "0x5C9FA0", Offset = "0x5C85A0", VA = "0x1805C9FA0")]
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

	// Token: 0x060025B8 RID: 9656 RVA: 0x000C6EC4 File Offset: 0x000C50C4
	[Token(Token = "0x60025B8")]
	[Address(RVA = "0x5C99A0", Offset = "0x5C7FA0", VA = "0x1805C99A0")]
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

	// Token: 0x060025B9 RID: 9657 RVA: 0x000C6F28 File Offset: 0x000C5128
	[Token(Token = "0x60025B9")]
	[Address(RVA = "0x5C9B80", Offset = "0x5C8180", VA = "0x1805C9B80")]
	public static void ApplyModify(CustomizedPlant plant)
	{
		PlantDataManager.ModifyPlant(plant);
	}

	// Token: 0x060025BA RID: 9658 RVA: 0x000C6F3C File Offset: 0x000C513C
	[Token(Token = "0x60025BA")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PlantDataManager()
	{
	}

	// Token: 0x04001308 RID: 4872
	[Token(Token = "0x4001308")]
	private static readonly Dictionary<PlantType, PlantDataManager.PlantData> PlantData_Default = new Dictionary();

	// Token: 0x04001309 RID: 4873
	[Token(Token = "0x4001309")]
	private static readonly Dictionary<PlantType, PlantDataManager.PlantData> PlantData_Modified = new Dictionary();

	// Token: 0x0200073E RID: 1854
	[Token(Token = "0x200073E")]
	[Serializable]
	public class PlantData
	{
		// Token: 0x060025BC RID: 9660 RVA: 0x000C6F74 File Offset: 0x000C5174
		[Token(Token = "0x60025BC")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public PlantData()
		{
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x000C6F88 File Offset: 0x000C5188
		[Token(Token = "0x60025BD")]
		[Address(RVA = "0x5CA590", Offset = "0x5C8B90", VA = "0x1805CA590")]
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

		// Token: 0x0400130A RID: 4874
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400130A")]
		public PlantType thePlantType;

		// Token: 0x0400130B RID: 4875
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400130B")]
		public float attackInterval;

		// Token: 0x0400130C RID: 4876
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400130C")]
		public float produceInterval;

		// Token: 0x0400130D RID: 4877
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400130D")]
		public int attackDamage;

		// Token: 0x0400130E RID: 4878
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400130E")]
		public int maxHealth;

		// Token: 0x0400130F RID: 4879
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400130F")]
		public float cd;

		// Token: 0x04001310 RID: 4880
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001310")]
		public int cost;
	}
}
