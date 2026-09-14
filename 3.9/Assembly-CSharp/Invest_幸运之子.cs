using System;
using Cpp2IlInjected;

// Token: 0x02000069 RID: 105
[Token(Token = "0x2000069")]
public class Invest_幸运之子 : InvestBuffData
{
	// Token: 0x060001C5 RID: 453 RVA: 0x00006518 File Offset: 0x00004718
	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x3F7470", Offset = "0x3F5A70", VA = "0x1803F7470", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.幸运之子;
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000652C File Offset: 0x0000472C
	[Token(Token = "0x17000069")]
	public override string Description
	{
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x3F7570", Offset = "0x3F5B70", VA = "0x1803F7570", Slot = "13")]
		get
		{
			return "我方小队的幸运一击率提高30%，当幸运一击率达到100%以上时，幸运一击伤害增加40%";
		}
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00006540 File Offset: 0x00004740
	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x3F7510", Offset = "0x3F5B10", VA = "0x1803F7510", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float luckyStrike = instance.luckyStrike;
		instance.luckyStrike = luckyStrike;
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x0000656C File Offset: 0x0000476C
	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x3F7480", Offset = "0x3F5A80", VA = "0x1803F7480", Slot = "16")]
	public override void OnBoardLateStart(Board board)
	{
		float luckyStrike = TravelMgr.Instance.luckyStrike;
		TravelMgr instance = TravelMgr.Instance;
		float luckyDamage = instance.luckyDamage;
		instance.luckyDamage = luckyDamage;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x000065A4 File Offset: 0x000047A4
	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001CA RID: 458 RVA: 0x000065B4 File Offset: 0x000047B4
	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_幸运之子()
	{
	}
}
