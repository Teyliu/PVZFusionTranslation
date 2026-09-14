using System;
using System.Collections.Generic;
using System.Linq;
using AdvBuffData;
using Core;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AE2 RID: 2786
	[Token(Token = "0x2000AE2")]
	public class NumBattleMecLevel : ChallengeLevelData
	{
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060039DA RID: 14810 RVA: 0x00131390 File Offset: 0x0012F590
		[Token(Token = "0x170003E9")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x60039DA")]
			[Address(RVA = "0x78EC30", Offset = "0x78D230", VA = "0x18078EC30", Slot = "42")]
			get
			{
				return ChallengeLevel.NumBattleMecLevel;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060039DB RID: 14811 RVA: 0x001313A4 File Offset: 0x0012F5A4
		[Token(Token = "0x170003EA")]
		public override string Name
		{
			[Token(Token = "0x60039DB")]
			[Address(RVA = "0x78EC40", Offset = "0x78D240", VA = "0x18078EC40", Slot = "8")]
			get
			{
				return "数值大战机制1";
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060039DC RID: 14812 RVA: 0x001313B8 File Offset: 0x0012F5B8
		[Token(Token = "0x170003EB")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60039DC")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060039DD RID: 14813 RVA: 0x001313C8 File Offset: 0x0012F5C8
		[Token(Token = "0x170003EC")]
		public override int MaxWave
		{
			[Token(Token = "0x60039DD")]
			[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "10")]
			get
			{
				return 40;
			}
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x001313D8 File Offset: 0x0012F5D8
		[Token(Token = "0x60039DE")]
		[Address(RVA = "0x78DA70", Offset = "0x78C070", VA = "0x18078DA70", Slot = "39")]
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
			List<SavePlantData> list = this.savePlantDatas;
			int size = list._size;
			list._size = (int)((ulong)0L);
			if (size > 0)
			{
			}
			this.count = (int)((ulong)5L);
			board.config.applyRandomData = true;
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
			TravelMgr instance9 = TravelMgr.Instance;
			TravelMgr instance10 = TravelMgr.Instance;
			TravelMgr instance11 = TravelMgr.Instance;
			TravelMgr.Instance.damageReduction = 0.9f;
			BoardConfig config2 = board.config;
			config2.zombieCountMultiplier = 2f;
			config2.startTip = "本关卡无法融合究极植物，但植物的数值大幅提高\n不要害怕死亡！";
			throw new NullReferenceException();
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00131550 File Offset: 0x0012F750
		[Token(Token = "0x60039DF")]
		[Address(RVA = "0x78E8C0", Offset = "0x78CEC0", VA = "0x18078E8C0", Slot = "35")]
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

		// Token: 0x060039E0 RID: 14816 RVA: 0x00131594 File Offset: 0x0012F794
		[Token(Token = "0x60039E0")]
		[Address(RVA = "0x78DDA0", Offset = "0x78C3A0", VA = "0x18078DDA0", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			SeedLibrary instance = SeedLibrary.Instance;
			List<PlantType> allPlants = GameAPP.resourcesManager.allPlants;
			Func<PlantType, bool> <>9__10_ = NumBattleMecLevel.<>c.<>9__10_0;
			if (<>9__10_ == 0)
			{
				NumBattleMecLevel.<>c.<>9__10_0 = delegate(PlantType p)
				{
					bool flag;
					return flag;
				};
			}
			List<PlantType> list = Enumerable.ToList<PlantType>(Enumerable.Where<PlantType>(allPlants, <>9__10_));
			if (NumBattleMecLevel.<>c.<>9__10_1 == 0)
			{
				Action<CardUI> action;
				NumBattleMecLevel.<>c.<>9__10_1 = action;
			}
			int num = 0;
			List<PlantType> list2 = new List();
			int size = list2._size;
			int size2 = list2._size;
			int size3 = list2._size;
			int size4 = list2._size;
			int size5 = list2._size;
			SeedLibrary instance2 = SeedLibrary.Instance;
			if (NumBattleMecLevel.<>c.<>9__10_2 == 0)
			{
				Action<CardUI> action2;
				NumBattleMecLevel.<>c.<>9__10_2 = action2;
			}
			SeedLibrary instance3 = SeedLibrary.Instance;
			List<PlantType> list3 = new List();
			int size6 = list3._size;
			int size7 = list3._size;
			int size8 = list3._size;
			int size9 = list3._size;
			int size10 = list3._size;
			int size11 = list3._size;
			int size12 = list3._size;
			if (NumBattleMecLevel.<>c.<>9__10_3 == 0)
			{
				Action<CardUI> action3;
				NumBattleMecLevel.<>c.<>9__10_3 = action3;
			}
			Board board2 = board;
			int levelNumber = base.LevelNumber;
			SceneType sceneType = board.sceneType;
			board.theWave = num;
			Action action4 = delegate
			{
				int theWave = board.theWave;
				if (theWave > 20)
				{
					if (theWave == 30)
					{
						goto IL_0025;
					}
					if (theWave != 40)
					{
						return;
					}
				}
				if (theWave != 10 && theWave != 20)
				{
					return;
				}
				IL_0025:
				this.SavePlants();
				int levelNumber2 = this.LevelNumber;
				SceneType sceneType2 = board.sceneType;
			};
			int num2 = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action4, num2 != 0);
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x001316F8 File Offset: 0x0012F8F8
		[Token(Token = "0x60039E1")]
		[Address(RVA = "0x78E970", Offset = "0x78CF70", VA = "0x18078E970")]
		private void SavePlants()
		{
			int num2;
			do
			{
				int num = 0;
				List<SavePlantData> list = this.savePlantDatas;
				int size = list._size;
				num2 = 0;
				list._size = num2;
				if (size > 0)
				{
				}
				int theWave = Board.Instance.theWave;
				this.saveWave = theWave;
				List<Plant> allPlants = global::Lawnf.GetAllPlants();
				bool flag;
				if (flag)
				{
					SavePlantData savePlantData = new SavePlantData(num);
					List<SavePlantData> list2 = this.savePlantDatas;
					int size2 = list2._size;
					list2._size = savePlantData;
				}
			}
			while (num2 != 0);
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x00131788 File Offset: 0x0012F988
		[Token(Token = "0x60039E2")]
		[Address(RVA = "0x78D410", Offset = "0x78BA10", VA = "0x18078D410", Slot = "41")]
		public override bool GameOver(Board board)
		{
			ulong num;
			while ((ulong)this.count > num)
			{
				int num2 = this.saveWave;
				board.theWave = num2;
				new Random_规则之力().OnSelect(board);
				List<Plant> allPlants = global::Lawnf.GetAllPlants();
				bool flag;
				if (flag)
				{
				}
				ulong num3;
				if (num3 != (ulong)0L)
				{
					throw new NullReferenceException();
				}
				bool flag2;
				if (flag2)
				{
				}
				ulong num4;
				if (num4 == (ulong)0L)
				{
					InGameText instance = InGameText.Instance;
					int num5 = 0;
					instance.ShowText("有僵尸进家了，但是邪恶猫瓜将你回溯到上一个记录点\n但可能没收了一些东西", 3f, num5 != 0);
					if (instance != 0)
					{
						if (instance != 0)
						{
							if (instance != (ulong)1L)
							{
								IL_0162:
								throw new NullReferenceException();
							}
							List<AdvBuff> advBuffs = TravelMgr.Instance.data.advBuffs;
							List<AdvBuff> advBuffs2 = TravelMgr.Instance.data.advBuffs;
							List<TravelDebuff> travelDebuffs = TravelMgr.Instance.data.travelDebuffs;
						}
						List<AdvBuff> advBuffs3 = TravelMgr.Instance.data.advBuffs;
						List<AdvBuff> advBuffs4 = TravelMgr.Instance.data.advBuffs;
						List<TravelDebuff> travelDebuffs2 = TravelMgr.Instance.data.travelDebuffs;
					}
					List<AdvBuff> advBuffs5 = TravelMgr.Instance.data.advBuffs;
					List<AdvBuff> advBuffs6 = TravelMgr.Instance.data.advBuffs;
					List<TravelDebuff> travelDebuffs3 = TravelMgr.Instance.data.travelDebuffs;
					break;
				}
			}
			bool flag3 = string.Equals(GameAPP.playerName, "Player");
			UIMgr.EnterLoseMenu("你" + "在回溯时被超时空豌豆射手击中了");
			goto IL_0162;
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060039E3 RID: 14819 RVA: 0x00131908 File Offset: 0x0012FB08
		[Token(Token = "0x170003ED")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x60039E3")]
			[Address(RVA = "0x78EC70", Offset = "0x78D270", VA = "0x18078EC70", Slot = "20")]
			get
			{
				Board instance = Board.Instance;
				List<ZombieType> list = new List();
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
				int size25 = list4._size;
				int size26 = list4._size;
				int size27 = list4._size;
				int size28 = list4._size;
				int size29 = list4._size;
				int size30 = list4._size;
				list.AddRange(list4);
				return list;
			}
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x00131A90 File Offset: 0x0012FC90
		[Token(Token = "0x60039E4")]
		[Address(RVA = "0x78EBB0", Offset = "0x78D1B0", VA = "0x18078EBB0")]
		public NumBattleMecLevel()
		{
			List<SavePlantData> list = new List();
			this.savePlantDatas = list;
			base..ctor();
		}

		// Token: 0x04002B38 RID: 11064
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002B38")]
		private readonly List<SavePlantData> savePlantDatas;

		// Token: 0x04002B39 RID: 11065
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002B39")]
		private int count;

		// Token: 0x04002B3A RID: 11066
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x4002B3A")]
		private int saveWave;
	}
}
