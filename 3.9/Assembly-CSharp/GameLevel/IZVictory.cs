using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AF8 RID: 2808
	[Token(Token = "0x2000AF8")]
	public class IZVictory : BoardVictory
	{
		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06003A1B RID: 14875 RVA: 0x00132750 File Offset: 0x00130950
		[Token(Token = "0x170003E2")]
		public override VictoryType VictoryType
		{
			[Token(Token = "0x6003A1B")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "4")]
			get
			{
				return VictoryType.IZVictory;
			}
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x00132760 File Offset: 0x00130960
		[Token(Token = "0x6003A1C")]
		[Address(RVA = "0x7EF930", Offset = "0x7EDF30", VA = "0x1807EF930", Slot = "6")]
		protected override bool Check(Board board)
		{
			if (board.brainManager == (ulong)0L)
			{
				BrainManager brainManager = new BrainManager(board);
				board.brainManager = brainManager;
			}
			List<Brain> brains = board.brainManager.brains;
			bool flag;
			return flag;
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x0013279C File Offset: 0x0013099C
		[Token(Token = "0x6003A1D")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public IZVictory()
		{
		}
	}
}
