using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000418 RID: 1048
[Token(Token = "0x2000418")]
public class PinkOnion : Prismflower
{
	// Token: 0x06001340 RID: 4928 RVA: 0x0006BA28 File Offset: 0x00069C28
	[Token(Token = "0x6001340")]
	[Address(RVA = "0x4B22B0", Offset = "0x4B08B0", VA = "0x1804B22B0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.SetMain();
	}

	// Token: 0x06001341 RID: 4929 RVA: 0x0006BA44 File Offset: 0x00069C44
	[Token(Token = "0x6001341")]
	[Address(RVA = "0x4B2050", Offset = "0x4B0650", VA = "0x1804B2050")]
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

	// Token: 0x06001342 RID: 4930 RVA: 0x0006BA98 File Offset: 0x00069C98
	[Token(Token = "0x6001342")]
	[Address(RVA = "0x4B1B50", Offset = "0x4B0150", VA = "0x1804B1B50", Slot = "39")]
	protected override void AttributeEvent()
	{
		if (this.main)
		{
			this.SearchZombieUpdate();
		}
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x0006BAC0 File Offset: 0x00069CC0
	[Token(Token = "0x6001343")]
	[Address(RVA = "0x4B1B90", Offset = "0x4B0190", VA = "0x1804B1B90", Slot = "69")]
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

	// Token: 0x06001344 RID: 4932 RVA: 0x0006BBA0 File Offset: 0x00069DA0
	[Token(Token = "0x6001344")]
	[Address(RVA = "0x4B19F0", Offset = "0x4AFFF0", VA = "0x1804B19F0", Slot = "68")]
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

	// Token: 0x06001345 RID: 4933 RVA: 0x0006BBF0 File Offset: 0x00069DF0
	[Token(Token = "0x6001345")]
	[Address(RVA = "0x4B1AA0", Offset = "0x4B00A0", VA = "0x1804B1AA0")]
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

	// Token: 0x06001346 RID: 4934 RVA: 0x0006BC38 File Offset: 0x00069E38
	[Token(Token = "0x6001346")]
	[Address(RVA = "0x4B17C0", Offset = "0x4AFDC0", VA = "0x1804B17C0")]
	private void ApplyDamage(Zombie zombie, int damage)
	{
		int num = 0;
		bool beforeDying = zombie.beforeDying;
		long theHealth = zombie.theHealth;
		PlantType thePlantType = this.thePlantType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, thePlantType, num2 != 0UL);
		if ((!beforeDying && zombie.beforeDying != beforeDying) || !zombie.beforeDying)
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

	// Token: 0x06001347 RID: 4935 RVA: 0x0006BCF0 File Offset: 0x00069EF0
	[Token(Token = "0x6001347")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public PinkOnion()
	{
	}

	// Token: 0x04000CA1 RID: 3233
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CA1")]
	public GameObject electric;

	// Token: 0x04000CA2 RID: 3234
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CA2")]
	private bool main;
}
