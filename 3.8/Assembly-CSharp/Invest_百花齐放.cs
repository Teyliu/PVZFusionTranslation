using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200004E RID: 78
[Token(Token = "0x200004E")]
public class Invest_百花齐放 : InvestBuffData
{
	// Token: 0x06000147 RID: 327 RVA: 0x00005658 File Offset: 0x00003858
	[Token(Token = "0x6000147")]
	[Address(RVA = "0x3AD150", Offset = "0x3AB750", VA = "0x1803AD150", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.百花齐放;
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0000566C File Offset: 0x0000386C
	[Token(Token = "0x6000148")]
	[Address(RVA = "0x3AD160", Offset = "0x3AB760", VA = "0x1803AD160", Slot = "13")]
	public override string GetDescription()
	{
		return "每一轮开始时，场上每有一种不同类型的植物，在场全体植物获得2%生命提高，3%伤害增幅";
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00005680 File Offset: 0x00003880
	[Token(Token = "0x6000149")]
	[Address(RVA = "0x3AD190", Offset = "0x3AB790", VA = "0x1803AD190", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		ulong num;
		do
		{
			int count = Lawnf.GetPlantTypes()._count;
			List<Plant> allPlants = Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		float num2;
		TravelMgr.Instance.damageAmplification = num2;
	}

	// Token: 0x0600014A RID: 330 RVA: 0x000056D0 File Offset: 0x000038D0
	[Token(Token = "0x600014A")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x0600014B RID: 331 RVA: 0x000056E0 File Offset: 0x000038E0
	[Token(Token = "0x600014B")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_百花齐放()
	{
	}
}
