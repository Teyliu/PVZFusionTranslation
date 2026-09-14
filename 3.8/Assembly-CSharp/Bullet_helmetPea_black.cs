using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200014A RID: 330
[Token(Token = "0x200014A")]
public class Bullet_helmetPea_black : Bullet_ironPea
{
	// Token: 0x0600061A RID: 1562 RVA: 0x000208D8 File Offset: 0x0001EAD8
	[Token(Token = "0x600061A")]
	[Address(RVA = "0x6C4980", Offset = "0x6C2F80", VA = "0x1806C4980", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		ZombieType theZombieType = zombie.theZombieType;
		if (theZombieType == ZombieType.FootballZombie || theZombieType == ZombieType.FlagFootball || theZombieType == ZombieType.TallNutFootballZombie)
		{
			zombie.Scared();
		}
		int num = 0;
		PlantType fromType = this.fromType;
		if (zombie.theSecondArmorHealth == num)
		{
		}
		int theSecondArmorHealth = zombie.theSecondArmorHealth;
		zombie.TakeDamage(theSecondArmorHealth, this, (DamageType)num, fromType, num != 0);
		if (!zombie.isMindControlled)
		{
		}
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x00020954 File Offset: 0x0001EB54
	[Token(Token = "0x600061B")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_helmetPea_black()
	{
	}
}
