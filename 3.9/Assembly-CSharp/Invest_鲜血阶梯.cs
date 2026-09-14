using System;
using Cpp2IlInjected;

// Token: 0x02000065 RID: 101
[Token(Token = "0x2000065")]
public class Invest_鲜血阶梯 : InvestBuffData
{
	// Token: 0x060001B5 RID: 437 RVA: 0x0000633C File Offset: 0x0000453C
	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x3FA760", Offset = "0x3F8D60", VA = "0x1803FA760", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.鲜血阶梯;
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x060001B6 RID: 438 RVA: 0x00006350 File Offset: 0x00004550
	[Token(Token = "0x17000067")]
	public override string Description
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x3FA890", Offset = "0x3F8E90", VA = "0x1803FA890", Slot = "13")]
		get
		{
			return "每有一个领袖僵尸死亡，我方小队永久获得8%伤害增幅";
		}
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00006364 File Offset: 0x00004564
	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x3FA770", Offset = "0x3F8D70", VA = "0x1803FA770", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (Invest_鲜血阶梯.<>c.<>9__3_0 == 0)
		{
			Action<object> action;
			Invest_鲜血阶梯.<>c.<>9__3_0 = action;
		}
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00006380 File Offset: 0x00004580
	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00006390 File Offset: 0x00004590
	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_鲜血阶梯()
	{
	}
}
