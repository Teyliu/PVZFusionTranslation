using System;
using Cpp2IlInjected;

namespace AlmanacData
{
	// Token: 0x02000A45 RID: 2629
	[Token(Token = "0x2000A45")]
	[Serializable]
	public class Link
	{
		// Token: 0x0600360C RID: 13836 RVA: 0x00123614 File Offset: 0x00121814
		[Token(Token = "0x600360C")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public Link()
		{
		}

		// Token: 0x0400295A RID: 10586
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400295A")]
		public string type;

		// Token: 0x0400295B RID: 10587
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400295B")]
		public string title;
	}
}
