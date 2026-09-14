using System;
using Cpp2IlInjected;

// Token: 0x0200006A RID: 106
[Token(Token = "0x200006A")]
public class Invest_积分大使飘飘 : InvestBuffData
{
	// Token: 0x060001CB RID: 459 RVA: 0x000065C8 File Offset: 0x000047C8
	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x3F91E0", Offset = "0x3F77E0", VA = "0x1803F91E0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.积分大使飘飘;
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060001CC RID: 460 RVA: 0x000065DC File Offset: 0x000047DC
	[Token(Token = "0x1700006A")]
	public override string Description
	{
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x3F9220", Offset = "0x3F7820", VA = "0x1803F9220", Slot = "13")]
		get
		{
			return "超稀有的飘飘登场！爆出超多积分！";
		}
	}

	// Token: 0x060001CD RID: 461 RVA: 0x000065F0 File Offset: 0x000047F0
	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x3F91F0", Offset = "0x3F77F0", VA = "0x1803F91F0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num = 0;
		board.GetPoint(20000f, num != 0);
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00006614 File Offset: 0x00004814
	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00006624 File Offset: 0x00004824
	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_积分大使飘飘()
	{
	}
}
