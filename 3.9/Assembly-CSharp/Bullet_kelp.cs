using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000162 RID: 354
[Token(Token = "0x2000162")]
public class Bullet_kelp : Bullet
{
	// Token: 0x06000661 RID: 1633 RVA: 0x00021394 File Offset: 0x0001F594
	[Token(Token = "0x6000661")]
	[Address(RVA = "0x6F3F20", Offset = "0x6F2520", VA = "0x1806F3F20", Slot = "22")]
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

	// Token: 0x06000662 RID: 1634 RVA: 0x000213E4 File Offset: 0x0001F5E4
	[Token(Token = "0x6000662")]
	[Address(RVA = "0x6F3EA0", Offset = "0x6F24A0", VA = "0x1806F3EA0", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00021410 File Offset: 0x0001F610
	[Token(Token = "0x6000663")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_kelp()
	{
	}
}
