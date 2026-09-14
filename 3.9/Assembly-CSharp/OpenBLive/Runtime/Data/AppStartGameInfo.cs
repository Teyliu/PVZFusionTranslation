using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E45 RID: 3653
	[Token(Token = "0x2000E45")]
	public class AppStartGameInfo
	{
		// Token: 0x06004B52 RID: 19282 RVA: 0x0017236C File Offset: 0x0017056C
		[Token(Token = "0x6004B52")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public AppStartGameInfo()
		{
		}

		// Token: 0x0400354C RID: 13644
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400354C")]
		[JsonProperty("game_id")]
		public string GameId;
	}
}
