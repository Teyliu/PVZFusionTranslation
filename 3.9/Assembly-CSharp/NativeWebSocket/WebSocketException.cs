using System;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000E03 RID: 3587
	[Token(Token = "0x2000E03")]
	public class WebSocketException : Exception
	{
		// Token: 0x06004A1B RID: 18971 RVA: 0x0016D388 File Offset: 0x0016B588
		[Token(Token = "0x6004A1B")]
		[Address(RVA = "0x8DDB30", Offset = "0x8DC130", VA = "0x1808DDB30")]
		public WebSocketException()
		{
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x0016D39C File Offset: 0x0016B59C
		[Token(Token = "0x6004A1C")]
		[Address(RVA = "0x8DDAD0", Offset = "0x8DC0D0", VA = "0x1808DDAD0")]
		public WebSocketException(string message)
			: base(message)
		{
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x0016D3B0 File Offset: 0x0016B5B0
		[Token(Token = "0x6004A1D")]
		[Address(RVA = "0x8DDA60", Offset = "0x8DC060", VA = "0x1808DDA60")]
		public WebSocketException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}
