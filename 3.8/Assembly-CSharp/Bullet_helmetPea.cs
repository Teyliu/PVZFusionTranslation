using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000149 RID: 329
[Token(Token = "0x2000149")]
public class Bullet_helmetPea : Bullet_ironPea
{
	// Token: 0x06000618 RID: 1560 RVA: 0x00020838 File Offset: 0x0001EA38
	[Token(Token = "0x6000618")]
	[Address(RVA = "0x6C4850", Offset = "0x6C2E50", VA = "0x1806C4850", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		ZombieType theZombieType = zombie.theZombieType;
		if (theZombieType == ZombieType.FootballZombie || theZombieType == ZombieType.FlagFootball || theZombieType == ZombieType.TallNutFootballZombie)
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

	// Token: 0x06000619 RID: 1561 RVA: 0x000208C4 File Offset: 0x0001EAC4
	[Token(Token = "0x6000619")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_helmetPea()
	{
	}
}
