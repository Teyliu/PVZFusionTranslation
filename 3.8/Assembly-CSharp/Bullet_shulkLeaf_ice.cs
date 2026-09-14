using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000192 RID: 402
[Token(Token = "0x2000192")]
public class Bullet_shulkLeaf_ice : Bullet_shulkLeaf
{
	// Token: 0x06000711 RID: 1809 RVA: 0x000248D0 File Offset: 0x00022AD0
	[Token(Token = "0x6000711")]
	[Address(RVA = "0x6BA0B0", Offset = "0x6B86B0", VA = "0x1806BA0B0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)2L);
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x000248E8 File Offset: 0x00022AE8
	[Token(Token = "0x6000712")]
	[Address(RVA = "0x7DEA10", Offset = "0x7DD010", VA = "0x1807DEA10", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		base.PlaySound(zombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theZombieRow = zombie.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num, theZombieRow, num3 != 0UL, (float)num2);
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num4 != 0UL);
		int num5 = 0;
		int damage2 = this._damage;
		PlantType fromType2 = this.fromType;
		ulong num6;
		zombie.TakeDamage(damage2, this, (DamageType)num5, fromType2, num6 != 0UL);
		CreateBullet instance2 = CreateBullet.Instance;
		Transform transform2 = base.transform;
		Vector2 velocity = this.rb.velocity;
		Transform transform3 = base.transform;
		BulletType theBulletType = this.theBulletType;
		Bullet bullet6;
		Bullet bullet = bullet6;
		Bullet bullet2 = bullet;
		int damage3 = this._damage;
		bullet2._damage = damage3;
		Bullet bullet3 = bullet;
		BulletStatus theStatus = this.theStatus;
		bullet3.theStatus = theStatus;
		Bullet bullet4 = bullet;
		PlantType fromType3 = this.fromType;
		bullet4.fromType = fromType3;
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
		int num7 = 0;
		zombie.SetCold(15f, 1, num7 != 0);
		int num8 = 0;
		zombie.AddfreezeLevel(20, num8);
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00024A40 File Offset: 0x00022C40
	[Token(Token = "0x6000713")]
	[Address(RVA = "0x7DEDF0", Offset = "0x7DD3F0", VA = "0x1807DEDF0", Slot = "21")]
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

	// Token: 0x06000714 RID: 1812 RVA: 0x00024AC4 File Offset: 0x00022CC4
	[Token(Token = "0x6000714")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_shulkLeaf_ice()
	{
	}
}
