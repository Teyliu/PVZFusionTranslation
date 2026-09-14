using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000199 RID: 409
[Token(Token = "0x2000199")]
public class Bullet_shulkLeaf_ice : Bullet_shulkLeaf
{
	// Token: 0x0600071E RID: 1822 RVA: 0x00024210 File Offset: 0x00022410
	[Token(Token = "0x600071E")]
	[Address(RVA = "0x6E4FA0", Offset = "0x6E35A0", VA = "0x1806E4FA0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)2L);
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00024228 File Offset: 0x00022428
	[Token(Token = "0x600071F")]
	[Address(RVA = "0x80C180", Offset = "0x80A780", VA = "0x18080C180", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		base.PlaySound(zombie);
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		BulletType theBulletType = this.theBulletType;
		Bullet bullet6;
		Bullet bullet = bullet6;
		Bullet bullet2 = bullet;
		int damage2 = this._damage;
		bullet2._damage = damage2;
		Bullet bullet3 = bullet;
		BulletStatus theStatus = this.theStatus;
		bullet3.theStatus = theStatus;
		Bullet bullet4 = bullet;
		PlantType fromType2 = this.fromType;
		bullet4.fromType = fromType2;
		bullet.maxHitCount = (int)((ulong)100000000L);
		DelayAction delayAction = GameAPP.delayAction;
		Action action = delegate
		{
			Bullet bullet5 = bullet;
			int num9 = 0;
			if (bullet5 != num9)
			{
				bullet.Die();
			}
		};
		delayAction.SetAction(action, 1.5f);
		ParticleManager instance2 = ParticleManager.Instance;
		Transform transform3 = base.transform;
		int num3 = 0;
		int theZombieRow = zombie.theZombieRow;
		int num4 = 0;
		ulong num5;
		Particle particle = instance2.SetParticle((ParticleType)((uint)24), num3, theZombieRow, num5 != 0UL, (float)num4);
		int damage3 = this._damage;
		PlantType fromType3 = this.fromType;
		ulong num6;
		zombie.TakeDamage(damage3, this, (DamageType)((uint)4), fromType3, num6 != 0UL);
		int num7 = 0;
		zombie.SetCold(15f, 1, num7 != 0);
		int num8 = 0;
		zombie.AddfreezeLevel(20, num8);
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x0002437C File Offset: 0x0002257C
	[Token(Token = "0x6000720")]
	[Address(RVA = "0x80C530", Offset = "0x80AB30", VA = "0x18080C530", Slot = "19")]
	public override void KeepHiting(Zombie zombie)
	{
		int num = 0;
		zombie.SetCold(15f, 1, num != 0);
		int num2 = 0;
		zombie.AddfreezeLevel(1, num2);
		if (global::UnityEngine.Random.Range(0, 3) == 0)
		{
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = base.transform;
			int num3 = 0;
			int theZombieRow = zombie.theZombieRow;
			int num4 = 0;
			ulong num5;
			Particle particle = instance.SetParticle((ParticleType)((uint)24), num3, theZombieRow, num5 != 0UL, (float)num4);
		}
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num6;
		zombie.TakeDamage(damage, this, (DamageType)((uint)1), fromType, num6 != 0UL);
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00024400 File Offset: 0x00022600
	[Token(Token = "0x6000721")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_shulkLeaf_ice()
	{
	}
}
