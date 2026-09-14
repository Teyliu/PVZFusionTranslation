using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000152 RID: 338
[Token(Token = "0x2000152")]
public class Bullet_icePeach : Bullet_pierce
{
	// Token: 0x06000630 RID: 1584 RVA: 0x00021058 File Offset: 0x0001F258
	[Token(Token = "0x6000630")]
	[Address(RVA = "0x6C6330", Offset = "0x6C4930", VA = "0x1806C6330", Slot = "25")]
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

	// Token: 0x06000631 RID: 1585 RVA: 0x000210CC File Offset: 0x0001F2CC
	[Token(Token = "0x6000631")]
	[Address(RVA = "0x6C6220", Offset = "0x6C4820", VA = "0x1806C6220", Slot = "18")]
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

	// Token: 0x06000632 RID: 1586 RVA: 0x00021118 File Offset: 0x0001F318
	[Token(Token = "0x6000632")]
	[Address(RVA = "0x6BB760", Offset = "0x6B9D60", VA = "0x1806BB760", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)3L);
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00021130 File Offset: 0x0001F330
	[Token(Token = "0x6000633")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_icePeach()
	{
	}
}
