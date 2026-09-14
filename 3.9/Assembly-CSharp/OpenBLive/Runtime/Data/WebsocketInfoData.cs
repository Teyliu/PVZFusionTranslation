using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E5E RID: 3678
	[Token(Token = "0x2000E5E")]
	public struct WebsocketInfoData
	{
		// Token: 0x040035CE RID: 13774
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40035CE")]
		[JsonProperty("ip")]
		public List<string> ip;

		// Token: 0x040035CF RID: 13775
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40035CF")]
		[JsonProperty("host")]
		public List<string> host;

		// Token: 0x040035D0 RID: 13776
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40035D0")]
		[JsonProperty("auth_body")]
		public string authBody;

		// Token: 0x040035D1 RID: 13777
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40035D1")]
		[JsonProperty("tcp_port")]
		public List<int> tcpPort;

		// Token: 0x040035D2 RID: 13778
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40035D2")]
		[JsonProperty("ws_port")]
		public List<int> wsPort;

		// Token: 0x040035D3 RID: 13779
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40035D3")]
		[JsonProperty("wss_port")]
		public List<int> wssPort;
	}
}
