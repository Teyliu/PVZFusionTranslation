using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000492 RID: 1170
[Token(Token = "0x2000492")]
public class UltimateSunNut : SuperSunNut
{
	// Token: 0x060015D9 RID: 5593 RVA: 0x00079264 File Offset: 0x00077464
	[Token(Token = "0x60015D9")]
	[Address(RVA = "0x493F40", Offset = "0x492540", VA = "0x180493F40")]
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

	// Token: 0x060015DA RID: 5594 RVA: 0x000792D8 File Offset: 0x000774D8
	[Token(Token = "0x60015DA")]
	[Address(RVA = "0x494250", Offset = "0x492850", VA = "0x180494250", Slot = "70")]
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

	// Token: 0x060015DB RID: 5595 RVA: 0x00079440 File Offset: 0x00077640
	[Token(Token = "0x60015DB")]
	[Address(RVA = "0x494180", Offset = "0x492780", VA = "0x180494180", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x00079460 File Offset: 0x00077660
	[Token(Token = "0x60015DC")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public UltimateSunNut()
	{
	}
}
