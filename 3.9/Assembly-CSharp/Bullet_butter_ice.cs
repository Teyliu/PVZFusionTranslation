using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000116 RID: 278
[Token(Token = "0x2000116")]
public class Bullet_butter_ice : Bullet_butter
{
	// Token: 0x06000563 RID: 1379 RVA: 0x0001C8AC File Offset: 0x0001AAAC
	[Token(Token = "0x6000563")]
	[Address(RVA = "0x6E2C00", Offset = "0x6E1200", VA = "0x1806E2C00", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(100, 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x0001C904 File Offset: 0x0001AB04
	[Token(Token = "0x6000564")]
	[Address(RVA = "0x6E2D00", Offset = "0x6E1300", VA = "0x1806E2D00", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(100, 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theZombieRow = zombie.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num, theZombieRow, num3 != 0UL, (float)num2);
		bool flag = zombie.HasBuff((EffectType)((uint)2));
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)((uint)5), fromType, num4 != 0UL);
		int num5 = 0;
		zombie.SetFreeze(4f, num5);
		base.Die();
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x0001C994 File Offset: 0x0001AB94
	[Token(Token = "0x6000565")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_butter_ice()
	{
	}
}
