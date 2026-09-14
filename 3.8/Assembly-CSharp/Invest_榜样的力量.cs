using System;
using Cpp2IlInjected;

// Token: 0x02000044 RID: 68
[Token(Token = "0x2000044")]
public class Invest_榜样的力量 : InvestBuffData
{
	// Token: 0x06000120 RID: 288 RVA: 0x000051F0 File Offset: 0x000033F0
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x3AC960", Offset = "0x3AAF60", VA = "0x1803AC960", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.榜样的力量;
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00005200 File Offset: 0x00003400
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x3AC970", Offset = "0x3AAF70", VA = "0x1803AC970", Slot = "13")]
	public override string GetDescription()
	{
		return "伤害统计排名第一的植物称为【榜样】，攻击力增加25%";
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00005214 File Offset: 0x00003414
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_榜样的力量()
	{
	}
}
