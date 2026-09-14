using System;
using Cpp2IlInjected;

// Token: 0x0200006D RID: 109
[Token(Token = "0x200006D")]
public class Invest_被动收入 : InvestBuffData
{
	// Token: 0x060001D8 RID: 472 RVA: 0x0000670C File Offset: 0x0000490C
	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x3F9C20", Offset = "0x3F8220", VA = "0x1803F9C20", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.被动收入;
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060001D9 RID: 473 RVA: 0x00006720 File Offset: 0x00004920
	[Token(Token = "0x1700006D")]
	public override string Description
	{
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x3F9C60", Offset = "0x3F8260", VA = "0x1803F9C60", Slot = "13")]
		get
		{
			return "每一轮开始时，获得2000积分";
		}
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00006734 File Offset: 0x00004934
	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x3F9C30", Offset = "0x3F8230", VA = "0x1803F9C30", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num = 0;
		board.GetPoint(2000f, num != 0);
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00006758 File Offset: 0x00004958
	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00006768 File Offset: 0x00004968
	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_被动收入()
	{
	}
}
