using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200012A RID: 298
[Token(Token = "0x200012A")]
public class Bullet_cactus_ice : Bullet_pierce
{
	// Token: 0x060005A8 RID: 1448 RVA: 0x0001DCF0 File Offset: 0x0001BEF0
	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x6E65D0", Offset = "0x6E4BD0", VA = "0x1806E65D0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)3L);
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x0001DD08 File Offset: 0x0001BF08
	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x6E71E0", Offset = "0x6E57E0", VA = "0x1806E71E0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		zombie.AddfreezeLevel(10, num);
		int damage = this._damage;
		if (zombie.theStatus != ZombieStatus.Flying)
		{
			this.maxHitCount = (int)((ulong)1L);
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

	// Token: 0x060005AA RID: 1450 RVA: 0x0001DD98 File Offset: 0x0001BF98
	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_cactus_ice()
	{
	}
}
