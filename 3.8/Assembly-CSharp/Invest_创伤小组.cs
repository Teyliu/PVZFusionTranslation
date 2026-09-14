using System;
using Cpp2IlInjected;

// Token: 0x02000054 RID: 84
[Token(Token = "0x2000054")]
public class Invest_创伤小组 : InvestBuffData
{
	// Token: 0x06000161 RID: 353 RVA: 0x000059FC File Offset: 0x00003BFC
	[Token(Token = "0x6000161")]
	[Address(RVA = "0x3AB140", Offset = "0x3A9740", VA = "0x1803AB140", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.创伤小组;
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00005A10 File Offset: 0x00003C10
	[Token(Token = "0x6000162")]
	[Address(RVA = "0x3AB150", Offset = "0x3A9750", VA = "0x1803AB150", Slot = "13")]
	public override string GetDescription()
	{
		return "每一轮开始时，我方小队获得25%幸运一击率，生命值上限降低30%";
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00005A24 File Offset: 0x00003C24
	[Token(Token = "0x6000163")]
	[Address(RVA = "0x3AB180", Offset = "0x3A9780", VA = "0x1803AB180", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float luckyStrike = instance.luckyStrike;
		instance.luckyStrike = luckyStrike;
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00005A50 File Offset: 0x00003C50
	[Token(Token = "0x6000164")]
	[Address(RVA = "0x3AB1E0", Offset = "0x3A97E0", VA = "0x1803AB1E0", Slot = "18")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		int num = 0;
		plant.ModifyHealth((PlantHealthAdder)((uint)3), -0.3f, num != 0);
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00005A74 File Offset: 0x00003C74
	[Token(Token = "0x6000165")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00005A84 File Offset: 0x00003C84
	[Token(Token = "0x6000166")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_创伤小组()
	{
	}
}
