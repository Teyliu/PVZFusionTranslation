using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200015F RID: 351
[Token(Token = "0x200015F")]
public class Bullet_kernal_ice : Bullet_kernal
{
	// Token: 0x0600065E RID: 1630 RVA: 0x00021B24 File Offset: 0x0001FD24
	[Token(Token = "0x600065E")]
	[Address(RVA = "0x6C8870", Offset = "0x6C6E70", VA = "0x1806C8870", Slot = "25")]
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

	// Token: 0x0600065F RID: 1631 RVA: 0x00021B88 File Offset: 0x0001FD88
	[Token(Token = "0x600065F")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_kernal_ice()
	{
	}
}
