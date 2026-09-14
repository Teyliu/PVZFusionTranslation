using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200011D RID: 285
[Token(Token = "0x200011D")]
public class Bullet_cabbage_ice : Bullet_sunCabbage
{
	// Token: 0x0600057E RID: 1406 RVA: 0x0001DCC4 File Offset: 0x0001BEC4
	[Token(Token = "0x600057E")]
	[Address(RVA = "0x6BB4F0", Offset = "0x6B9AF0", VA = "0x1806BB4F0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)1L);
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x0001DCDC File Offset: 0x0001BEDC
	[Token(Token = "0x600057F")]
	[Address(RVA = "0x6BB290", Offset = "0x6B9890", VA = "0x1806BB290", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		base.PlaySound(zombie);
		int num = 0;
		zombie.AddfreezeLevel(10, num);
		int num2 = 0;
		int damage = this._damage;
		if (zombie == 0)
		{
			Plant from = this.from;
			int num3 = 0;
			if (from != num3)
			{
				Plant from2 = this.from;
			}
		}
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)((uint)5), fromType, num4 != 0UL);
		float num5 = this.Vy * -1f;
		float num6 = this.Vx * 0.4f;
		float num7 = num5 * -0.5f;
		this.Vx = num6;
		this.Vy = num7;
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num8 = 0;
		int theBulletRow = this.theBulletRow;
		ulong num9;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num8, theBulletRow, num9 != 0UL, (float)num2);
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x0001DDAC File Offset: 0x0001BFAC
	[Token(Token = "0x6000580")]
	[Address(RVA = "0x6BB180", Offset = "0x6B9780", VA = "0x1806BB180", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x0001DDF8 File Offset: 0x0001BFF8
	[Token(Token = "0x6000581")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_cabbage_ice()
	{
	}
}
