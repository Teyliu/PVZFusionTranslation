using System;
using Cpp2IlInjected;

// Token: 0x020006D8 RID: 1752
[Token(Token = "0x20006D8")]
public class SuperBlackFootball : BlackFlagFootball
{
	// Token: 0x06002283 RID: 8835 RVA: 0x000B4DAC File Offset: 0x000B2FAC
	[Token(Token = "0x6002283")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002284 RID: 8836 RVA: 0x000B4DBC File Offset: 0x000B2FBC
	[Token(Token = "0x6002284")]
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

	// Token: 0x06002285 RID: 8837 RVA: 0x000B4DF8 File Offset: 0x000B2FF8
	[Token(Token = "0x6002285")]
	[Address(RVA = "0x574480", Offset = "0x572A80", VA = "0x180574480", Slot = "74")]
	protected override void OnRoll()
	{
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			Zombie zombie = CreateZombie.Instance.SetZombie(num, (ZombieType)((uint)256), 9.9f, num != 0);
			Board board2 = this.board;
			num++;
		}
	}

	// Token: 0x06002286 RID: 8838 RVA: 0x000B4E44 File Offset: 0x000B3044
	[Token(Token = "0x6002286")]
	[Address(RVA = "0x531AD0", Offset = "0x5300D0", VA = "0x180531AD0")]
	public SuperBlackFootball()
	{
	}
}
