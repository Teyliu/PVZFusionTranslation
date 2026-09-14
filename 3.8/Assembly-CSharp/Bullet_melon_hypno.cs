using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200016E RID: 366
[Token(Token = "0x200016E")]
public class Bullet_melon_hypno : Bullet_melon
{
	// Token: 0x0600068A RID: 1674 RVA: 0x000226A8 File Offset: 0x000208A8
	[Token(Token = "0x600068A")]
	[Address(RVA = "0x6CB160", Offset = "0x6C9760", VA = "0x1806CB160", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theZombieRow = zombie.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)112), num, theZombieRow, num3 != 0UL, (float)num2);
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)((uint)1), fromType, num4 != 0UL);
		int currentFirstHealth = zombie.CurrentFirstHealth;
		float num5 = zombie.TotalFirstHealth * 0.5f;
		if (currentFirstHealth == 0)
		{
			int num6 = 0;
			zombie.SetMindControl(num6);
		}
		base.AttackOtherZombie(zombie, (MelonSputterType)((uint)6));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x00022758 File Offset: 0x00020958
	[Token(Token = "0x600068B")]
	[Address(RVA = "0x6CB030", Offset = "0x6C9630", VA = "0x1806CB030", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)112), num, theBulletRow, num3 != 0UL, (float)num2);
		int num4 = 0;
		base.AttackOtherZombie(num4, (MelonSputterType)((uint)6));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x000227C4 File Offset: 0x000209C4
	[Token(Token = "0x600068C")]
	[Address(RVA = "0x6CB340", Offset = "0x6C9940", VA = "0x1806CB340")]
	public Bullet_melon_hypno()
	{
	}
}
