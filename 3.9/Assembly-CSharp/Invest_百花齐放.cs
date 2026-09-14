using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000052 RID: 82
[Token(Token = "0x2000052")]
public class Invest_百花齐放 : InvestBuffData
{
	// Token: 0x0600015E RID: 350 RVA: 0x000058DC File Offset: 0x00003ADC
	[Token(Token = "0x600015E")]
	[Address(RVA = "0x3F8FC0", Offset = "0x3F75C0", VA = "0x1803F8FC0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.百花齐放;
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x0600015F RID: 351 RVA: 0x000058F0 File Offset: 0x00003AF0
	[Token(Token = "0x17000059")]
	public override string Description
	{
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x3F91B0", Offset = "0x3F77B0", VA = "0x1803F91B0", Slot = "13")]
		get
		{
			return "每一轮开始时，场上每有一种不同类型的植物，在场全体植物获得2%生命提高，3%伤害增幅";
		}
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00005904 File Offset: 0x00003B04
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x3F8FD0", Offset = "0x3F75D0", VA = "0x1803F8FD0", Slot = "15")]
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

	// Token: 0x06000161 RID: 353 RVA: 0x00005954 File Offset: 0x00003B54
	[Token(Token = "0x6000161")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00005964 File Offset: 0x00003B64
	[Token(Token = "0x6000162")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_百花齐放()
	{
	}
}
