using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200043A RID: 1082
[Token(Token = "0x200043A")]
public class Shulkflower : Shooter
{
	// Token: 0x060013ED RID: 5101 RVA: 0x0006F1FC File Offset: 0x0006D3FC
	[Token(Token = "0x60013ED")]
	[Address(RVA = "0x48F270", Offset = "0x48D870", VA = "0x18048F270", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 0.5f;
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x0006F21C File Offset: 0x0006D41C
	[Token(Token = "0x60013EE")]
	[Address(RVA = "0x4BCFE0", Offset = "0x4BB5E0", VA = "0x1804BCFE0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x0006F230 File Offset: 0x0006D430
	[Token(Token = "0x60013EF")]
	[Address(RVA = "0x4BCEB0", Offset = "0x4BB4B0", VA = "0x1804BCEB0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.SearchUpdate();
		base.AttributeCountdown = 0.5f;
		AdvantureData data = AdvantureConfig.data;
		int thePlantMaxHealth = this.thePlantMaxHealth;
		int i = this.theShieldHealth;
		bool flag;
		if (!flag)
		{
			if (i < thePlantMaxHealth)
			{
				base.GetShield(5f);
				int thePlantMaxHealth2 = this.thePlantMaxHealth;
				this.theShieldHealth = thePlantMaxHealth2;
			}
			return;
		}
		while (i >= (flag ? 1 : 0))
		{
		}
		base.GetShield(10f);
		int num = this.thePlantMaxHealth;
		num += num;
		int num2 = this.thePlantMaxHealth;
		num2 += num2;
		this.theShieldHealth = num2;
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x0006F2C8 File Offset: 0x0006D4C8
	[Token(Token = "0x60013F0")]
	[Address(RVA = "0x4BD3C0", Offset = "0x4BB9C0", VA = "0x1804BD3C0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (this.theShieldHealth > 0)
		{
		}
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x0006F2E0 File Offset: 0x0006D4E0
	[Token(Token = "0x60013F1")]
	[Address(RVA = "0x4BCC70", Offset = "0x4BB270", VA = "0x1804BCC70", Slot = "72")]
	protected virtual void AttackUpdate()
	{
		int num = 0;
		List<Zombie> list = new List();
		Transform axis = this.axis;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				if (base.SearchUniqueZombie(num))
				{
				}
			}
			num++;
		}
		this.AttackEffect(list);
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x0006F33C File Offset: 0x0006D53C
	[Token(Token = "0x60013F2")]
	[Address(RVA = "0x4BCA90", Offset = "0x4BB090", VA = "0x1804BCA90", Slot = "73")]
	protected virtual void AttackEffect(List<Zombie> zombies)
	{
		ulong num;
		do
		{
			bool result = AdvantureConfig.data.GetResult((AdvantureLevel)((uint)63), (MissionResult)((uint)2));
			int attackDamage = this.attackDamage;
			if (result)
			{
			}
			bool flag;
			if (flag)
			{
				PlantType thePlantType = this.thePlantType;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x0006F38C File Offset: 0x0006D58C
	[Token(Token = "0x60013F3")]
	[Address(RVA = "0x4BD1C0", Offset = "0x4BB7C0", VA = "0x1804BD1C0")]
	private void SearchUpdate()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = 0;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				bool flag2 = base.SearchUniqueZombie(num);
			}
			num++;
		}
		Animator anim = this.anim;
		if (num2 == 0)
		{
			int num4 = 0;
			anim.SetBool("shooting", num4 != 0);
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x0006F3FC File Offset: 0x0006D5FC
	[Token(Token = "0x60013F4")]
	[Address(RVA = "0x4BD020", Offset = "0x4BB620", VA = "0x1804BD020")]
	private void OnDrawGizmosSelected()
	{
		Transform transform = base.transform.Find("Shadow");
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x0006F42C File Offset: 0x0006D62C
	[Token(Token = "0x60013F5")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public Shulkflower()
	{
	}
}
