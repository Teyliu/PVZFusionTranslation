using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200011C RID: 284
[Token(Token = "0x200011C")]
public class Bullet_butter_ulti : Bullet
{
	// Token: 0x06000574 RID: 1396 RVA: 0x0001CDD4 File Offset: 0x0001AFD4
	[Token(Token = "0x6000574")]
	[Address(RVA = "0x6E4310", Offset = "0x6E2910", VA = "0x1806E4310", Slot = "22")]
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

	// Token: 0x06000575 RID: 1397 RVA: 0x0001CE3C File Offset: 0x0001B03C
	[Token(Token = "0x6000575")]
	[Address(RVA = "0x6E4210", Offset = "0x6E2810", VA = "0x1806E4210", Slot = "17")]
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

	// Token: 0x06000576 RID: 1398 RVA: 0x0001CE94 File Offset: 0x0001B094
	[Token(Token = "0x6000576")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_butter_ulti()
	{
	}
}
