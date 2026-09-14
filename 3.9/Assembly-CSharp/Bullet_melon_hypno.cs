using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000174 RID: 372
[Token(Token = "0x2000174")]
public class Bullet_melon_hypno : Bullet_melon
{
	// Token: 0x06000695 RID: 1685 RVA: 0x00022030 File Offset: 0x00020230
	[Token(Token = "0x6000695")]
	[Address(RVA = "0x805210", Offset = "0x803810", VA = "0x180805210", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		long currentFirstHealth = zombie.CurrentFirstHealth;
		int num = 0;
		long num2 = zombie.TotalFirstHealth;
		num2 -= (long)num;
		if (currentFirstHealth < num2)
		{
			int num3 = 0;
			zombie.SetMindControl(num3);
		}
		uint num4;
		uint num5;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num4, (int)num5), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x000220A8 File Offset: 0x000202A8
	[Token(Token = "0x6000696")]
	[Address(RVA = "0x8050E0", Offset = "0x8036E0", VA = "0x1808050E0", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)112), num, theBulletRow, num3 != 0UL, (float)num2);
		int num4 = 0;
		base.AttackOtherZombie(num4, (MelonSputterType)((uint)6));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00022114 File Offset: 0x00020314
	[Token(Token = "0x6000697")]
	[Address(RVA = "0x8053E0", Offset = "0x8039E0", VA = "0x1808053E0")]
	public Bullet_melon_hypno()
	{
	}
}
