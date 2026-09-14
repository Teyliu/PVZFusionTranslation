using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E51 RID: 3665
	[Token(Token = "0x2000E51")]
	public struct LoginStatusReady
	{
		// Token: 0x04003588 RID: 13704
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003588")]
		[JsonProperty("code")]
		public int code;

		// Token: 0x04003589 RID: 13705
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4003589")]
		[JsonProperty("status")]
		public bool status;

		// Token: 0x0400358A RID: 13706
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400358A")]
		[JsonProperty("data")]
		public LoginStatusData data;
	}
}
