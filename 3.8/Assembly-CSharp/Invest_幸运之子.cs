using System;
using Cpp2IlInjected;

// Token: 0x02000065 RID: 101
[Token(Token = "0x2000065")]
public class Invest_幸运之子 : InvestBuffData
{
	// Token: 0x060001AE RID: 430 RVA: 0x0000627C File Offset: 0x0000447C
	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x3AB670", Offset = "0x3A9C70", VA = "0x1803AB670", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.幸运之子;
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00006290 File Offset: 0x00004490
	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x3AB680", Offset = "0x3A9C80", VA = "0x1803AB680", Slot = "13")]
	public override string GetDescription()
	{
		return "我方小队的幸运一击率提高30%，当幸运一击率达到100%以上时，幸运一击伤害增加40%";
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x000062A4 File Offset: 0x000044A4
	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x3AB740", Offset = "0x3A9D40", VA = "0x1803AB740", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float luckyStrike = instance.luckyStrike;
		instance.luckyStrike = luckyStrike;
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x000062D0 File Offset: 0x000044D0
	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x3AB6B0", Offset = "0x3A9CB0", VA = "0x1803AB6B0", Slot = "16")]
	public override void OnBoardLateStart(Board board)
	{
		float luckyStrike = TravelMgr.Instance.luckyStrike;
		TravelMgr instance = TravelMgr.Instance;
		float luckyDamage = instance.luckyDamage;
		instance.luckyDamage = luckyDamage;
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00006308 File Offset: 0x00004508
	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00006318 File Offset: 0x00004518
	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_幸运之子()
	{
	}
}
