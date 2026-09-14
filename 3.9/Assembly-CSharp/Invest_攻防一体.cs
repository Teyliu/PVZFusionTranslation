using System;
using Cpp2IlInjected;

// Token: 0x02000063 RID: 99
[Token(Token = "0x2000063")]
public class Invest_攻防一体 : InvestBuffData
{
	// Token: 0x060001AB RID: 427 RVA: 0x00006218 File Offset: 0x00004418
	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x3F7C30", Offset = "0x3F6230", VA = "0x1803F7C30", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.攻防一体;
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060001AC RID: 428 RVA: 0x0000622C File Offset: 0x0000442C
	[Token(Token = "0x17000065")]
	public override string Description
	{
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x3F7D20", Offset = "0x3F6320", VA = "0x1803F7D20", Slot = "13")]
		get
		{
			return "我方小队获得25%伤害减免，且获得等同于伤害减免的幸运一击率";
		}
	}

	// Token: 0x060001AD RID: 429 RVA: 0x00006240 File Offset: 0x00004440
	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x3F7CC0", Offset = "0x3F62C0", VA = "0x1803F7CC0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float damageReduction = instance.damageReduction;
		instance.damageReduction = damageReduction;
	}

	// Token: 0x060001AE RID: 430 RVA: 0x0000626C File Offset: 0x0000446C
	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x3F7C40", Offset = "0x3F6240", VA = "0x1803F7C40", Slot = "16")]
	public override void OnBoardLateStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float luckyStrike = instance.luckyStrike;
		TravelMgr instance2 = TravelMgr.Instance;
		instance.luckyStrike = luckyStrike;
	}

	// Token: 0x060001AF RID: 431 RVA: 0x000062A0 File Offset: 0x000044A0
	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x000062B0 File Offset: 0x000044B0
	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_攻防一体()
	{
	}
}
