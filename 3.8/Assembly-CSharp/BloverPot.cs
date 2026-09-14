using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x0200034A RID: 842
[Token(Token = "0x200034A")]
public class BloverPot : Pot
{
	// Token: 0x06000F75 RID: 3957 RVA: 0x00059C00 File Offset: 0x00057E00
	[Token(Token = "0x6000F75")]
	[Address(RVA = "0x41BD20", Offset = "0x41A320", VA = "0x18041BD20", Slot = "15")]
	protected override void Start()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x00059C20 File Offset: 0x00057E20
	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public BloverPot()
	{
	}
}
