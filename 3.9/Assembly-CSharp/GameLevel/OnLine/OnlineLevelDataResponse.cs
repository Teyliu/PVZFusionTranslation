using System;
using Cpp2IlInjected;

namespace GameLevel.OnLine
{
	// Token: 0x02000B67 RID: 2919
	[Token(Token = "0x2000B67")]
	[Serializable]
	public class OnlineLevelDataResponse
	{
		// Token: 0x06003CDA RID: 15578 RVA: 0x0013D550 File Offset: 0x0013B750
		[Token(Token = "0x6003CDA")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public OnlineLevelDataResponse()
		{
		}

		// Token: 0x04002D60 RID: 11616
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002D60")]
		public string levelId;

		// Token: 0x04002D61 RID: 11617
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002D61")]
		public string levelData;
	}
}
