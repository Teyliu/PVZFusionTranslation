using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000175 RID: 373
[Token(Token = "0x2000175")]
public class Bullet_melon_ulti2 : Bullet_melon_ulti
{
	// Token: 0x060006A2 RID: 1698 RVA: 0x00022D40 File Offset: 0x00020F40
	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x7D8EC0", Offset = "0x7D74C0", VA = "0x1807D8EC0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		PlantType fromType = this.fromType;
		if (zombie.isSmall)
		{
		}
		int num = 0;
		uint num2;
		zombie.AddfreezeLevel((int)num2, num);
		zombie.AddPoisonLevel();
		base.PlaySound(zombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		base.Die();
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00022D94 File Offset: 0x00020F94
	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x7D8DB0", Offset = "0x7D73B0", VA = "0x1807D8DB0", Slot = "18")]
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

	// Token: 0x060006A4 RID: 1700 RVA: 0x00022DE0 File Offset: 0x00020FE0
	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_melon_ulti2()
	{
	}
}
