using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200017A RID: 378
[Token(Token = "0x200017A")]
public class Bullet_pea : Bullet
{
	// Token: 0x060006B2 RID: 1714 RVA: 0x00023130 File Offset: 0x00021330
	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x7D9FB0", Offset = "0x7D85B0", VA = "0x1807D9FB0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num2 = 0;
		int theZombieRow = zombie.theZombieRow;
		int num3 = 0;
		int num4 = 0;
		ulong num5;
		Particle particle = instance.SetParticle((ParticleType)num4, num2, theZombieRow, num5 != 0UL, (float)num3);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x0002319C File Offset: 0x0002139C
	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x7D9E50", Offset = "0x7D8450", VA = "0x1807D9E50", Slot = "24")]
	protected override void HitPlant(Plant plant)
	{
		plant.FlashOnce();
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int thePlantRow = plant.thePlantRow;
		int num2 = 0;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)num3, num, thePlantRow, num4 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x000231F0 File Offset: 0x000213F0
	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x7D9D40", Offset = "0x7D8340", VA = "0x1807D9D40", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)num3, num, theBulletRow, num4 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x0002323C File Offset: 0x0002143C
	[Token(Token = "0x60006B5")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_pea()
	{
	}
}
