using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200005A RID: 90
[Token(Token = "0x200005A")]
public class Invest_人海战术 : InvestBuffData
{
	// Token: 0x06000183 RID: 387 RVA: 0x00005DB4 File Offset: 0x00003FB4
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x3F6BE0", Offset = "0x3F51E0", VA = "0x1803F6BE0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.人海战术;
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000184 RID: 388 RVA: 0x00005DC8 File Offset: 0x00003FC8
	[Token(Token = "0x1700005F")]
	public override string Description
	{
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x3F6D90", Offset = "0x3F5390", VA = "0x1803F6D90", Slot = "13")]
		get
		{
			return "我方小队获得20%攻击力加成，每一轮开始时，若我方小队的植物数量大于200，全场植物获得50%攻击力加成";
		}
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00005DDC File Offset: 0x00003FDC
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x3F6BF0", Offset = "0x3F51F0", VA = "0x1803F6BF0", Slot = "15")]
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

	// Token: 0x06000186 RID: 390 RVA: 0x00005E0C File Offset: 0x0000400C
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x3F6D50", Offset = "0x3F5350", VA = "0x1803F6D50", Slot = "18")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		int num = 0;
		int num2 = 0;
		plant.ModifyDamage((PlantDamageAdder)((uint)39), 0.2f, num2 != 0, num);
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00005E34 File Offset: 0x00004034
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00005E44 File Offset: 0x00004044
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_人海战术()
	{
	}
}
