using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000165 RID: 357
[Token(Token = "0x2000165")]
public class Bullet_kernal_ice : Bullet_kernal
{
	// Token: 0x06000669 RID: 1641 RVA: 0x00021510 File Offset: 0x0001F710
	[Token(Token = "0x6000669")]
	[Address(RVA = "0x6F4220", Offset = "0x6F2820", VA = "0x1806F4220", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(98, 100), 0.5f, 1f);
		bool flag = zombie.HasBuff((EffectType)((uint)2));
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)5), fromType, num != 0UL);
		int num2 = 0;
		zombie.AddfreezeLevel(10, num2);
		base.Die();
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00021574 File Offset: 0x0001F774
	[Token(Token = "0x600066A")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_kernal_ice()
	{
	}
}
