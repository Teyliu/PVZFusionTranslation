using System;
using Cpp2IlInjected;

// Token: 0x0200006E RID: 110
[Token(Token = "0x200006E")]
public class Invest_藏一手 : InvestBuffData
{
	// Token: 0x060001D5 RID: 469 RVA: 0x00006654 File Offset: 0x00004854
	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x3ADD70", Offset = "0x3AC370", VA = "0x1803ADD70", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.藏一手;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00006668 File Offset: 0x00004868
	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x3ADD80", Offset = "0x3AC380", VA = "0x1803ADD80", Slot = "13")]
	public override string GetDescription()
	{
		return "僵尸进家时视为直接通关本轮，并获得10000点积分";
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x0000667C File Offset: 0x0000487C
	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_藏一手()
	{
	}
}
