using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200046C RID: 1132
[Token(Token = "0x200046C")]
public class SuperSunNut : WallNut
{
	// Token: 0x060014E3 RID: 5347 RVA: 0x00073954 File Offset: 0x00071B54
	[Token(Token = "0x60014E3")]
	[Address(RVA = "0x4CCC50", Offset = "0x4CB250", VA = "0x1804CCC50", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)5));
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x060014E4 RID: 5348 RVA: 0x00073978 File Offset: 0x00071B78
	[Token(Token = "0x60014E4")]
	[Address(RVA = "0x4CC8E0", Offset = "0x4CAEE0", VA = "0x1804CC8E0", Slot = "69")]
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

	// Token: 0x060014E5 RID: 5349 RVA: 0x00073A44 File Offset: 0x00071C44
	[Token(Token = "0x60014E5")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SuperSunNut()
	{
	}
}
