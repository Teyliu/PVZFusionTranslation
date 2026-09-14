using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000179 RID: 377
[Token(Token = "0x2000179")]
public class Bullet_melon_small : Bullet
{
	// Token: 0x060006A7 RID: 1703 RVA: 0x0002253C File Offset: 0x0002073C
	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x806510", Offset = "0x804B10", VA = "0x180806510", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = this._damage;
		PlantType fromType = this.fromType;
		if (zombie.isSmall)
		{
			num += num;
		}
		base.PlaySound(zombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		base.Die();
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x0002258C File Offset: 0x0002078C
	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x806450", Offset = "0x804A50", VA = "0x180806450", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)111), num, theBulletRow, num3 != 0UL, (float)num2);
		base.HitLand();
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x000225D4 File Offset: 0x000207D4
	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_melon_small()
	{
	}
}
