using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x0200005C RID: 92
[Token(Token = "0x200005C")]
public class Invest_星变 : InvestBuffData
{
	// Token: 0x0600018E RID: 398 RVA: 0x00005ED4 File Offset: 0x000040D4
	[Token(Token = "0x600018E")]
	[Address(RVA = "0x3F2C00", Offset = "0x3F1200", VA = "0x1803F2C00", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.星变;
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x0600018F RID: 399 RVA: 0x00005EE8 File Offset: 0x000040E8
	[Token(Token = "0x17000061")]
	public override string Description
	{
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x3F8170", Offset = "0x3F6770", VA = "0x1803F8170", Slot = "13")]
		get
		{
			return "每一轮开始时，使一个非究植物升至2星";
		}
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00005EFC File Offset: 0x000040FC
	[Token(Token = "0x6000190")]
	[Address(RVA = "0x3F7FB0", Offset = "0x3F65B0", VA = "0x1803F7FB0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		List<Plant> allPlants = Lawnf.GetAllPlants();
		Func<Plant, bool> <>9__3_ = Invest_星变.<>c.<>9__3_0;
		if (<>9__3_ == 0)
		{
			Invest_星变.<>c.<>9__3_0 = delegate(Plant p)
			{
				bool flag2 = Lawnf.IsUltiPlant(p.thePlantType);
				if (!flag2 && p.plantTag == flag2)
				{
					return p.isLily == flag2;
				}
				throw new NullReferenceException();
			};
		}
		Plant random = ListExtensions.GetRandom<Plant>(Enumerable.ToList<Plant>(Enumerable.Where<Plant>(allPlants, <>9__3_)));
		int num = 0;
		uint num2;
		ulong num3;
		bool flag = random.Upgrade((int)num2, num3 != 0UL, num != 0);
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00005F5C File Offset: 0x0000415C
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00005F6C File Offset: 0x0000416C
	[Token(Token = "0x6000192")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_星变()
	{
	}
}
