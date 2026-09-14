using System;
using Cpp2IlInjected;

// Token: 0x020008A9 RID: 2217
[Token(Token = "0x20008A9")]
public interface IClickable
{
	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x06002D1E RID: 11550
	[Token(Token = "0x170001C5")]
	int Priority
	{
		[Token(Token = "0x6002D1E")]
		[Address(Slot = "0")]
		get;
	}

	// Token: 0x06002D1F RID: 11551
	[Token(Token = "0x6002D1F")]
	[Address(Slot = "1")]
	bool OnClick(Mouse mouse);
}
