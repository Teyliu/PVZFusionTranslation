using System;
using Cpp2IlInjected;

// Token: 0x0200005A RID: 90
[Token(Token = "0x200005A")]
public class Invest_沙里淘金 : InvestBuffData
{
	// Token: 0x0600017F RID: 383 RVA: 0x00005D58 File Offset: 0x00003F58
	[Token(Token = "0x600017F")]
	[Address(RVA = "0x3A7340", Offset = "0x3A5940", VA = "0x1803A7340", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.沙里淘金;
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00005D6C File Offset: 0x00003F6C
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x3ACC00", Offset = "0x3AB200", VA = "0x1803ACC00", Slot = "13")]
	public override string GetDescription()
	{
		return "每次融合，获得一个随机礼盒";
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00005D80 File Offset: 0x00003F80
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x3ACC30", Offset = "0x3AB230", VA = "0x1803ACC30", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (Invest_沙里淘金.<>c.<>9__2_0 == 0)
		{
			Action<object> action;
			Invest_沙里淘金.<>c.<>9__2_0 = action;
		}
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00005D9C File Offset: 0x00003F9C
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00005DAC File Offset: 0x00003FAC
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_沙里淘金()
	{
	}
}
