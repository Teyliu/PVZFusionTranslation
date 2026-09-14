using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000115 RID: 277
[Token(Token = "0x2000115")]
public class Bullet_butter_doom : Bullet_butter
{
	// Token: 0x06000560 RID: 1376 RVA: 0x0001C7BC File Offset: 0x0001A9BC
	[Token(Token = "0x6000560")]
	[Address(RVA = "0x6E2A70", Offset = "0x6E1070", VA = "0x1806E2A70", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(100, 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theZombieRow = zombie.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)27), num, theZombieRow, num3 != 0UL, (float)num2);
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num4 != 0UL);
		zombie.Buttered(4f, true);
		base.Die();
		throw new NullReferenceException();
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x0001C840 File Offset: 0x0001AA40
	[Token(Token = "0x6000561")]
	[Address(RVA = "0x6E2970", Offset = "0x6E0F70", VA = "0x1806E2970", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(100, 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)27), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x0001C898 File Offset: 0x0001AA98
	[Token(Token = "0x6000562")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_butter_doom()
	{
	}
}
