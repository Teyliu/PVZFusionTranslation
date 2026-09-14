using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B25 RID: 2853
	[Token(Token = "0x2000B25")]
	public class NumBattleMecLevel2 : ChallengeLevelData
	{
		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06003B32 RID: 15154 RVA: 0x00136D30 File Offset: 0x00134F30
		[Token(Token = "0x17000436")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003B32")]
			[Address(RVA = "0x7F2F20", Offset = "0x7F1520", VA = "0x1807F2F20", Slot = "42")]
			get
			{
				return ChallengeLevel.NumBattleMecLevel2;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06003B33 RID: 15155 RVA: 0x00136D44 File Offset: 0x00134F44
		[Token(Token = "0x17000437")]
		public override string Name
		{
			[Token(Token = "0x6003B33")]
			[Address(RVA = "0x7F2F30", Offset = "0x7F1530", VA = "0x1807F2F30", Slot = "8")]
			get
			{
				return "数值大战机制2";
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06003B34 RID: 15156 RVA: 0x00136D58 File Offset: 0x00134F58
		[Token(Token = "0x17000438")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B34")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06003B35 RID: 15157 RVA: 0x00136D68 File Offset: 0x00134F68
		[Token(Token = "0x17000439")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B35")]
			[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "10")]
			get
			{
				return 40;
			}
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x00136D78 File Offset: 0x00134F78
		[Token(Token = "0x6003B36")]
		[Address(RVA = "0x7F24D0", Offset = "0x7F0AD0", VA = "0x1807F24D0", Slot = "39")]
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
			board.config.applyRandomData = true;
			board.boardTag.enableAllTravelPlant = true;
			board.boardTag.disableMower = true;
			BoardConfig config = board.config;
			config.plantModifyMax = 40f;
			config.plantModifyMin = 40f;
			config.plantSpeedAvg = 4f;
			config.plantSpeedMax = 4f;
			config.plantSpeedMin = 4f;
			config.firstWaveArrivedTimer = 30f;
			TravelMgr instance = TravelMgr.Instance;
			TravelMgr instance2 = TravelMgr.Instance;
			TravelMgr instance3 = TravelMgr.Instance;
			TravelMgr instance4 = TravelMgr.Instance;
			TravelMgr instance5 = TravelMgr.Instance;
			TravelMgr instance6 = TravelMgr.Instance;
			TravelMgr instance7 = TravelMgr.Instance;
			TravelMgr instance8 = TravelMgr.Instance;
			TravelDebuff[] enumValues = global::Core.Lawnf.GetEnumValues<TravelDebuff>();
			int num = 0;
			if (num < enumValues.Length)
			{
				TravelMgr instance9 = TravelMgr.Instance;
				num++;
			}
			TravelMgr.Instance.damageReduction = 0.9f;
			BoardConfig config2 = board.config;
			config2.zombieCountMultiplier = 2f;
			config2.startTip = "僵尸死亡时有概率复活成随机僵尸";
			throw new NullReferenceException();
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x00136EDC File Offset: 0x001350DC
		[Token(Token = "0x6003B37")]
		[Address(RVA = "0x7F2E70", Offset = "0x7F1470", VA = "0x1807F2E70", Slot = "35")]
		public override void ReinforceZombie(Zombie zombie)
		{
			int theZombieType = (int)zombie.theZombieType;
			bool flag;
			if (!flag)
			{
				ZombieType theZombieType2 = zombie.theZombieType;
				if (theZombieType2 != ZombieType.JalaSquashZombie && theZombieType2 != ZombieType.ObsidianTallNutZombie && theZombieType2 != ZombieType.SuperSunNutZombie)
				{
					global::Lawnf.SetZombieHealth(zombie, 5f);
				}
			}
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x00136F20 File Offset: 0x00135120
		[Token(Token = "0x6003B38")]
		[Address(RVA = "0x7F2850", Offset = "0x7F0E50", VA = "0x1807F2850", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			ulong num2;
			do
			{
				NumBattleMecLevel2.<>c__DisplayClass10_0 CS$<>8__locals1;
				CS$<>8__locals1.board = board;
				CS$<>8__locals1.<>4__this = this;
				Board board2 = CS$<>8__locals1.board;
				int levelNumber = base.LevelNumber;
				SceneType sceneType = CS$<>8__locals1.board.sceneType;
				CS$<>8__locals1.board.theWave = (int)((ulong)0L);
				Action action = delegate
				{
					int theWave = CS$<>8__locals1.board.theWave;
					if ((theWave > 20 && theWave == 30) || theWave == 10 || theWave == 20)
					{
						int levelNumber2 = CS$<>8__locals1.<>4__this.LevelNumber;
						SceneType sceneType2 = CS$<>8__locals1.board.sceneType;
					}
				};
				int num = 0;
				EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
				List<PlantType> list = new List();
				Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
				bool flag;
				if (flag)
				{
					int size = list._size;
					list._size = (flag ? 1 : 0);
					while (!flag)
					{
					}
				}
			}
			while (num2 != (ulong)0L);
			SeedLibrary instance = SeedLibrary.Instance;
			if (NumBattleMecLevel2.<>c.<>9__10_2 == 0)
			{
				Action<CardUI> action2;
				NumBattleMecLevel2.<>c.<>9__10_2 = action2;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06003B39 RID: 15161 RVA: 0x00136FE4 File Offset: 0x001351E4
		[Token(Token = "0x1700043A")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B39")]
			[Address(RVA = "0x7F2F60", Offset = "0x7F1560", VA = "0x1807F2F60", Slot = "20")]
			get
			{
				List<ZombieType> list;
				ulong num2;
				do
				{
					Board instance = Board.Instance;
					list = new List();
					int num = 0;
					if (instance != num)
					{
						num++;
						num += num;
						if (instance.theWave == 0)
						{
						}
					}
					List<ZombieType> list2 = new List();
					int size = list2._size;
					int size2 = list2._size;
					int size3 = list2._size;
					int size4 = list2._size;
					int size5 = list2._size;
					int size6 = list2._size;
					int size7 = list2._size;
					int size8 = list2._size;
					int size9 = list2._size;
					int size10 = list2._size;
					int size11 = list2._size;
					list.AddRange(list2);
					List<ZombieType> list3 = new List();
					int size12 = list3._size;
					int size13 = list3._size;
					int size14 = list3._size;
					int size15 = list3._size;
					int size16 = list3._size;
					int size17 = list3._size;
					int size18 = list3._size;
					list.AddRange(list3);
					List<ZombieType> list4 = new List();
					int size19 = list4._size;
					int size20 = list4._size;
					int size21 = list4._size;
					int size22 = list4._size;
					int size23 = list4._size;
					int size24 = list4._size;
					list.AddRange(list4);
					HashSet<ZombieType> leaderZombies = TypeMgr.LeaderZombies;
					bool flag;
					if (flag)
					{
						int size25 = list._size;
						list._size = (flag ? 1 : 0);
					}
				}
				while (num2 != (ulong)0L);
				return list;
			}
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x00137174 File Offset: 0x00135374
		[Token(Token = "0x6003B3A")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public NumBattleMecLevel2()
		{
		}
	}
}
