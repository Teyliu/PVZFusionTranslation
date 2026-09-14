using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000447 RID: 1095
[Token(Token = "0x2000447")]
public class SuperJalaNut : WallNut
{
	// Token: 0x06001431 RID: 5169 RVA: 0x00070CF8 File Offset: 0x0006EEF8
	[Token(Token = "0x6001431")]
	[Address(RVA = "0x42DFB0", Offset = "0x42C5B0", VA = "0x18042DFB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
	}

	// Token: 0x06001432 RID: 5170 RVA: 0x00070D18 File Offset: 0x0006EF18
	[Token(Token = "0x6001432")]
	[Address(RVA = "0x4735A0", Offset = "0x471BA0", VA = "0x1804735A0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 3f;
		int thePlantMaxHealth = this.thePlantMaxHealth;
		this.thePlantHealth = thePlantMaxHealth;
	}

	// Token: 0x06001433 RID: 5171 RVA: 0x00070D40 File Offset: 0x0006EF40
	[Token(Token = "0x6001433")]
	[Address(RVA = "0x4739E0", Offset = "0x471FE0", VA = "0x1804739E0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		Board board = this.board;
	}

	// Token: 0x06001434 RID: 5172 RVA: 0x00070D80 File Offset: 0x0006EF80
	[Token(Token = "0x6001434")]
	[Address(RVA = "0x473610", Offset = "0x471C10", VA = "0x180473610", Slot = "28")]
	protected override void LimHealth()
	{
		this.thePlantHealth = (int)((ulong)1000000000L);
	}

	// Token: 0x06001435 RID: 5173 RVA: 0x00070D9C File Offset: 0x0006EF9C
	[Token(Token = "0x6001435")]
	[Address(RVA = "0x473630", Offset = "0x471C30", VA = "0x180473630", Slot = "26")]
	public override void Recover(float health, DamageType damageType = DamageType.Normal, bool particle = true, bool continuous = false)
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)4)))
		{
		}
	}

	// Token: 0x06001436 RID: 5174 RVA: 0x00070DB4 File Offset: 0x0006EFB4
	[Token(Token = "0x6001436")]
	[Address(RVA = "0x4736A0", Offset = "0x471CA0", VA = "0x1804736A0", Slot = "70")]
	public virtual void SummonAndRecover()
	{
		int num3;
		Plant plant;
		for (;;)
		{
			base.UpdateText();
			base.ReplaceSprite();
			Plant targetPlant = this.targetPlant;
			int num = 0;
			if (!(targetPlant == num) && this.targetPlant.theStatus == PlantStatus.Default)
			{
				break;
			}
			CreatePlant instance = CreatePlant.Instance;
			int num2 = this.thePlantColumn;
			num3 = 0;
			num2++;
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
			this.targetPlant = plant;
			Plant targetPlant2 = this.targetPlant;
			ParticleManager instance2 = ParticleManager.Instance;
			Transform axis = targetPlant2.axis;
			Plant targetPlant3 = this.targetPlant;
		}
		this.targetPlant = num3;
		throw new NullReferenceException();
	}

	// Token: 0x06001437 RID: 5175 RVA: 0x00070E5C File Offset: 0x0006F05C
	[Token(Token = "0x6001437")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SuperJalaNut()
	{
	}
}
