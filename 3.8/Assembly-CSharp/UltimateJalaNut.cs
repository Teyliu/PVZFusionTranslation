using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200047B RID: 1147
[Token(Token = "0x200047B")]
public class UltimateJalaNut : SuperJalaNut
{
	// Token: 0x06001547 RID: 5447 RVA: 0x00075E84 File Offset: 0x00074084
	[Token(Token = "0x6001547")]
	[Address(RVA = "0x48A490", Offset = "0x488A90", VA = "0x18048A490")]
	public void GetEnergy(int value)
	{
		do
		{
			float num = this.coolTime;
			int num2 = 0;
			if (num > (float)num2)
			{
				return;
			}
			int num3 = this.attributeCount;
			num3 += value;
			this.attributeCount = num3;
			num3 += -100;
			this.attributeCount = num3;
			CreatePlant instance = CreatePlant.Instance;
			int num4 = this.thePlantColumn;
			num4++;
			int num5 = 0;
			Plant plant;
			if (!(plant != num5))
			{
				break;
			}
			Transform axis = plant.axis;
		}
		while (ParticleManager.Instance != 0);
		base.UpdateText();
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x00075F04 File Offset: 0x00074104
	[Token(Token = "0x6001548")]
	[Address(RVA = "0x48A420", Offset = "0x488A20", VA = "0x18048A420", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			float num = this.coolTime;
			int num2 = 0;
			if (num > (float)num2)
			{
				float fixedDeltaTime = Time.fixedDeltaTime;
				this.coolTime = num;
				this.coolTime = 0f;
			}
		}
	}

	// Token: 0x06001549 RID: 5449 RVA: 0x00075F48 File Offset: 0x00074148
	[Token(Token = "0x6001549")]
	[Address(RVA = "0x48AB10", Offset = "0x489110", VA = "0x18048AB10", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		this.GetEnergy(2);
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x00075F60 File Offset: 0x00074160
	[Token(Token = "0x600154A")]
	[Address(RVA = "0x48A7C0", Offset = "0x488DC0", VA = "0x18048A7C0", Slot = "70")]
	public override void SummonAndRecover()
	{
		Plant plant;
		for (;;)
		{
			int num = 0;
			uint num2;
			this.GetEnergy((int)num2);
			base.UpdateText();
			base.ReplaceSprite();
			Plant targetPlant = this.targetPlant;
			int num3 = 0;
			if (!(targetPlant == num3) && this.targetPlant.theStatus == PlantStatus.Default)
			{
				break;
			}
			CreatePlant instance = CreatePlant.Instance;
			num++;
			int num4 = 0;
			if (plant != num4)
			{
				goto Block_2;
			}
		}
		return;
		Block_2:
		if (plant != 0)
		{
			ParticleManager instance2 = ParticleManager.Instance;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600154B RID: 5451 RVA: 0x00075FE0 File Offset: 0x000741E0
	[Token(Token = "0x600154B")]
	[Address(RVA = "0x48A6F0", Offset = "0x488CF0", VA = "0x18048A6F0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x00076000 File Offset: 0x00074200
	[Token(Token = "0x600154C")]
	[Address(RVA = "0x48ABE0", Offset = "0x4891E0", VA = "0x18048ABE0")]
	public UltimateJalaNut()
	{
	}

	// Token: 0x04000D0E RID: 3342
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D0E")]
	private float coolTime = 0.1f;
}
