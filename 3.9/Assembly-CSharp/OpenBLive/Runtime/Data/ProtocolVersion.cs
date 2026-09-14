using System;
using Cpp2IlInjected;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E58 RID: 3672
	[Token(Token = "0x2000E58")]
	public enum ProtocolVersion
	{
		// Token: 0x040035A2 RID: 13730
		[Token(Token = "0x40035A2")]
		UnCompressed,
		// Token: 0x040035A3 RID: 13731
		[Token(Token = "0x40035A3")]
		HeartBeat,
		// Token: 0x040035A4 RID: 13732
		[Token(Token = "0x40035A4")]
		Zlib,
		// Token: 0x040035A5 RID: 13733
		[Token(Token = "0x40035A5")]
		Brotli
	}
}
