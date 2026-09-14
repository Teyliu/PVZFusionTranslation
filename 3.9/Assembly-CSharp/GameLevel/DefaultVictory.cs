using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AF7 RID: 2807
	[Token(Token = "0x2000AF7")]
	public class DefaultVictory : BoardVictory
	{
		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06003A18 RID: 14872 RVA: 0x001326FC File Offset: 0x001308FC
		[Token(Token = "0x170003E1")]
		public override VictoryType VictoryType
		{
			[Token(Token = "0x6003A18")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "4")]
			get
			{
				return VictoryType.DefaultVictory;
			}
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x00132714 File Offset: 0x00130914
		[Token(Token = "0x6003A19")]
		[Address(RVA = "0x7EE6A0", Offset = "0x7ECCA0", VA = "0x1807EE6A0", Slot = "6")]
		protected override bool Check(Board board)
		{
			int theMaxWave = board.theMaxWave;
			return Lawnf.GetScaryPotNum(board) == 0;
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x0013273C File Offset: 0x0013093C
		[Token(Token = "0x6003A1A")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public DefaultVictory()
		{
		}
	}
}
