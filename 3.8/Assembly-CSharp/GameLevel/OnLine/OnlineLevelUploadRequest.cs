using System;
using Cpp2IlInjected;

namespace GameLevel.OnLine
{
	// Token: 0x02000B27 RID: 2855
	[Token(Token = "0x2000B27")]
	[Serializable]
	public class OnlineLevelUploadRequest
	{
		// Token: 0x06003B8B RID: 15243 RVA: 0x0013829C File Offset: 0x0013649C
		[Token(Token = "0x6003B8B")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public OnlineLevelUploadRequest()
		{
		}

		// Token: 0x04002BF2 RID: 11250
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002BF2")]
		public string levelName;

		// Token: 0x04002BF3 RID: 11251
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002BF3")]
		public string authorName;

		// Token: 0x04002BF4 RID: 11252
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002BF4")]
		public string levelData;
	}
}
