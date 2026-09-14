using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AB8 RID: 2744
	[Token(Token = "0x2000AB8")]
	public class IZVictory : BoardVictory
	{
		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060038D7 RID: 14551 RVA: 0x0012D528 File Offset: 0x0012B728
		[Token(Token = "0x1700039A")]
		public override VictoryType VictoryType
		{
			[Token(Token = "0x60038D7")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "4")]
			get
			{
				return VictoryType.IZVictory;
			}
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x0012D538 File Offset: 0x0012B738
		[Token(Token = "0x60038D8")]
		[Address(RVA = "0x7892C0", Offset = "0x7878C0", VA = "0x1807892C0", Slot = "6")]
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

		// Token: 0x060038D9 RID: 14553 RVA: 0x0012D574 File Offset: 0x0012B774
		[Token(Token = "0x60038D9")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public IZVictory()
		{
		}
	}
}
