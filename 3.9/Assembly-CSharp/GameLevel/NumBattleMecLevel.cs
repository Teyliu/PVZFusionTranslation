using System;
using System.Collections.Generic;
using System.Linq;
using AdvBuffData;
using Core;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B22 RID: 2850
	[Token(Token = "0x2000B22")]
	public class NumBattleMecLevel : ChallengeLevelData
	{
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x0013645C File Offset: 0x0013465C
		[Token(Token = "0x17000431")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003B1E")]
			[Address(RVA = "0x7F52F0", Offset = "0x7F38F0", VA = "0x1807F52F0", Slot = "42")]
			get
			{
				return ChallengeLevel.NumBattleMecLevel;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06003B1F RID: 15135 RVA: 0x00136470 File Offset: 0x00134670
		[Token(Token = "0x17000432")]
		public override string Name
		{
			[Token(Token = "0x6003B1F")]
			[Address(RVA = "0x7F5300", Offset = "0x7F3900", VA = "0x1807F5300", Slot = "8")]
			get
			{
				return "数值大战机制1";
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06003B20 RID: 15136 RVA: 0x00136484 File Offset: 0x00134684
		[Token(Token = "0x17000433")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B20")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06003B21 RID: 15137 RVA: 0x00136494 File Offset: 0x00134694
		[Token(Token = "0x17000434")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B21")]
			[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "10")]
			get
			{
				return 40;
			}
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x001364A4 File Offset: 0x001346A4
		[Token(Token = "0x6003B22")]
		[Address(RVA = "0x7F4130", Offset = "0x7F2730", VA = "0x1807F4130", Slot = "39")]
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

		// Token: 0x06003B23 RID: 15139 RVA: 0x0013661C File Offset: 0x0013481C
		[Token(Token = "0x6003B23")]
		[Address(RVA = "0x7F4F80", Offset = "0x7F3580", VA = "0x1807F4F80", Slot = "35")]
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

		// Token: 0x06003B24 RID: 15140 RVA: 0x00136660 File Offset: 0x00134860
		[Token(Token = "0x6003B24")]
		[Address(RVA = "0x7F4460", Offset = "0x7F2A60", VA = "0x1807F4460", Slot = "36")]
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

		// Token: 0x06003B25 RID: 15141 RVA: 0x001367C4 File Offset: 0x001349C4
		[Token(Token = "0x6003B25")]
		[Address(RVA = "0x7F5030", Offset = "0x7F3630", VA = "0x1807F5030")]
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

		// Token: 0x06003B26 RID: 15142 RVA: 0x00136854 File Offset: 0x00134A54
		[Token(Token = "0x6003B26")]
		[Address(RVA = "0x7F3AC0", Offset = "0x7F20C0", VA = "0x1807F3AC0", Slot = "41")]
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
					if (instance != 0)
					{
						if (instance != 0)
						{
							if (instance != (ulong)1L)
							{
								IL_014C:
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
			goto IL_014C;
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06003B27 RID: 15143 RVA: 0x001369C0 File Offset: 0x00134BC0
		[Token(Token = "0x17000435")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B27")]
			[Address(RVA = "0x7F5330", Offset = "0x7F3930", VA = "0x1807F5330", Slot = "20")]
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

		// Token: 0x06003B28 RID: 15144 RVA: 0x00136B48 File Offset: 0x00134D48
		[Token(Token = "0x6003B28")]
		[Address(RVA = "0x7F5270", Offset = "0x7F3870", VA = "0x1807F5270")]
		public NumBattleMecLevel()
		{
			List<SavePlantData> list = new List();
			this.savePlantDatas = list;
			base..ctor();
		}

		// Token: 0x04002CAB RID: 11435
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002CAB")]
		private readonly List<SavePlantData> savePlantDatas;

		// Token: 0x04002CAC RID: 11436
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002CAC")]
		private int count;

		// Token: 0x04002CAD RID: 11437
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x4002CAD")]
		private int saveWave;
	}
}
