using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000185 RID: 389
[Token(Token = "0x2000185")]
public class Bullet_pea_jala : Bullet
{
	// Token: 0x060006CC RID: 1740 RVA: 0x00022EA4 File Offset: 0x000210A4
	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x808410", Offset = "0x806A10", VA = "0x180808410", Slot = "22")]
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

	// Token: 0x060006CD RID: 1741 RVA: 0x00022F14 File Offset: 0x00021114
	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x808300", Offset = "0x806900", VA = "0x180808300", Slot = "17")]
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

	// Token: 0x060006CE RID: 1742 RVA: 0x00022F60 File Offset: 0x00021160
	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_pea_jala()
	{
	}
}
