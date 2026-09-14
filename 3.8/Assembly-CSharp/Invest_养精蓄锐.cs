using System;
using Cpp2IlInjected;

// Token: 0x0200006D RID: 109
[Token(Token = "0x200006D")]
public class Invest_养精蓄锐 : InvestBuffData
{
	// Token: 0x060001D1 RID: 465 RVA: 0x000065DC File Offset: 0x000047DC
	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x3AB060", Offset = "0x3A9660", VA = "0x1803AB060", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.养精蓄锐;
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x000065F0 File Offset: 0x000047F0
	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x3AB070", Offset = "0x3A9670", VA = "0x1803AB070", Slot = "13")]
	public override string GetDescription()
	{
		return "消耗你当前的全部积分，每消耗1000点积分，为全场植物永久提高1%幸运一击率";
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00006604 File Offset: 0x00004804
	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x3AB0A0", Offset = "0x3A96A0", VA = "0x1803AB0A0", Slot = "17")]
	public override void OnSelect(Board board)
	{
		board.thePoints = 0f;
		TravelData data = TravelMgr.Instance.data;
		float num2;
		float num = num2 * 0.01f;
		data.moreLuckyStrike = num;
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00006640 File Offset: 0x00004840
	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_养精蓄锐()
	{
	}
}
