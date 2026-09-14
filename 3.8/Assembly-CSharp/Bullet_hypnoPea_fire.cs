using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200014D RID: 333
[Token(Token = "0x200014D")]
public class Bullet_hypnoPea_fire : Bullet_firePea
{
	// Token: 0x06000624 RID: 1572 RVA: 0x00020C80 File Offset: 0x0001EE80
	[Token(Token = "0x6000624")]
	[Address(RVA = "0x6C5580", Offset = "0x6C3B80", VA = "0x1806C5580", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		bool beforeDying = zombie.beforeDying;
		int theHealth = zombie.theHealth;
		base.FireZombie(zombie, true);
		if (zombie.BoxType != BoxType.Water && ((!beforeDying && zombie.beforeDying != beforeDying) || (theHealth > 0 && !zombie.beforeDying)))
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

	// Token: 0x06000625 RID: 1573 RVA: 0x00020D48 File Offset: 0x0001EF48
	[Token(Token = "0x6000625")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_hypnoPea_fire()
	{
	}
}
