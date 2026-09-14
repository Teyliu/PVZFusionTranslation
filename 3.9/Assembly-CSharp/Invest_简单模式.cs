using System;
using Cpp2IlInjected;

// Token: 0x02000044 RID: 68
[Token(Token = "0x2000044")]
public class Invest_简单模式 : InvestBuffData
{
	// Token: 0x06000129 RID: 297 RVA: 0x000052F8 File Offset: 0x000034F8
	[Token(Token = "0x6000129")]
	[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.简单模式;
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x0600012A RID: 298 RVA: 0x00005308 File Offset: 0x00003508
	[Token(Token = "0x1700004E")]
	public override string Description
	{
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x3F9470", Offset = "0x3F7A70", VA = "0x1803F9470", Slot = "13")]
		get
		{
			return "非领袖僵尸的血量降低10%";
		}
	}

	// Token: 0x0600012B RID: 299 RVA: 0x0000531C File Offset: 0x0000351C
	[Token(Token = "0x600012B")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_简单模式()
	{
	}
}
