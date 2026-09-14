using System;
using Cpp2IlInjected;

// Token: 0x0200006C RID: 108
[Token(Token = "0x200006C")]
public class Invest_淘宝积分 : InvestBuffData
{
	// Token: 0x060001CE RID: 462 RVA: 0x000065A0 File Offset: 0x000047A0
	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x3ACD50", Offset = "0x3AB350", VA = "0x1803ACD50", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.淘宝积分;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x000065B4 File Offset: 0x000047B4
	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x3ACD60", Offset = "0x3AB360", VA = "0x1803ACD60", Slot = "13")]
	public override string GetDescription()
	{
		return "每次刷新，获得500积分";
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x000065C8 File Offset: 0x000047C8
	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_淘宝积分()
	{
	}
}
