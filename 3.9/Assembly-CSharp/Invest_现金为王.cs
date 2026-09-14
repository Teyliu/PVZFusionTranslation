using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200004F RID: 79
[Token(Token = "0x200004F")]
public class Invest_现金为王 : InvestBuffData
{
	// Token: 0x06000150 RID: 336 RVA: 0x000056F8 File Offset: 0x000038F8
	[Token(Token = "0x6000150")]
	[Address(RVA = "0x3F8C00", Offset = "0x3F7200", VA = "0x1803F8C00", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.现金为王;
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06000151 RID: 337 RVA: 0x0000570C File Offset: 0x0000390C
	[Token(Token = "0x17000056")]
	public override string Description
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x3F8F90", Offset = "0x3F7590", VA = "0x1803F8F90", Slot = "13")]
		get
		{
			return "铲除场上的全部植物，获得双倍阳光，之后每次进入战斗时，为我方全部植物提供护盾，护盾量为铲除植物的阳光数";
		}
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00005720 File Offset: 0x00003920
	[Token(Token = "0x6000152")]
	[Address(RVA = "0x3F8C10", Offset = "0x3F7210", VA = "0x1803F8C10", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		ulong num;
		do
		{
			List<Plant> allPlants = Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
				TravelData data = TravelMgr.Instance.data;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00005768 File Offset: 0x00003968
	[Token(Token = "0x6000153")]
	[Address(RVA = "0x3F8D80", Offset = "0x3F7380", VA = "0x1803F8D80", Slot = "17")]
	public override void OnSelect(Board board)
	{
		int num;
		do
		{
			num = 0;
			List<Plant> allPlants = Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
		TravelMgr.Instance.data.shieldCount = num;
	}

	// Token: 0x06000154 RID: 340 RVA: 0x000057B4 File Offset: 0x000039B4
	[Token(Token = "0x6000154")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_现金为王()
	{
	}
}
