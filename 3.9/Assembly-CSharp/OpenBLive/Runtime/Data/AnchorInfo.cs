using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E42 RID: 3650
	[Token(Token = "0x2000E42")]
	[Serializable]
	public struct AnchorInfo
	{
		// Token: 0x04003543 RID: 13635
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003543")]
		[JsonProperty("uid")]
		public long uid;

		// Token: 0x04003544 RID: 13636
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003544")]
		[JsonProperty("uname")]
		public string userName;

		// Token: 0x04003545 RID: 13637
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003545")]
		[JsonProperty("uface")]
		public string userFace;
	}
}
