using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E5C RID: 3676
	[Token(Token = "0x2000E5C")]
	[Serializable]
	public struct UserInfo
	{
		// Token: 0x040035C7 RID: 13767
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40035C7")]
		[JsonProperty("uid")]
		public long uid;

		// Token: 0x040035C8 RID: 13768
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40035C8")]
		[JsonProperty("open_id")]
		public string openId;

		// Token: 0x040035C9 RID: 13769
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40035C9")]
		[JsonProperty("uname")]
		public string userName;

		// Token: 0x040035CA RID: 13770
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40035CA")]
		[JsonProperty("uface")]
		public string userFace;
	}
}
