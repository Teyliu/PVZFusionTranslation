using System;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000E10 RID: 3600
	[Token(Token = "0x2000E10")]
	public static class WebSocketFactory
	{
		// Token: 0x06004A4E RID: 19022 RVA: 0x0016E3F8 File Offset: 0x0016C5F8
		[Token(Token = "0x6004A4E")]
		[Address(RVA = "0x8DDB80", Offset = "0x8DC180", VA = "0x1808DDB80")]
		public static WebSocket CreateInstance(string url)
		{
			int num;
			WebSocket webSocket = new WebSocket(url, num);
			num = 0;
			return webSocket;
		}
	}
}
