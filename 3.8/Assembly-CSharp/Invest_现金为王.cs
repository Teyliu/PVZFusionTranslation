using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200004B RID: 75
[Token(Token = "0x200004B")]
public class Invest_现金为王 : InvestBuffData
{
	// Token: 0x06000139 RID: 313 RVA: 0x00005474 File Offset: 0x00003674
	[Token(Token = "0x6000139")]
	[Address(RVA = "0x3ACD90", Offset = "0x3AB390", VA = "0x1803ACD90", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.现金为王;
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00005488 File Offset: 0x00003688
	[Token(Token = "0x600013A")]
	[Address(RVA = "0x3ACDA0", Offset = "0x3AB3A0", VA = "0x1803ACDA0", Slot = "13")]
	public override string GetDescription()
	{
		return "铲除场上的全部植物，获得双倍阳光，之后每次进入战斗时，为我方全部植物提供护盾，护盾量为铲除植物的阳光数";
	}

	// Token: 0x0600013B RID: 315 RVA: 0x0000549C File Offset: 0x0000369C
	[Token(Token = "0x600013B")]
	[Address(RVA = "0x3ACDD0", Offset = "0x3AB3D0", VA = "0x1803ACDD0", Slot = "15")]
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

	// Token: 0x0600013C RID: 316 RVA: 0x000054E4 File Offset: 0x000036E4
	[Token(Token = "0x600013C")]
	[Address(RVA = "0x3ACF40", Offset = "0x3AB540", VA = "0x1803ACF40", Slot = "17")]
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

	// Token: 0x0600013D RID: 317 RVA: 0x00005530 File Offset: 0x00003730
	[Token(Token = "0x600013D")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_现金为王()
	{
	}
}
