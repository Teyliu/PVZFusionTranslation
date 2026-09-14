using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000174 RID: 372
[Token(Token = "0x2000174")]
public class Bullet_melon_ulti : Bullet_melon_small
{
	// Token: 0x0600069F RID: 1695 RVA: 0x00022C98 File Offset: 0x00020E98
	[Token(Token = "0x600069F")]
	[Address(RVA = "0x7D9130", Offset = "0x7D7730", VA = "0x1807D9130", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		PlantType fromType = this.fromType;
		if (zombie.isSmall)
		{
		}
		zombie.AddPoisonLevel();
		base.PlaySound(zombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		base.Die();
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x00022CE0 File Offset: 0x00020EE0
	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x7D9020", Offset = "0x7D7620", VA = "0x1807D9020", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)57), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00022D2C File Offset: 0x00020F2C
	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_melon_ulti()
	{
	}
}
