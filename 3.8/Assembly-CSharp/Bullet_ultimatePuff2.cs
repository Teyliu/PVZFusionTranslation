using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C7 RID: 455
[Token(Token = "0x20001C7")]
public class Bullet_ultimatePuff2 : Bullet_ultimatePuff
{
	// Token: 0x060007D1 RID: 2001 RVA: 0x0002843C File Offset: 0x0002663C
	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x7E8E40", Offset = "0x7E7440", VA = "0x1807E8E40", Slot = "18")]
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

	// Token: 0x060007D2 RID: 2002 RVA: 0x00028488 File Offset: 0x00026688
	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x7E8F50", Offset = "0x7E7550", VA = "0x1807E8F50", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num, theBulletRow, num3 != 0UL, (float)num2);
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)((uint)5), fromType, num4 != 0UL);
		int num5 = 0;
		zombie.AddfreezeLevel(5, num5);
		base.PlaySound(zombie);
		int theZombieRow = zombie.theZombieRow;
		int theZombieRow2 = zombie.theZombieRow;
		base.Die();
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00028510 File Offset: 0x00026710
	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x7E7570", Offset = "0x7E5B70", VA = "0x1807E7570")]
	public Bullet_ultimatePuff2()
	{
	}
}
