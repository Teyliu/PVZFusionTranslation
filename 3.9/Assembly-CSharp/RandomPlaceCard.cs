using System;
using Cpp2IlInjected;

// Token: 0x02000206 RID: 518
[Token(Token = "0x2000206")]
public class RandomPlaceCard : SpecialCard
{
	// Token: 0x060008C3 RID: 2243 RVA: 0x0002D018 File Offset: 0x0002B218
	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x8FC8A0", Offset = "0x8FAEA0", VA = "0x1808FC8A0", Slot = "10")]
	public override void ClickedEvent()
	{
		PVPRandomManager instance;
		for (;;)
		{
			Board board = this.board;
			int theSeedCost = this.theSeedCost;
			instance = PVPRandomManager.Instance;
			if (!this.plant)
			{
				break;
			}
			if (instance.PlayerSetPlant())
			{
				goto Block_1;
			}
		}
		int num = 0;
		instance.PlayerSetZombie();
		this.board.UseSun((float)num);
		return;
		Block_1:
		GameAPP.PlaySound(26, 0.5f, 1f);
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x0002D078 File Offset: 0x0002B278
	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x8DF910", Offset = "0x8DDF10", VA = "0x1808DF910")]
	public RandomPlaceCard()
	{
		this.d = 1f;
		base..ctor();
	}

	// Token: 0x0400044D RID: 1101
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400044D")]
	public bool plant;
}
