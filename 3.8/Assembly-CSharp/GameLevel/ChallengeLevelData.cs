using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AD9 RID: 2777
	[Token(Token = "0x2000AD9")]
	public abstract class ChallengeLevelData : LevelData
	{
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600399C RID: 14748 RVA: 0x001302E4 File Offset: 0x0012E4E4
		[Token(Token = "0x170003D1")]
		public override int LevelNumber
		{
			[Token(Token = "0x600399C")]
			[Address(RVA = "0x783AC0", Offset = "0x7820C0", VA = "0x180783AC0", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600399D RID: 14749 RVA: 0x001302F4 File Offset: 0x0012E4F4
		[Token(Token = "0x170003D2")]
		public override LevelType LevelType
		{
			[Token(Token = "0x600399D")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "14")]
			get
			{
				return LevelType.Challenge;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600399E RID: 14750 RVA: 0x00130304 File Offset: 0x0012E504
		[Token(Token = "0x170003D3")]
		protected virtual ChallengeLevel Level
		{
			[Token(Token = "0x600399E")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "42")]
			get
			{
				return (ChallengeLevel)0;
			}
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x0013031C File Offset: 0x0012E51C
		[Token(Token = "0x600399F")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		protected ChallengeLevelData()
		{
		}
	}
}
