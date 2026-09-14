using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000063 RID: 99
[Token(Token = "0x2000063")]
public class Invest_超光速提拔 : InvestBuffData
{
	// Token: 0x060001A6 RID: 422 RVA: 0x00006174 File Offset: 0x00004374
	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x3ADE20", Offset = "0x3AC420", VA = "0x1803ADE20", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.超光速提拔;
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00006188 File Offset: 0x00004388
	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x3ADE30", Offset = "0x3AC430", VA = "0x1803ADE30", Slot = "13")]
	public override string GetDescription()
	{
		return "每一轮开始时，使一个随机的非究常规植物升至3星";
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x0000619C File Offset: 0x0000439C
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x3ADE60", Offset = "0x3AC460", VA = "0x1803ADE60", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		List<Plant> allPlants = Lawnf.GetAllPlants();
		Func<Plant, bool> <>9__2_ = Invest_超光速提拔.<>c.<>9__2_0;
		if (<>9__2_ == 0)
		{
			Func<Plant, bool> func;
			Invest_超光速提拔.<>c.<>9__2_0 = func;
		}
		Plant random = ListExtensions.GetRandom<Plant>(Enumerable.ToList<Plant>(Enumerable.Where<Plant>(allPlants, <>9__2_)));
		int num = 0;
		uint num2;
		ulong num3;
		bool flag = random.Upgrade((int)num2, num3 != 0UL, num != 0);
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x000061F0 File Offset: 0x000043F0
	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00006200 File Offset: 0x00004400
	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_超光速提拔()
	{
	}
}
