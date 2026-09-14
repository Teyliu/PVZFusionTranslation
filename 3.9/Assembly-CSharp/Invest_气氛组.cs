using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x0200003B RID: 59
[Token(Token = "0x200003B")]
public class Invest_气氛组 : InvestBuffData
{
	// Token: 0x06000107 RID: 263 RVA: 0x00004E88 File Offset: 0x00003088
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.气氛组;
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06000108 RID: 264 RVA: 0x00004E98 File Offset: 0x00003098
	[Token(Token = "0x17000049")]
	public override string Description
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x3F8A30", Offset = "0x3F7030", VA = "0x1803F8A30", Slot = "13")]
		get
		{
			return "每一轮结束时，每有一种造成伤害为0的植物，获得300积分，最多计入10种";
		}
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00004EAC File Offset: 0x000030AC
	[Token(Token = "0x6000109")]
	[Address(RVA = "0x3F8800", Offset = "0x3F6E00", VA = "0x1803F8800", Slot = "14")]
	public override void OnBoardEnd(Board board)
	{
		List<Plant> allPlants = Lawnf.GetAllPlants();
		Func<Plant, PlantType> <>9__3_ = Invest_气氛组.<>c.<>9__3_0;
		if (<>9__3_ == 0)
		{
			Func<Plant, PlantType> func;
			Invest_气氛组.<>c.<>9__3_0 = func;
		}
		HashSet<PlantType> hashSet = new HashSet(Enumerable.Select<Plant, PlantType>(allPlants, <>9__3_));
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

	// Token: 0x0600010A RID: 266 RVA: 0x00004F20 File Offset: 0x00003120
	[Token(Token = "0x600010A")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_气氛组()
	{
	}
}
