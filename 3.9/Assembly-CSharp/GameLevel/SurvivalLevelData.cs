using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B3E RID: 2878
	[Token(Token = "0x2000B3E")]
	public abstract class SurvivalLevelData : LevelData
	{
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06003BC4 RID: 15300 RVA: 0x0013952C File Offset: 0x0013772C
		[Token(Token = "0x17000478")]
		public override int LevelNumber
		{
			[Token(Token = "0x6003BC4")]
			[Address(RVA = "0x7EA480", Offset = "0x7E8A80", VA = "0x1807EA480", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06003BC5 RID: 15301 RVA: 0x0013953C File Offset: 0x0013773C
		[Token(Token = "0x17000479")]
		public override LevelType LevelType
		{
			[Token(Token = "0x6003BC5")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "14")]
			get
			{
				return LevelType.Survival;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x0013954C File Offset: 0x0013774C
		[Token(Token = "0x1700047A")]
		protected virtual SurvivalLevel Level
		{
			[Token(Token = "0x6003BC6")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "42")]
			get
			{
				return (SurvivalLevel)0;
			}
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x00139564 File Offset: 0x00137764
		[Token(Token = "0x6003BC7")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		protected SurvivalLevelData()
		{
		}
	}
}
