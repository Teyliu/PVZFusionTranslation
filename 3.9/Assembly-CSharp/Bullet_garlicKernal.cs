using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200014B RID: 331
[Token(Token = "0x200014B")]
public class Bullet_garlicKernal : Bullet_kernal
{
	// Token: 0x06000619 RID: 1561 RVA: 0x0001FEE4 File Offset: 0x0001E0E4
	[Token(Token = "0x6000619")]
	[Address(RVA = "0x6EF370", Offset = "0x6ED970", VA = "0x1806EF370", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(98, 100), 0.5f, 1f);
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(100, this, (DamageType)((uint)4), fromType, num != 0UL);
		zombie.AddPoisonLevel();
		base.Die();
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x0001FF30 File Offset: 0x0001E130
	[Token(Token = "0x600061A")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_garlicKernal()
	{
	}
}
