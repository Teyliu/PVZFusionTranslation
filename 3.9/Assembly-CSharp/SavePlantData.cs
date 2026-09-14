using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007ED RID: 2029
[Token(Token = "0x20007ED")]
[Serializable]
public class SavePlantData
{
	// Token: 0x06002921 RID: 10529 RVA: 0x000DE038 File Offset: 0x000DC238
	[Token(Token = "0x6002921")]
	[Address(RVA = "0x66FB10", Offset = "0x66E110", VA = "0x18066FB10")]
	public SavePlantData(Plant plant)
	{
		List<object> list = new List();
		this.objects = list;
		base..ctor();
		int num = 0;
		if (plant != num)
		{
			plant.BeforeSerialized(this);
			int num2 = plant.thePlantColumn;
			this.thePlantColumn = num2;
			int num3 = plant.thePlantRow;
			this.thePlantRow = num3;
			PlantType plantType = plant.thePlantType;
			this.thePlantType = plantType;
			int num4 = plant.thePlantHealth;
			this.thePlantHealth = num4;
			int num5 = plant.thePlantStage;
			this.thePlantStage = num5;
			PlantType plantType2 = plant.theLilyType;
			this.theLilyType = plantType2;
			int attributeCount = plant.attributeCount;
			this.theAttributeCount = attributeCount;
			int num6 = plant.theLevel;
			this.theLevel = num6;
			bool flag = plant.imitatless;
			this.imitatless = flag;
			bool dieMeansLose = plant.dieMeansLose;
			this.diemeanlose = dieMeansLose;
			bool flag2 = plant.uncrashable;
			this.uncrashable = flag2;
			bool flag3 = plant.starUp;
			this.starUp = flag3;
			this.towards = (flag3 ? Towards.Right : Towards.Left);
			this.upgradeType = (flag3 ? TowerUpgradeType.Upgraded : TowerUpgradeType.Default);
		}
	}

	// Token: 0x06002922 RID: 10530 RVA: 0x000DE144 File Offset: 0x000DC344
	[Token(Token = "0x6002922")]
	[Address(RVA = "0x66FA10", Offset = "0x66E010", VA = "0x18066FA10")]
	public Plant SetPlant()
	{
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		Plant plant;
		if (!(plant != num))
		{
		}
		this.LoadData(plant);
		return plant;
	}

	// Token: 0x06002923 RID: 10531 RVA: 0x000DE180 File Offset: 0x000DC380
	[Token(Token = "0x6002923")]
	[Address(RVA = "0x66F8C0", Offset = "0x66DEC0", VA = "0x18066F8C0")]
	public void LoadData(Plant plant)
	{
		Towards towards = this.towards;
		if (this.upgradeType == TowerUpgradeType.Upgraded)
		{
		}
		int num = this.thePlantStage;
		plant.thePlantStage = num;
		int num2 = this.thePlantHealth;
		plant.thePlantHealth = num2;
		int num3 = this.theAttributeCount;
		plant.attributeCount = num3;
		bool flag = this.imitatless;
		plant.imitatless = flag;
		bool flag2 = this.diemeanlose;
		plant.dieMeansLose = flag2;
		bool flag3 = this.uncrashable;
		plant.uncrashable = flag3;
		if (this.starUp)
		{
			plant.StarUp();
		}
		if (this.theLevel != 0)
		{
			int num4 = this.theLevel;
			int num5 = 0;
			ulong num6;
			bool flag4 = plant.Upgrade(num4, num6 != 0UL, num5 != 0);
		}
		throw new NullReferenceException();
	}

	// Token: 0x0400172C RID: 5932
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400172C")]
	public int thePlantColumn;

	// Token: 0x0400172D RID: 5933
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400172D")]
	public int thePlantRow;

	// Token: 0x0400172E RID: 5934
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400172E")]
	public PlantType thePlantType;

	// Token: 0x0400172F RID: 5935
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400172F")]
	public int thePlantHealth;

	// Token: 0x04001730 RID: 5936
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001730")]
	public PlantType theLilyType;

	// Token: 0x04001731 RID: 5937
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001731")]
	public int thePlantStage;

	// Token: 0x04001732 RID: 5938
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001732")]
	public int theAttributeCount;

	// Token: 0x04001733 RID: 5939
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001733")]
	public int theLevel;

	// Token: 0x04001734 RID: 5940
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001734")]
	public bool imitatless;

	// Token: 0x04001735 RID: 5941
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4001735")]
	public bool diemeanlose;

	// Token: 0x04001736 RID: 5942
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x4001736")]
	public bool uncrashable;

	// Token: 0x04001737 RID: 5943
	[FieldOffset(Offset = "0x33")]
	[Token(Token = "0x4001737")]
	public bool starUp;

	// Token: 0x04001738 RID: 5944
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001738")]
	public Towards towards;

	// Token: 0x04001739 RID: 5945
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001739")]
	public TowerUpgradeType upgradeType;

	// Token: 0x0400173A RID: 5946
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400173A")]
	[SerializeReference]
	public List<object> objects;
}
