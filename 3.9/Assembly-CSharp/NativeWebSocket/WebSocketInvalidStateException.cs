using System;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000E06 RID: 3590
	[Token(Token = "0x2000E06")]
	public class WebSocketInvalidStateException : WebSocketException
	{
		// Token: 0x06004A24 RID: 18980 RVA: 0x0016D448 File Offset: 0x0016B648
		[Token(Token = "0x6004A24")]
		[Address(RVA = "0x8DDB30", Offset = "0x8DC130", VA = "0x1808DDB30")]
		public WebSocketInvalidStateException()
		{
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x0016D45C File Offset: 0x0016B65C
		[Token(Token = "0x6004A25")]
		[Address(RVA = "0x8DDAD0", Offset = "0x8DC0D0", VA = "0x1808DDAD0")]
		public WebSocketInvalidStateException(string message)
			: base(message)
		{
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x0016D470 File Offset: 0x0016B670
		[Token(Token = "0x6004A26")]
		[Address(RVA = "0x8DDA60", Offset = "0x8DC060", VA = "0x1808DDA60")]
		public WebSocketInvalidStateException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}
