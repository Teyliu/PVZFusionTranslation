using System;
using Cpp2IlInjected;

// Token: 0x02000749 RID: 1865
[Token(Token = "0x2000749")]
public class WallNutZombie : ArmorZombie
{
	// Token: 0x06002574 RID: 9588 RVA: 0x000C238C File Offset: 0x000C058C
	[Token(Token = "0x6002574")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002575 RID: 9589 RVA: 0x000C239C File Offset: 0x000C059C
	[Token(Token = "0x6002575")]
	[Address(RVA = "0x588740", Offset = "0x586D40", VA = "0x180588740", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06002576 RID: 9590 RVA: 0x000C23D8 File Offset: 0x000C05D8
	[Token(Token = "0x6002576")]
	[Address(RVA = "0x59C5A0", Offset = "0x59ABA0", VA = "0x18059C5A0")]
	public WallNutZombie()
	{
	}
}
