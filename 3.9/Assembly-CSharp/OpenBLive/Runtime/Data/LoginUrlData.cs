using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E54 RID: 3668
	[Token(Token = "0x2000E54")]
	public struct LoginUrlData
	{
		// Token: 0x04003590 RID: 13712
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003590")]
		[JsonProperty("oauthKey")]
		public string oauthKey;

		// Token: 0x04003591 RID: 13713
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003591")]
		[JsonProperty("url")]
		public string url;
	}
}
