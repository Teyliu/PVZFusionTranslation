using System;
using Cpp2IlInjected;

// Token: 0x0200005E RID: 94
[Token(Token = "0x200005E")]
public class Invest_幸运闪避 : InvestBuffData
{
	// Token: 0x0600018F RID: 399 RVA: 0x00005F10 File Offset: 0x00004110
	[Token(Token = "0x600018F")]
	[Address(RVA = "0x3AB7A0", Offset = "0x3A9DA0", VA = "0x1803AB7A0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.幸运闪避;
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00005F24 File Offset: 0x00004124
	[Token(Token = "0x6000190")]
	[Address(RVA = "0x3AB7B0", Offset = "0x3A9DB0", VA = "0x1803AB7B0", Slot = "13")]
	public override string GetDescription()
	{
		return "我方小队获得25%幸运一击率，受到攻击时，有等同于30%幸运一击率的概率使受到的伤害变为1";
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00005F38 File Offset: 0x00004138
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x3AB7E0", Offset = "0x3A9DE0", VA = "0x1803AB7E0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float luckyStrike = instance.luckyStrike;
		instance.luckyStrike = luckyStrike;
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00005F64 File Offset: 0x00004164
	[Token(Token = "0x6000192")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00005F74 File Offset: 0x00004174
	[Token(Token = "0x6000193")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_幸运闪避()
	{
	}
}
