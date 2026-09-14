using System;
using Cpp2IlInjected;

// Token: 0x02000068 RID: 104
[Token(Token = "0x2000068")]
public class Invest_概率事件 : InvestBuffData
{
	// Token: 0x060001BE RID: 446 RVA: 0x00006434 File Offset: 0x00004634
	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x3AC880", Offset = "0x3AAE80", VA = "0x1803AC880", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.概率事件;
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00006448 File Offset: 0x00004648
	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x3AC890", Offset = "0x3AAE90", VA = "0x1803AC890", Slot = "13")]
	public override string GetDescription()
	{
		return "刷新时有45%概率获得一次额外刷新次数";
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x0000645C File Offset: 0x0000465C
	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_概率事件()
	{
	}
}
