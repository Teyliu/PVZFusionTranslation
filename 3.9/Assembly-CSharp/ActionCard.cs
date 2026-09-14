using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x020001F3 RID: 499
[Token(Token = "0x20001F3")]
public class ActionCard : SpecialCard
{
	// Token: 0x06000861 RID: 2145 RVA: 0x0002A228 File Offset: 0x00028428
	[Token(Token = "0x6000861")]
	[Address(RVA = "0x8DF850", Offset = "0x8DDE50", VA = "0x1808DF850", Slot = "10")]
	public override void ClickedEvent()
	{
		Board instance = Board.Instance;
		int theSeedCost = this.theSeedCost;
		if (this.clickAction != 0)
		{
		}
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x0002A264 File Offset: 0x00028464
	[Token(Token = "0x6000862")]
	[Address(RVA = "0x8DF910", Offset = "0x8DDF10", VA = "0x1808DF910")]
	public ActionCard()
	{
		this.d = 1f;
		base..ctor();
	}

	// Token: 0x040003D2 RID: 978
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40003D2")]
	public Action<SpecialCard> clickAction;

	// Token: 0x040003D3 RID: 979
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40003D3")]
	public TextMeshProUGUI cardText;
}
