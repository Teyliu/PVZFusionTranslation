using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E49 RID: 3657
	[Token(Token = "0x2000E49")]
	[Serializable]
	public struct Dm
	{
		// Token: 0x04003559 RID: 13657
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003559")]
		[JsonProperty("uid")]
		public long uid;

		// Token: 0x0400355A RID: 13658
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400355A")]
		[JsonProperty("open_id")]
		public string openId;

		// Token: 0x0400355B RID: 13659
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400355B")]
		[JsonProperty("uname")]
		public string userName;

		// Token: 0x0400355C RID: 13660
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400355C")]
		[JsonProperty("uface")]
		public string userFace;

		// Token: 0x0400355D RID: 13661
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400355D")]
		[JsonProperty("timestamp")]
		public long timestamp;

		// Token: 0x0400355E RID: 13662
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400355E")]
		[JsonProperty("msg")]
		public string msg;

		// Token: 0x0400355F RID: 13663
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400355F")]
		[JsonProperty("fans_medal_level")]
		public long fansMedalLevel;

		// Token: 0x04003560 RID: 13664
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003560")]
		[JsonProperty("fans_medal_name")]
		public string fansMedalName;

		// Token: 0x04003561 RID: 13665
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003561")]
		[JsonProperty("fans_medal_wearing_status")]
		public bool fansMedalWearingStatus;

		// Token: 0x04003562 RID: 13666
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003562")]
		[JsonProperty("guard_level")]
		public long guardLevel;

		// Token: 0x04003563 RID: 13667
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003563")]
		[JsonProperty("room_id")]
		public long roomId;
	}
}
