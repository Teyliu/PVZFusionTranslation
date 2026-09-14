using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000718 RID: 1816
[Token(Token = "0x2000718")]
public class SuperKirov : KirovAirship
{
	// Token: 0x170001AD RID: 429
	// (get) Token: 0x060023DA RID: 9178 RVA: 0x000BB478 File Offset: 0x000B9678
	[Token(Token = "0x170001AD")]
	public override float CrashNeedCount
	{
		[Token(Token = "0x60023DA")]
		[Address(RVA = "0x5BD8A0", Offset = "0x5BBEA0", VA = "0x1805BD8A0", Slot = "80")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060023DB RID: 9179 RVA: 0x000BB48C File Offset: 0x000B968C
	[Token(Token = "0x60023DB")]
	[Address(RVA = "0x5F3B00", Offset = "0x5F2100", VA = "0x1805F3B00", Slot = "83")]
	protected override void CreateBomb()
	{
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)7)))
		{
			Zombie zombie;
			Lawnf.SetZombieHealth(zombie, 50f);
		}
	}

	// Token: 0x060023DC RID: 9180 RVA: 0x000BB4D4 File Offset: 0x000B96D4
	[Token(Token = "0x60023DC")]
	[Address(RVA = "0x5F3A60", Offset = "0x5F2060", VA = "0x1805F3A60", Slot = "82")]
	protected override void BombUpdate()
	{
		this.anim.SetTrigger("throw");
		this.existBomb = false;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x060023DD RID: 9181 RVA: 0x000BB514 File Offset: 0x000B9714
	[Token(Token = "0x60023DD")]
	[Address(RVA = "0x58ADF0", Offset = "0x5893F0", VA = "0x18058ADF0")]
	public SuperKirov()
	{
	}
}
