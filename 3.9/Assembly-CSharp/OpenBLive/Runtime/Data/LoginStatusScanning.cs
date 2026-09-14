using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E52 RID: 3666
	[Token(Token = "0x2000E52")]
	public struct LoginStatusScanning
	{
		// Token: 0x0400358B RID: 13707
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400358B")]
		[JsonProperty("status")]
		public bool status;

		// Token: 0x0400358C RID: 13708
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400358C")]
		[JsonProperty("data")]
		public int data;

		// Token: 0x0400358D RID: 13709
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400358D")]
		[JsonProperty("message")]
		public string message;
	}
}
