using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200015C RID: 348
[Token(Token = "0x200015C")]
public class Bullet_kelp : Bullet
{
	// Token: 0x06000656 RID: 1622 RVA: 0x000219A8 File Offset: 0x0001FBA8
	[Token(Token = "0x6000656")]
	[Address(RVA = "0x6C8570", Offset = "0x6C6B70", VA = "0x1806C8570", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		if (zombie.inWater)
		{
			int num3 = 0;
			zombie.SetKelped((float)damage, num3 != 0);
		}
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x000219F8 File Offset: 0x0001FBF8
	[Token(Token = "0x6000657")]
	[Address(RVA = "0x6C84F0", Offset = "0x6C6AF0", VA = "0x1806C84F0", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x00021A24 File Offset: 0x0001FC24
	[Token(Token = "0x6000658")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_kelp()
	{
	}
}
