using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C6 RID: 454
[Token(Token = "0x20001C6")]
public class Bullet_ultimatePuff : Bullet_ultimateMelon
{
	// Token: 0x060007CD RID: 1997 RVA: 0x000281CC File Offset: 0x000263CC
	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x7E90F0", Offset = "0x7E76F0", VA = "0x1807E90F0", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)57), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x00028218 File Offset: 0x00026418
	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x7E9200", Offset = "0x7E7800", VA = "0x1807E9200", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)57), num, theBulletRow, num3 != 0UL, (float)num2);
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num4 != 0UL);
		base.PlaySound(zombie);
		int theZombieRow = zombie.theZombieRow;
		base.Die();
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x0002828C File Offset: 0x0002648C
	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x7E9360", Offset = "0x7E7960", VA = "0x1807E9360")]
	protected void Split(BulletType t1, BulletType t2, BulletType t3, BulletType t4, int row)
	{
		int num = (int)(t1 + (int)t1);
		float num2 = global::UnityEngine.Random.Range(0.9f, 1.1f);
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		float num3 = this.Vy * 0.5f;
		Bullet bullet;
		bullet.Vy = num3;
		float num4 = this.Vx * 0.5f;
		bullet.Vx = num4;
		float detaVy = this.detaVy;
		bullet.detaVy = detaVy;
		bool melonSputter = this.melonSputter;
		bullet.melonSputter = melonSputter;
		PlantType fromType = this.fromType;
		bullet.fromType = fromType;
		CreateBullet instance2 = CreateBullet.Instance;
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		float num5 = this.Vy * 0.4f;
		Bullet bullet2;
		bullet2.Vy = num5;
		float num6 = this.Vx * 0.4f;
		bullet2.Vx = num6;
		float detaVy2 = this.detaVy;
		bullet2.detaVy = detaVy2;
		bool melonSputter2 = this.melonSputter;
		bullet2.melonSputter = melonSputter2;
		PlantType fromType2 = this.fromType;
		bullet2.fromType = fromType2;
		CreateBullet instance3 = CreateBullet.Instance;
		Transform transform5 = base.transform;
		Transform transform6 = base.transform;
		float vy = this.Vy;
		Bullet bullet3;
		bullet3.Vy = vy;
		float vx = this.Vx;
		bullet3.Vx = vx;
		float detaVy3 = this.detaVy;
		bullet3.detaVy = detaVy3;
		bullet3.Damage = (int)detaVy3;
		bool melonSputter3 = this.melonSputter;
		bullet3.melonSputter = melonSputter3;
		PlantType fromType3 = this.fromType;
		bullet3.fromType = fromType3;
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x00028428 File Offset: 0x00026628
	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x7E7570", Offset = "0x7E5B70", VA = "0x1807E7570")]
	public Bullet_ultimatePuff()
	{
	}
}
