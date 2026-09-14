using System;
using Cpp2IlInjected;

// Token: 0x0200004D RID: 77
[Token(Token = "0x200004D")]
public class Invest_精准暴击 : InvestBuffData
{
	// Token: 0x06000142 RID: 322 RVA: 0x000055E0 File Offset: 0x000037E0
	[Token(Token = "0x6000142")]
	[Address(RVA = "0x3AD630", Offset = "0x3ABC30", VA = "0x1803AD630", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.精准暴击;
	}

	// Token: 0x06000143 RID: 323 RVA: 0x000055F4 File Offset: 0x000037F4
	[Token(Token = "0x6000143")]
	[Address(RVA = "0x3AD640", Offset = "0x3ABC40", VA = "0x1803AD640", Slot = "13")]
	public override string GetDescription()
	{
		return "我方小队的幸运一击率提高18%";
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00005608 File Offset: 0x00003808
	[Token(Token = "0x6000144")]
	[Address(RVA = "0x3AD670", Offset = "0x3ABC70", VA = "0x1803AD670", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float luckyStrike = instance.luckyStrike;
		instance.luckyStrike = luckyStrike;
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00005634 File Offset: 0x00003834
	[Token(Token = "0x6000145")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00005644 File Offset: 0x00003844
	[Token(Token = "0x6000146")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_精准暴击()
	{
	}
}
