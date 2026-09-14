using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x02000050 RID: 80
[Token(Token = "0x2000050")]
public class Invest_降本增效 : InvestBuffData
{
	// Token: 0x06000155 RID: 341 RVA: 0x000057C8 File Offset: 0x000039C8
	[Token(Token = "0x6000155")]
	[Address(RVA = "0x3FA040", Offset = "0x3F8640", VA = "0x1803FA040", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.降本增效;
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06000156 RID: 342 RVA: 0x000057DC File Offset: 0x000039DC
	[Token(Token = "0x17000057")]
	public override string Description
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x3FA3A0", Offset = "0x3F89A0", VA = "0x1803FA3A0", Slot = "13")]
		get
		{
			return "铲除场上的全部植物，获得双倍阳光，在这一轮卡牌不再有冷却";
		}
	}

	// Token: 0x06000157 RID: 343 RVA: 0x000057F0 File Offset: 0x000039F0
	[Token(Token = "0x6000157")]
	[Address(RVA = "0x3FA050", Offset = "0x3F8650", VA = "0x1803FA050", Slot = "17")]
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

	// Token: 0x06000158 RID: 344 RVA: 0x00005850 File Offset: 0x00003A50
	[Token(Token = "0x6000158")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_降本增效()
	{
	}
}
