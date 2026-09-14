using System;
using Cpp2IlInjected;

// Token: 0x02000456 RID: 1110
[Token(Token = "0x2000456")]
public class SunCaltrop : Caltrop
{
	// Token: 0x06001474 RID: 5236 RVA: 0x00071CD8 File Offset: 0x0006FED8
	[Token(Token = "0x6001474")]
	[Address(RVA = "0x4C79D0", Offset = "0x4C5FD0", VA = "0x1804C79D0", Slot = "71")]
	protected override void AnimAttack()
	{
		base.AnimAttack();
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06001475 RID: 5237 RVA: 0x00071CFC File Offset: 0x0006FEFC
	[Token(Token = "0x6001475")]
	[Address(RVA = "0x444D10", Offset = "0x443310", VA = "0x180444D10")]
	public SunCaltrop()
	{
	}
}
