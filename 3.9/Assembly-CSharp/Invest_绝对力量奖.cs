using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x0200004B RID: 75
[Token(Token = "0x200004B")]
public class Invest_绝对力量奖 : InvestBuffData
{
	// Token: 0x06000142 RID: 322 RVA: 0x00005590 File Offset: 0x00003790
	[Token(Token = "0x6000142")]
	[Address(RVA = "0x3F9920", Offset = "0x3F7F20", VA = "0x1803F9920", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.绝对力量奖;
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000143 RID: 323 RVA: 0x000055A0 File Offset: 0x000037A0
	[Token(Token = "0x17000053")]
	public override string Description
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x3F9BB0", Offset = "0x3F81B0", VA = "0x1803F9BB0", Slot = "13")]
		get
		{
			return "每一轮开始时，攻击力最高的6株植物获得30%伤害加成";
		}
	}

	// Token: 0x06000144 RID: 324 RVA: 0x000055B4 File Offset: 0x000037B4
	[Token(Token = "0x6000144")]
	[Address(RVA = "0x3F9930", Offset = "0x3F7F30", VA = "0x1803F9930", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num2;
		do
		{
			List<Plant> allPlants = Lawnf.GetAllPlants();
			Func<Plant, int> <>9__3_ = Invest_绝对力量奖.<>c.<>9__3_0;
			if (<>9__3_ == 0)
			{
				Func<Plant, int> func;
				Invest_绝对力量奖.<>c.<>9__3_0 = func;
			}
			uint num;
			List<Plant> list = Enumerable.ToList<Plant>(Enumerable.Take<Plant>(Enumerable.OrderBy<Plant, int>(allPlants, <>9__3_), (int)num));
			num2 = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06000145 RID: 325 RVA: 0x0000560C File Offset: 0x0000380C
	[Token(Token = "0x6000145")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_绝对力量奖()
	{
	}
}
