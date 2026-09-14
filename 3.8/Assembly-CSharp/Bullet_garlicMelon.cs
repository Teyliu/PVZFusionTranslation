using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000147 RID: 327
[Token(Token = "0x2000147")]
public class Bullet_garlicMelon : Bullet_melon
{
	// Token: 0x06000613 RID: 1555 RVA: 0x000206B4 File Offset: 0x0001E8B4
	[Token(Token = "0x6000613")]
	[Address(RVA = "0x6C42D0", Offset = "0x6C28D0", VA = "0x1806C42D0", Slot = "18")]
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

	// Token: 0x06000614 RID: 1556 RVA: 0x00020720 File Offset: 0x0001E920
	[Token(Token = "0x6000614")]
	[Address(RVA = "0x6C4400", Offset = "0x6C2A00", VA = "0x1806C4400", Slot = "25")]
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

	// Token: 0x06000615 RID: 1557 RVA: 0x000207A4 File Offset: 0x0001E9A4
	[Token(Token = "0x6000615")]
	[Address(RVA = "0x6C45A0", Offset = "0x6C2BA0", VA = "0x1806C45A0")]
	public Bullet_garlicMelon()
	{
	}
}
