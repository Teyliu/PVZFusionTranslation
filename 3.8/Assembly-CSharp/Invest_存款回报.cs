using System;
using Cpp2IlInjected;

// Token: 0x02000049 RID: 73
[Token(Token = "0x2000049")]
public class Invest_存款回报 : InvestBuffData
{
	// Token: 0x06000132 RID: 306 RVA: 0x000053E4 File Offset: 0x000035E4
	[Token(Token = "0x6000132")]
	[Address(RVA = "0x3AB4C0", Offset = "0x3A9AC0", VA = "0x1803AB4C0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.存款回报;
	}

	// Token: 0x06000133 RID: 307 RVA: 0x000053F4 File Offset: 0x000035F4
	[Token(Token = "0x6000133")]
	[Address(RVA = "0x3AB4D0", Offset = "0x3A9AD0", VA = "0x1803AB4D0", Slot = "13")]
	public override string GetDescription()
	{
		return "进入商店时，如果上一次进入商店没有购买东西，则获得6次额外刷新次数";
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00005408 File Offset: 0x00003608
	[Token(Token = "0x6000134")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_存款回报()
	{
	}
}
