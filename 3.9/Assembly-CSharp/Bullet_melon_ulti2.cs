using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200017B RID: 379
[Token(Token = "0x200017B")]
public class Bullet_melon_ulti2 : Bullet_melon_ulti
{
	// Token: 0x060006AD RID: 1709 RVA: 0x00022690 File Offset: 0x00020890
	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x806750", Offset = "0x804D50", VA = "0x180806750", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		PlantType fromType = this.fromType;
		if (zombie.isSmall)
		{
		}
		int num = 0;
		uint num2;
		zombie.AddfreezeLevel((int)num2, num);
		zombie.AddPoisonLevel();
		base.PlaySound(zombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		base.Die();
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x000226E4 File Offset: 0x000208E4
	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x806640", Offset = "0x804C40", VA = "0x180806640", Slot = "17")]
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

	// Token: 0x060006AF RID: 1711 RVA: 0x00022730 File Offset: 0x00020930
	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_melon_ulti2()
	{
	}
}
