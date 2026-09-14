using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E53 RID: 3667
	[Token(Token = "0x2000E53")]
	public struct LoginUrl
	{
		// Token: 0x0400358E RID: 13710
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400358E")]
		[JsonProperty("data")]
		public LoginUrlData data;

		// Token: 0x0400358F RID: 13711
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400358F")]
		[JsonProperty("status")]
		public bool status;
	}
}
