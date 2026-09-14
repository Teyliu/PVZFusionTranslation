using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200015E RID: 350
[Token(Token = "0x200015E")]
public class Bullet_kernal_doom : Bullet_kernal
{
	// Token: 0x0600065C RID: 1628 RVA: 0x00021AC4 File Offset: 0x0001FCC4
	[Token(Token = "0x600065C")]
	[Address(RVA = "0x6C8780", Offset = "0x6C6D80", VA = "0x1806C8780", Slot = "25")]
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

	// Token: 0x0600065D RID: 1629 RVA: 0x00021B10 File Offset: 0x0001FD10
	[Token(Token = "0x600065D")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_kernal_doom()
	{
	}
}
