using System;
using Cpp2IlInjected;

// Token: 0x02000042 RID: 66
[Token(Token = "0x2000042")]
public class Invest_恢复生机 : InvestBuffData
{
	// Token: 0x06000122 RID: 290 RVA: 0x00005240 File Offset: 0x00003440
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.恢复生机;
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06000123 RID: 291 RVA: 0x00005250 File Offset: 0x00003450
	[Token(Token = "0x1700004D")]
	public override string Description
	{
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x3F7B30", Offset = "0x3F6130", VA = "0x1803F7B30", Slot = "13")]
		get
		{
			return "每有一个领袖僵尸死亡，全体植物回复10%最大生命值";
		}
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00005264 File Offset: 0x00003464
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x3F7A10", Offset = "0x3F6010", VA = "0x1803F7A10", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (Invest_恢复生机.<>c.<>9__3_0 == 0)
		{
			Action<object> action;
			Invest_恢复生机.<>c.<>9__3_0 = action;
		}
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00005280 File Offset: 0x00003480
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_恢复生机()
	{
	}
}
