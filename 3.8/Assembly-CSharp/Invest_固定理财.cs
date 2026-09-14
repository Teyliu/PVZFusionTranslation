using System;
using Cpp2IlInjected;

// Token: 0x02000057 RID: 87
[Token(Token = "0x2000057")]
public class Invest_固定理财 : InvestBuffData
{
	// Token: 0x06000172 RID: 370 RVA: 0x00005BD4 File Offset: 0x00003DD4
	[Token(Token = "0x6000172")]
	[Address(RVA = "0x3AB220", Offset = "0x3A9820", VA = "0x1803AB220", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.固定理财;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00005BE8 File Offset: 0x00003DE8
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x3AB230", Offset = "0x3A9830", VA = "0x1803AB230", Slot = "13")]
	public override string GetDescription()
	{
		return "现在以及每一轮开始，获得1500积分和1次额外刷新次数";
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00005BFC File Offset: 0x00003DFC
	[Token(Token = "0x6000174")]
	[Address(RVA = "0x3AB260", Offset = "0x3A9860", VA = "0x1803AB260", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num = 0;
		board.GetPoint(1500f, num != 0);
		TravelData data = TravelMgr.Instance.data;
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00005C2C File Offset: 0x00003E2C
	[Token(Token = "0x6000175")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00005C3C File Offset: 0x00003E3C
	[Token(Token = "0x6000176")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_固定理财()
	{
	}
}
