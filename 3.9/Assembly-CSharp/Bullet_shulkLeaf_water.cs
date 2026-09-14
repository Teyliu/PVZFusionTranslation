using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200019C RID: 412
[Token(Token = "0x200019C")]
public class Bullet_shulkLeaf_water : Bullet_shulkLeaf
{
	// Token: 0x0600072B RID: 1835 RVA: 0x000245F4 File Offset: 0x000227F4
	[Token(Token = "0x600072B")]
	[Address(RVA = "0x6E4FA0", Offset = "0x6E35A0", VA = "0x1806E4FA0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)2L);
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x0002460C File Offset: 0x0002280C
	[Token(Token = "0x600072C")]
	[Address(RVA = "0x80C8F0", Offset = "0x80AEF0", VA = "0x18080C8F0", Slot = "22")]
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
			int num3 = 0;
			if (bullet5 != num3)
			{
				bullet.Die();
			}
		};
		delayAction.SetAction(action, 1.5f);
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x00024714 File Offset: 0x00022914
	[Token(Token = "0x600072D")]
	[Address(RVA = "0x80CBD0", Offset = "0x80B1D0", VA = "0x18080CBD0", Slot = "19")]
	public override void KeepHiting(Zombie zombie)
	{
		if (global::UnityEngine.Random.Range(0, 3) == 0)
		{
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = base.transform;
			int num = 0;
			int theZombieRow = zombie.theZombieRow;
			int num2 = 0;
			ulong num3;
			Particle particle = instance.SetParticle((ParticleType)((uint)32), num, theZombieRow, num3 != 0UL, (float)num2);
		}
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)((uint)1), fromType, num4 != 0UL);
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x00024780 File Offset: 0x00022980
	[Token(Token = "0x600072E")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_shulkLeaf_water()
	{
	}
}
