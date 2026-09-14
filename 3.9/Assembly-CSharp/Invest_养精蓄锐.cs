using System;
using Cpp2IlInjected;

// Token: 0x02000071 RID: 113
[Token(Token = "0x2000071")]
public class Invest_养精蓄锐 : InvestBuffData
{
	// Token: 0x060001E8 RID: 488 RVA: 0x00006878 File Offset: 0x00004A78
	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x3F6E60", Offset = "0x3F5460", VA = "0x1803F6E60", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.养精蓄锐;
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000688C File Offset: 0x00004A8C
	[Token(Token = "0x17000070")]
	public override string Description
	{
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x3F6F10", Offset = "0x3F5510", VA = "0x1803F6F10", Slot = "13")]
		get
		{
			return "消耗你当前的全部积分，每消耗1000点积分，为全场植物永久提高1%幸运一击率";
		}
	}

	// Token: 0x060001EA RID: 490 RVA: 0x000068A0 File Offset: 0x00004AA0
	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x3F6E70", Offset = "0x3F5470", VA = "0x1803F6E70", Slot = "17")]
	public override void OnSelect(Board board)
	{
		board.thePoints = 0f;
		TravelData data = TravelMgr.Instance.data;
		float num2;
		float num = num2 * 0.01f;
		data.moreLuckyStrike = num;
	}

	// Token: 0x060001EB RID: 491 RVA: 0x000068DC File Offset: 0x00004ADC
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_养精蓄锐()
	{
	}
}
