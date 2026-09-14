using System;
using Cpp2IlInjected;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E5D RID: 3677
	[Token(Token = "0x2000E5D")]
	public struct WebsocketInfo
	{
		// Token: 0x040035CB RID: 13771
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40035CB")]
		public int code;

		// Token: 0x040035CC RID: 13772
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40035CC")]
		public string message;

		// Token: 0x040035CD RID: 13773
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40035CD")]
		public WebsocketInfoData data;
	}
}
