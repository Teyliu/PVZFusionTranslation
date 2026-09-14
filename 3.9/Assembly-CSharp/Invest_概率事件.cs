using System;
using Cpp2IlInjected;

// Token: 0x0200006C RID: 108
[Token(Token = "0x200006C")]
public class Invest_概率事件 : InvestBuffData
{
	// Token: 0x060001D5 RID: 469 RVA: 0x000066D0 File Offset: 0x000048D0
	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x3F86E0", Offset = "0x3F6CE0", VA = "0x1803F86E0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.概率事件;
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x060001D6 RID: 470 RVA: 0x000066E4 File Offset: 0x000048E4
	[Token(Token = "0x1700006C")]
	public override string Description
	{
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x3F86F0", Offset = "0x3F6CF0", VA = "0x1803F86F0", Slot = "13")]
		get
		{
			return "刷新时有45%概率获得一次额外刷新次数";
		}
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x000066F8 File Offset: 0x000048F8
	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_概率事件()
	{
	}
}
