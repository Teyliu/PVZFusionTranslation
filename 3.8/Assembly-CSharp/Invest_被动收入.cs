using System;
using Cpp2IlInjected;

// Token: 0x02000069 RID: 105
[Token(Token = "0x2000069")]
public class Invest_被动收入 : InvestBuffData
{
	// Token: 0x060001C1 RID: 449 RVA: 0x00006470 File Offset: 0x00004670
	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x3ADDB0", Offset = "0x3AC3B0", VA = "0x1803ADDB0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.被动收入;
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00006484 File Offset: 0x00004684
	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x3ADDC0", Offset = "0x3AC3C0", VA = "0x1803ADDC0", Slot = "13")]
	public override string GetDescription()
	{
		return "每一轮开始时，获得2000积分";
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00006498 File Offset: 0x00004698
	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x3ADDF0", Offset = "0x3AC3F0", VA = "0x1803ADDF0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num = 0;
		board.GetPoint(2000f, num != 0);
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x000064BC File Offset: 0x000046BC
	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x000064CC File Offset: 0x000046CC
	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_被动收入()
	{
	}
}
