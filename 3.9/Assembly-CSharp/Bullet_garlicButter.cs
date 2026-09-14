using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000149 RID: 329
[Token(Token = "0x2000149")]
public class Bullet_garlicButter : Bullet_butter
{
	// Token: 0x06000612 RID: 1554 RVA: 0x0001FCCC File Offset: 0x0001DECC
	[Token(Token = "0x6000612")]
	[Address(RVA = "0x6EEEC0", Offset = "0x6ED4C0", VA = "0x1806EEEC0", Slot = "22")]
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

	// Token: 0x06000613 RID: 1555 RVA: 0x0001FD54 File Offset: 0x0001DF54
	[Token(Token = "0x6000613")]
	[Address(RVA = "0x6EEDC0", Offset = "0x6ED3C0", VA = "0x1806EEDC0", Slot = "17")]
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

	// Token: 0x06000614 RID: 1556 RVA: 0x0001FDAC File Offset: 0x0001DFAC
	[Token(Token = "0x6000614")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_garlicButter()
	{
	}
}
