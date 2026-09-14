using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AF6 RID: 2806
	[Token(Token = "0x2000AF6")]
	public abstract class BoardVictory
	{
		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06003A0E RID: 14862 RVA: 0x001325CC File Offset: 0x001307CC
		// (set) Token: 0x06003A0F RID: 14863 RVA: 0x001325E0 File Offset: 0x001307E0
		[Token(Token = "0x170003DE")]
		public virtual VictoryType VictoryType
		{
			[Token(Token = "0x6003A0E")]
			[Address(RVA = "0x3E8430", Offset = "0x3E6A30", VA = "0x1803E8430", Slot = "4")]
			get;
			[Token(Token = "0x6003A0F")]
			[Address(RVA = "0x5159A0", Offset = "0x513FA0", VA = "0x1805159A0", Slot = "5")]
			set;
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06003A10 RID: 14864 RVA: 0x001325F4 File Offset: 0x001307F4
		// (set) Token: 0x06003A11 RID: 14865 RVA: 0x00132608 File Offset: 0x00130808
		[Token(Token = "0x170003DF")]
		public Action Victiory
		{
			[Token(Token = "0x6003A10")]
			[Address(RVA = "0x3FDA60", Offset = "0x3FC060", VA = "0x1803FDA60")]
			get;
			[Token(Token = "0x6003A11")]
			[Address(RVA = "0x515980", Offset = "0x513F80", VA = "0x180515980")]
			set;
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06003A12 RID: 14866 RVA: 0x0013261C File Offset: 0x0013081C
		// (set) Token: 0x06003A13 RID: 14867 RVA: 0x00132630 File Offset: 0x00130830
		[Token(Token = "0x170003E0")]
		public int CheckCount
		{
			[Token(Token = "0x6003A12")]
			[Address(RVA = "0x41DF70", Offset = "0x41C570", VA = "0x18041DF70")]
			get;
			[Token(Token = "0x6003A13")]
			[Address(RVA = "0x7EA240", Offset = "0x7E8840", VA = "0x1807EA240")]
			set;
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x00132644 File Offset: 0x00130844
		[Token(Token = "0x6003A14")]
		[Address(RVA = "0x7EA250", Offset = "0x7E8850", VA = "0x1807EA250")]
		public void OnUpdate(Board board)
		{
			if (this.Check(board))
			{
				board.over = true;
				if (this.<Victiory>k__BackingField != (ulong)0L)
				{
					Action action = this.<Victiory>k__BackingField;
				}
				bool flag;
				if (flag)
				{
				}
				board.boardStatistics.GameOver((GameResult)((uint)1));
			}
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x00132690 File Offset: 0x00130890
		[Token(Token = "0x6003A15")]
		[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "6")]
		protected virtual bool Check(Board board)
		{
			return false;
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x001326A0 File Offset: 0x001308A0
		[Token(Token = "0x6003A16")]
		[Address(RVA = "0x7EA390", Offset = "0x7E8990", VA = "0x1807EA390")]
		public void Win()
		{
			Board instance = Board.Instance;
			int num = 0;
			if (instance != num && !instance.over)
			{
				BoardStatistics boardStatistics = instance.boardStatistics;
				instance.over = true;
				boardStatistics.GameOver((GameResult)((uint)1));
			}
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x001326E8 File Offset: 0x001308E8
		[Token(Token = "0x6003A17")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		protected BoardVictory()
		{
		}
	}
}
