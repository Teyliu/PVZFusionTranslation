using System;
using Cpp2IlInjected;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E24 RID: 3620
	[Token(Token = "0x2000E24")]
	[Serializable]
	public class ConnectData
	{
		// Token: 0x06004AB2 RID: 19122 RVA: 0x0016F750 File Offset: 0x0016D950
		[Token(Token = "0x6004AB2")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public ConnectData()
		{
		}

		// Token: 0x040034EC RID: 13548
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40034EC")]
		public string accessKeySecret;

		// Token: 0x040034ED RID: 13549
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40034ED")]
		public string accessKeyId;

		// Token: 0x040034EE RID: 13550
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40034EE")]
		public string appId;

		// Token: 0x040034EF RID: 13551
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40034EF")]
		public string code;
	}
}
