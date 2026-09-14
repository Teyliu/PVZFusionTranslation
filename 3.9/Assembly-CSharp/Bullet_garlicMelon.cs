using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200014C RID: 332
[Token(Token = "0x200014C")]
public class Bullet_garlicMelon : Bullet_melon
{
	// Token: 0x0600061B RID: 1563 RVA: 0x0001FF44 File Offset: 0x0001E144
	[Token(Token = "0x600061B")]
	[Address(RVA = "0x6EF470", Offset = "0x6EDA70", VA = "0x1806EF470", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)58), num, theBulletRow, num3 != 0UL, (float)num2);
		int num4 = 0;
		base.AttackOtherZombie(num4, (MelonSputterType)((uint)2));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x0001FFB0 File Offset: 0x0001E1B0
	[Token(Token = "0x600061C")]
	[Address(RVA = "0x6EF5A0", Offset = "0x6EDBA0", VA = "0x1806EF5A0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theZombieRow = zombie.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle(ParticleType.Splat_white_big, num, theZombieRow, num3 != 0UL, (float)num2);
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(58, this, (DamageType)((uint)1), fromType, num4 != 0UL);
		zombie.AddPoisonLevel();
		base.AttackOtherZombie(zombie, (MelonSputterType)((uint)2));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x00020034 File Offset: 0x0001E234
	[Token(Token = "0x600061D")]
	[Address(RVA = "0x6EF740", Offset = "0x6EDD40", VA = "0x1806EF740")]
	public Bullet_garlicMelon()
	{
	}
}
