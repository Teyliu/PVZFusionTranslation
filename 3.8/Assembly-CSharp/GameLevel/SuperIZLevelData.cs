using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AF9 RID: 2809
	[Token(Token = "0x2000AF9")]
	public abstract class SuperIZLevelData : ChallengeLevelData
	{
		// Token: 0x06003A69 RID: 14953 RVA: 0x00133F50 File Offset: 0x00132150
		[Token(Token = "0x6003A69")]
		[Address(RVA = "0x793520", Offset = "0x791B20", VA = "0x180793520", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			if (base.CardCount != 0)
			{
				int cardCount = base.CardCount;
				board.cardCountLimit = cardCount;
			}
			BoardConfig boardConfig = base.Config.Copy();
			board.config = boardConfig;
			float firstWaveArrivedTimer = base.Config.firstWaveArrivedTimer;
			board.timeUntilNextWave = firstWaveArrivedTimer;
			board.boardTag.isIZ = true;
			board.boardTag.disableSummonZombie = true;
			board.boardTag.disableInInterlude = true;
		}

		// Token: 0x06003A6A RID: 14954 RVA: 0x00133FC4 File Offset: 0x001321C4
		[Token(Token = "0x6003A6A")]
		[Address(RVA = "0x7935F0", Offset = "0x791BF0", VA = "0x1807935F0", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			int num2;
			do
			{
				int num = 0;
				SuperIZLevelData.<>c__DisplayClass1_0 CS$<>8__locals1;
				CS$<>8__locals1.board = board;
				Board board2 = CS$<>8__locals1.board;
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1000));
				List<CardUI> cards = InGameUI.Instance.Cards;
				num2 = 0;
				bool flag;
				if (flag)
				{
					while (num == 0)
					{
					}
					while (num == 0)
					{
					}
					if (CS$<>8__locals1.<>9__0 == 0)
					{
						Action<Zombie> action;
						CS$<>8__locals1.<>9__0 = action;
					}
				}
			}
			while (num2 != 0);
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x0013402C File Offset: 0x0013222C
		[Token(Token = "0x6003A6B")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		protected SuperIZLevelData()
		{
		}
	}
}
