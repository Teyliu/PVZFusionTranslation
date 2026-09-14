using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000153 RID: 339
[Token(Token = "0x2000153")]
public class Bullet_iceSpark : Bullet_pierce
{
	// Token: 0x06000634 RID: 1588 RVA: 0x00021144 File Offset: 0x0001F344
	[Token(Token = "0x6000634")]
	[Address(RVA = "0x6C65A0", Offset = "0x6C4BA0", VA = "0x1806C65A0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		uint num2;
		zombie.AddfreezeLevel((int)num2, num);
		int num3 = 0;
		int num4 = 0;
		zombie.SetCold(1f, num4, num3 != 0);
		if (zombie != 0)
		{
			int num5 = 0;
			if (zombie.HasBuff((EffectType)num5))
			{
				goto IL_0035;
			}
		}
		bool flag;
		if (flag)
		{
		}
		IL_0035:
		bool flag2;
		if (flag2)
		{
			CreateBullet instance = CreateBullet.Instance;
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			BulletType theBulletType = this.theBulletType;
			Bullet bullet;
			Transform transform3 = bullet.transform;
			PlantType fromType = this.fromType;
			bullet.fromType = fromType;
			CreateBullet instance2 = CreateBullet.Instance;
			Transform transform4 = base.transform;
			Transform transform5 = base.transform;
			BulletType theBulletType2 = this.theBulletType;
			Bullet bullet2;
			Transform transform6 = bullet2.transform;
			PlantType fromType2 = this.fromType;
			bullet2.fromType = fromType2;
		}
		ParticleManager instance3 = ParticleManager.Instance;
		Transform transform7 = base.transform;
		PlantType fromType3 = this.fromType;
		base.PlaySound(zombie);
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x00021224 File Offset: 0x0001F424
	[Token(Token = "0x6000635")]
	[Address(RVA = "0x6C6490", Offset = "0x6C4A90", VA = "0x1806C6490", Slot = "18")]
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

	// Token: 0x06000636 RID: 1590 RVA: 0x00021270 File Offset: 0x0001F470
	[Token(Token = "0x6000636")]
	[Address(RVA = "0x6C6A20", Offset = "0x6C5020", VA = "0x1806C6A20", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		if (!Lawnf.TravelAdvanced((AdvBuff)((uint)10)))
		{
			base.SetPenetrationTime();
			return;
		}
		this.penetrationTimes = (int)((ulong)2147483647L);
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x000212A0 File Offset: 0x0001F4A0
	[Token(Token = "0x6000637")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_iceSpark()
	{
	}
}
