using System;
using Cpp2IlInjected;

namespace GameLevel.OnLine
{
	// Token: 0x02000B26 RID: 2854
	[Token(Token = "0x2000B26")]
	[Serializable]
	public class OnlineLevelApiResponse
	{
		// Token: 0x06003B8A RID: 15242 RVA: 0x00138288 File Offset: 0x00136488
		[Token(Token = "0x6003B8A")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public OnlineLevelApiResponse()
		{
		}

		// Token: 0x04002BEE RID: 11246
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002BEE")]
		public bool success;

		// Token: 0x04002BEF RID: 11247
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002BEF")]
		public string levelId;

		// Token: 0x04002BF0 RID: 11248
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002BF0")]
		public string error;

		// Token: 0x04002BF1 RID: 11249
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002BF1")]
		public string message;
	}
}
