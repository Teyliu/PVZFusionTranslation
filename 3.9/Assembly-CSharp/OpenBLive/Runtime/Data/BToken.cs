using System;
using Cpp2IlInjected;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E48 RID: 3656
	[Token(Token = "0x2000E48")]
	public struct BToken
	{
		// Token: 0x04003554 RID: 13652
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003554")]
		public int code;

		// Token: 0x04003555 RID: 13653
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003555")]
		public long dedeUserID;

		// Token: 0x04003556 RID: 13654
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003556")]
		public string dedeUserIDCkMd5;

		// Token: 0x04003557 RID: 13655
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003557")]
		public string sessData;

		// Token: 0x04003558 RID: 13656
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003558")]
		public string biliJct;
	}
}
