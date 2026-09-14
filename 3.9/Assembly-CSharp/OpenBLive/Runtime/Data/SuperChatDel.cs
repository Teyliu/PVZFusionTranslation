using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E5B RID: 3675
	[Token(Token = "0x2000E5B")]
	[Serializable]
	public struct SuperChatDel
	{
		// Token: 0x040035C5 RID: 13765
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40035C5")]
		[JsonProperty("room_id")]
		public long roomId;

		// Token: 0x040035C6 RID: 13766
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40035C6")]
		[JsonProperty("message_ids")]
		public long[] messageIds;
	}
}
