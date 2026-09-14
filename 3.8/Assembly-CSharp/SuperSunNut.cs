using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200044C RID: 1100
[Token(Token = "0x200044C")]
public class SuperSunNut : WallNut
{
	// Token: 0x06001453 RID: 5203 RVA: 0x00071614 File Offset: 0x0006F814
	[Token(Token = "0x6001453")]
	[Address(RVA = "0x4753A0", Offset = "0x4739A0", VA = "0x1804753A0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)5));
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06001454 RID: 5204 RVA: 0x00071638 File Offset: 0x0006F838
	[Token(Token = "0x6001454")]
	[Address(RVA = "0x475030", Offset = "0x473630", VA = "0x180475030", Slot = "70")]
	public virtual void SummonAndRecover()
	{
		Plant plant;
		for (;;)
		{
			bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)4));
			this.board.UseSun(7E-43f);
			Plant targetPlant = this.targetPlant;
			int num = 0;
			if (!(targetPlant == num) && this.targetPlant.theStatus == PlantStatus.Default)
			{
				break;
			}
			CreatePlant instance = CreatePlant.Instance;
			int num2 = this.thePlantColumn;
			int num3 = 0;
			num2++;
			int num4 = 0;
			if (plant != num4)
			{
				goto Block_2;
			}
		}
		return;
		Block_2:
		if (plant == 0)
		{
			int num3;
			this.targetPlant = num3;
		}
		this.targetPlant = plant;
		Plant targetPlant2 = this.targetPlant;
		ParticleManager instance2 = ParticleManager.Instance;
		Transform axis = targetPlant2.axis;
		int num5 = 0;
		int num6 = 0;
		int thePlantRow = this.targetPlant.thePlantRow;
		ulong num7;
		Particle particle = instance2.SetParticle((ParticleType)((uint)11), num5, thePlantRow, num7 != 0UL, (float)num6);
	}

	// Token: 0x06001455 RID: 5205 RVA: 0x00071704 File Offset: 0x0006F904
	[Token(Token = "0x6001455")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SuperSunNut()
	{
	}
}
