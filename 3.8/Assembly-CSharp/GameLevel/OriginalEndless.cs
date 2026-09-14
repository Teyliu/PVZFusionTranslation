using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000AFD RID: 2813
	[Token(Token = "0x2000AFD")]
	public class OriginalEndless : SurvivalLevelData
	{
		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06003A77 RID: 14967 RVA: 0x00134228 File Offset: 0x00132428
		[Token(Token = "0x1700042B")]
		protected override SurvivalLevel Level
		{
			[Token(Token = "0x6003A77")]
			[Address(RVA = "0x69C9D0", Offset = "0x69AFD0", VA = "0x18069C9D0", Slot = "42")]
			get
			{
				return SurvivalLevel.OriginalEndless;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06003A78 RID: 14968 RVA: 0x00134238 File Offset: 0x00132438
		// (set) Token: 0x06003A79 RID: 14969 RVA: 0x00134274 File Offset: 0x00132474
		[Token(Token = "0x1700042C")]
		public override string Name
		{
			[Token(Token = "0x6003A78")]
			[Address(RVA = "0x78F920", Offset = "0x78DF20", VA = "0x18078F920", Slot = "8")]
			get
			{
				Board instance = Board.Instance;
				if (instance.theCurrentSurvivalRound != 1)
				{
					int theCurrentSurvivalRound = instance.theCurrentSurvivalRound;
					return string.Format("泳池无尽：安逸 第{0}轮", theCurrentSurvivalRound);
				}
				return "泳池无尽：安逸";
			}
			[Token(Token = "0x6003A79")]
			[Address(RVA = "0x4A9D50", Offset = "0x4A8350", VA = "0x1804A9D50", Slot = "9")]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06003A7A RID: 14970 RVA: 0x00134288 File Offset: 0x00132488
		[Token(Token = "0x1700042D")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003A7A")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06003A7B RID: 14971 RVA: 0x00134298 File Offset: 0x00132498
		[Token(Token = "0x1700042E")]
		public override int MaxWave
		{
			[Token(Token = "0x6003A7B")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x001342A8 File Offset: 0x001324A8
		[Token(Token = "0x6003A7C")]
		[Address(RVA = "0x78F850", Offset = "0x78DE50", VA = "0x18078F850", Slot = "39")]
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
			board.boardTag.isEndless = true;
			board.theSurvivalMaxRound = (int)((ulong)2147483647L);
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06003A7D RID: 14973 RVA: 0x00134314 File Offset: 0x00132514
		// (set) Token: 0x06003A7E RID: 14974 RVA: 0x0013443C File Offset: 0x0013263C
		[Token(Token = "0x1700042F")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003A7D")]
			[Address(RVA = "0x78F9D0", Offset = "0x78DFD0", VA = "0x18078F9D0", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				int size7 = list._size;
				int size8 = list._size;
				int size9 = list._size;
				int size10 = list._size;
				int size11 = list._size;
				int size12 = list._size;
				int size13 = list._size;
				int size14 = list._size;
				int size15 = list._size;
				int size16 = list._size;
				int size17 = list._size;
				int size18 = list._size;
				int size19 = list._size;
				int size20 = list._size;
				int size21 = list._size;
				ListExtensions.Shuffle<ZombieType>(list);
				Board instance = Board.Instance;
				int theCurrentSurvivalRound = instance.theCurrentSurvivalRound;
				if (instance == 0)
				{
					return new List();
				}
				if (instance != 0)
				{
					if (instance == 0 || instance == 0 || theCurrentSurvivalRound != 1)
					{
					}
					uint num;
					return Enumerable.ToList<ZombieType>(Enumerable.Take<ZombieType>(list, (int)num));
				}
				uint num2;
				List<ZombieType> list2;
				if (global::UnityEngine.Random.Range(0, (int)num2) != 0)
				{
					list2 = new List();
					return list2;
				}
				return list2;
			}
			[Token(Token = "0x6003A7E")]
			[Address(RVA = "0x6FBEB0", Offset = "0x6FA4B0", VA = "0x1806FBEB0", Slot = "21")]
			set
			{
				this.<SpawnZombies>k__BackingField = value;
			}
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x00134450 File Offset: 0x00132650
		[Token(Token = "0x6003A7F")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public OriginalEndless()
		{
		}
	}
}
