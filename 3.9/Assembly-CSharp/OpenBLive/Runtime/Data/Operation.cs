using System;
using Cpp2IlInjected;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E57 RID: 3671
	[Token(Token = "0x2000E57")]
	public enum Operation
	{
		// Token: 0x0400359C RID: 13724
		[Token(Token = "0x400359C")]
		HeartBeat = 2,
		// Token: 0x0400359D RID: 13725
		[Token(Token = "0x400359D")]
		HeartBeatResponse,
		// Token: 0x0400359E RID: 13726
		[Token(Token = "0x400359E")]
		ServerNotify = 5,
		// Token: 0x0400359F RID: 13727
		[Token(Token = "0x400359F")]
		Authority = 7,
		// Token: 0x040035A0 RID: 13728
		[Token(Token = "0x40035A0")]
		AuthorityResponse
	}
}
