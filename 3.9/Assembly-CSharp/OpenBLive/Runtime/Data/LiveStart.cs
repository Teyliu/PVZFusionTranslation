using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E4F RID: 3663
	[Token(Token = "0x2000E4F")]
	[Serializable]
	public struct LiveStart
	{
		// Token: 0x04003582 RID: 13698
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003582")]
		[JsonProperty("open_id")]
		public string open_id;

		// Token: 0x04003583 RID: 13699
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003583")]
		[JsonProperty("timestamp")]
		public long timestamp;

		// Token: 0x04003584 RID: 13700
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003584")]
		[JsonProperty("room_id")]
		public long room_id;

		// Token: 0x04003585 RID: 13701
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003585")]
		[JsonProperty("title")]
		public string title;

		// Token: 0x04003586 RID: 13702
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003586")]
		[JsonProperty("area_id")]
		public long area_id;
	}
}
