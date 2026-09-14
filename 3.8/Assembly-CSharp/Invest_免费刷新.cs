using System;
using Cpp2IlInjected;

// Token: 0x0200004A RID: 74
[Token(Token = "0x200004A")]
public class Invest_免费刷新 : InvestBuffData
{
	// Token: 0x06000135 RID: 309 RVA: 0x0000541C File Offset: 0x0000361C
	[Token(Token = "0x6000135")]
	[Address(RVA = "0x3AAFC0", Offset = "0x3A95C0", VA = "0x1803AAFC0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.免费刷新;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x0000542C File Offset: 0x0000362C
	[Token(Token = "0x6000136")]
	[Address(RVA = "0x3AAFD0", Offset = "0x3A95D0", VA = "0x1803AAFD0", Slot = "13")]
	public override string GetDescription()
	{
		return "获得11次额外刷新次数";
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00005440 File Offset: 0x00003640
	[Token(Token = "0x6000137")]
	[Address(RVA = "0x3AB000", Offset = "0x3A9600", VA = "0x1803AB000", Slot = "17")]
	public override void OnSelect(Board board)
	{
		TravelData data = TravelMgr.Instance.data;
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00005460 File Offset: 0x00003660
	[Token(Token = "0x6000138")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_免费刷新()
	{
	}
}
