using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E44 RID: 3652
	[Token(Token = "0x2000E44")]
	public class AppStartInfoData
	{
		// Token: 0x06004B51 RID: 19281 RVA: 0x00172358 File Offset: 0x00170558
		[Token(Token = "0x6004B51")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public AppStartInfoData()
		{
		}

		// Token: 0x04003549 RID: 13641
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003549")]
		[JsonProperty("game_info")]
		public AppStartGameInfo GameInfo;

		// Token: 0x0400354A RID: 13642
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400354A")]
		[JsonProperty("websocket_info")]
		public AppStartWebsocketInfo WebsocketInfo;

		// Token: 0x0400354B RID: 13643
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400354B")]
		[JsonProperty("anchor_info")]
		public AppStartAnchorInfo AnchorInfo;
	}
}
