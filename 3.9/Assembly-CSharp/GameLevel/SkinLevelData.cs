using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B36 RID: 2870
	[Token(Token = "0x2000B36")]
	public abstract class SkinLevelData : LevelData
	{
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06003B9C RID: 15260 RVA: 0x00138BE8 File Offset: 0x00136DE8
		[Token(Token = "0x17000461")]
		public override int LevelNumber
		{
			[Token(Token = "0x6003B9C")]
			[Address(RVA = "0x7EA480", Offset = "0x7E8A80", VA = "0x1807EA480", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06003B9D RID: 15261 RVA: 0x00138BF8 File Offset: 0x00136DF8
		[Token(Token = "0x17000462")]
		public override LevelType LevelType
		{
			[Token(Token = "0x6003B9D")]
			[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "14")]
			get
			{
				return LevelType.SkinLevel;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06003B9E RID: 15262 RVA: 0x00138C08 File Offset: 0x00136E08
		[Token(Token = "0x17000463")]
		protected virtual SkinLevel Level
		{
			[Token(Token = "0x6003B9E")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "42")]
			get
			{
				return (SkinLevel)0;
			}
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x00138C20 File Offset: 0x00136E20
		[Token(Token = "0x6003B9F")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		protected SkinLevelData()
		{
		}
	}
}
