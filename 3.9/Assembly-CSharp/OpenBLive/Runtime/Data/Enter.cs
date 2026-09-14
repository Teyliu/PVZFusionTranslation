using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E4A RID: 3658
	[Token(Token = "0x2000E4A")]
	[Serializable]
	public struct Enter
	{
		// Token: 0x04003564 RID: 13668
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003564")]
		[JsonProperty("uname")]
		public string uname;

		// Token: 0x04003565 RID: 13669
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003565")]
		[JsonProperty("open_id")]
		public string open_id;

		// Token: 0x04003566 RID: 13670
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003566")]
		[JsonProperty("uface")]
		public string uface;

		// Token: 0x04003567 RID: 13671
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003567")]
		[JsonProperty("timestamp")]
		public long timestamp;

		// Token: 0x04003568 RID: 13672
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003568")]
		[JsonProperty("room_id")]
		public long room_id;
	}
}
