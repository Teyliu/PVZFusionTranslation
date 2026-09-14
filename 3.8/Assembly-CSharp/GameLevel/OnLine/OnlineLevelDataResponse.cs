using System;
using Cpp2IlInjected;

namespace GameLevel.OnLine
{
	// Token: 0x02000B25 RID: 2853
	[Token(Token = "0x2000B25")]
	[Serializable]
	public class OnlineLevelDataResponse
	{
		// Token: 0x06003B89 RID: 15241 RVA: 0x00138274 File Offset: 0x00136474
		[Token(Token = "0x6003B89")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public OnlineLevelDataResponse()
		{
		}

		// Token: 0x04002BEC RID: 11244
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002BEC")]
		public string levelId;

		// Token: 0x04002BED RID: 11245
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002BED")]
		public string levelData;
	}
}
