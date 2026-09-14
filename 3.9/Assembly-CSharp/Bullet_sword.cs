using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C9 RID: 457
[Token(Token = "0x20001C9")]
public class Bullet_sword : Bullet_pierce
{
	// Token: 0x060007C7 RID: 1991 RVA: 0x000274FC File Offset: 0x000256FC
	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x807150", Offset = "0x805750", VA = "0x180807150", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)2147483647L);
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x0002751C File Offset: 0x0002571C
	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x810A50", Offset = "0x80F050", VA = "0x180810A50", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x00027550 File Offset: 0x00025750
	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x815150", Offset = "0x813750", VA = "0x180815150", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x0002757C File Offset: 0x0002577C
	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_sword()
	{
	}
}
