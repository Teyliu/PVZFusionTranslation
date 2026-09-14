using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B3B RID: 2875
	[Token(Token = "0x2000B3B")]
	public abstract class SuperIZLevelData : ChallengeLevelData
	{
		// Token: 0x06003BBA RID: 15290 RVA: 0x001392A0 File Offset: 0x001374A0
		[Token(Token = "0x6003BBA")]
		[Address(RVA = "0x7FA250", Offset = "0x7F8850", VA = "0x1807FA250", Slot = "39")]
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

		// Token: 0x06003BBB RID: 15291 RVA: 0x00139314 File Offset: 0x00137514
		[Token(Token = "0x6003BBB")]
		[Address(RVA = "0x7FA320", Offset = "0x7F8920", VA = "0x1807FA320", Slot = "36")]
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

		// Token: 0x06003BBC RID: 15292 RVA: 0x0013937C File Offset: 0x0013757C
		[Token(Token = "0x6003BBC")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		protected SuperIZLevelData()
		{
		}
	}
}
