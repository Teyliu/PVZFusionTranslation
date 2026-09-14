using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200014C RID: 332
[Token(Token = "0x200014C")]
public class Bullet_hypnoPea : Bullet
{
	// Token: 0x06000621 RID: 1569 RVA: 0x00020B10 File Offset: 0x0001ED10
	[Token(Token = "0x6000621")]
	[Address(RVA = "0x6C5290", Offset = "0x6C3890", VA = "0x1806C5290", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		bool beforeDying = zombie.beforeDying;
		int theHealth = zombie.theHealth;
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
		if (zombie.BoxType != BoxType.Water && ((!beforeDying && zombie.beforeDying != beforeDying) || (theHealth > 0 && !zombie.beforeDying)))
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

	// Token: 0x06000622 RID: 1570 RVA: 0x00020C08 File Offset: 0x0001EE08
	[Token(Token = "0x6000622")]
	[Address(RVA = "0x6C5120", Offset = "0x6C3720", VA = "0x1806C5120", Slot = "24")]
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

	// Token: 0x06000623 RID: 1571 RVA: 0x00020C6C File Offset: 0x0001EE6C
	[Token(Token = "0x6000623")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_hypnoPea()
	{
	}
}
