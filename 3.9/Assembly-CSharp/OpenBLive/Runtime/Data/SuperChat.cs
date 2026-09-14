using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E5A RID: 3674
	[Token(Token = "0x2000E5A")]
	[Serializable]
	public struct SuperChat
	{
		// Token: 0x040035B6 RID: 13750
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40035B6")]
		[JsonProperty("room_id")]
		public long roomId;

		// Token: 0x040035B7 RID: 13751
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40035B7")]
		[JsonProperty("uid")]
		public long uid;

		// Token: 0x040035B8 RID: 13752
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40035B8")]
		[JsonProperty("open_id")]
		public string openId;

		// Token: 0x040035B9 RID: 13753
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40035B9")]
		[JsonProperty("uname")]
		public string userName;

		// Token: 0x040035BA RID: 13754
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40035BA")]
		[JsonProperty("uface")]
		public string userFace;

		// Token: 0x040035BB RID: 13755
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40035BB")]
		[JsonProperty("message_id")]
		public long messageId;

		// Token: 0x040035BC RID: 13756
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40035BC")]
		[JsonProperty("message")]
		public string message;

		// Token: 0x040035BD RID: 13757
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40035BD")]
		[JsonProperty("rmb")]
		public long rmb;

		// Token: 0x040035BE RID: 13758
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40035BE")]
		[JsonProperty("timestamp")]
		public long timeStamp;

		// Token: 0x040035BF RID: 13759
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40035BF")]
		[JsonProperty("start_time")]
		public long startTime;

		// Token: 0x040035C0 RID: 13760
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40035C0")]
		[JsonProperty("end_time")]
		public long endTime;

		// Token: 0x040035C1 RID: 13761
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40035C1")]
		[JsonProperty("guard_level")]
		public long guardLevel;

		// Token: 0x040035C2 RID: 13762
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40035C2")]
		[JsonProperty("fans_medal_level")]
		public long fansMedalLevel;

		// Token: 0x040035C3 RID: 13763
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40035C3")]
		[JsonProperty("fans_medal_name")]
		public string fansMedalName;

		// Token: 0x040035C4 RID: 13764
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40035C4")]
		[JsonProperty("fans_medal_wearing_status")]
		public bool fansMedalWearingStatus;
	}
}
