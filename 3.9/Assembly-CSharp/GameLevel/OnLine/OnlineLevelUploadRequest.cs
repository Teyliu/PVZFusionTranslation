using System;
using Cpp2IlInjected;

namespace GameLevel.OnLine
{
	// Token: 0x02000B69 RID: 2921
	[Token(Token = "0x2000B69")]
	[Serializable]
	public class OnlineLevelUploadRequest
	{
		// Token: 0x06003CDC RID: 15580 RVA: 0x0013D578 File Offset: 0x0013B778
		[Token(Token = "0x6003CDC")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public OnlineLevelUploadRequest()
		{
		}

		// Token: 0x04002D66 RID: 11622
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002D66")]
		public string levelName;

		// Token: 0x04002D67 RID: 11623
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002D67")]
		public string authorName;

		// Token: 0x04002D68 RID: 11624
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002D68")]
		public string levelData;
	}
}
