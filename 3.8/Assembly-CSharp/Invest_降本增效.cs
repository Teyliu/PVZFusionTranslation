using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x0200004C RID: 76
[Token(Token = "0x200004C")]
public class Invest_降本增效 : InvestBuffData
{
	// Token: 0x0600013E RID: 318 RVA: 0x00005544 File Offset: 0x00003744
	[Token(Token = "0x600013E")]
	[Address(RVA = "0x3AE1D0", Offset = "0x3AC7D0", VA = "0x1803AE1D0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.降本增效;
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00005558 File Offset: 0x00003758
	[Token(Token = "0x600013F")]
	[Address(RVA = "0x3AE1E0", Offset = "0x3AC7E0", VA = "0x1803AE1E0", Slot = "13")]
	public override string GetDescription()
	{
		return "铲除场上的全部植物，获得双倍阳光，在这一轮卡牌不再有冷却";
	}

	// Token: 0x06000140 RID: 320 RVA: 0x0000556C File Offset: 0x0000376C
	[Token(Token = "0x6000140")]
	[Address(RVA = "0x3AE210", Offset = "0x3AC810", VA = "0x1803AE210", Slot = "17")]
	public override void OnSelect(Board board)
	{
		int num2;
		do
		{
			int num = 0;
			List<Plant> allPlants = global::Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
			}
			if (num != 0)
			{
				goto IL_004C;
			}
			num2 = 0;
			List<CardUI> childs = global::Core.Lawnf.GetChilds<CardUI>(InGameUI.Instance.transform);
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num2 != 0);
		return;
		IL_004C:
		throw new NullReferenceException();
	}

	// Token: 0x06000141 RID: 321 RVA: 0x000055CC File Offset: 0x000037CC
	[Token(Token = "0x6000141")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_降本增效()
	{
	}
}
