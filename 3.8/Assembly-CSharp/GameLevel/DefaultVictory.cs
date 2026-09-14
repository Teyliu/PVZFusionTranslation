using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AB7 RID: 2743
	[Token(Token = "0x2000AB7")]
	public class DefaultVictory : BoardVictory
	{
		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060038D4 RID: 14548 RVA: 0x0012D4D4 File Offset: 0x0012B6D4
		[Token(Token = "0x17000399")]
		public override VictoryType VictoryType
		{
			[Token(Token = "0x60038D4")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "4")]
			get
			{
				return VictoryType.DefaultVictory;
			}
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x0012D4EC File Offset: 0x0012B6EC
		[Token(Token = "0x60038D5")]
		[Address(RVA = "0x787C80", Offset = "0x786280", VA = "0x180787C80", Slot = "6")]
		protected override bool Check(Board board)
		{
			int theMaxWave = board.theMaxWave;
			return Lawnf.GetScaryPotNum(board) == 0;
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x0012D514 File Offset: 0x0012B714
		[Token(Token = "0x60038D6")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public DefaultVictory()
		{
		}
	}
}
