using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E59 RID: 3673
	[Token(Token = "0x2000E59")]
	[Serializable]
	public struct SendGift
	{
		// Token: 0x040035A6 RID: 13734
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40035A6")]
		[JsonProperty("room_id")]
		public long roomId;

		// Token: 0x040035A7 RID: 13735
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40035A7")]
		[JsonProperty("uid")]
		public long uid;

		// Token: 0x040035A8 RID: 13736
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40035A8")]
		[JsonProperty("open_id")]
		public string openId;

		// Token: 0x040035A9 RID: 13737
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40035A9")]
		[JsonProperty("uname")]
		public string userName;

		// Token: 0x040035AA RID: 13738
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40035AA")]
		[JsonProperty("uface")]
		public string userFace;

		// Token: 0x040035AB RID: 13739
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40035AB")]
		[JsonProperty("gift_id")]
		public long giftId;

		// Token: 0x040035AC RID: 13740
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40035AC")]
		[JsonProperty("gift_name")]
		public string giftName;

		// Token: 0x040035AD RID: 13741
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40035AD")]
		[JsonProperty("gift_num")]
		public long giftNum;

		// Token: 0x040035AE RID: 13742
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40035AE")]
		[JsonProperty("price")]
		public long price;

		// Token: 0x040035AF RID: 13743
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40035AF")]
		[JsonProperty("paid")]
		public bool paid;

		// Token: 0x040035B0 RID: 13744
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40035B0")]
		[JsonProperty("fans_medal_level")]
		public long fansMedalLevel;

		// Token: 0x040035B1 RID: 13745
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40035B1")]
		[JsonProperty("fans_medal_name")]
		public string fansMedalName;

		// Token: 0x040035B2 RID: 13746
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40035B2")]
		[JsonProperty("fans_medal_wearing_status")]
		public bool fansMedalWearingStatus;

		// Token: 0x040035B3 RID: 13747
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40035B3")]
		[JsonProperty("guard_level")]
		public long guardLevel;

		// Token: 0x040035B4 RID: 13748
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40035B4")]
		[JsonProperty("timestamp")]
		public long timestamp;

		// Token: 0x040035B5 RID: 13749
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40035B5")]
		[JsonProperty("anchor_info")]
		public AnchorInfo anchorInfo;
	}
}
