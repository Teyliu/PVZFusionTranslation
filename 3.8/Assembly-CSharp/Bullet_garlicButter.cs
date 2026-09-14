using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000144 RID: 324
[Token(Token = "0x2000144")]
public class Bullet_garlicButter : Bullet_butter
{
	// Token: 0x0600060A RID: 1546 RVA: 0x00020444 File Offset: 0x0001E644
	[Token(Token = "0x600060A")]
	[Address(RVA = "0x6C3D40", Offset = "0x6C2340", VA = "0x1806C3D40", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(100, 0.5f, 1f);
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
		int num5 = 0;
		zombie.Buttered(4f, num5 != 0);
		zombie.SetPoison(10f);
		base.Die();
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x000204CC File Offset: 0x0001E6CC
	[Token(Token = "0x600060B")]
	[Address(RVA = "0x6C3C40", Offset = "0x6C2240", VA = "0x1806C3C40", Slot = "18")]
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

	// Token: 0x0600060C RID: 1548 RVA: 0x00020524 File Offset: 0x0001E724
	[Token(Token = "0x600060C")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_garlicButter()
	{
	}
}
