using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200014F RID: 335
[Token(Token = "0x200014F")]
public class Bullet_helmetPea_black : Bullet_ironPea
{
	// Token: 0x06000622 RID: 1570 RVA: 0x00020174 File Offset: 0x0001E374
	[Token(Token = "0x6000622")]
	[Address(RVA = "0x6EFB50", Offset = "0x6EE150", VA = "0x1806EFB50", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		ZombieType theZombieType = zombie.theZombieType;
		if ((theZombieType > ZombieType.FlagFootball && theZombieType == ZombieType.PolFootballZombie) || theZombieType == ZombieType.FootballZombie || theZombieType == ZombieType.FlagFootball)
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

	// Token: 0x06000623 RID: 1571 RVA: 0x000201F8 File Offset: 0x0001E3F8
	[Token(Token = "0x6000623")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_helmetPea_black()
	{
	}
}
