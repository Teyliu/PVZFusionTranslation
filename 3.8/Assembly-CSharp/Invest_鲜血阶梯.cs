using System;
using Cpp2IlInjected;

// Token: 0x02000061 RID: 97
[Token(Token = "0x2000061")]
public class Invest_鲜血阶梯 : InvestBuffData
{
	// Token: 0x0600019E RID: 414 RVA: 0x000060AC File Offset: 0x000042AC
	[Token(Token = "0x600019E")]
	[Address(RVA = "0x3AE8F0", Offset = "0x3ACEF0", VA = "0x1803AE8F0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.鲜血阶梯;
	}

	// Token: 0x0600019F RID: 415 RVA: 0x000060C0 File Offset: 0x000042C0
	[Token(Token = "0x600019F")]
	[Address(RVA = "0x3AE900", Offset = "0x3ACF00", VA = "0x1803AE900", Slot = "13")]
	public override string GetDescription()
	{
		return "每有一个领袖僵尸死亡，我方小队永久获得8%伤害增幅";
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x000060D4 File Offset: 0x000042D4
	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x3AE930", Offset = "0x3ACF30", VA = "0x1803AE930", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (Invest_鲜血阶梯.<>c.<>9__2_0 == 0)
		{
			Action<object> action;
			Invest_鲜血阶梯.<>c.<>9__2_0 = action;
		}
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x000060F0 File Offset: 0x000042F0
	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00006100 File Offset: 0x00004300
	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_鲜血阶梯()
	{
	}
}
