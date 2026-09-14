using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200019E RID: 414
[Token(Token = "0x200019E")]
public class Bullet_smallIceSpark_sp : Bullet_iceSpark
{
	// Token: 0x06000739 RID: 1849 RVA: 0x00025424 File Offset: 0x00023624
	[Token(Token = "0x6000739")]
	[Address(RVA = "0x7E0A10", Offset = "0x7DF010", VA = "0x1807E0A10", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		if (!zombie.HasBuff((EffectType)((uint)2)))
		{
			int num = 0;
			if (!zombie.HasBuff((EffectType)num))
			{
				goto IL_0046;
			}
			int num2 = 0;
			zombie.SetFreeze(4f, num2);
		}
		zombie.Unfreezing();
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num3;
		zombie.TakeDamage(damage, this, (DamageType)((uint)5), fromType, num3 != 0UL);
		IL_0046:
		base.PlaySound(zombie);
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00025484 File Offset: 0x00023684
	[Token(Token = "0x600073A")]
	[Address(RVA = "0x7E0900", Offset = "0x7DEF00", VA = "0x1807E0900", Slot = "18")]
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

	// Token: 0x0600073B RID: 1851 RVA: 0x000254D0 File Offset: 0x000236D0
	[Token(Token = "0x600073B")]
	[Address(RVA = "0x7D98C0", Offset = "0x7D7EC0", VA = "0x1807D98C0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)2147483647L);
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x000254F0 File Offset: 0x000236F0
	[Token(Token = "0x600073C")]
	[Address(RVA = "0x7E0730", Offset = "0x7DED30", VA = "0x1807E0730")]
	public Bullet_smallIceSpark_sp()
	{
	}
}
