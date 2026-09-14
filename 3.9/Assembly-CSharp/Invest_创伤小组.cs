using System;
using Cpp2IlInjected;

// Token: 0x02000058 RID: 88
[Token(Token = "0x2000058")]
public class Invest_创伤小组 : InvestBuffData
{
	// Token: 0x06000178 RID: 376 RVA: 0x00005C80 File Offset: 0x00003E80
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x3F6F40", Offset = "0x3F5540", VA = "0x1803F6F40", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.创伤小组;
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000179 RID: 377 RVA: 0x00005C94 File Offset: 0x00003E94
	[Token(Token = "0x1700005D")]
	public override string Description
	{
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x3F6FF0", Offset = "0x3F55F0", VA = "0x1803F6FF0", Slot = "13")]
		get
		{
			return "每一轮开始时，我方小队获得25%幸运一击率，生命值上限降低30%";
		}
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00005CA8 File Offset: 0x00003EA8
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x3F6F50", Offset = "0x3F5550", VA = "0x1803F6F50", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float luckyStrike = instance.luckyStrike;
		instance.luckyStrike = luckyStrike;
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00005CD4 File Offset: 0x00003ED4
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x3F6FB0", Offset = "0x3F55B0", VA = "0x1803F6FB0", Slot = "18")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		int num = 0;
		plant.ModifyHealth((PlantHealthAdder)((uint)3), -0.3f, num != 0);
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00005CF8 File Offset: 0x00003EF8
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00005D08 File Offset: 0x00003F08
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_创伤小组()
	{
	}
}
