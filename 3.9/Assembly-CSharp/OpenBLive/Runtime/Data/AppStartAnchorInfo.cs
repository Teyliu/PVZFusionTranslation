using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E47 RID: 3655
	[Token(Token = "0x2000E47")]
	public class AppStartAnchorInfo
	{
		// Token: 0x06004B54 RID: 19284 RVA: 0x00172394 File Offset: 0x00170594
		[Token(Token = "0x6004B54")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public AppStartAnchorInfo()
		{
		}

		// Token: 0x0400354F RID: 13647
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400354F")]
		[JsonProperty("room_id")]
		public long RoomId;

		// Token: 0x04003550 RID: 13648
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003550")]
		[JsonProperty("uname")]
		public string UName;

		// Token: 0x04003551 RID: 13649
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003551")]
		[JsonProperty("uface")]
		public string UFace;

		// Token: 0x04003552 RID: 13650
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003552")]
		[JsonProperty("uid")]
		public string Uid;

		// Token: 0x04003553 RID: 13651
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003553")]
		[JsonProperty("open_id")]
		public string OpenId;
	}
}
