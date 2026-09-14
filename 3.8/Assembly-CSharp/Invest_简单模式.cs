using System;
using Cpp2IlInjected;

// Token: 0x02000040 RID: 64
[Token(Token = "0x2000040")]
public class Invest_简单模式 : InvestBuffData
{
	// Token: 0x06000112 RID: 274 RVA: 0x0000507C File Offset: 0x0000327C
	[Token(Token = "0x6000112")]
	[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.简单模式;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0000508C File Offset: 0x0000328C
	[Token(Token = "0x6000113")]
	[Address(RVA = "0x3AD600", Offset = "0x3ABC00", VA = "0x1803AD600", Slot = "13")]
	public override string GetDescription()
	{
		return "非领袖僵尸的血量降低10%";
	}

	// Token: 0x06000114 RID: 276 RVA: 0x000050A0 File Offset: 0x000032A0
	[Token(Token = "0x6000114")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_简单模式()
	{
	}
}
