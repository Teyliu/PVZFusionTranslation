using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200010F RID: 271
[Token(Token = "0x200010F")]
public class Bullet_butter_doom : Bullet_butter
{
	// Token: 0x0600054F RID: 1359 RVA: 0x0001CE38 File Offset: 0x0001B038
	[Token(Token = "0x600054F")]
	[Address(RVA = "0x6B7B80", Offset = "0x6B6180", VA = "0x1806B7B80", Slot = "25")]
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

	// Token: 0x06000550 RID: 1360 RVA: 0x0001CEBC File Offset: 0x0001B0BC
	[Token(Token = "0x6000550")]
	[Address(RVA = "0x6B7A80", Offset = "0x6B6080", VA = "0x1806B7A80", Slot = "18")]
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

	// Token: 0x06000551 RID: 1361 RVA: 0x0001CF14 File Offset: 0x0001B114
	[Token(Token = "0x6000551")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_butter_doom()
	{
	}
}
