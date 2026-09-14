using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200017D RID: 381
[Token(Token = "0x200017D")]
public class Bullet_pea_garlic : Bullet
{
	// Token: 0x060006BA RID: 1722 RVA: 0x000233AC File Offset: 0x000215AC
	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x7DA760", Offset = "0x7D8D60", VA = "0x1807DA760", Slot = "25")]
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

	// Token: 0x060006BB RID: 1723 RVA: 0x0002343C File Offset: 0x0002163C
	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x7DA650", Offset = "0x7D8C50", VA = "0x1807DA650", Slot = "18")]
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

	// Token: 0x060006BC RID: 1724 RVA: 0x00023498 File Offset: 0x00021698
	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_pea_garlic()
	{
	}
}
