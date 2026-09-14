using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200049D RID: 1181
[Token(Token = "0x200049D")]
public class UltimateJalaNut : SuperJalaNut
{
	// Token: 0x060015E7 RID: 5607 RVA: 0x00078854 File Offset: 0x00076A54
	[Token(Token = "0x60015E7")]
	[Address(RVA = "0x4E39F0", Offset = "0x4E1FF0", VA = "0x1804E39F0")]
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

	// Token: 0x060015E8 RID: 5608 RVA: 0x000788D4 File Offset: 0x00076AD4
	[Token(Token = "0x60015E8")]
	[Address(RVA = "0x4E3980", Offset = "0x4E1F80", VA = "0x1804E3980", Slot = "17")]
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

	// Token: 0x060015E9 RID: 5609 RVA: 0x00078918 File Offset: 0x00076B18
	[Token(Token = "0x60015E9")]
	[Address(RVA = "0x4E4070", Offset = "0x4E2670", VA = "0x1804E4070", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		this.GetEnergy(2);
	}

	// Token: 0x060015EA RID: 5610 RVA: 0x00078930 File Offset: 0x00076B30
	[Token(Token = "0x60015EA")]
	[Address(RVA = "0x4E3D20", Offset = "0x4E2320", VA = "0x1804E3D20", Slot = "69")]
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

	// Token: 0x060015EB RID: 5611 RVA: 0x000789B0 File Offset: 0x00076BB0
	[Token(Token = "0x60015EB")]
	[Address(RVA = "0x4E3C50", Offset = "0x4E2250", VA = "0x1804E3C50", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060015EC RID: 5612 RVA: 0x000789D0 File Offset: 0x00076BD0
	[Token(Token = "0x60015EC")]
	[Address(RVA = "0x4E4140", Offset = "0x4E2740", VA = "0x1804E4140")]
	public UltimateJalaNut()
	{
	}

	// Token: 0x04000DA7 RID: 3495
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000DA7")]
	private float coolTime = 0.1f;
}
