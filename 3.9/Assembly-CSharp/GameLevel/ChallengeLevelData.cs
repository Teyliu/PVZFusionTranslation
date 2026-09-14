using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B19 RID: 2841
	[Token(Token = "0x2000B19")]
	public abstract class ChallengeLevelData : LevelData
	{
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06003AE0 RID: 15072 RVA: 0x00135424 File Offset: 0x00133624
		[Token(Token = "0x17000419")]
		public override int LevelNumber
		{
			[Token(Token = "0x6003AE0")]
			[Address(RVA = "0x7EA480", Offset = "0x7E8A80", VA = "0x1807EA480", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06003AE1 RID: 15073 RVA: 0x00135434 File Offset: 0x00133634
		[Token(Token = "0x1700041A")]
		public override LevelType LevelType
		{
			[Token(Token = "0x6003AE1")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "14")]
			get
			{
				return LevelType.Challenge;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x00135444 File Offset: 0x00133644
		[Token(Token = "0x1700041B")]
		protected virtual ChallengeLevel Level
		{
			[Token(Token = "0x6003AE2")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "42")]
			get
			{
				return (ChallengeLevel)0;
			}
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x0013545C File Offset: 0x0013365C
		[Token(Token = "0x6003AE3")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		protected ChallengeLevelData()
		{
		}
	}
}
