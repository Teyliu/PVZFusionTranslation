using System;
using Cpp2IlInjected;

// Token: 0x0200003E RID: 62
[Token(Token = "0x200003E")]
public class Invest_恢复生机 : InvestBuffData
{
	// Token: 0x0600010B RID: 267 RVA: 0x00004FC4 File Offset: 0x000031C4
	[Token(Token = "0x600010B")]
	[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.恢复生机;
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00004FD4 File Offset: 0x000031D4
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x3ABC10", Offset = "0x3AA210", VA = "0x1803ABC10", Slot = "13")]
	public override string GetDescription()
	{
		return "每有一个领袖僵尸死亡，全体植物回复10%最大生命值";
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00004FE8 File Offset: 0x000031E8
	[Token(Token = "0x600010D")]
	[Address(RVA = "0x3ABC40", Offset = "0x3AA240", VA = "0x1803ABC40", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (Invest_恢复生机.<>c.<>9__2_0 == 0)
		{
			Action<object> action;
			Invest_恢复生机.<>c.<>9__2_0 = action;
		}
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00005004 File Offset: 0x00003204
	[Token(Token = "0x600010E")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_恢复生机()
	{
	}
}
