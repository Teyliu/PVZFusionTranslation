using System;
using Cpp2IlInjected;

// Token: 0x02000062 RID: 98
[Token(Token = "0x2000062")]
public class Invest_幸运闪避 : InvestBuffData
{
	// Token: 0x060001A6 RID: 422 RVA: 0x000061A0 File Offset: 0x000043A0
	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x3F75A0", Offset = "0x3F5BA0", VA = "0x1803F75A0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.幸运闪避;
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060001A7 RID: 423 RVA: 0x000061B4 File Offset: 0x000043B4
	[Token(Token = "0x17000064")]
	public override string Description
	{
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x3F7610", Offset = "0x3F5C10", VA = "0x1803F7610", Slot = "13")]
		get
		{
			return "我方小队获得25%幸运一击率，受到攻击时，有等同于30%幸运一击率的概率使受到的伤害变为1";
		}
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x000061C8 File Offset: 0x000043C8
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x3F75B0", Offset = "0x3F5BB0", VA = "0x1803F75B0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float luckyStrike = instance.luckyStrike;
		instance.luckyStrike = luckyStrike;
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x000061F4 File Offset: 0x000043F4
	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00006204 File Offset: 0x00004404
	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_幸运闪避()
	{
	}
}
