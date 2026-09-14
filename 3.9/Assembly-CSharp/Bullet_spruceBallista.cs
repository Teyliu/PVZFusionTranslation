using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020001AD RID: 429
[Token(Token = "0x20001AD")]
public class Bullet_spruceBallista : Bullet_pierce
{
	// Token: 0x06000767 RID: 1895 RVA: 0x0002585C File Offset: 0x00023A5C
	[Token(Token = "0x6000767")]
	[Address(RVA = "0x6E65D0", Offset = "0x6E4BD0", VA = "0x1806E65D0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)3L);
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00025874 File Offset: 0x00023A74
	[Token(Token = "0x6000768")]
	[Address(RVA = "0x8105B0", Offset = "0x80EBB0", VA = "0x1808105B0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
		BallistaBomb ballistaBomb = zombie.AddComponent<BallistaBomb>();
		ballistaBomb.timer = 0.3f;
		ballistaBomb.zombie = zombie;
		int damage2 = this._damage;
		ballistaBomb.damage = damage2;
		ballistaBomb.particleType = (ParticleType)((ulong)107L);
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x000258DC File Offset: 0x00023ADC
	[Token(Token = "0x6000769")]
	[Address(RVA = "0x810530", Offset = "0x80EB30", VA = "0x180810530", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x00025908 File Offset: 0x00023B08
	[Token(Token = "0x600076A")]
	[Address(RVA = "0x810490", Offset = "0x80EA90", VA = "0x180810490", Slot = "18")]
	public override void HitBlock()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		int num = this.hitCount;
		num++;
		this.hitCount = num;
		base.Die();
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00025944 File Offset: 0x00023B44
	[Token(Token = "0x600076B")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_spruceBallista()
	{
	}
}
