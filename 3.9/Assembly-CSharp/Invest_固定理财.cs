using System;
using Cpp2IlInjected;

// Token: 0x0200005B RID: 91
[Token(Token = "0x200005B")]
public class Invest_固定理财 : InvestBuffData
{
	// Token: 0x06000189 RID: 393 RVA: 0x00005E58 File Offset: 0x00004058
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x3F7020", Offset = "0x3F5620", VA = "0x1803F7020", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.固定理财;
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x0600018A RID: 394 RVA: 0x00005E6C File Offset: 0x0000406C
	[Token(Token = "0x17000060")]
	public override string Description
	{
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x3F70B0", Offset = "0x3F56B0", VA = "0x1803F70B0", Slot = "13")]
		get
		{
			return "现在以及每一轮开始，获得1500积分和1次额外刷新次数";
		}
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00005E80 File Offset: 0x00004080
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x3F7030", Offset = "0x3F5630", VA = "0x1803F7030", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num = 0;
		board.GetPoint(1500f, num != 0);
		TravelData data = TravelMgr.Instance.data;
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00005EB0 File Offset: 0x000040B0
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00005EC0 File Offset: 0x000040C0
	[Token(Token = "0x600018D")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_固定理财()
	{
	}
}
