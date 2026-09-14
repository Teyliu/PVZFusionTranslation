using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200041B RID: 1051
[Token(Token = "0x200041B")]
public class Shulkflower : Shooter
{
	// Token: 0x06001363 RID: 4963 RVA: 0x0006CF54 File Offset: 0x0006B154
	[Token(Token = "0x6001363")]
	[Address(RVA = "0x43BA20", Offset = "0x43A020", VA = "0x18043BA20", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 0.5f;
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x0006CF74 File Offset: 0x0006B174
	[Token(Token = "0x6001364")]
	[Address(RVA = "0x465FF0", Offset = "0x4645F0", VA = "0x180465FF0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x0006CF88 File Offset: 0x0006B188
	[Token(Token = "0x6001365")]
	[Address(RVA = "0x465EC0", Offset = "0x4644C0", VA = "0x180465EC0", Slot = "40")]
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

	// Token: 0x06001366 RID: 4966 RVA: 0x0006D020 File Offset: 0x0006B220
	[Token(Token = "0x6001366")]
	[Address(RVA = "0x4663D0", Offset = "0x4649D0", VA = "0x1804663D0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (this.theShieldHealth > 0)
		{
		}
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x0006D038 File Offset: 0x0006B238
	[Token(Token = "0x6001367")]
	[Address(RVA = "0x465C80", Offset = "0x464280", VA = "0x180465C80", Slot = "73")]
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

	// Token: 0x06001368 RID: 4968 RVA: 0x0006D094 File Offset: 0x0006B294
	[Token(Token = "0x6001368")]
	[Address(RVA = "0x465AA0", Offset = "0x4640A0", VA = "0x180465AA0", Slot = "74")]
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

	// Token: 0x06001369 RID: 4969 RVA: 0x0006D0E4 File Offset: 0x0006B2E4
	[Token(Token = "0x6001369")]
	[Address(RVA = "0x4661D0", Offset = "0x4647D0", VA = "0x1804661D0")]
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

	// Token: 0x0600136A RID: 4970 RVA: 0x0006D154 File Offset: 0x0006B354
	[Token(Token = "0x600136A")]
	[Address(RVA = "0x466030", Offset = "0x464630", VA = "0x180466030")]
	private void OnDrawGizmosSelected()
	{
		Transform transform = base.transform.Find("Shadow");
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x0006D184 File Offset: 0x0006B384
	[Token(Token = "0x600136B")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public Shulkflower()
	{
	}
}
