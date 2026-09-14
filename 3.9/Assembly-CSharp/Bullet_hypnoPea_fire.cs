using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000152 RID: 338
[Token(Token = "0x2000152")]
public class Bullet_hypnoPea_fire : Bullet_firePea
{
	// Token: 0x0600062C RID: 1580 RVA: 0x00020520 File Offset: 0x0001E720
	[Token(Token = "0x600062C")]
	[Address(RVA = "0x6F0770", Offset = "0x6EED70", VA = "0x1806F0770", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		bool beforeDying = zombie.beforeDying;
		long theHealth = zombie.theHealth;
		base.FireZombie(zombie, true);
		if (zombie.BoxType != BoxType.Water && ((!beforeDying && zombie.beforeDying != beforeDying) || !zombie.beforeDying))
		{
			Transform axis = zombie.axis;
			CreateZombie instance = CreateZombie.Instance;
			bool flag;
			if (flag)
			{
				PeaShooterZ peaShooterZ;
				peaShooterZ.hypnoHead.SetActive(true);
				GameObject normalHead = peaShooterZ.normalHead;
				int num = 0;
				normalHead.SetActive(num != 0);
				peaShooterZ.hypnoPea = true;
			}
			Transform axis2 = zombie.axis;
			ParticleManager instance2 = ParticleManager.Instance;
			int num2 = 0;
			int num3 = 0;
			int theZombieRow = zombie.theZombieRow;
			ulong num4;
			Particle particle = instance2.SetParticle((ParticleType)((uint)99), num2, theZombieRow, num4 != 0UL, (float)num3);
		}
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x000205E0 File Offset: 0x0001E7E0
	[Token(Token = "0x600062D")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_hypnoPea_fire()
	{
	}
}
