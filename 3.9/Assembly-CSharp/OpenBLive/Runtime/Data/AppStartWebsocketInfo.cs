using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E46 RID: 3654
	[Token(Token = "0x2000E46")]
	public class AppStartWebsocketInfo
	{
		// Token: 0x06004B53 RID: 19283 RVA: 0x00172380 File Offset: 0x00170580
		[Token(Token = "0x6004B53")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public AppStartWebsocketInfo()
		{
		}

		// Token: 0x0400354D RID: 13645
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400354D")]
		[JsonProperty("auth_body")]
		public string AuthBody;

		// Token: 0x0400354E RID: 13646
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400354E")]
		[JsonProperty("wss_link")]
		public List<string> WssLink;
	}
}
