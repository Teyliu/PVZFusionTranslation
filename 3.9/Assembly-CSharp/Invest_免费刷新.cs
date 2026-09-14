using System;
using Cpp2IlInjected;

// Token: 0x0200004E RID: 78
[Token(Token = "0x200004E")]
public class Invest_免费刷新 : InvestBuffData
{
	// Token: 0x0600014C RID: 332 RVA: 0x000056A0 File Offset: 0x000038A0
	[Token(Token = "0x600014C")]
	[Address(RVA = "0x3F6DC0", Offset = "0x3F53C0", VA = "0x1803F6DC0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.免费刷新;
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x0600014D RID: 333 RVA: 0x000056B0 File Offset: 0x000038B0
	[Token(Token = "0x17000055")]
	public override string Description
	{
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x3F6E30", Offset = "0x3F5430", VA = "0x1803F6E30", Slot = "13")]
		get
		{
			return "获得11次额外刷新次数";
		}
	}

	// Token: 0x0600014E RID: 334 RVA: 0x000056C4 File Offset: 0x000038C4
	[Token(Token = "0x600014E")]
	[Address(RVA = "0x3F6DD0", Offset = "0x3F53D0", VA = "0x1803F6DD0", Slot = "17")]
	public override void OnSelect(Board board)
	{
		TravelData data = TravelMgr.Instance.data;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x000056E4 File Offset: 0x000038E4
	[Token(Token = "0x600014F")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_免费刷新()
	{
	}
}
