using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E4E RID: 3662
	[Token(Token = "0x2000E4E")]
	[Serializable]
	public struct LiveEnd
	{
		// Token: 0x0400357D RID: 13693
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400357D")]
		[JsonProperty("open_id")]
		public string open_id;

		// Token: 0x0400357E RID: 13694
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400357E")]
		[JsonProperty("timestamp")]
		public long timestamp;

		// Token: 0x0400357F RID: 13695
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400357F")]
		[JsonProperty("room_id")]
		public long room_id;

		// Token: 0x04003580 RID: 13696
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003580")]
		[JsonProperty("title")]
		public string title;

		// Token: 0x04003581 RID: 13697
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003581")]
		[JsonProperty("area_id")]
		public long area_id;
	}
}
