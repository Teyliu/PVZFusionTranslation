using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004B4 RID: 1204
[Token(Token = "0x20004B4")]
public class UltimateSunNut : SuperSunNut
{
	// Token: 0x06001679 RID: 5753 RVA: 0x0007BBF8 File Offset: 0x00079DF8
	[Token(Token = "0x6001679")]
	[Address(RVA = "0x4ED3F0", Offset = "0x4EB9F0", VA = "0x1804ED3F0")]
	public void GetEnergy(int value)
	{
		int num = this.attributeCount;
		num += value;
		this.attributeCount = num;
		if (num > 100)
		{
			num += -100;
			this.attributeCount = num;
			CreatePlant instance = CreatePlant.Instance;
			int num2 = this.thePlantColumn;
			num2++;
			int num3 = 0;
			Plant plant;
			if (plant != num3)
			{
				ParticleManager instance2 = ParticleManager.Instance;
				Transform axis = plant.axis;
				while (instance2 != 0)
				{
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x0007BC6C File Offset: 0x00079E6C
	[Token(Token = "0x600167A")]
	[Address(RVA = "0x4ED700", Offset = "0x4EBD00", VA = "0x1804ED700", Slot = "69")]
	public override void SummonAndRecover()
	{
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)4));
		Board board = this.board;
		this.GetEnergy((int)1.4E-44f);
		this.board.UseSun(1.4E-44f);
		Plant targetPlant = this.targetPlant;
		int num = 0;
		if (targetPlant == num || this.targetPlant.theStatus == PlantStatus.Default)
		{
		}
		CreatePlant instance = CreatePlant.Instance;
		int num2 = this.thePlantColumn;
		num2++;
		int num3 = 0;
		Plant plant;
		if (plant != num3)
		{
			this.targetPlant = plant;
			Plant targetPlant2 = this.targetPlant;
			ParticleManager instance2 = ParticleManager.Instance;
			Transform axis = targetPlant2.axis;
			int num4 = 0;
			int num5 = 0;
			int thePlantRow = this.targetPlant.thePlantRow;
			ulong num6;
			Particle particle = instance2.SetParticle((ParticleType)((uint)11), num4, thePlantRow, num6 != 0UL, (float)num5);
		}
		Board board2 = this.board;
		int thePlantColumn = this.thePlantColumn;
		int thePlantRow2 = this.thePlantRow;
		int num7 = thePlantColumn + 1;
		LoonNut loon = LoonManager.GetLoon(board2, num7, thePlantRow2, (PlantType)((uint)1006));
		loon.direction = (LoonNut.LoonDirection)((ulong)1L);
		int thePlantHealth = this.thePlantHealth;
		loon.damage = thePlantHealth;
		int num8 = this.thePlantColumn;
		int thePlantRow3 = this.thePlantRow;
		num8++;
		LoonNut loon2 = LoonManager.GetLoon(this.board, num8, thePlantRow3, (PlantType)((uint)1006));
		loon2.direction = (LoonNut.LoonDirection)((ulong)2L);
		int thePlantHealth2 = this.thePlantHealth;
		loon2.damage = thePlantHealth2;
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x0007BDD4 File Offset: 0x00079FD4
	[Token(Token = "0x600167B")]
	[Address(RVA = "0x4ED630", Offset = "0x4EBC30", VA = "0x1804ED630", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x0007BDF4 File Offset: 0x00079FF4
	[Token(Token = "0x600167C")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public UltimateSunNut()
	{
	}
}
