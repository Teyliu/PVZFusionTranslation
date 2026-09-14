using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x0200035A RID: 858
[Token(Token = "0x200035A")]
public class BloverPot : Pot
{
	// Token: 0x06000FC1 RID: 4033 RVA: 0x0005AB60 File Offset: 0x00058D60
	[Token(Token = "0x6000FC1")]
	[Address(RVA = "0x472BC0", Offset = "0x4711C0", VA = "0x180472BC0", Slot = "15")]
	protected override void Start()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x0005AB80 File Offset: 0x00058D80
	[Token(Token = "0x6000FC2")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public BloverPot()
	{
	}
}
