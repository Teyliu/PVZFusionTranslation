using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000067 RID: 103
[Token(Token = "0x2000067")]
public class Invest_超光速提拔 : InvestBuffData
{
	// Token: 0x060001BD RID: 445 RVA: 0x00006404 File Offset: 0x00004604
	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x3F9C90", Offset = "0x3F8290", VA = "0x1803F9C90", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.超光速提拔;
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060001BE RID: 446 RVA: 0x00006418 File Offset: 0x00004618
	[Token(Token = "0x17000068")]
	public override string Description
	{
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x3F9E60", Offset = "0x3F8460", VA = "0x1803F9E60", Slot = "13")]
		get
		{
			return "每一轮开始时，使一个随机的非究常规植物升至3星";
		}
	}

	// Token: 0x060001BF RID: 447 RVA: 0x0000642C File Offset: 0x0000462C
	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x3F9CA0", Offset = "0x3F82A0", VA = "0x1803F9CA0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		List<Plant> allPlants = Lawnf.GetAllPlants();
		Func<Plant, bool> <>9__3_ = Invest_超光速提拔.<>c.<>9__3_0;
		if (<>9__3_ == 0)
		{
			Invest_超光速提拔.<>c.<>9__3_0 = delegate(Plant p)
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

	// Token: 0x060001C0 RID: 448 RVA: 0x0000648C File Offset: 0x0000468C
	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x0000649C File Offset: 0x0000469C
	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_超光速提拔()
	{
	}
}
