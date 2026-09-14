using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000163 RID: 355
[Token(Token = "0x2000163")]
public class Bullet_kernal : Bullet_cabbage
{
	// Token: 0x06000664 RID: 1636 RVA: 0x00021424 File Offset: 0x0001F624
	[Token(Token = "0x6000664")]
	[Address(RVA = "0x6F4050", Offset = "0x6F2650", VA = "0x1806F4050", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(98, 100), 0.5f, 1f);
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.Die();
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00021470 File Offset: 0x0001F670
	[Token(Token = "0x6000665")]
	[Address(RVA = "0x6F3FD0", Offset = "0x6F25D0", VA = "0x1806F3FD0", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(98, 100), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x0002149C File Offset: 0x0001F69C
	[Token(Token = "0x6000666")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_kernal()
	{
	}
}
