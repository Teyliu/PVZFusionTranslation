using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AFD RID: 2813
	[Token(Token = "0x2000AFD")]
	[Serializable]
	public class CompleteData
	{
		// Token: 0x06003A27 RID: 14887 RVA: 0x00132998 File Offset: 0x00130B98
		[Token(Token = "0x6003A27")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public CompleteData()
		{
		}

		// Token: 0x04002C1A RID: 11290
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002C1A")]
		public LevelType levelType;

		// Token: 0x04002C1B RID: 11291
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002C1B")]
		public int levelNumber;

		// Token: 0x04002C1C RID: 11292
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002C1C")]
		public int victoryCount;

		// Token: 0x04002C1D RID: 11293
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4002C1D")]
		public int startCount;
	}
}
