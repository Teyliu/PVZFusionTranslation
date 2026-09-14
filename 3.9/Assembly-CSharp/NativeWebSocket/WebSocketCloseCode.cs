using System;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000DFF RID: 3583
	[Token(Token = "0x2000DFF")]
	public enum WebSocketCloseCode
	{
		// Token: 0x0400346D RID: 13421
		[Token(Token = "0x400346D")]
		NotSet,
		// Token: 0x0400346E RID: 13422
		[Token(Token = "0x400346E")]
		Normal = 1000,
		// Token: 0x0400346F RID: 13423
		[Token(Token = "0x400346F")]
		Away,
		// Token: 0x04003470 RID: 13424
		[Token(Token = "0x4003470")]
		ProtocolError,
		// Token: 0x04003471 RID: 13425
		[Token(Token = "0x4003471")]
		UnsupportedData,
		// Token: 0x04003472 RID: 13426
		[Token(Token = "0x4003472")]
		Undefined,
		// Token: 0x04003473 RID: 13427
		[Token(Token = "0x4003473")]
		NoStatus,
		// Token: 0x04003474 RID: 13428
		[Token(Token = "0x4003474")]
		Abnormal,
		// Token: 0x04003475 RID: 13429
		[Token(Token = "0x4003475")]
		InvalidData,
		// Token: 0x04003476 RID: 13430
		[Token(Token = "0x4003476")]
		PolicyViolation,
		// Token: 0x04003477 RID: 13431
		[Token(Token = "0x4003477")]
		TooBig,
		// Token: 0x04003478 RID: 13432
		[Token(Token = "0x4003478")]
		MandatoryExtension,
		// Token: 0x04003479 RID: 13433
		[Token(Token = "0x4003479")]
		ServerError,
		// Token: 0x0400347A RID: 13434
		[Token(Token = "0x400347A")]
		TlsHandshakeFailure = 1015
	}
}
