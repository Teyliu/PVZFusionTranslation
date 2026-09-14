using System;
using Cpp2IlInjected;

// Token: 0x02000051 RID: 81
[Token(Token = "0x2000051")]
public class Invest_精准暴击 : InvestBuffData
{
	// Token: 0x06000159 RID: 345 RVA: 0x00005864 File Offset: 0x00003A64
	[Token(Token = "0x6000159")]
	[Address(RVA = "0x3F94A0", Offset = "0x3F7AA0", VA = "0x1803F94A0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.精准暴击;
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x0600015A RID: 346 RVA: 0x00005878 File Offset: 0x00003A78
	[Token(Token = "0x17000058")]
	public override string Description
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x3F9510", Offset = "0x3F7B10", VA = "0x1803F9510", Slot = "13")]
		get
		{
			return "我方小队的幸运一击率提高18%";
		}
	}

	// Token: 0x0600015B RID: 347 RVA: 0x0000588C File Offset: 0x00003A8C
	[Token(Token = "0x600015B")]
	[Address(RVA = "0x3F94B0", Offset = "0x3F7AB0", VA = "0x1803F94B0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float luckyStrike = instance.luckyStrike;
		instance.luckyStrike = luckyStrike;
	}

	// Token: 0x0600015C RID: 348 RVA: 0x000058B8 File Offset: 0x00003AB8
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x0600015D RID: 349 RVA: 0x000058C8 File Offset: 0x00003AC8
	[Token(Token = "0x600015D")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_精准暴击()
	{
	}
}
