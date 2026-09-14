using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200003F RID: 63
[Token(Token = "0x200003F")]
public class Invest_植物重组 : InvestBuffData
{
	// Token: 0x06000117 RID: 279 RVA: 0x00005098 File Offset: 0x00003298
	[Token(Token = "0x6000117")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.植物重组;
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000118 RID: 280 RVA: 0x000050A8 File Offset: 0x000032A8
	[Token(Token = "0x1700004B")]
	public override string Description
	{
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x3F86B0", Offset = "0x3F6CB0", VA = "0x1803F86B0", Slot = "13")]
		get
		{
			return "将场上的植物变为随机植物，这一轮中手套不再有冷却，立即获得1000积分";
		}
	}

	// Token: 0x06000119 RID: 281 RVA: 0x000050BC File Offset: 0x000032BC
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x3F8350", Offset = "0x3F6950", VA = "0x1803F8350", Slot = "17")]
	public override void OnSelect(Board board)
	{
		int num;
		do
		{
			Glove instance = Glove.Instance;
			num = 0;
			instance.fullCD = (float)num;
			Glove.Instance.CD = (float)num;
			int num2;
			Debug.Log(num2);
			List<Plant> allPlants = Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
				bool isSuperRandom = board.boardTag.isSuperRandom;
				board.boardTag.isSuperRandom = true;
				CreatePlant instance2 = CreatePlant.Instance;
				int num3 = 0;
				Plant plant;
				if (!(plant != num3) || plant != 0)
				{
				}
				board.boardTag.isSuperRandom = isSuperRandom;
			}
		}
		while (num != 0);
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00005168 File Offset: 0x00003368
	[Token(Token = "0x600011A")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_植物重组()
	{
	}
}
