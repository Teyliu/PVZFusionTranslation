using System;
using Cpp2IlInjected;

// Token: 0x02000710 RID: 1808
[Token(Token = "0x2000710")]
public class SuperBlackFootball : BlackFlagFootball
{
	// Token: 0x0600239D RID: 9117 RVA: 0x000B9B64 File Offset: 0x000B7D64
	[Token(Token = "0x600239D")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x0600239E RID: 9118 RVA: 0x000B9B74 File Offset: 0x000B7D74
	[Token(Token = "0x600239E")]
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

	// Token: 0x0600239F RID: 9119 RVA: 0x000B9BB0 File Offset: 0x000B7DB0
	[Token(Token = "0x600239F")]
	[Address(RVA = "0x5D7AF0", Offset = "0x5D60F0", VA = "0x1805D7AF0", Slot = "76")]
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

	// Token: 0x060023A0 RID: 9120 RVA: 0x000B9BFC File Offset: 0x000B7DFC
	[Token(Token = "0x60023A0")]
	[Address(RVA = "0x588620", Offset = "0x586C20", VA = "0x180588620")]
	public SuperBlackFootball()
	{
	}
}
