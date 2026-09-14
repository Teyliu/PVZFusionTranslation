using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000160 RID: 352
[Token(Token = "0x2000160")]
public class Bullet_kernal_jala : Bullet_cabbage
{
	// Token: 0x06000660 RID: 1632 RVA: 0x00021B9C File Offset: 0x0001FD9C
	[Token(Token = "0x6000660")]
	[Address(RVA = "0x6C8A00", Offset = "0x6C7000", VA = "0x1806C8A00", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(98, 100), 0.5f, 1f);
		zombie.SetJalaed();
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.Die();
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00021BF0 File Offset: 0x0001FDF0
	[Token(Token = "0x6000661")]
	[Address(RVA = "0x6C8980", Offset = "0x6C6F80", VA = "0x1806C8980", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(98, 100), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00021C1C File Offset: 0x0001FE1C
	[Token(Token = "0x6000662")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_kernal_jala()
	{
	}
}
