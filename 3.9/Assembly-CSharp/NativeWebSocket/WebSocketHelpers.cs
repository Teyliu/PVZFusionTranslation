using System;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000E02 RID: 3586
	[Token(Token = "0x2000E02")]
	public static class WebSocketHelpers
	{
		// Token: 0x06004A19 RID: 18969 RVA: 0x0016D2E4 File Offset: 0x0016B4E4
		[Token(Token = "0x6004A19")]
		[Address(RVA = "0x8DDEA0", Offset = "0x8DC4A0", VA = "0x1808DDEA0")]
		public static WebSocketCloseCode ParseCloseCodeEnum(int closeCode)
		{
			Type typeFromHandle = typeof(WebSocketCloseCode);
			bool flag = Enum.IsDefined(typeFromHandle, typeFromHandle);
			return WebSocketCloseCode.Undefined;
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x0016D30C File Offset: 0x0016B50C
		[Token(Token = "0x6004A1A")]
		[Address(RVA = "0x8DDBE0", Offset = "0x8DC1E0", VA = "0x1808DDBE0")]
		public static WebSocketException GetErrorMessageFromCode(int errorCode, Exception inner)
		{
			if ("WebSocket is already closed." <= (ulong)6L)
			{
				WebSocketInvalidArgumentException ex = new WebSocketInvalidArgumentException("WebSocket is not in open state.", inner);
				WebSocketInvalidStateException ex2 = new WebSocketInvalidStateException("WebSocket is not in open state.", inner);
				WebSocketInvalidStateException ex3 = new WebSocketInvalidStateException("WebSocket is already closed.", inner);
				WebSocketInvalidStateException ex4 = new WebSocketInvalidStateException("WebSocket is already closing.", inner);
				WebSocketInvalidStateException ex5 = new WebSocketInvalidStateException("WebSocket is not connected.", inner);
				WebSocketInvalidStateException ex6 = new WebSocketInvalidStateException("WebSocket is already connected or in connecting state.", inner);
				WebSocketUnexpectedException ex7 = new WebSocketUnexpectedException("WebSocket instance not found.", inner);
			}
			WebSocketUnexpectedException ex8 = new WebSocketUnexpectedException("Unknown error.", inner);
			return null;
		}
	}
}
