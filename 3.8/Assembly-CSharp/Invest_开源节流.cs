using System;
using Cpp2IlInjected;

// Token: 0x02000067 RID: 103
[Token(Token = "0x2000067")]
public class Invest_开源节流 : InvestBuffData
{
	// Token: 0x060001B9 RID: 441 RVA: 0x0000639C File Offset: 0x0000459C
	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x3AB9B0", Offset = "0x3A9FB0", VA = "0x1803AB9B0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.开源节流;
	}

	// Token: 0x060001BA RID: 442 RVA: 0x000063B0 File Offset: 0x000045B0
	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x3AB9C0", Offset = "0x3A9FC0", VA = "0x1803AB9C0", Slot = "13")]
	public override string GetDescription()
	{
		return "获得5000积分，如果上次在商店没有消耗积分，则每次进入新的一轮获得3000积分";
	}

	// Token: 0x060001BB RID: 443 RVA: 0x000063C4 File Offset: 0x000045C4
	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x3AB9F0", Offset = "0x3A9FF0", VA = "0x1803AB9F0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (!TravelMgr.Instance.data.usePoint)
		{
			int num = 0;
			board.GetPoint(3000f, num != 0);
			return;
		}
	}

	// Token: 0x060001BC RID: 444 RVA: 0x000063FC File Offset: 0x000045FC
	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x3ABA80", Offset = "0x3AA080", VA = "0x1803ABA80", Slot = "17")]
	public override void OnSelect(Board board)
	{
		int num = 0;
		board.GetPoint(5000f, num != 0);
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00006420 File Offset: 0x00004620
	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_开源节流()
	{
	}
}
