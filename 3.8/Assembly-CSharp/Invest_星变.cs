using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000058 RID: 88
[Token(Token = "0x2000058")]
public class Invest_星变 : InvestBuffData
{
	// Token: 0x06000177 RID: 375 RVA: 0x00005C50 File Offset: 0x00003E50
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x3A6CA0", Offset = "0x3A52A0", VA = "0x1803A6CA0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.星变;
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00005C64 File Offset: 0x00003E64
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x3AC1B0", Offset = "0x3AA7B0", VA = "0x1803AC1B0", Slot = "13")]
	public override string GetDescription()
	{
		return "每一轮开始时，使一个非究植物升至2星";
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00005C78 File Offset: 0x00003E78
	[Token(Token = "0x6000179")]
	[Address(RVA = "0x3AC1E0", Offset = "0x3AA7E0", VA = "0x1803AC1E0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		List<Plant> allPlants = Lawnf.GetAllPlants();
		Func<Plant, bool> <>9__2_ = Invest_星变.<>c.<>9__2_0;
		if (<>9__2_ == 0)
		{
			Func<Plant, bool> func;
			Invest_星变.<>c.<>9__2_0 = func;
		}
		Plant random = ListExtensions.GetRandom<Plant>(Enumerable.ToList<Plant>(Enumerable.Where<Plant>(allPlants, <>9__2_)));
		int num = 0;
		uint num2;
		ulong num3;
		bool flag = random.Upgrade((int)num2, num3 != 0UL, num != 0);
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00005CCC File Offset: 0x00003ECC
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00005CDC File Offset: 0x00003EDC
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_星变()
	{
	}
}
