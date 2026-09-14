using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000042 RID: 66
[Token(Token = "0x2000042")]
public class Invest_当头一棒 : InvestBuffData
{
	// Token: 0x06000118 RID: 280 RVA: 0x000050EC File Offset: 0x000032EC
	[Token(Token = "0x6000118")]
	[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.当头一棒;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x000050FC File Offset: 0x000032FC
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x3ABAB0", Offset = "0x3AA0B0", VA = "0x1803ABAB0", Slot = "13")]
	public override string GetDescription()
	{
		return "每波僵尸出现时，对血量最高的僵尸造成1500%基础伤害";
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00005110 File Offset: 0x00003310
	[Token(Token = "0x600011A")]
	[Address(RVA = "0x3ABAE0", Offset = "0x3AA0E0", VA = "0x1803ABAE0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (Invest_当头一棒.<>c.<>9__2_0 == 0)
		{
			Invest_当头一棒.<>c.<>9__2_0 = delegate
			{
				List<Zombie> allZombies = Lawnf.GetAllZombies(false);
				Func<Zombie, int> <>9__2_ = Invest_当头一棒.<>c.<>9__2_1;
				if (<>9__2_ == 0)
				{
					Func<Zombie, int> func;
					Invest_当头一棒.<>c.<>9__2_1 = func;
				}
				Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderByDescending<Zombie, int>(allZombies, <>9__2_));
				int num = 0;
				if (zombie != num)
				{
					int basicDamage = TravelMgr.Instance.BasicDamage;
				}
			};
		}
	}

	// Token: 0x0600011B RID: 283 RVA: 0x0000513C File Offset: 0x0000333C
	[Token(Token = "0x600011B")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_当头一棒()
	{
	}
}
