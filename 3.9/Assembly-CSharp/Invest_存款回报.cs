using System;
using Cpp2IlInjected;

// Token: 0x0200004D RID: 77
[Token(Token = "0x200004D")]
public class Invest_存款回报 : InvestBuffData
{
	// Token: 0x06000149 RID: 329 RVA: 0x00005668 File Offset: 0x00003868
	[Token(Token = "0x6000149")]
	[Address(RVA = "0x3F72C0", Offset = "0x3F58C0", VA = "0x1803F72C0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.存款回报;
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x0600014A RID: 330 RVA: 0x00005678 File Offset: 0x00003878
	[Token(Token = "0x17000054")]
	public override string Description
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x3F72D0", Offset = "0x3F58D0", VA = "0x1803F72D0", Slot = "13")]
		get
		{
			return "进入商店时，如果上一次进入商店没有购买东西，则获得6次额外刷新次数";
		}
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0000568C File Offset: 0x0000388C
	[Token(Token = "0x600014B")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_存款回报()
	{
	}
}
