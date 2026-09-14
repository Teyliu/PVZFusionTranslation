using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AlmanacData
{
	// Token: 0x02000A84 RID: 2692
	[Token(Token = "0x2000A84")]
	[Serializable]
	public class Details
	{
		// Token: 0x0600374F RID: 14159 RVA: 0x0012887C File Offset: 0x00126A7C
		[Token(Token = "0x600374F")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public Details()
		{
		}

		// Token: 0x04002AC9 RID: 10953
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002AC9")]
		public string type;

		// Token: 0x04002ACA RID: 10954
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002ACA")]
		public string title;

		// Token: 0x04002ACB RID: 10955
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002ACB")]
		public string text;

		// Token: 0x04002ACC RID: 10956
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002ACC")]
		public List<Link> link;
	}
}
