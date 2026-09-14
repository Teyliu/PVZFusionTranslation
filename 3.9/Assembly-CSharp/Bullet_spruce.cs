using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001AC RID: 428
[Token(Token = "0x20001AC")]
public class Bullet_spruce : Bullet_pierce
{
	// Token: 0x06000763 RID: 1891 RVA: 0x000257D8 File Offset: 0x000239D8
	[Token(Token = "0x6000763")]
	[Address(RVA = "0x6E4FA0", Offset = "0x6E35A0", VA = "0x1806E4FA0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)2L);
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x000257F0 File Offset: 0x000239F0
	[Token(Token = "0x6000764")]
	[Address(RVA = "0x810A50", Offset = "0x80F050", VA = "0x180810A50", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x00025824 File Offset: 0x00023A24
	[Token(Token = "0x6000765")]
	[Address(RVA = "0x8109E0", Offset = "0x80EFE0", VA = "0x1808109E0", Slot = "18")]
	public override void HitBlock()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00025848 File Offset: 0x00023A48
	[Token(Token = "0x6000766")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_spruce()
	{
	}
}
