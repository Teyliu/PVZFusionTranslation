using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020001A6 RID: 422
[Token(Token = "0x20001A6")]
public class Bullet_spruceBallista : Bullet_pierce
{
	// Token: 0x0600075A RID: 1882 RVA: 0x00025F64 File Offset: 0x00024164
	[Token(Token = "0x600075A")]
	[Address(RVA = "0x6BB760", Offset = "0x6B9D60", VA = "0x1806BB760", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)3L);
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x00025F7C File Offset: 0x0002417C
	[Token(Token = "0x600075B")]
	[Address(RVA = "0x7E2EF0", Offset = "0x7E14F0", VA = "0x1807E2EF0", Slot = "25")]
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

	// Token: 0x0600075C RID: 1884 RVA: 0x00025FE4 File Offset: 0x000241E4
	[Token(Token = "0x600075C")]
	[Address(RVA = "0x7E2E70", Offset = "0x7E1470", VA = "0x1807E2E70", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00026010 File Offset: 0x00024210
	[Token(Token = "0x600075D")]
	[Address(RVA = "0x7E2DC0", Offset = "0x7E13C0", VA = "0x1807E2DC0", Slot = "19")]
	public override void HitBlock()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		int num = this.hitTimes;
		num++;
		this.hitTimes = num;
		this.hit = false;
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00026054 File Offset: 0x00024254
	[Token(Token = "0x600075E")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_spruceBallista()
	{
	}
}
