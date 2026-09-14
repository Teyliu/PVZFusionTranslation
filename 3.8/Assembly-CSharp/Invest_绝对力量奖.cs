using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000047 RID: 71
[Token(Token = "0x2000047")]
public class Invest_绝对力量奖 : InvestBuffData
{
	// Token: 0x0600012B RID: 299 RVA: 0x0000530C File Offset: 0x0000350C
	[Token(Token = "0x600012B")]
	[Address(RVA = "0x3ADAB0", Offset = "0x3AC0B0", VA = "0x1803ADAB0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.绝对力量奖;
	}

	// Token: 0x0600012C RID: 300 RVA: 0x0000531C File Offset: 0x0000351C
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x3ADAC0", Offset = "0x3AC0C0", VA = "0x1803ADAC0", Slot = "13")]
	public override string GetDescription()
	{
		return "每一轮开始时，攻击力最高的6株植物获得30%伤害加成";
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00005330 File Offset: 0x00003530
	[Token(Token = "0x600012D")]
	[Address(RVA = "0x3ADAF0", Offset = "0x3AC0F0", VA = "0x1803ADAF0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num2;
		do
		{
			List<Plant> allPlants = Lawnf.GetAllPlants();
			Func<Plant, int> <>9__2_ = Invest_绝对力量奖.<>c.<>9__2_0;
			if (<>9__2_ == 0)
			{
				Func<Plant, int> func;
				Invest_绝对力量奖.<>c.<>9__2_0 = func;
			}
			uint num;
			List<Plant> list = Enumerable.ToList<Plant>(Enumerable.Take<Plant>(Enumerable.OrderBy<Plant, int>(allPlants, <>9__2_), (int)num));
			num2 = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != 0);
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00005388 File Offset: 0x00003588
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_绝对力量奖()
	{
	}
}
