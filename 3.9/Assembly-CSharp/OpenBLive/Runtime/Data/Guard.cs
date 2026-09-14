using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E4C RID: 3660
	[Token(Token = "0x2000E4C")]
	[Serializable]
	public struct Guard
	{
		// Token: 0x0400356A RID: 13674
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400356A")]
		[JsonProperty("guard_level")]
		public long guardLevel;

		// Token: 0x0400356B RID: 13675
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400356B")]
		[JsonProperty("guard_num")]
		public long guardNum;

		// Token: 0x0400356C RID: 13676
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400356C")]
		[JsonProperty("guard_unit")]
		public string guardUnit;

		// Token: 0x0400356D RID: 13677
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400356D")]
		[JsonProperty("fans_medal_level")]
		public long fansMedalLevel;

		// Token: 0x0400356E RID: 13678
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400356E")]
		[JsonProperty("fans_medal_name")]
		public string fansMedalName;

		// Token: 0x0400356F RID: 13679
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400356F")]
		[JsonProperty("fans_medal_wearing_status")]
		public bool fansMedalWearingStatus;

		// Token: 0x04003570 RID: 13680
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003570")]
		[JsonProperty("user_info")]
		public UserInfo userInfo;

		// Token: 0x04003571 RID: 13681
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003571")]
		[JsonProperty("room_id")]
		public long roomID;
	}
}
