using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000ABD RID: 2749
	[Token(Token = "0x2000ABD")]
	[Serializable]
	public class CompleteData
	{
		// Token: 0x060038E3 RID: 14563 RVA: 0x0012D770 File Offset: 0x0012B970
		[Token(Token = "0x60038E3")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public CompleteData()
		{
		}

		// Token: 0x04002AA7 RID: 10919
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002AA7")]
		public LevelType levelType;

		// Token: 0x04002AA8 RID: 10920
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002AA8")]
		public int levelNumber;

		// Token: 0x04002AA9 RID: 10921
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002AA9")]
		public int victoryCount;

		// Token: 0x04002AAA RID: 10922
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4002AAA")]
		public int startCount;
	}
}
