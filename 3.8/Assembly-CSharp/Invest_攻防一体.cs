using System;
using Cpp2IlInjected;

// Token: 0x0200005F RID: 95
[Token(Token = "0x200005F")]
public class Invest_攻防一体 : InvestBuffData
{
	// Token: 0x06000194 RID: 404 RVA: 0x00005F88 File Offset: 0x00004188
	[Token(Token = "0x6000194")]
	[Address(RVA = "0x3ABE30", Offset = "0x3AA430", VA = "0x1803ABE30", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.攻防一体;
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00005F9C File Offset: 0x0000419C
	[Token(Token = "0x6000195")]
	[Address(RVA = "0x3ABE40", Offset = "0x3AA440", VA = "0x1803ABE40", Slot = "13")]
	public override string GetDescription()
	{
		return "我方小队获得25%伤害减免，且获得等同于伤害减免的幸运一击率";
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00005FB0 File Offset: 0x000041B0
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x3ABEF0", Offset = "0x3AA4F0", VA = "0x1803ABEF0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float damageReduction = instance.damageReduction;
		instance.damageReduction = damageReduction;
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00005FDC File Offset: 0x000041DC
	[Token(Token = "0x6000197")]
	[Address(RVA = "0x3ABE70", Offset = "0x3AA470", VA = "0x1803ABE70", Slot = "16")]
	public override void OnBoardLateStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float luckyStrike = instance.luckyStrike;
		TravelMgr instance2 = TravelMgr.Instance;
		instance.luckyStrike = luckyStrike;
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00006010 File Offset: 0x00004210
	[Token(Token = "0x6000198")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00006020 File Offset: 0x00004220
	[Token(Token = "0x6000199")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_攻防一体()
	{
	}
}
