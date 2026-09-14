using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000064 RID: 100
[Token(Token = "0x2000064")]
public class Invest_野蛮成长 : InvestBuffData
{
	// Token: 0x060001B1 RID: 433 RVA: 0x000062C4 File Offset: 0x000044C4
	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x3F9E90", Offset = "0x3F8490", VA = "0x1803F9E90", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.野蛮成长;
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x060001B2 RID: 434 RVA: 0x000062D8 File Offset: 0x000044D8
	[Token(Token = "0x17000066")]
	public override string Description
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x3FA010", Offset = "0x3F8610", VA = "0x1803FA010", Slot = "13")]
		get
		{
			return "每一轮开始时，每个植物有50%概率获得100%攻击力加成";
		}
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x000062EC File Offset: 0x000044EC
	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x3F9EA0", Offset = "0x3F84A0", VA = "0x1803F9EA0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num;
		bool flag;
		do
		{
			List<Plant> allPlants = Lawnf.GetAllPlants();
			num = 0;
		}
		while ((flag && global::UnityEngine.Random.Range(0, 2) != 0) || num != 0);
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00006328 File Offset: 0x00004528
	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_野蛮成长()
	{
	}
}
