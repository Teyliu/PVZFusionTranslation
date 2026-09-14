using System;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000E01 RID: 3585
	[Token(Token = "0x2000E01")]
	public interface IWebSocket
	{
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06004A10 RID: 18960
		// (remove) Token: 0x06004A11 RID: 18961
		[Token(Token = "0x14000013")]
		event WebSocketOpenEventHandler OnOpen;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06004A12 RID: 18962
		// (remove) Token: 0x06004A13 RID: 18963
		[Token(Token = "0x14000014")]
		event WebSocketMessageEventHandler OnMessage;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06004A14 RID: 18964
		// (remove) Token: 0x06004A15 RID: 18965
		[Token(Token = "0x14000015")]
		event WebSocketErrorEventHandler OnError;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06004A16 RID: 18966
		// (remove) Token: 0x06004A17 RID: 18967
		[Token(Token = "0x14000016")]
		event WebSocketCloseEventHandler OnClose;

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06004A18 RID: 18968
		[Token(Token = "0x17000968")]
		WebSocketState State
		{
			[Token(Token = "0x6004A18")]
			[Address(Slot = "8")]
			get;
		}
	}
}
