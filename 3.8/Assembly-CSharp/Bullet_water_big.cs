using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001CF RID: 463
[Token(Token = "0x20001CF")]
public class Bullet_water_big : Bullet
{
	// Token: 0x060007F1 RID: 2033 RVA: 0x00028F10 File Offset: 0x00027110
	[Token(Token = "0x60007F1")]
	[Address(RVA = "0x853370", Offset = "0x851970", VA = "0x180853370", Slot = "25")]
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

	// Token: 0x060007F2 RID: 2034 RVA: 0x00028F7C File Offset: 0x0002717C
	[Token(Token = "0x60007F2")]
	[Address(RVA = "0x853260", Offset = "0x851860", VA = "0x180853260", Slot = "18")]
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

	// Token: 0x060007F3 RID: 2035 RVA: 0x00028FC8 File Offset: 0x000271C8
	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_water_big()
	{
	}
}
