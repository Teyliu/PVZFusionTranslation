using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000127 RID: 295
[Token(Token = "0x2000127")]
public class Bullet_cabbage_ulti2 : Bullet_cabbage_ulti
{
	// Token: 0x0600059E RID: 1438 RVA: 0x0001DACC File Offset: 0x0001BCCC
	[Token(Token = "0x600059E")]
	[Address(RVA = "0x6E6AE0", Offset = "0x6E50E0", VA = "0x1806E6AE0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		if (!zombie.isSmall)
		{
			zombie.BeSmall(0.7f);
		}
		this.smallEffect = true;
		zombie.AddPoisonLevel();
		PlantType fromType = this.fromType;
		int num = 0;
		uint num2;
		zombie.AddfreezeLevel((int)num2, num);
		base.PlaySound(zombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		float num3 = this.velocity.y * -1f;
		this.velocity.y = num3;
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x0001DB4C File Offset: 0x0001BD4C
	[Token(Token = "0x600059F")]
	[Address(RVA = "0x6E69D0", Offset = "0x6E4FD0", VA = "0x1806E69D0", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x0001DBA8 File Offset: 0x0001BDA8
	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_cabbage_ulti2()
	{
	}
}
