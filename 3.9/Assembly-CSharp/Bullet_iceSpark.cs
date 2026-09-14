using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000159 RID: 345
[Token(Token = "0x2000159")]
public class Bullet_iceSpark : Bullet_pierce
{
	// Token: 0x0600063F RID: 1599 RVA: 0x00020B0C File Offset: 0x0001ED0C
	[Token(Token = "0x600063F")]
	[Address(RVA = "0x6F1E60", Offset = "0x6F0460", VA = "0x1806F1E60", Slot = "22")]
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

	// Token: 0x06000640 RID: 1600 RVA: 0x00020BEC File Offset: 0x0001EDEC
	[Token(Token = "0x6000640")]
	[Address(RVA = "0x6F1D50", Offset = "0x6F0350", VA = "0x1806F1D50", Slot = "17")]
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

	// Token: 0x06000641 RID: 1601 RVA: 0x00020C38 File Offset: 0x0001EE38
	[Token(Token = "0x6000641")]
	[Address(RVA = "0x6F22E0", Offset = "0x6F08E0", VA = "0x1806F22E0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		if (!Lawnf.TravelAdvanced((AdvBuff)((uint)10)))
		{
			base.SetPenetrationTime();
			return;
		}
		this.maxHitCount = (int)((ulong)2147483647L);
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x00020C68 File Offset: 0x0001EE68
	[Token(Token = "0x6000642")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_iceSpark()
	{
	}
}
