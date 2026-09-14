using System;
using Cpp2IlInjected;

// Token: 0x02000048 RID: 72
[Token(Token = "0x2000048")]
public class Invest_榜样的力量 : InvestBuffData
{
	// Token: 0x06000137 RID: 311 RVA: 0x00005474 File Offset: 0x00003674
	[Token(Token = "0x6000137")]
	[Address(RVA = "0x3F87C0", Offset = "0x3F6DC0", VA = "0x1803F87C0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.榜样的力量;
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000138 RID: 312 RVA: 0x00005484 File Offset: 0x00003684
	[Token(Token = "0x17000051")]
	public override string Description
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x3F87D0", Offset = "0x3F6DD0", VA = "0x1803F87D0", Slot = "13")]
		get
		{
			return "伤害统计排名第一的植物称为【榜样】，攻击力增加25%";
		}
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00005498 File Offset: 0x00003698
	[Token(Token = "0x6000139")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_榜样的力量()
	{
	}
}
