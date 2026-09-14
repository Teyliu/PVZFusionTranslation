using System;
using Cpp2IlInjected;

// Token: 0x0200005E RID: 94
[Token(Token = "0x200005E")]
public class Invest_沙里淘金 : InvestBuffData
{
	// Token: 0x06000196 RID: 406 RVA: 0x00005FE8 File Offset: 0x000041E8
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x3F8A60", Offset = "0x3F7060", VA = "0x1803F8A60", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.沙里淘金;
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06000197 RID: 407 RVA: 0x00005FFC File Offset: 0x000041FC
	[Token(Token = "0x17000062")]
	public override string Description
	{
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x3F8B90", Offset = "0x3F7190", VA = "0x1803F8B90", Slot = "13")]
		get
		{
			return "每次融合，获得一个随机礼盒";
		}
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00006010 File Offset: 0x00004210
	[Token(Token = "0x6000198")]
	[Address(RVA = "0x3F8A70", Offset = "0x3F7070", VA = "0x1803F8A70", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (Invest_沙里淘金.<>c.<>9__3_0 == 0)
		{
			Action<object> action;
			Invest_沙里淘金.<>c.<>9__3_0 = action;
		}
	}

	// Token: 0x06000199 RID: 409 RVA: 0x0000602C File Offset: 0x0000422C
	[Token(Token = "0x6000199")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x0600019A RID: 410 RVA: 0x0000603C File Offset: 0x0000423C
	[Token(Token = "0x600019A")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_沙里淘金()
	{
	}
}
