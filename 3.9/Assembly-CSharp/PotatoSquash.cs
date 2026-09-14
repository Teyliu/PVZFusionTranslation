using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200041E RID: 1054
[Token(Token = "0x200041E")]
public class PotatoSquash : Squash
{
	// Token: 0x1700013A RID: 314
	// (get) Token: 0x0600136A RID: 4970 RVA: 0x0006CB04 File Offset: 0x0006AD04
	[Token(Token = "0x1700013A")]
	protected override Vector2 Range
	{
		[Token(Token = "0x600136A")]
		[Address(RVA = "0x47D250", Offset = "0x47B850", VA = "0x18047D250", Slot = "68")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x0006CB1C File Offset: 0x0006AD1C
	[Token(Token = "0x600136B")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public PotatoSquash()
	{
	}
}
