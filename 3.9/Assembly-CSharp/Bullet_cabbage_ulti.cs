using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000126 RID: 294
[Token(Token = "0x2000126")]
public class Bullet_cabbage_ulti : Bullet_cabbage_small
{
	// Token: 0x0600059B RID: 1435 RVA: 0x0001D9E8 File Offset: 0x0001BBE8
	[Token(Token = "0x600059B")]
	[Address(RVA = "0x6E6DF0", Offset = "0x6E53F0", VA = "0x1806E6DF0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		if (!zombie.isSmall)
		{
			zombie.BeSmall(0.7f);
		}
		this.smallEffect = true;
		zombie.AddPoisonLevel();
		PlantType fromType = this.fromType;
		base.PlaySound(zombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		float num = this.velocity.y * -1f;
		this.velocity.y = num;
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x0001DA5C File Offset: 0x0001BC5C
	[Token(Token = "0x600059C")]
	[Address(RVA = "0x6E6CE0", Offset = "0x6E52E0", VA = "0x1806E6CE0", Slot = "17")]
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

	// Token: 0x0600059D RID: 1437 RVA: 0x0001DAB8 File Offset: 0x0001BCB8
	[Token(Token = "0x600059D")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_cabbage_ulti()
	{
	}
}
