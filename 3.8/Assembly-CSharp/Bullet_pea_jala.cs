using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200017E RID: 382
[Token(Token = "0x200017E")]
public class Bullet_pea_jala : Bullet
{
	// Token: 0x060006BD RID: 1725 RVA: 0x000234AC File Offset: 0x000216AC
	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x7DAA50", Offset = "0x7D9050", VA = "0x1807DAA50", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		zombie.SetJalaed();
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num2 = 0;
		int theBulletRow = this.theBulletRow;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)116), num2, theBulletRow, num4 != 0UL, (float)num3);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x0002351C File Offset: 0x0002171C
	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x7DA940", Offset = "0x7D8F40", VA = "0x1807DA940", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)116), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x00023568 File Offset: 0x00021768
	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_pea_jala()
	{
	}
}
