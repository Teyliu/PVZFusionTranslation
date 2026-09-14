using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AB6 RID: 2742
	[Token(Token = "0x2000AB6")]
	public abstract class BoardVictory
	{
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060038CA RID: 14538 RVA: 0x0012D3A4 File Offset: 0x0012B5A4
		// (set) Token: 0x060038CB RID: 14539 RVA: 0x0012D3B8 File Offset: 0x0012B5B8
		[Token(Token = "0x17000396")]
		public virtual VictoryType VictoryType
		{
			[Token(Token = "0x60038CA")]
			[Address(RVA = "0x39C420", Offset = "0x39AA20", VA = "0x18039C420", Slot = "4")]
			get;
			[Token(Token = "0x60038CB")]
			[Address(RVA = "0x4A9D70", Offset = "0x4A8370", VA = "0x1804A9D70", Slot = "5")]
			set;
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060038CC RID: 14540 RVA: 0x0012D3CC File Offset: 0x0012B5CC
		// (set) Token: 0x060038CD RID: 14541 RVA: 0x0012D3E0 File Offset: 0x0012B5E0
		[Token(Token = "0x17000397")]
		public Action Victiory
		{
			[Token(Token = "0x60038CC")]
			[Address(RVA = "0x3C9940", Offset = "0x3C7F40", VA = "0x1803C9940")]
			get;
			[Token(Token = "0x60038CD")]
			[Address(RVA = "0x4A9D50", Offset = "0x4A8350", VA = "0x1804A9D50")]
			set;
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060038CE RID: 14542 RVA: 0x0012D3F4 File Offset: 0x0012B5F4
		// (set) Token: 0x060038CF RID: 14543 RVA: 0x0012D408 File Offset: 0x0012B608
		[Token(Token = "0x17000398")]
		public int CheckCount
		{
			[Token(Token = "0x60038CE")]
			[Address(RVA = "0x3D1110", Offset = "0x3CF710", VA = "0x1803D1110")]
			get;
			[Token(Token = "0x60038CF")]
			[Address(RVA = "0x783390", Offset = "0x781990", VA = "0x180783390")]
			set;
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x0012D41C File Offset: 0x0012B61C
		[Token(Token = "0x60038D0")]
		[Address(RVA = "0x7833A0", Offset = "0x7819A0", VA = "0x1807833A0")]
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

		// Token: 0x060038D1 RID: 14545 RVA: 0x0012D468 File Offset: 0x0012B668
		[Token(Token = "0x60038D1")]
		[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "6")]
		protected virtual bool Check(Board board)
		{
			return false;
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x0012D478 File Offset: 0x0012B678
		[Token(Token = "0x60038D2")]
		[Address(RVA = "0x7834E0", Offset = "0x781AE0", VA = "0x1807834E0")]
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

		// Token: 0x060038D3 RID: 14547 RVA: 0x0012D4C0 File Offset: 0x0012B6C0
		[Token(Token = "0x60038D3")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		protected BoardVictory()
		{
		}
	}
}
