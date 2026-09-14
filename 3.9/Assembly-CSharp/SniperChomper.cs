using System;
using Cpp2IlInjected;

// Token: 0x02000343 RID: 835
[Token(Token = "0x2000343")]
public class SniperChomper : SniperPea
{
	// Token: 0x06000F40 RID: 3904 RVA: 0x00058778 File Offset: 0x00056978
	[Token(Token = "0x6000F40")]
	[Address(RVA = "0x469780", Offset = "0x467D80", VA = "0x180469780", Slot = "72")]
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

	// Token: 0x06000F41 RID: 3905 RVA: 0x000587BC File Offset: 0x000569BC
	[Token(Token = "0x6000F41")]
	[Address(RVA = "0x4698A0", Offset = "0x467EA0", VA = "0x1804698A0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		GameAPP.PlaySound((SoundType)((uint)49), 0.5f, 1f);
		return base.Shoot1();
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x000587E4 File Offset: 0x000569E4
	[Token(Token = "0x6000F42")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public SniperChomper()
	{
	}
}
