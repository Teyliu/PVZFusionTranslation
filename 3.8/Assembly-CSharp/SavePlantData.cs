using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007B4 RID: 1972
[Token(Token = "0x20007B4")]
[Serializable]
public class SavePlantData
{
	// Token: 0x060027F2 RID: 10226 RVA: 0x000D907C File Offset: 0x000D727C
	[Token(Token = "0x60027F2")]
	[Address(RVA = "0x60C2C0", Offset = "0x60A8C0", VA = "0x18060C2C0")]
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

	// Token: 0x060027F3 RID: 10227 RVA: 0x000D9188 File Offset: 0x000D7388
	[Token(Token = "0x60027F3")]
	[Address(RVA = "0x60C1C0", Offset = "0x60A7C0", VA = "0x18060C1C0")]
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

	// Token: 0x060027F4 RID: 10228 RVA: 0x000D91C4 File Offset: 0x000D73C4
	[Token(Token = "0x60027F4")]
	[Address(RVA = "0x60C070", Offset = "0x60A670", VA = "0x18060C070")]
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

	// Token: 0x04001650 RID: 5712
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001650")]
	public int thePlantColumn;

	// Token: 0x04001651 RID: 5713
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001651")]
	public int thePlantRow;

	// Token: 0x04001652 RID: 5714
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001652")]
	public PlantType thePlantType;

	// Token: 0x04001653 RID: 5715
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001653")]
	public int thePlantHealth;

	// Token: 0x04001654 RID: 5716
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001654")]
	public PlantType theLilyType;

	// Token: 0x04001655 RID: 5717
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001655")]
	public int thePlantStage;

	// Token: 0x04001656 RID: 5718
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001656")]
	public int theAttributeCount;

	// Token: 0x04001657 RID: 5719
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001657")]
	public int theLevel;

	// Token: 0x04001658 RID: 5720
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001658")]
	public bool imitatless;

	// Token: 0x04001659 RID: 5721
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4001659")]
	public bool diemeanlose;

	// Token: 0x0400165A RID: 5722
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x400165A")]
	public bool uncrashable;

	// Token: 0x0400165B RID: 5723
	[FieldOffset(Offset = "0x33")]
	[Token(Token = "0x400165B")]
	public bool starUp;

	// Token: 0x0400165C RID: 5724
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400165C")]
	public Towards towards;

	// Token: 0x0400165D RID: 5725
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400165D")]
	public TowerUpgradeType upgradeType;

	// Token: 0x0400165E RID: 5726
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400165E")]
	[SerializeReference]
	public List<object> objects;
}
