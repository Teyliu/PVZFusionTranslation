using System;
using Cpp2IlInjected;

// Token: 0x02000070 RID: 112
[Token(Token = "0x2000070")]
public class Invest_淘宝积分 : InvestBuffData
{
	// Token: 0x060001E5 RID: 485 RVA: 0x0000683C File Offset: 0x00004A3C
	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x3F8BC0", Offset = "0x3F71C0", VA = "0x1803F8BC0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.淘宝积分;
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x060001E6 RID: 486 RVA: 0x00006850 File Offset: 0x00004A50
	[Token(Token = "0x1700006F")]
	public override string Description
	{
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x3F8BD0", Offset = "0x3F71D0", VA = "0x1803F8BD0", Slot = "13")]
		get
		{
			return "每次刷新，获得500积分";
		}
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x00006864 File Offset: 0x00004A64
	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_淘宝积分()
	{
	}
}
