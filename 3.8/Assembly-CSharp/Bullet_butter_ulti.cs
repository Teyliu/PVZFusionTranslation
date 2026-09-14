using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000116 RID: 278
[Token(Token = "0x2000116")]
public class Bullet_butter_ulti : Bullet
{
	// Token: 0x06000563 RID: 1379 RVA: 0x0001D454 File Offset: 0x0001B654
	[Token(Token = "0x6000563")]
	[Address(RVA = "0x6B9420", Offset = "0x6B7A20", VA = "0x1806B9420", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		uint num;
		GameAPP.PlaySound((int)num, 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		if (!zombie.isSmall)
		{
		}
		int num2 = 0;
		zombie.Buttered(1.5f, num2 != 0);
		zombie.SetPoison(10f);
		base.Die();
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x0001D4BC File Offset: 0x0001B6BC
	[Token(Token = "0x6000564")]
	[Address(RVA = "0x6B9320", Offset = "0x6B7920", VA = "0x1806B9320", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(100, 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)57), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x0001D514 File Offset: 0x0001B714
	[Token(Token = "0x6000565")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_butter_ulti()
	{
	}
}
