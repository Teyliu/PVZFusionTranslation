using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003FD RID: 1021
[Token(Token = "0x20003FD")]
public class PinkOnion : Prismflower
{
	// Token: 0x060012CA RID: 4810 RVA: 0x00069BF0 File Offset: 0x00067DF0
	[Token(Token = "0x60012CA")]
	[Address(RVA = "0x45BDC0", Offset = "0x45A3C0", VA = "0x18045BDC0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.SetMain();
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x00069C0C File Offset: 0x00067E0C
	[Token(Token = "0x60012CB")]
	[Address(RVA = "0x45BB60", Offset = "0x45A160", VA = "0x18045BB60")]
	public void SetMain()
	{
		int num2;
		do
		{
			int num = 0;
			Board board = this.board;
			List<Plant> plants = Lawnf.GetPlants(this.thePlantType, board, num != 0);
			num2 = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != 0);
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x00069C60 File Offset: 0x00067E60
	[Token(Token = "0x60012CC")]
	[Address(RVA = "0x45B660", Offset = "0x459C60", VA = "0x18045B660", Slot = "40")]
	protected override void AttributeEvent()
	{
		if (this.main)
		{
			this.SearchZombieUpdate();
		}
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x00069C88 File Offset: 0x00067E88
	[Token(Token = "0x60012CD")]
	[Address(RVA = "0x45B6A0", Offset = "0x459CA0", VA = "0x18045B6A0", Slot = "70")]
	protected override void SearchZombieUpdate()
	{
		int num;
		bool flag3;
		ulong num8;
		do
		{
			num = 0;
			Transform shoot = this.shoot;
			int num2 = this.zombieLayer;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			Collider2D[] array;
			if (num5 < array.Length)
			{
				bool flag;
				bool flag2;
				if (flag && flag2)
				{
					Transform shoot2 = this.shoot;
				}
				num4++;
			}
			int num6 = 0;
			if (!(num3 != num6))
			{
				return;
			}
			this.targetZombie = num3;
			this.thePlantStage = (int)((ulong)0L);
			this.anim.SetTrigger("shoot");
			this.theStatus = (PlantStatus)((ulong)11L);
			int num7 = 0;
			Board board = this.board;
			List<Plant> plants = Lawnf.GetPlants(this.thePlantType, board, num7 != 0);
		}
		while ((flag3 && !(num != this)) || num8 != (ulong)0L);
		uint num9;
		GameAPP.PlaySound((int)num9, 0.4f, 1f);
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x00069D68 File Offset: 0x00067F68
	[Token(Token = "0x60012CE")]
	[Address(RVA = "0x45B500", Offset = "0x459B00", VA = "0x18045B500", Slot = "69")]
	protected override void AttackOtherZombie(Zombie basicZombie, Vector2 center, int damage)
	{
		PinkOnion.<Attacking>d__7 <Attacking>d__;
		<Attacking>d__.System.IDisposable.Dispose();
		<Attacking>d__.<>1__state = (int)((ulong)0L);
		<Attacking>d__.<>4__this = this;
		<Attacking>d__.targetZombie = basicZombie;
		<Attacking>d__.center = center;
		<Attacking>d__.center.y = (float)0;
		<Attacking>d__.damage = damage;
		Coroutine coroutine = base.StartCoroutine(<Attacking>d__);
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x00069DB8 File Offset: 0x00067FB8
	[Token(Token = "0x60012CF")]
	[Address(RVA = "0x45B5B0", Offset = "0x459BB0", VA = "0x18045B5B0")]
	private IEnumerator Attacking(Zombie targetZombie, Vector2 center, int damage)
	{
		PinkOnion.<Attacking>d__7 <Attacking>d__;
		<Attacking>d__.System.IDisposable.Dispose();
		<Attacking>d__.<>1__state = (int)((ulong)0L);
		<Attacking>d__.<>4__this = this;
		<Attacking>d__.targetZombie = targetZombie;
		<Attacking>d__.damage = damage;
		<Attacking>d__.center = center;
		<Attacking>d__.center.y = (float)0;
		return null;
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x00069E00 File Offset: 0x00068000
	[Token(Token = "0x60012D0")]
	[Address(RVA = "0x45B2D0", Offset = "0x4598D0", VA = "0x18045B2D0")]
	private void ApplyDamage(Zombie zombie, int damage)
	{
		int num = 0;
		bool beforeDying = zombie.beforeDying;
		int theHealth = zombie.theHealth;
		PlantType thePlantType = this.thePlantType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, thePlantType, num2 != 0UL);
		if ((!beforeDying && zombie.beforeDying != beforeDying) || (theHealth > 0 && !zombie.beforeDying))
		{
			Board board = this.board;
			int num3 = 0;
			Plant random = ListExtensions.GetRandom<Plant>(Lawnf.GetPlants((PlantType)((uint)926), board, num3 != 0));
			bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)16));
			bool flag2 = "{il2cpp field on 16, offset 0xFFFFFFFFFFFFFFF8}" == typeof(CattailLour).TypeHandle;
		}
		int theZombieType = (int)zombie.theZombieType;
		float theArmor = zombie.theArmor;
		bool flag3;
		if (!flag3)
		{
		}
		int num4 = 0;
		zombie.theArmor = theArmor;
		if (num4 > (int)theArmor)
		{
			zombie.theArmor = 0f;
		}
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x00069EBC File Offset: 0x000680BC
	[Token(Token = "0x60012D1")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public PinkOnion()
	{
	}

	// Token: 0x04000C26 RID: 3110
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C26")]
	public GameObject electric;

	// Token: 0x04000C27 RID: 3111
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C27")]
	private bool main;
}
