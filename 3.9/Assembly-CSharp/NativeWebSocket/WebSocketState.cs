using System;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000E00 RID: 3584
	[Token(Token = "0x2000E00")]
	public enum WebSocketState
	{
		// Token: 0x0400347C RID: 13436
		[Token(Token = "0x400347C")]
		Connecting,
		// Token: 0x0400347D RID: 13437
		[Token(Token = "0x400347D")]
		Open,
		// Token: 0x0400347E RID: 13438
		[Token(Token = "0x400347E")]
		Closing,
		// Token: 0x0400347F RID: 13439
		[Token(Token = "0x400347F")]
		Closed
	}
}
