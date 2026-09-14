using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000146 RID: 326
[Token(Token = "0x2000146")]
public class Bullet_garlicKernal : Bullet_kernal
{
	// Token: 0x06000611 RID: 1553 RVA: 0x00020654 File Offset: 0x0001E854
	[Token(Token = "0x6000611")]
	[Address(RVA = "0x6C41D0", Offset = "0x6C27D0", VA = "0x1806C41D0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(98, 100), 0.5f, 1f);
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(100, this, (DamageType)((uint)4), fromType, num != 0UL);
		zombie.AddPoisonLevel();
		base.Die();
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x000206A0 File Offset: 0x0001E8A0
	[Token(Token = "0x6000612")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_garlicKernal()
	{
	}
}
