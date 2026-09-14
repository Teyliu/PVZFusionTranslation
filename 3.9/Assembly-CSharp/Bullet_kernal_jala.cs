using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000166 RID: 358
[Token(Token = "0x2000166")]
public class Bullet_kernal_jala : Bullet_cabbage
{
	// Token: 0x0600066B RID: 1643 RVA: 0x00021588 File Offset: 0x0001F788
	[Token(Token = "0x600066B")]
	[Address(RVA = "0x6F43B0", Offset = "0x6F29B0", VA = "0x1806F43B0", Slot = "22")]
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

	// Token: 0x0600066C RID: 1644 RVA: 0x000215DC File Offset: 0x0001F7DC
	[Token(Token = "0x600066C")]
	[Address(RVA = "0x6F4330", Offset = "0x6F2930", VA = "0x1806F4330", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(98, 100), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00021608 File Offset: 0x0001F808
	[Token(Token = "0x600066D")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_kernal_jala()
	{
	}
}
