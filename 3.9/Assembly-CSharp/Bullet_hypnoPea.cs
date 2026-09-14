using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000151 RID: 337
[Token(Token = "0x2000151")]
public class Bullet_hypnoPea : Bullet
{
	// Token: 0x06000629 RID: 1577 RVA: 0x000203B4 File Offset: 0x0001E5B4
	[Token(Token = "0x6000629")]
	[Address(RVA = "0x6F0470", Offset = "0x6EEA70", VA = "0x1806F0470", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		bool beforeDying = zombie.beforeDying;
		long theHealth = zombie.theHealth;
		base.HitZombie(zombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int theZombieRow = zombie.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)114), num, theZombieRow, num3 != 0UL, (float)num2);
		if (zombie.BoxType != BoxType.Water && ((!beforeDying && zombie.beforeDying != beforeDying) || !zombie.beforeDying))
		{
			Transform axis = zombie.axis;
			CreateZombie instance2 = CreateZombie.Instance;
			bool flag;
			if (flag)
			{
				PeaShooterZ peaShooterZ;
				peaShooterZ.hypnoHead.SetActive(true);
				GameObject normalHead = peaShooterZ.normalHead;
				int num4 = 0;
				normalHead.SetActive(num4 != 0);
				peaShooterZ.hypnoPea = true;
			}
			Transform axis2 = zombie.axis;
			ParticleManager instance3 = ParticleManager.Instance;
			int num5 = 0;
			int theZombieRow2 = zombie.theZombieRow;
			ulong num6;
			Particle particle2 = instance3.SetParticle((ParticleType)((uint)99), num5, theZombieRow2, num6 != 0UL, (float)num2);
		}
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x000204A8 File Offset: 0x0001E6A8
	[Token(Token = "0x600062A")]
	[Address(RVA = "0x6F0300", Offset = "0x6EE900", VA = "0x1806F0300", Slot = "21")]
	protected override void HitPlant(Plant plant)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)114), num, theBulletRow, num3 != 0UL, (float)num2);
		plant.FlashOnce();
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x0002050C File Offset: 0x0001E70C
	[Token(Token = "0x600062B")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_hypnoPea()
	{
	}
}
