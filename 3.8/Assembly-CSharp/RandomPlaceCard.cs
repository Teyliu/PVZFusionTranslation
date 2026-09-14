using System;
using Cpp2IlInjected;

// Token: 0x020001FF RID: 511
[Token(Token = "0x20001FF")]
public class RandomPlaceCard : SpecialCard
{
	// Token: 0x060008A9 RID: 2217 RVA: 0x0002CFEC File Offset: 0x0002B1EC
	[Token(Token = "0x60008A9")]
	[Address(RVA = "0x86CDA0", Offset = "0x86B3A0", VA = "0x18086CDA0", Slot = "10")]
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

	// Token: 0x060008AA RID: 2218 RVA: 0x0002D04C File Offset: 0x0002B24C
	[Token(Token = "0x60008AA")]
	[Address(RVA = "0x8516E0", Offset = "0x84FCE0", VA = "0x1808516E0")]
	public RandomPlaceCard()
	{
		this.d = 1f;
		base..ctor();
	}

	// Token: 0x04000443 RID: 1091
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000443")]
	public bool plant;
}
