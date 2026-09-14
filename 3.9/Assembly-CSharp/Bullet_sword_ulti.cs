using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001CA RID: 458
[Token(Token = "0x20001CA")]
public class Bullet_sword_ulti : Bullet
{
	// Token: 0x060007CB RID: 1995 RVA: 0x00027590 File Offset: 0x00025790
	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x8151D0", Offset = "0x8137D0", VA = "0x1808151D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		TrailRenderer componentInChildren = base.transform.GetComponentInChildren<TrailRenderer>();
		this.r = componentInChildren;
		throw new NullReferenceException();
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x000275BC File Offset: 0x000257BC
	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x8152C0", Offset = "0x8138C0", VA = "0x1808152C0", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		TrailRenderer trailRenderer = this.r;
		this.maxHitCount = (int)((ulong)2147483647L);
		trailRenderer.Clear();
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x000275F4 File Offset: 0x000257F4
	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x810A50", Offset = "0x80F050", VA = "0x180810A50", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x00027628 File Offset: 0x00025828
	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x815240", Offset = "0x813840", VA = "0x180815240", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00027654 File Offset: 0x00025854
	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_sword_ulti()
	{
	}

	// Token: 0x040003BA RID: 954
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40003BA")]
	private TrailRenderer r;
}
