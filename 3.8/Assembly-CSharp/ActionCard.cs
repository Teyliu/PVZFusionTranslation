using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x020001EC RID: 492
[Token(Token = "0x20001EC")]
public class ActionCard : SpecialCard
{
	// Token: 0x06000847 RID: 2119 RVA: 0x0002A238 File Offset: 0x00028438
	[Token(Token = "0x6000847")]
	[Address(RVA = "0x851620", Offset = "0x84FC20", VA = "0x180851620", Slot = "10")]
	public override void ClickedEvent()
	{
		Board instance = Board.Instance;
		int theSeedCost = this.theSeedCost;
		if (this.clickAction != 0)
		{
		}
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x0002A274 File Offset: 0x00028474
	[Token(Token = "0x6000848")]
	[Address(RVA = "0x8516E0", Offset = "0x84FCE0", VA = "0x1808516E0")]
	public ActionCard()
	{
		this.d = 1f;
		base..ctor();
	}

	// Token: 0x040003C8 RID: 968
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40003C8")]
	public Action<SpecialCard> clickAction;

	// Token: 0x040003C9 RID: 969
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40003C9")]
	public TextMeshProUGUI cardText;
}
