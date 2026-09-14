using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200065F RID: 1631
[Token(Token = "0x200065F")]
public class BlackFootballZombie_b : BlackFootballZombie_a
{
	// Token: 0x06001ED9 RID: 7897 RVA: 0x000A474C File Offset: 0x000A294C
	[Token(Token = "0x6001ED9")]
	[Address(RVA = "0x588720", Offset = "0x586D20", VA = "0x180588720", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 3f;
	}

	// Token: 0x06001EDA RID: 7898 RVA: 0x000A476C File Offset: 0x000A296C
	[Token(Token = "0x6001EDA")]
	[Address(RVA = "0x588680", Offset = "0x586C80", VA = "0x180588680", Slot = "24")]
	protected override void AttributeEvent()
	{
		base.ZombieUpdate();
		GameObject theFirstArmor = this.theFirstArmor;
		int num = 0;
		if (theFirstArmor != num)
		{
			long totalFirstHealth = base.TotalFirstHealth;
			float num2 = (float)(0 * (int)0.05f);
			base.Recover(num2);
			this.attributeCountDown = 3f;
		}
	}

	// Token: 0x06001EDB RID: 7899 RVA: 0x000A47B4 File Offset: 0x000A29B4
	[Token(Token = "0x6001EDB")]
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

	// Token: 0x06001EDC RID: 7900 RVA: 0x000A47F0 File Offset: 0x000A29F0
	[Token(Token = "0x6001EDC")]
	[Address(RVA = "0x588630", Offset = "0x586C30", VA = "0x180588630")]
	public BlackFootballZombie_b()
	{
	}
}
