using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000125 RID: 293
[Token(Token = "0x2000125")]
public class Bullet_cactus_ice : Bullet_pierce
{
	// Token: 0x060005A1 RID: 1441 RVA: 0x0001E520 File Offset: 0x0001C720
	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x6BB760", Offset = "0x6B9D60", VA = "0x1806BB760", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)3L);
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x0001E538 File Offset: 0x0001C738
	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x6BC420", Offset = "0x6BAA20", VA = "0x1806BC420", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		zombie.AddfreezeLevel(10, num);
		int damage = this._damage;
		if (zombie.theStatus != ZombieStatus.Flying)
		{
			this.penetrationTimes = (int)((ulong)1L);
		}
		bool flag = zombie.HasBuff((EffectType)((uint)2));
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)((uint)5), fromType, num2 != 0UL);
		base.PlaySound(zombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num3 = 0;
		int theZombieRow = zombie.theZombieRow;
		int num4 = 0;
		ulong num5;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num3, theZombieRow, num5 != 0UL, (float)num4);
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x0001E5C8 File Offset: 0x0001C7C8
	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_cactus_ice()
	{
	}
}
