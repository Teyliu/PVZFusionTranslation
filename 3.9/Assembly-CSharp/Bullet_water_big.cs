using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001D9 RID: 473
[Token(Token = "0x20001D9")]
public class Bullet_water_big : Bullet
{
	// Token: 0x06000807 RID: 2055 RVA: 0x00028AD0 File Offset: 0x00026CD0
	[Token(Token = "0x6000807")]
	[Address(RVA = "0x8E19A0", Offset = "0x8DFFA0", VA = "0x1808E19A0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)1), fromType, num != 0UL);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num2 = 0;
		int theZombieRow = zombie.theZombieRow;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)32), num2, theZombieRow, num4 != 0UL, (float)num3);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00028B3C File Offset: 0x00026D3C
	[Token(Token = "0x6000808")]
	[Address(RVA = "0x8E1890", Offset = "0x8DFE90", VA = "0x1808E1890", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)32), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x00028B88 File Offset: 0x00026D88
	[Token(Token = "0x6000809")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_water_big()
	{
	}
}
