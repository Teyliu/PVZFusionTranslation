using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AFC RID: 2812
	[Token(Token = "0x2000AFC")]
	public abstract class SurvivalLevelData : LevelData
	{
		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06003A73 RID: 14963 RVA: 0x001341DC File Offset: 0x001323DC
		[Token(Token = "0x17000428")]
		public override int LevelNumber
		{
			[Token(Token = "0x6003A73")]
			[Address(RVA = "0x783AC0", Offset = "0x7820C0", VA = "0x180783AC0", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06003A74 RID: 14964 RVA: 0x001341EC File Offset: 0x001323EC
		[Token(Token = "0x17000429")]
		public override LevelType LevelType
		{
			[Token(Token = "0x6003A74")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "14")]
			get
			{
				return LevelType.Survival;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06003A75 RID: 14965 RVA: 0x001341FC File Offset: 0x001323FC
		[Token(Token = "0x1700042A")]
		protected virtual SurvivalLevel Level
		{
			[Token(Token = "0x6003A75")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "42")]
			get
			{
				return (SurvivalLevel)0;
			}
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x00134214 File Offset: 0x00132414
		[Token(Token = "0x6003A76")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		protected SurvivalLevelData()
		{
		}
	}
}
