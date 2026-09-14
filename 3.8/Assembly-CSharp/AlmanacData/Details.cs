using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AlmanacData
{
	// Token: 0x02000A44 RID: 2628
	[Token(Token = "0x2000A44")]
	[Serializable]
	public class Details
	{
		// Token: 0x0600360B RID: 13835 RVA: 0x00123600 File Offset: 0x00121800
		[Token(Token = "0x600360B")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public Details()
		{
		}

		// Token: 0x04002956 RID: 10582
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002956")]
		public string type;

		// Token: 0x04002957 RID: 10583
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002957")]
		public string title;

		// Token: 0x04002958 RID: 10584
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002958")]
		public string text;

		// Token: 0x04002959 RID: 10585
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002959")]
		public List<Link> link;
	}
}
