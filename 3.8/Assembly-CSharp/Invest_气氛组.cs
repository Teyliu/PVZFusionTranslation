using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000037 RID: 55
[Token(Token = "0x2000037")]
public class Invest_气氛组 : InvestBuffData
{
	// Token: 0x060000F0 RID: 240 RVA: 0x00004BF8 File Offset: 0x00002DF8
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.气氛组;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00004C08 File Offset: 0x00002E08
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x3AC9A0", Offset = "0x3AAFA0", VA = "0x1803AC9A0", Slot = "13")]
	public override string GetDescription()
	{
		return "每一轮结束时，每有一种造成伤害为0的植物，获得300积分，最多计入10种";
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00004C1C File Offset: 0x00002E1C
	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x3AC9D0", Offset = "0x3AAFD0", VA = "0x1803AC9D0", Slot = "14")]
	public override void OnBoardEnd(Board board)
	{
		List<Plant> allPlants = Lawnf.GetAllPlants();
		Func<Plant, PlantType> <>9__2_ = Invest_气氛组.<>c.<>9__2_0;
		if (<>9__2_ == 0)
		{
			Func<Plant, PlantType> func;
			Invest_气氛组.<>c.<>9__2_0 = func;
		}
		HashSet<PlantType> hashSet = new HashSet(Enumerable.Select<Plant, PlantType>(allPlants, <>9__2_));
		Func<PlantType, bool> func2 = delegate(PlantType plantType)
		{
			Dictionary<PlantType, long> reportDic = board.damageReporter.ReportDic;
			bool flag;
			bool flag2;
			return !flag || flag2;
		};
		int num = Enumerable.Count<PlantType>(hashSet, func2);
		Board board2 = board;
		uint num3;
		long num2 = (long)(num3 * (uint)300);
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00004C90 File Offset: 0x00002E90
	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_气氛组()
	{
	}
}
