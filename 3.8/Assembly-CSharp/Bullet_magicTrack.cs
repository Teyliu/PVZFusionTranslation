using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000166 RID: 358
[Token(Token = "0x2000166")]
public class Bullet_magicTrack : Bullet
{
	// Token: 0x06000672 RID: 1650 RVA: 0x00021F10 File Offset: 0x00020110
	[Token(Token = "0x6000672")]
	[Address(RVA = "0x6C9390", Offset = "0x6C7990", VA = "0x1806C9390", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		GameAPP.PlaySound(80, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00021F58 File Offset: 0x00020158
	[Token(Token = "0x6000673")]
	[Address(RVA = "0x6C9310", Offset = "0x6C7910", VA = "0x1806C9310", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00021F84 File Offset: 0x00020184
	[Token(Token = "0x6000674")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_magicTrack()
	{
	}
}
