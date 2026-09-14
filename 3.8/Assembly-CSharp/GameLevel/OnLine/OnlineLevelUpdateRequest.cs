using System;
using Cpp2IlInjected;

namespace GameLevel.OnLine
{
	// Token: 0x02000B28 RID: 2856
	[Token(Token = "0x2000B28")]
	[Serializable]
	public class OnlineLevelUpdateRequest
	{
		// Token: 0x06003B8C RID: 15244 RVA: 0x001382B0 File Offset: 0x001364B0
		[Token(Token = "0x6003B8C")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public OnlineLevelUpdateRequest()
		{
		}

		// Token: 0x04002BF5 RID: 11253
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002BF5")]
		public string levelName;

		// Token: 0x04002BF6 RID: 11254
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002BF6")]
		public string authorName;

		// Token: 0x04002BF7 RID: 11255
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002BF7")]
		public string levelData;
	}
}
