using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E4B RID: 3659
	[Token(Token = "0x2000E4B")]
	public struct GameIds
	{
		// Token: 0x04003569 RID: 13673
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003569")]
		[JsonProperty("game_ids")]
		public string[] gameIds;
	}
}
