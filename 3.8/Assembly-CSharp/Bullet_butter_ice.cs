using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000110 RID: 272
[Token(Token = "0x2000110")]
public class Bullet_butter_ice : Bullet_butter
{
	// Token: 0x06000552 RID: 1362 RVA: 0x0001CF28 File Offset: 0x0001B128
	[Token(Token = "0x6000552")]
	[Address(RVA = "0x6B7D10", Offset = "0x6B6310", VA = "0x1806B7D10", Slot = "18")]
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

	// Token: 0x06000553 RID: 1363 RVA: 0x0001CF80 File Offset: 0x0001B180
	[Token(Token = "0x6000553")]
	[Address(RVA = "0x6B7E10", Offset = "0x6B6410", VA = "0x1806B7E10", Slot = "25")]
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

	// Token: 0x06000554 RID: 1364 RVA: 0x0001D010 File Offset: 0x0001B210
	[Token(Token = "0x6000554")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_butter_ice()
	{
	}
}
