using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200014A RID: 330
[Token(Token = "0x200014A")]
public class Bullet_garlicCabbage : Bullet_sunCabbage
{
	// Token: 0x06000615 RID: 1557 RVA: 0x0001FDC0 File Offset: 0x0001DFC0
	[Token(Token = "0x6000615")]
	[Address(RVA = "0x6E4FA0", Offset = "0x6E35A0", VA = "0x1806E4FA0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)2L);
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x0001FDD8 File Offset: 0x0001DFD8
	[Token(Token = "0x6000616")]
	[Address(RVA = "0x6EF170", Offset = "0x6ED770", VA = "0x1806EF170", Slot = "22")]
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
		float num5 = this.velocity.y * -1f;
		this.velocity.y = num5;
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x0001FE74 File Offset: 0x0001E074
	[Token(Token = "0x6000617")]
	[Address(RVA = "0x6EF060", Offset = "0x6ED660", VA = "0x1806EF060", Slot = "17")]
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

	// Token: 0x06000618 RID: 1560 RVA: 0x0001FED0 File Offset: 0x0001E0D0
	[Token(Token = "0x6000618")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_garlicCabbage()
	{
	}
}
