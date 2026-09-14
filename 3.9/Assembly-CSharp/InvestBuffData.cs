using System;
using Cpp2IlInjected;

// Token: 0x02000038 RID: 56
[Token(Token = "0x2000038")]
public abstract class InvestBuffData : BaseBuff<InvestBuff>
{
	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060000FC RID: 252 RVA: 0x00004D40 File Offset: 0x00002F40
	[Token(Token = "0x17000047")]
	public override InvestBuff BuffType
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x3F6BC0", Offset = "0x3F51C0", VA = "0x1803F6BC0", Slot = "12")]
		get
		{
			return InvestBuff.完美开局;
		}
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00004D58 File Offset: 0x00002F58
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "20")]
	public virtual InvestBuff GetBuffType()
	{
		return InvestBuff.完美开局;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00004D70 File Offset: 0x00002F70
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	protected InvestBuffData()
	{
	}
}
