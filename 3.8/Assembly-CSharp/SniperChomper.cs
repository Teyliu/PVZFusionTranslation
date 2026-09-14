using System;
using Cpp2IlInjected;

// Token: 0x02000333 RID: 819
[Token(Token = "0x2000333")]
public class SniperChomper : SniperPea
{
	// Token: 0x06000EF5 RID: 3829 RVA: 0x000577BC File Offset: 0x000559BC
	[Token(Token = "0x6000EF5")]
	[Address(RVA = "0x4294B0", Offset = "0x427AB0", VA = "0x1804294B0", Slot = "73")]
	protected override void AttackZombie(Zombie zombie, int damage, DamageType theDamageType = DamageType.Shieldless)
	{
		ZombieType theZombieType = zombie.theZombieType;
		if (theDamageType != DamageType.MaxDamage)
		{
		}
		bool flag;
		if (!flag)
		{
			zombie.Die(2);
		}
		if (zombie.Alive)
		{
			PlantType thePlantType = this.thePlantType;
		}
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x00057800 File Offset: 0x00055A00
	[Token(Token = "0x6000EF6")]
	[Address(RVA = "0x4295C0", Offset = "0x427BC0", VA = "0x1804295C0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		GameAPP.PlaySound((SoundType)((uint)49), 0.5f, 1f);
		return base.Shoot1();
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00057828 File Offset: 0x00055A28
	[Token(Token = "0x6000EF7")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public SniperChomper()
	{
	}
}
