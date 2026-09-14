using System;
using Cpp2IlInjected;

// Token: 0x02000041 RID: 65
[Token(Token = "0x2000041")]
public class Invest_难度修改器 : InvestBuffData
{
	// Token: 0x06000115 RID: 277 RVA: 0x000050B4 File Offset: 0x000032B4
	[Token(Token = "0x6000115")]
	[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.难度修改器;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x000050C4 File Offset: 0x000032C4
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x3AE570", Offset = "0x3ACB70", VA = "0x1803AE570", Slot = "13")]
	public override string GetDescription()
	{
		return "领袖僵尸的血量降低10%";
	}

	// Token: 0x06000117 RID: 279 RVA: 0x000050D8 File Offset: 0x000032D8
	[Token(Token = "0x6000117")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_难度修改器()
	{
	}
}
