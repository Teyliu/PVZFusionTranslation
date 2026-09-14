using System;
using Cpp2IlInjected;

namespace GameLevel.OnLine
{
	// Token: 0x02000B6A RID: 2922
	[Token(Token = "0x2000B6A")]
	[Serializable]
	public class OnlineLevelUpdateRequest
	{
		// Token: 0x06003CDD RID: 15581 RVA: 0x0013D58C File Offset: 0x0013B78C
		[Token(Token = "0x6003CDD")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public OnlineLevelUpdateRequest()
		{
		}

		// Token: 0x04002D69 RID: 11625
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002D69")]
		public string levelName;

		// Token: 0x04002D6A RID: 11626
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002D6A")]
		public string authorName;

		// Token: 0x04002D6B RID: 11627
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002D6B")]
		public string levelData;
	}
}
