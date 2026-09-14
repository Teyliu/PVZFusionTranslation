using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000184 RID: 388
[Token(Token = "0x2000184")]
public class Bullet_pea_garlic : Bullet
{
	// Token: 0x060006C9 RID: 1737 RVA: 0x00022DA4 File Offset: 0x00020FA4
	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x808120", Offset = "0x806720", VA = "0x180808120", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		base.PlaySound(zombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int theZombieRow = zombie.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)57), num, theZombieRow, num3 != 0UL, (float)num2);
		int num4 = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num5;
		zombie.TakeDamage(damage, this, (DamageType)num4, fromType, num5 != 0UL);
		zombie.AddPoisonLevel();
		if (zombie.HasBuff((EffectType)((uint)4)))
		{
			Transform axis = zombie.axis;
		}
		base.Die();
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00022E34 File Offset: 0x00021034
	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x808010", Offset = "0x806610", VA = "0x180808010", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)57), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00022E90 File Offset: 0x00021090
	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_pea_garlic()
	{
	}
}
