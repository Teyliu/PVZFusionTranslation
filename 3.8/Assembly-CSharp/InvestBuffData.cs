using System;
using Cpp2IlInjected;

// Token: 0x02000034 RID: 52
[Token(Token = "0x2000034")]
public abstract class InvestBuffData : BaseBuff<InvestBuff>
{
	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060000E5 RID: 229 RVA: 0x00004AB0 File Offset: 0x00002CB0
	[Token(Token = "0x17000034")]
	public override InvestBuff BuffType
	{
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x3AADC0", Offset = "0x3A93C0", VA = "0x1803AADC0", Slot = "12")]
		get
		{
			return InvestBuff.完美开局;
		}
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00004AC8 File Offset: 0x00002CC8
	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "20")]
	public virtual InvestBuff GetBuffType()
	{
		return InvestBuff.完美开局;
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00004AE0 File Offset: 0x00002CE0
	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	protected InvestBuffData()
	{
	}
}
