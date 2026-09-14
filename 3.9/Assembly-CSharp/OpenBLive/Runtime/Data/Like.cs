using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E4D RID: 3661
	[Token(Token = "0x2000E4D")]
	[Serializable]
	public struct Like
	{
		// Token: 0x04003572 RID: 13682
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003572")]
		[JsonProperty("uname")]
		public string uname;

		// Token: 0x04003573 RID: 13683
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003573")]
		[JsonProperty("uid")]
		public long uid;

		// Token: 0x04003574 RID: 13684
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003574")]
		[JsonProperty("open_id")]
		public string openId;

		// Token: 0x04003575 RID: 13685
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003575")]
		[JsonProperty("uface")]
		public string uface;

		// Token: 0x04003576 RID: 13686
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003576")]
		[JsonProperty("timestamp")]
		public long timestamp;

		// Token: 0x04003577 RID: 13687
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003577")]
		[JsonProperty("room_id")]
		public long room_id;

		// Token: 0x04003578 RID: 13688
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003578")]
		[JsonProperty("like_text")]
		public string like_text;

		// Token: 0x04003579 RID: 13689
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003579")]
		[JsonProperty("like_count")]
		public long unamelike_count;

		// Token: 0x0400357A RID: 13690
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400357A")]
		[JsonProperty("fans_medal_wearing_status")]
		public bool fans_medal_wearing_status;

		// Token: 0x0400357B RID: 13691
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400357B")]
		[JsonProperty("fans_medal_name")]
		public string fans_medal_name;

		// Token: 0x0400357C RID: 13692
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400357C")]
		[JsonProperty("fans_medal_level")]
		public long fans_medal_level;
	}
}
