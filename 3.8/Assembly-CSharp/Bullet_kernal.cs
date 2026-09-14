using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200015D RID: 349
[Token(Token = "0x200015D")]
public class Bullet_kernal : Bullet_cabbage
{
	// Token: 0x06000659 RID: 1625 RVA: 0x00021A38 File Offset: 0x0001FC38
	[Token(Token = "0x6000659")]
	[Address(RVA = "0x6C86A0", Offset = "0x6C6CA0", VA = "0x1806C86A0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(98, 100), 0.5f, 1f);
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.Die();
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00021A84 File Offset: 0x0001FC84
	[Token(Token = "0x600065A")]
	[Address(RVA = "0x6C8620", Offset = "0x6C6C20", VA = "0x1806C8620", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(98, 100), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00021AB0 File Offset: 0x0001FCB0
	[Token(Token = "0x600065B")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_kernal()
	{
	}
}
