using System;
using Cpp2IlInjected;

// Token: 0x02000055 RID: 85
[Token(Token = "0x2000055")]
public class Invest_打通上下游 : InvestBuffData
{
	// Token: 0x06000167 RID: 359 RVA: 0x00005A98 File Offset: 0x00003C98
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x3ABD60", Offset = "0x3AA360", VA = "0x1803ABD60", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.打通上下游;
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00005AAC File Offset: 0x00003CAC
	[Token(Token = "0x6000168")]
	[Address(RVA = "0x3ABD70", Offset = "0x3AA370", VA = "0x1803ABD70", Slot = "13")]
	public override string GetDescription()
	{
		return "我方小队获得10%幸运一击率，每一轮开始时，幸运一击率额外提高1%";
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00005AC0 File Offset: 0x00003CC0
	[Token(Token = "0x6000169")]
	[Address(RVA = "0x3ABDA0", Offset = "0x3AA3A0", VA = "0x1803ABDA0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float luckyStrike = instance.luckyStrike;
		instance.luckyStrike = luckyStrike;
		TravelData data = TravelMgr.Instance.data;
		float moreLuckyStrike = data.moreLuckyStrike;
		data.moreLuckyStrike = moreLuckyStrike;
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00005B0C File Offset: 0x00003D0C
	[Token(Token = "0x600016A")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00005B1C File Offset: 0x00003D1C
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_打通上下游()
	{
	}
}
