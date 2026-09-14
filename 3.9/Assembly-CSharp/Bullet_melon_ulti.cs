using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200017A RID: 378
[Token(Token = "0x200017A")]
public class Bullet_melon_ulti : Bullet_melon_small
{
	// Token: 0x060006AA RID: 1706 RVA: 0x000225E8 File Offset: 0x000207E8
	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x8069C0", Offset = "0x804FC0", VA = "0x1808069C0", Slot = "22")]
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

	// Token: 0x060006AB RID: 1707 RVA: 0x00022630 File Offset: 0x00020830
	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x8068B0", Offset = "0x804EB0", VA = "0x1808068B0", Slot = "17")]
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

	// Token: 0x060006AC RID: 1708 RVA: 0x0002267C File Offset: 0x0002087C
	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_melon_ulti()
	{
	}
}
