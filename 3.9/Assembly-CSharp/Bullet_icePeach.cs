using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000158 RID: 344
[Token(Token = "0x2000158")]
public class Bullet_icePeach : Bullet_pierce
{
	// Token: 0x0600063B RID: 1595 RVA: 0x00020A20 File Offset: 0x0001EC20
	[Token(Token = "0x600063B")]
	[Address(RVA = "0x6F1BF0", Offset = "0x6F01F0", VA = "0x1806F1BF0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		zombie.AddfreezeLevel(5, num);
		int num2 = 0;
		int damage = this._damage;
		if (zombie == 0)
		{
		}
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num3 = 0;
		int theZombieRow = zombie.theZombieRow;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num3, theZombieRow, num4 != 0UL, (float)num2);
		PlantType fromType = this.fromType;
		ulong num5;
		zombie.TakeDamage(damage, this, (DamageType)((uint)3), fromType, num5 != 0UL);
		base.PlaySound(zombie);
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00020A94 File Offset: 0x0001EC94
	[Token(Token = "0x600063C")]
	[Address(RVA = "0x6F1AE0", Offset = "0x6F00E0", VA = "0x1806F1AE0", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00020AE0 File Offset: 0x0001ECE0
	[Token(Token = "0x600063D")]
	[Address(RVA = "0x6E65D0", Offset = "0x6E4BD0", VA = "0x1806E65D0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)3L);
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x00020AF8 File Offset: 0x0001ECF8
	[Token(Token = "0x600063E")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_icePeach()
	{
	}
}
