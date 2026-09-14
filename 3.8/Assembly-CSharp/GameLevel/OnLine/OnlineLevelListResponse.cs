using System;
using Cpp2IlInjected;

namespace GameLevel.OnLine
{
	// Token: 0x02000B23 RID: 2851
	[Token(Token = "0x2000B23")]
	[Serializable]
	public class OnlineLevelListResponse
	{
		// Token: 0x06003B86 RID: 15238 RVA: 0x00138238 File Offset: 0x00136438
		[Token(Token = "0x6003B86")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public OnlineLevelListResponse()
		{
		}

		// Token: 0x04002BDF RID: 11231
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002BDF")]
		public OnlineLevelInfo[] levels;
	}
}
