using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AE5 RID: 2789
	[Token(Token = "0x2000AE5")]
	public class NumBattleMecLevel2 : ChallengeLevelData
	{
		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060039EE RID: 14830 RVA: 0x00131C78 File Offset: 0x0012FE78
		[Token(Token = "0x170003EE")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x60039EE")]
			[Address(RVA = "0x78C870", Offset = "0x78AE70", VA = "0x18078C870", Slot = "42")]
			get
			{
				return ChallengeLevel.NumBattleMecLevel2;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060039EF RID: 14831 RVA: 0x00131C8C File Offset: 0x0012FE8C
		[Token(Token = "0x170003EF")]
		public override string Name
		{
			[Token(Token = "0x60039EF")]
			[Address(RVA = "0x78C880", Offset = "0x78AE80", VA = "0x18078C880", Slot = "8")]
			get
			{
				return "数值大战机制2";
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060039F0 RID: 14832 RVA: 0x00131CA0 File Offset: 0x0012FEA0
		[Token(Token = "0x170003F0")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60039F0")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060039F1 RID: 14833 RVA: 0x00131CB0 File Offset: 0x0012FEB0
		[Token(Token = "0x170003F1")]
		public override int MaxWave
		{
			[Token(Token = "0x60039F1")]
			[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "10")]
			get
			{
				return 40;
			}
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x00131CC0 File Offset: 0x0012FEC0
		[Token(Token = "0x60039F2")]
		[Address(RVA = "0x78BE20", Offset = "0x78A420", VA = "0x18078BE20", Slot = "39")]
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

		// Token: 0x060039F3 RID: 14835 RVA: 0x00131E24 File Offset: 0x00130024
		[Token(Token = "0x60039F3")]
		[Address(RVA = "0x78C7C0", Offset = "0x78ADC0", VA = "0x18078C7C0", Slot = "35")]
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

		// Token: 0x060039F4 RID: 14836 RVA: 0x00131E68 File Offset: 0x00130068
		[Token(Token = "0x60039F4")]
		[Address(RVA = "0x78C1A0", Offset = "0x78A7A0", VA = "0x18078C1A0", Slot = "36")]
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

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060039F5 RID: 14837 RVA: 0x00131F2C File Offset: 0x0013012C
		[Token(Token = "0x170003F2")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x60039F5")]
			[Address(RVA = "0x78C8B0", Offset = "0x78AEB0", VA = "0x18078C8B0", Slot = "20")]
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

		// Token: 0x060039F6 RID: 14838 RVA: 0x001320BC File Offset: 0x001302BC
		[Token(Token = "0x60039F6")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public NumBattleMecLevel2()
		{
		}
	}
}
