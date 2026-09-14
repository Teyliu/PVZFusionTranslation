using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200014E RID: 334
[Token(Token = "0x200014E")]
public class Bullet_helmetPea : Bullet_ironPea
{
	// Token: 0x06000620 RID: 1568 RVA: 0x000200D0 File Offset: 0x0001E2D0
	[Token(Token = "0x6000620")]
	[Address(RVA = "0x6EFA10", Offset = "0x6EE010", VA = "0x1806EFA10", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		ZombieType theZombieType = zombie.theZombieType;
		if ((theZombieType > ZombieType.FlagFootball && theZombieType == ZombieType.PolFootballZombie) || theZombieType == ZombieType.FootballZombie || theZombieType == ZombieType.FlagFootball)
		{
			zombie.Scared();
		}
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num3 = 0;
		int theZombieRow = zombie.theZombieRow;
		int num4 = 0;
		ulong num5;
		Particle particle = instance.SetParticle((ParticleType)((uint)18), num3, theZombieRow, num5 != 0UL, (float)num4);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x00020160 File Offset: 0x0001E360
	[Token(Token = "0x6000621")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_helmetPea()
	{
	}
}
