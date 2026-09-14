using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AF6 RID: 2806
	[Token(Token = "0x2000AF6")]
	public abstract class SkinLevelData : LevelData
	{
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06003A58 RID: 14936 RVA: 0x00133BA4 File Offset: 0x00131DA4
		[Token(Token = "0x17000419")]
		public override int LevelNumber
		{
			[Token(Token = "0x6003A58")]
			[Address(RVA = "0x783AC0", Offset = "0x7820C0", VA = "0x180783AC0", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06003A59 RID: 14937 RVA: 0x00133BB4 File Offset: 0x00131DB4
		[Token(Token = "0x1700041A")]
		public override LevelType LevelType
		{
			[Token(Token = "0x6003A59")]
			[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "14")]
			get
			{
				return LevelType.SkinLevel;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06003A5A RID: 14938 RVA: 0x00133BC4 File Offset: 0x00131DC4
		[Token(Token = "0x1700041B")]
		protected virtual SkinLevel Level
		{
			[Token(Token = "0x6003A5A")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "42")]
			get
			{
				return (SkinLevel)0;
			}
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x00133BDC File Offset: 0x00131DDC
		[Token(Token = "0x6003A5B")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		protected SkinLevelData()
		{
		}
	}
}
