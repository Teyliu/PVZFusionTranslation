using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000164 RID: 356
[Token(Token = "0x2000164")]
public class Bullet_kernal_doom : Bullet_kernal
{
	// Token: 0x06000667 RID: 1639 RVA: 0x000214B0 File Offset: 0x0001F6B0
	[Token(Token = "0x6000667")]
	[Address(RVA = "0x6F4130", Offset = "0x6F2730", VA = "0x1806F4130", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(98, 100), 0.5f, 1f);
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.Die();
		throw new NullReferenceException();
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x000214FC File Offset: 0x0001F6FC
	[Token(Token = "0x6000668")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_kernal_doom()
	{
	}
}
