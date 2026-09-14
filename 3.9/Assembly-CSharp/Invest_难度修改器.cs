using System;
using Cpp2IlInjected;

// Token: 0x02000045 RID: 69
[Token(Token = "0x2000045")]
public class Invest_难度修改器 : InvestBuffData
{
	// Token: 0x0600012C RID: 300 RVA: 0x00005330 File Offset: 0x00003530
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.难度修改器;
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x0600012D RID: 301 RVA: 0x00005340 File Offset: 0x00003540
	[Token(Token = "0x1700004F")]
	public override string Description
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x3FA3E0", Offset = "0x3F89E0", VA = "0x1803FA3E0", Slot = "13")]
		get
		{
			return "领袖僵尸的血量降低10%";
		}
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00005354 File Offset: 0x00003554
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_难度修改器()
	{
	}
}
