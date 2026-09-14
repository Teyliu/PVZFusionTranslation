using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000403 RID: 1027
[Token(Token = "0x2000403")]
public class PotatoSquash : Squash
{
	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x060012F4 RID: 4852 RVA: 0x0006ACD0 File Offset: 0x00068ED0
	[Token(Token = "0x170000F6")]
	protected override Vector2 Range
	{
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x426560", Offset = "0x424B60", VA = "0x180426560", Slot = "69")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x0006ACE8 File Offset: 0x00068EE8
	[Token(Token = "0x60012F5")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public PotatoSquash()
	{
	}
}
