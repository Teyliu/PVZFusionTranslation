using System;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000E04 RID: 3588
	[Token(Token = "0x2000E04")]
	public class WebSocketUnexpectedException : WebSocketException
	{
		// Token: 0x06004A1E RID: 18974 RVA: 0x0016D3C8 File Offset: 0x0016B5C8
		[Token(Token = "0x6004A1E")]
		[Address(RVA = "0x8DDB30", Offset = "0x8DC130", VA = "0x1808DDB30")]
		public WebSocketUnexpectedException()
		{
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x0016D3DC File Offset: 0x0016B5DC
		[Token(Token = "0x6004A1F")]
		[Address(RVA = "0x8DDAD0", Offset = "0x8DC0D0", VA = "0x1808DDAD0")]
		public WebSocketUnexpectedException(string message)
			: base(message)
		{
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x0016D3F0 File Offset: 0x0016B5F0
		[Token(Token = "0x6004A20")]
		[Address(RVA = "0x8DDA60", Offset = "0x8DC060", VA = "0x1808DDA60")]
		public WebSocketUnexpectedException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}
