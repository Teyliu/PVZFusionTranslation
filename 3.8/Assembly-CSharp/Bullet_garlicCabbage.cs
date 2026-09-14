using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000145 RID: 325
[Token(Token = "0x2000145")]
public class Bullet_garlicCabbage : Bullet_sunCabbage
{
	// Token: 0x0600060D RID: 1549 RVA: 0x00020538 File Offset: 0x0001E738
	[Token(Token = "0x600060D")]
	[Address(RVA = "0x6BA0B0", Offset = "0x6B86B0", VA = "0x1806BA0B0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)2L);
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00020550 File Offset: 0x0001E750
	[Token(Token = "0x600060E")]
	[Address(RVA = "0x6C3FF0", Offset = "0x6C25F0", VA = "0x1806C3FF0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		if (zombie.poisonLevel > 0)
		{
		}
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theZombieRow = zombie.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle(ParticleType.Splat_white, num, theZombieRow, num3 != 0UL, (float)num2);
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(57, this, (DamageType)((uint)4), fromType, num4 != 0UL);
		zombie.AddPoisonLevel();
		float num5 = this.Vy * -1f;
		this.Vy = num5;
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x000205E4 File Offset: 0x0001E7E4
	[Token(Token = "0x600060F")]
	[Address(RVA = "0x6C3EE0", Offset = "0x6C24E0", VA = "0x1806C3EE0", Slot = "18")]
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

	// Token: 0x06000610 RID: 1552 RVA: 0x00020640 File Offset: 0x0001E840
	[Token(Token = "0x6000610")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_garlicCabbage()
	{
	}
}
