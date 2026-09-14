using System;
using Cpp2IlInjected;

// Token: 0x020008E5 RID: 2277
[Token(Token = "0x20008E5")]
public interface IClickable
{
	// Token: 0x1700020D RID: 525
	// (get) Token: 0x06002E51 RID: 11857
	[Token(Token = "0x1700020D")]
	int Priority
	{
		[Token(Token = "0x6002E51")]
		[Address(Slot = "0")]
		get;
	}

	// Token: 0x06002E52 RID: 11858
	[Token(Token = "0x6002E52")]
	[Address(Slot = "1")]
	bool OnClick(Mouse mouse);
}
