using System;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000E05 RID: 3589
	[Token(Token = "0x2000E05")]
	public class WebSocketInvalidArgumentException : WebSocketException
	{
		// Token: 0x06004A21 RID: 18977 RVA: 0x0016D408 File Offset: 0x0016B608
		[Token(Token = "0x6004A21")]
		[Address(RVA = "0x8DDB30", Offset = "0x8DC130", VA = "0x1808DDB30")]
		public WebSocketInvalidArgumentException()
		{
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x0016D41C File Offset: 0x0016B61C
		[Token(Token = "0x6004A22")]
		[Address(RVA = "0x8DDAD0", Offset = "0x8DC0D0", VA = "0x1808DDAD0")]
		public WebSocketInvalidArgumentException(string message)
			: base(message)
		{
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x0016D430 File Offset: 0x0016B630
		[Token(Token = "0x6004A23")]
		[Address(RVA = "0x8DDA60", Offset = "0x8DC060", VA = "0x1808DDA60")]
		public WebSocketInvalidArgumentException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}
