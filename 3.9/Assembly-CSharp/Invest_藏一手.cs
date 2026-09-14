using System;
using Cpp2IlInjected;

// Token: 0x02000072 RID: 114
[Token(Token = "0x2000072")]
public class Invest_藏一手 : InvestBuffData
{
	// Token: 0x060001EC RID: 492 RVA: 0x000068F0 File Offset: 0x00004AF0
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x3F9BE0", Offset = "0x3F81E0", VA = "0x1803F9BE0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.藏一手;
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x060001ED RID: 493 RVA: 0x00006904 File Offset: 0x00004B04
	[Token(Token = "0x17000071")]
	public override string Description
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x3F9BF0", Offset = "0x3F81F0", VA = "0x1803F9BF0", Slot = "13")]
		get
		{
			return "僵尸进家时视为直接通关本轮，并获得10000点积分";
		}
	}

	// Token: 0x060001EE RID: 494 RVA: 0x00006918 File Offset: 0x00004B18
	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_藏一手()
	{
	}
}
