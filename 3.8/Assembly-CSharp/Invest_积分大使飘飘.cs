using System;
using Cpp2IlInjected;

// Token: 0x02000066 RID: 102
[Token(Token = "0x2000066")]
public class Invest_积分大使飘飘 : InvestBuffData
{
	// Token: 0x060001B4 RID: 436 RVA: 0x0000632C File Offset: 0x0000452C
	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x3AD370", Offset = "0x3AB970", VA = "0x1803AD370", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.积分大使飘飘;
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00006340 File Offset: 0x00004540
	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x3AD380", Offset = "0x3AB980", VA = "0x1803AD380", Slot = "13")]
	public override string GetDescription()
	{
		return "超稀有的飘飘登场！爆出超多积分！";
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00006354 File Offset: 0x00004554
	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x3AD3B0", Offset = "0x3AB9B0", VA = "0x1803AD3B0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num = 0;
		board.GetPoint(20000f, num != 0);
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00006378 File Offset: 0x00004578
	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00006388 File Offset: 0x00004588
	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_积分大使飘飘()
	{
	}
}
