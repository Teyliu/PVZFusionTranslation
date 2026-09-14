using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000056 RID: 86
[Token(Token = "0x2000056")]
public class Invest_人海战术 : InvestBuffData
{
	// Token: 0x0600016C RID: 364 RVA: 0x00005B30 File Offset: 0x00003D30
	[Token(Token = "0x600016C")]
	[Address(RVA = "0x3AADE0", Offset = "0x3A93E0", VA = "0x1803AADE0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.人海战术;
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00005B44 File Offset: 0x00003D44
	[Token(Token = "0x600016D")]
	[Address(RVA = "0x3AADF0", Offset = "0x3A93F0", VA = "0x1803AADF0", Slot = "13")]
	public override string GetDescription()
	{
		return "我方小队获得20%攻击力加成，每一轮开始时，若我方小队的植物数量大于200，全场植物获得50%攻击力加成";
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00005B58 File Offset: 0x00003D58
	[Token(Token = "0x600016E")]
	[Address(RVA = "0x3AAE20", Offset = "0x3A9420", VA = "0x1803AAE20", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num;
		do
		{
			List<Plant> allPlants = Lawnf.GetAllPlants();
			num = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00005B88 File Offset: 0x00003D88
	[Token(Token = "0x600016F")]
	[Address(RVA = "0x3AAF80", Offset = "0x3A9580", VA = "0x1803AAF80", Slot = "18")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		int num = 0;
		int num2 = 0;
		plant.ModifyDamage((PlantDamageAdder)((uint)39), 0.2f, num2 != 0, num);
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00005BB0 File Offset: 0x00003DB0
	[Token(Token = "0x6000170")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00005BC0 File Offset: 0x00003DC0
	[Token(Token = "0x6000171")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_人海战术()
	{
	}
}
