using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000046 RID: 70
[Token(Token = "0x2000046")]
public class Invest_当头一棒 : InvestBuffData
{
	// Token: 0x0600012F RID: 303 RVA: 0x00005368 File Offset: 0x00003568
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.当头一棒;
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000130 RID: 304 RVA: 0x00005378 File Offset: 0x00003578
	[Token(Token = "0x17000050")]
	public override string Description
	{
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x3F79D0", Offset = "0x3F5FD0", VA = "0x1803F79D0", Slot = "13")]
		get
		{
			return "每波僵尸出现时，对血量最高的僵尸造成1500%基础伤害";
		}
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0000538C File Offset: 0x0000358C
	[Token(Token = "0x6000131")]
	[Address(RVA = "0x3F78B0", Offset = "0x3F5EB0", VA = "0x1803F78B0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (Invest_当头一棒.<>c.<>9__3_0 == 0)
		{
			Invest_当头一棒.<>c.<>9__3_0 = delegate
			{
				List<Zombie> allZombies = Lawnf.GetAllZombies(false);
				Func<Zombie, long> <>9__3_ = Invest_当头一棒.<>c.<>9__3_1;
				if (<>9__3_ == 0)
				{
					Func<Zombie, long> func;
					Invest_当头一棒.<>c.<>9__3_1 = func;
				}
				Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderByDescending<Zombie, long>(allZombies, <>9__3_));
				int num = 0;
				if (zombie != num)
				{
					int basicDamage = TravelMgr.Instance.BasicDamage;
				}
			};
		}
	}

	// Token: 0x06000132 RID: 306 RVA: 0x000053B8 File Offset: 0x000035B8
	[Token(Token = "0x6000132")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_当头一棒()
	{
	}
}
