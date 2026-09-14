using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B3F RID: 2879
	[Token(Token = "0x2000B3F")]
	public class OriginalEndless : SurvivalLevelData
	{
		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06003BC8 RID: 15304 RVA: 0x00139578 File Offset: 0x00137778
		[Token(Token = "0x1700047B")]
		protected override SurvivalLevel Level
		{
			[Token(Token = "0x6003BC8")]
			[Address(RVA = "0x716B30", Offset = "0x715130", VA = "0x180716B30", Slot = "42")]
			get
			{
				return SurvivalLevel.OriginalEndless;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06003BC9 RID: 15305 RVA: 0x00139588 File Offset: 0x00137788
		// (set) Token: 0x06003BCA RID: 15306 RVA: 0x001395C4 File Offset: 0x001377C4
		[Token(Token = "0x1700047C")]
		public override string Name
		{
			[Token(Token = "0x6003BC9")]
			[Address(RVA = "0x7F5FE0", Offset = "0x7F45E0", VA = "0x1807F5FE0", Slot = "8")]
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
			[Token(Token = "0x6003BCA")]
			[Address(RVA = "0x515980", Offset = "0x513F80", VA = "0x180515980", Slot = "9")]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06003BCB RID: 15307 RVA: 0x001395D8 File Offset: 0x001377D8
		[Token(Token = "0x1700047D")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003BCB")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06003BCC RID: 15308 RVA: 0x001395E8 File Offset: 0x001377E8
		[Token(Token = "0x1700047E")]
		public override int MaxWave
		{
			[Token(Token = "0x6003BCC")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x001395F8 File Offset: 0x001377F8
		[Token(Token = "0x6003BCD")]
		[Address(RVA = "0x7F5F10", Offset = "0x7F4510", VA = "0x1807F5F10", Slot = "39")]
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

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06003BCE RID: 15310 RVA: 0x00139664 File Offset: 0x00137864
		// (set) Token: 0x06003BCF RID: 15311 RVA: 0x0013978C File Offset: 0x0013798C
		[Token(Token = "0x1700047F")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003BCE")]
			[Address(RVA = "0x7F6090", Offset = "0x7F4690", VA = "0x1807F6090", Slot = "20")]
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
			[Token(Token = "0x6003BCF")]
			[Address(RVA = "0x761250", Offset = "0x75F850", VA = "0x180761250", Slot = "21")]
			set
			{
				this.<SpawnZombies>k__BackingField = value;
			}
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x001397A0 File Offset: 0x001379A0
		[Token(Token = "0x6003BD0")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public OriginalEndless()
		{
		}
	}
}
