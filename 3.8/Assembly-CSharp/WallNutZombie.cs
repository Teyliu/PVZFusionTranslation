using System;
using Cpp2IlInjected;

// Token: 0x02000710 RID: 1808
[Token(Token = "0x2000710")]
public class WallNutZombie : ArmorZombie
{
	// Token: 0x06002454 RID: 9300 RVA: 0x000BD5A0 File Offset: 0x000BB7A0
	[Token(Token = "0x6002454")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002455 RID: 9301 RVA: 0x000BD5B0 File Offset: 0x000BB7B0
	[Token(Token = "0x6002455")]
	[Address(RVA = "0x531BF0", Offset = "0x5301F0", VA = "0x180531BF0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06002456 RID: 9302 RVA: 0x000BD5EC File Offset: 0x000BB7EC
	[Token(Token = "0x6002456")]
	[Address(RVA = "0x55BE80", Offset = "0x55A480", VA = "0x18055BE80")]
	public WallNutZombie()
	{
	}
}
