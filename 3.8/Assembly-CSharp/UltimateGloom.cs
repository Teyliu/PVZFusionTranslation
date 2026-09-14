using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005AE RID: 1454
[Token(Token = "0x20005AE")]
public class UltimateGloom : IceGloom
{
	// Token: 0x06001B09 RID: 6921 RVA: 0x0009104C File Offset: 0x0008F24C
	[Token(Token = "0x6001B09")]
	[Address(RVA = "0x4FE960", Offset = "0x4FCF60", VA = "0x1804FE960")]
	private void CheckDie()
	{
		float value;
		float num;
		do
		{
			value = global::UnityEngine.Random.value;
		}
		while (0 <= (int)num && num <= 1f);
		if (0 > (int)value)
		{
		}
	}

	// Token: 0x06001B0A RID: 6922 RVA: 0x00091074 File Offset: 0x0008F274
	[Token(Token = "0x6001B0A")]
	[Address(RVA = "0x4FE910", Offset = "0x4FCF10", VA = "0x1804FE910", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.UpdateText();
		this.CheckDie();
		this.attributeCountdown = 1f;
	}

	// Token: 0x06001B0B RID: 6923 RVA: 0x000910A0 File Offset: 0x0008F2A0
	[Token(Token = "0x6001B0B")]
	[Address(RVA = "0x4FEC20", Offset = "0x4FD220", VA = "0x1804FEC20", Slot = "57")]
	protected override bool OnStarUp()
	{
		this.anim.SetBool("starUp", true);
		this.range = 5f;
		base.AddSpeed(0.5f);
		return true;
	}

	// Token: 0x06001B0C RID: 6924 RVA: 0x000910DC File Offset: 0x0008F2DC
	[Token(Token = "0x6001B0C")]
	[Address(RVA = "0x4FEFB0", Offset = "0x4FD5B0", VA = "0x1804FEFB0")]
	private void StarShoot(Vector2 center, int depth, bool spread = true)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001B0D RID: 6925 RVA: 0x000910FC File Offset: 0x0008F2FC
	[Token(Token = "0x6001B0D")]
	[Address(RVA = "0x4FEC90", Offset = "0x4FD290", VA = "0x1804FEC90", Slot = "69")]
	protected override Bullet Shoot1()
	{
		float num;
		this.range = num;
		if (num > 4f)
		{
			this.maxRow = (int)((ulong)2L);
		}
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = this.center.transform;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)52), num2, thePlantRow, num4 != 0UL, (float)num3);
		Transform transform2 = this.center.transform;
		base.AttackZombie();
		Transform transform3 = this.center.transform;
		throw new NullReferenceException();
	}

	// Token: 0x06001B0E RID: 6926 RVA: 0x0009117C File Offset: 0x0008F37C
	[Token(Token = "0x6001B0E")]
	[Address(RVA = "0x4FE820", Offset = "0x4FCE20", VA = "0x1804FE820")]
	private void AttackZombie2(Vector2[] vectors, float range)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001B0F RID: 6927 RVA: 0x0009119C File Offset: 0x0008F39C
	[Token(Token = "0x6001B0F")]
	[Address(RVA = "0x4FE9E0", Offset = "0x4FCFE0", VA = "0x1804FE9E0", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		bool flag = Lawnf.TravelUltimate((UltiBuff)((uint)10));
		if (flag)
		{
			BoardAction boardAction = this.board.boardAction;
			PlantType thePlantType = this.thePlantType;
		}
		bool flag2 = Lawnf.TravelAdvanced((AdvBuff)((uint)12005));
		BoardAction boardAction2 = this.board.boardAction;
		if (!flag2)
		{
			PlantType thePlantType2 = this.thePlantType;
		}
		PlantType thePlantType3 = this.thePlantType;
	}

	// Token: 0x06001B10 RID: 6928 RVA: 0x0009120C File Offset: 0x0008F40C
	[Token(Token = "0x6001B10")]
	[Address(RVA = "0x4FF0B0", Offset = "0x4FD6B0", VA = "0x1804FF0B0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (!Lawnf.TravelUltimate((UltiBuff)((uint)11)))
		{
			return;
		}
		this.attributeCountdown = 5f;
		base.UpdateText();
		this.CheckDie();
	}

	// Token: 0x06001B11 RID: 6929 RVA: 0x00091240 File Offset: 0x0008F440
	[Token(Token = "0x6001B11")]
	[Address(RVA = "0x4FEB50", Offset = "0x4FD150", VA = "0x1804FEB50", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001B12 RID: 6930 RVA: 0x00091260 File Offset: 0x0008F460
	[Token(Token = "0x6001B12")]
	[Address(RVA = "0x4FF1C0", Offset = "0x4FD7C0", VA = "0x1804FF1C0")]
	public UltimateGloom()
	{
	}
}
