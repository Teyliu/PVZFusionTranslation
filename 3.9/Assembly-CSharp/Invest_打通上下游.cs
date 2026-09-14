using System;
using Cpp2IlInjected;

// Token: 0x02000059 RID: 89
[Token(Token = "0x2000059")]
public class Invest_打通上下游 : InvestBuffData
{
	// Token: 0x0600017E RID: 382 RVA: 0x00005D1C File Offset: 0x00003F1C
	[Token(Token = "0x600017E")]
	[Address(RVA = "0x3F7B60", Offset = "0x3F6160", VA = "0x1803F7B60", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.打通上下游;
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x0600017F RID: 383 RVA: 0x00005D30 File Offset: 0x00003F30
	[Token(Token = "0x1700005E")]
	public override string Description
	{
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x3F7C00", Offset = "0x3F6200", VA = "0x1803F7C00", Slot = "13")]
		get
		{
			return "我方小队获得10%幸运一击率，每一轮开始时，幸运一击率额外提高1%";
		}
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00005D44 File Offset: 0x00003F44
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x3F7B70", Offset = "0x3F6170", VA = "0x1803F7B70", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float luckyStrike = instance.luckyStrike;
		instance.luckyStrike = luckyStrike;
		TravelData data = TravelMgr.Instance.data;
		float moreLuckyStrike = data.moreLuckyStrike;
		data.moreLuckyStrike = moreLuckyStrike;
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00005D90 File Offset: 0x00003F90
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00005DA0 File Offset: 0x00003FA0
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_打通上下游()
	{
	}
}
