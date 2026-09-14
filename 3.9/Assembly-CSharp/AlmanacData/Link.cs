using System;
using Cpp2IlInjected;

namespace AlmanacData
{
	// Token: 0x02000A85 RID: 2693
	[Token(Token = "0x2000A85")]
	[Serializable]
	public class Link
	{
		// Token: 0x06003750 RID: 14160 RVA: 0x00128890 File Offset: 0x00126A90
		[Token(Token = "0x6003750")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public Link()
		{
		}

		// Token: 0x04002ACD RID: 10957
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002ACD")]
		public string type;

		// Token: 0x04002ACE RID: 10958
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002ACE")]
		public string title;
	}
}
