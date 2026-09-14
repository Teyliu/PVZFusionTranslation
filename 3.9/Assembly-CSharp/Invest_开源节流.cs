using System;
using Cpp2IlInjected;

// Token: 0x0200006B RID: 107
[Token(Token = "0x200006B")]
public class Invest_开源节流 : InvestBuffData
{
	// Token: 0x060001D0 RID: 464 RVA: 0x00006638 File Offset: 0x00004838
	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x3F77B0", Offset = "0x3F5DB0", VA = "0x1803F77B0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.开源节流;
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000664C File Offset: 0x0000484C
	[Token(Token = "0x1700006B")]
	public override string Description
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x3F7880", Offset = "0x3F5E80", VA = "0x1803F7880", Slot = "13")]
		get
		{
			return "获得5000积分，如果上次在商店没有消耗积分，则每次进入新的一轮获得3000积分";
		}
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00006660 File Offset: 0x00004860
	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x3F77C0", Offset = "0x3F5DC0", VA = "0x1803F77C0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (!TravelMgr.Instance.data.usePoint)
		{
			int num = 0;
			board.GetPoint(3000f, num != 0);
			return;
		}
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00006698 File Offset: 0x00004898
	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x3F7850", Offset = "0x3F5E50", VA = "0x1803F7850", Slot = "17")]
	public override void OnSelect(Board board)
	{
		int num = 0;
		board.GetPoint(5000f, num != 0);
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x000066BC File Offset: 0x000048BC
	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_开源节流()
	{
	}
}
