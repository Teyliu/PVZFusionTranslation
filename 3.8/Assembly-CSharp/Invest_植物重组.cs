using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200003B RID: 59
[Token(Token = "0x200003B")]
public class Invest_植物重组 : InvestBuffData
{
	// Token: 0x06000100 RID: 256 RVA: 0x00004E08 File Offset: 0x00003008
	[Token(Token = "0x6000100")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.植物重组;
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00004E18 File Offset: 0x00003018
	[Token(Token = "0x6000101")]
	[Address(RVA = "0x3AC550", Offset = "0x3AAB50", VA = "0x1803AC550", Slot = "13")]
	public override string GetDescription()
	{
		return "将场上的植物变为随机植物，这一轮中手套不再有冷却，立即获得1000积分";
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00004E2C File Offset: 0x0000302C
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x3AC580", Offset = "0x3AAB80", VA = "0x1803AC580", Slot = "17")]
	public override void OnSelect(Board board)
	{
		int num;
		do
		{
			List<Plant> allPlants = Lawnf.GetAllPlants();
			num = 0;
			bool flag;
			if (flag)
			{
				bool isSuperRandom = board.boardTag.isSuperRandom;
				board.boardTag.isSuperRandom = true;
				CreatePlant instance = CreatePlant.Instance;
				int num2 = 0;
				Plant plant;
				if (plant != num2)
				{
					Present component = plant.GetComponent<Present>();
					int num3 = 0;
					component.SuperRandomPlant(num3 != 0);
				}
				board.boardTag.isSuperRandom = isSuperRandom;
			}
		}
		while (num != 0);
		int num4 = 0;
		Glove.Instance.fullCD = (float)num4;
		Glove.Instance.CD = (float)num4;
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00004EEC File Offset: 0x000030EC
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_植物重组()
	{
	}
}
