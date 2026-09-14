using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000060 RID: 96
[Token(Token = "0x2000060")]
public class Invest_野蛮成长 : InvestBuffData
{
	// Token: 0x0600019A RID: 410 RVA: 0x00006034 File Offset: 0x00004234
	[Token(Token = "0x600019A")]
	[Address(RVA = "0x3AE020", Offset = "0x3AC620", VA = "0x1803AE020", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.野蛮成长;
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00006048 File Offset: 0x00004248
	[Token(Token = "0x600019B")]
	[Address(RVA = "0x3AE030", Offset = "0x3AC630", VA = "0x1803AE030", Slot = "13")]
	public override string GetDescription()
	{
		return "每一轮开始时，每个植物有50%概率获得100%攻击力加成";
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0000605C File Offset: 0x0000425C
	[Token(Token = "0x600019C")]
	[Address(RVA = "0x3AE060", Offset = "0x3AC660", VA = "0x1803AE060", Slot = "15")]
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

	// Token: 0x0600019D RID: 413 RVA: 0x00006098 File Offset: 0x00004298
	[Token(Token = "0x600019D")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_野蛮成长()
	{
	}
}
