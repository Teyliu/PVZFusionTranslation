using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B1B RID: 2843
	[Token(Token = "0x2000B1B")]
	public class RandomMix3Level : ChallengeLevelData
	{
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x0013573C File Offset: 0x0013393C
		[Token(Token = "0x17000420")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003AF0")]
			[Address(RVA = "0x7F7C20", Offset = "0x7F6220", VA = "0x1807F7C20", Slot = "42")]
			get
			{
				return ChallengeLevel.RandomMix3;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06003AF1 RID: 15089 RVA: 0x00135750 File Offset: 0x00133950
		[Token(Token = "0x17000421")]
		public override string Name
		{
			[Token(Token = "0x6003AF1")]
			[Address(RVA = "0x7F7C30", Offset = "0x7F6230", VA = "0x1807F7C30", Slot = "8")]
			get
			{
				return "随机融合：命运";
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06003AF2 RID: 15090 RVA: 0x00135764 File Offset: 0x00133964
		[Token(Token = "0x17000422")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003AF2")]
			[Address(RVA = "0x7F7C60", Offset = "0x7F6260", VA = "0x1807F7C60", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06003AF3 RID: 15091 RVA: 0x001357A8 File Offset: 0x001339A8
		[Token(Token = "0x17000423")]
		public override int MaxWave
		{
			[Token(Token = "0x6003AF3")]
			[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "10")]
			get
			{
				return 100;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x001357B8 File Offset: 0x001339B8
		[Token(Token = "0x17000424")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003AF4")]
			[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "12")]
			get
			{
				return SceneType.Day_6;
			}
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x001357C8 File Offset: 0x001339C8
		[Token(Token = "0x6003AF5")]
		[Address(RVA = "0x7F7420", Offset = "0x7F5A20", VA = "0x1807F7420", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			BoardConfig boardConfig = new BoardConfig();
			base.Config = boardConfig;
			if (base.CardCount != 0)
			{
				int cardCount = base.CardCount;
				board.cardCountLimit = cardCount;
			}
			BoardConfig boardConfig2 = base.Config.Copy();
			board.config = boardConfig2;
			float firstWaveArrivedTimer = base.Config.firstWaveArrivedTimer;
			board.timeUntilNextWave = firstWaveArrivedTimer;
			board.boardTag.disableSelectCard = true;
			board.boardTag.isSuperRandom = true;
			board.boardTag.enableAllTravelPlant = true;
			board.config.applyRandomData = true;
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1000));
			if (this.SceneType == SceneType.Day_6)
			{
				board.boardTag.isRandomMix2 = true;
				int num = 0;
				board.boardTag.isDixMix = true;
				board.UpdateRandomData(num != 0);
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1014));
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1003));
			}
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x001358BC File Offset: 0x00133ABC
		[Token(Token = "0x6003AF6")]
		[Address(RVA = "0x7F7970", Offset = "0x7F5F70", VA = "0x1807F7970", Slot = "37")]
		public override void OnBoardWin(Board board)
		{
			LevelComplete levelComplete = GameAPP.config.levelComplete;
			int levelNumber = base.LevelNumber;
			int num = 0;
			if (levelComplete.completeDictionary.TryGetValue(num, num))
			{
			}
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x001358F4 File Offset: 0x00133AF4
		[Token(Token = "0x6003AF7")]
		[Address(RVA = "0x7F7340", Offset = "0x7F5940", VA = "0x1807F7340", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			SceneType sceneType = this.SceneType;
			if (sceneType != SceneType.Day_6)
			{
				InGameText instance = InGameText.Instance;
				return;
			}
			InGameText instance2 = InGameText.Instance;
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x00135924 File Offset: 0x00133B24
		[Token(Token = "0x6003AF8")]
		[Address(RVA = "0x7F6A20", Offset = "0x7F5020", VA = "0x1807F6A20")]
		private float DynamicRandom(float good, float bad)
		{
			float value = global::UnityEngine.Random.value;
			float num = this.difficulty;
			int num2 = 0;
			if (num2 > (int)num || num > 1f)
			{
			}
			if (num2 > (int)value || value > 1f)
			{
			}
			return good;
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x0013595C File Offset: 0x00133B5C
		[Token(Token = "0x6003AF9")]
		[Address(RVA = "0x7F6AE0", Offset = "0x7F50E0", VA = "0x1807F6AE0")]
		private int DynamicRandom(int good, int bad)
		{
			float num = this.DynamicRandom((float)good, (float)bad);
			return good;
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x00135978 File Offset: 0x00133B78
		[Token(Token = "0x6003AFA")]
		[Address(RVA = "0x7F7A90", Offset = "0x7F6090", VA = "0x1807F7A90", Slot = "43")]
		protected virtual void UpdateDifficulty()
		{
			LevelComplete levelComplete = GameAPP.config.levelComplete;
			int levelNumber = base.LevelNumber;
			int num = 0;
			if (levelComplete.completeDictionary.TryGetValue(num, num))
			{
				float num2 = (float)(0 * (int)0.5f);
				this.difficulty = num2;
			}
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x001359C4 File Offset: 0x00133BC4
		[Token(Token = "0x6003AFB")]
		[Address(RVA = "0x7F7630", Offset = "0x7F5C30", VA = "0x1807F7630", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			this.difficulty = 1f;
			this.UpdateDifficulty();
			Board board2 = board;
			BoardConfig boardConfig;
			float plantSpeedAvg = boardConfig.plantSpeedAvg;
			boardConfig.plantSpeedAvg = plantSpeedAvg;
			BoardConfig config = board.config;
			float num = config.zombieModifyAvg * this.difficulty;
			Board board3 = board;
			config.zombieModifyAvg = num;
			float num2 = this.DynamicRandom(50f, 10f);
			if (config > (ulong)50L)
			{
			}
			long num3 = config * (uint)100;
			board3.theSun = (int)num3;
			Board board4 = board;
			InitBoard instance = InitBoard.Instance;
			if (board4.sceneType != SceneType.Pool)
			{
				int num4 = 0;
				CardUI cardUI = instance.CreateCard((PlantType)((uint)256), true, num4 != 0);
				float num5 = this.DynamicRandom(4f, 12f);
				if (cardUI > (ulong)12L)
				{
				}
				long num6 = (long)((uint)4 * (uint)25);
				cardUI.theSeedCost = (int)num6;
			}
			int num7 = 0;
			CardUI cardUI2;
			cardUI2.fullCD = 3f;
			InitBoard instance2 = InitBoard.Instance;
			int num8 = 0;
			CardUI cardUI3 = instance2.CreateCard((PlantType)((uint)256), true, num8 != 0);
			float num9 = this.DynamicRandom(4f, 12f);
			if (cardUI3 > (ulong)12L)
			{
			}
			long num10 = (long)((uint)4 * (uint)25);
			num7++;
			cardUI3.theSeedCost = (int)num10;
			Action action = delegate
			{
				for (;;)
				{
					int num12 = 0;
					if (board.theWave != 30)
					{
						goto IL_0070;
					}
					LevelComplete levelComplete = GameAPP.config.levelComplete;
					int levelNumber = this.LevelNumber;
					if (!levelComplete.completeDictionary.TryGetValue(num12, num12))
					{
						CompleteData completeData;
						completeData.levelType = (LevelType)((ulong)1L);
						completeData.levelNumber = levelNumber;
						completeData.startCount = (int)((ulong)1L);
						levelComplete.completeDictionary[num12] = completeData;
						goto IL_0070;
					}
					IL_0154:
					float num13 = (float)(0 * (int)4f);
					Func<PlantType, bool> func;
					if (RandomMix3Level.<>c.<>9__17_5 == 0)
					{
						func = delegate(PlantType p)
						{
							bool flag2;
							return flag2;
						};
						RandomMix3Level.<>c.<>9__17_5 = func;
					}
					List<PlantType> list2;
					List<PlantType> list = Enumerable.ToList<PlantType>(Enumerable.Where<PlantType>(list2, func));
					Board board5;
					List<PlantType> list3;
					if (board5 > 0)
					{
						list3.AddRange(list);
						while (board5 != 0)
						{
						}
					}
					Board board6 = board;
					float num14 = this.DynamicRandom(num13, 0.33f);
					float num15 = num13 * 0.5f;
					ulong num16;
					board6.GetSun(num15, num16 != 0UL);
					int num17 = 0;
					List<CardUI> list4;
					CardUI cardUI4 = list4[num17];
					num17 += num17;
					int size = list4._size;
					int num18 = list4[size].theSeedCost;
					num18 += num18;
					Func<CardUI, float> func2;
					if (RandomMix3Level.<>c.<>9__17_6 == 0)
					{
						RandomMix3Level.<>c.<>9__17_6 = func2;
					}
					List<CardUI> list5 = Enumerable.ToList<CardUI>(Enumerable.OrderBy<CardUI, float>(list4, func2));
					int num19 = 0;
					CardUI cardUI5 = list5[num19];
					int size2 = list5._size;
					float cd = list5[size2].CD;
					global::Core.Lawnf.LessThan(30f, num15);
					List<CardUI> cards = InGameUI.Instance.Cards;
					bool flag;
					if (flag)
					{
						int num20 = this.DynamicRandom(num17, num18);
						float num21 = this.DynamicRandom(num15, cd);
						PlantType random = ListExtensions.GetRandom<PlantType>(list3);
						CardLevel cardLevel;
						if (cardLevel <= CardLevel.Red)
						{
						}
					}
					ulong num22;
					if (num22 == (ulong)0L)
					{
						break;
					}
					continue;
					IL_0070:
					List<CardUI> cards2 = InGameUI.Instance.Cards;
					Func<CardUI, int> func3;
					if (RandomMix3Level.<>c.<>9__17_1 == 0)
					{
						RandomMix3Level.<>c.<>9__17_1 = func3;
					}
					list4 = Enumerable.ToList<CardUI>(Enumerable.OrderBy<CardUI, int>(cards2, func3));
					list2 = new List(GameAPP.resourcesManager.allPlants);
					Predicate<PlantType> predicate;
					if (RandomMix3Level.<>c.<>9__17_2 == 0)
					{
						predicate = delegate(PlantType p)
						{
							bool flag3;
							return flag3 || p == PlantType.LilyPad;
						};
						RandomMix3Level.<>c.<>9__17_2 = predicate;
					}
					int num23 = list2.RemoveAll(predicate);
					if (board.sceneType == SceneType.Day_6)
					{
						Predicate<PlantType> predicate2;
						if (RandomMix3Level.<>c.<>9__17_3 == 0)
						{
							predicate2 = delegate(PlantType p)
							{
								bool flag4;
								return flag4;
							};
							RandomMix3Level.<>c.<>9__17_3 = predicate2;
						}
						int num24 = list2.RemoveAll(predicate2);
					}
					Func<PlantType, bool> func4;
					if (RandomMix3Level.<>c.<>9__17_4 == 0)
					{
						func4 = delegate(PlantType p)
						{
							bool flag5;
							return flag5;
						};
						RandomMix3Level.<>c.<>9__17_4 = func4;
					}
					list3 = Enumerable.ToList<PlantType>(Enumerable.Where<PlantType>(list2, func4));
					list3.AddRange(list3);
					board5 = board;
					goto IL_0154;
				}
			};
			int num11 = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num11 != 0);
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x00135B44 File Offset: 0x00133D44
		[Token(Token = "0x6003AFC")]
		[Address(RVA = "0x7F6B40", Offset = "0x7F5140", VA = "0x1807F6B40", Slot = "44")]
		protected virtual void GetBuffs(Board board)
		{
			List<object> list;
			ulong num7;
			do
			{
				list = new List();
				int num = board.theWave;
				ulong num2;
				num2 += num2;
				num = (int)((ulong)num - num2);
				if (num == 2)
				{
					Dictionary<AdvBuff, string> advancedBuffsText = TravelDictionary.advancedBuffsText;
					bool flag;
					if (flag)
					{
						bool flag2;
						while (flag2)
						{
						}
					}
					ulong num3;
					if (num3 != (ulong)0L)
					{
						goto IL_0102;
					}
					Dictionary<UltiBuff, string> ultimateBuffsText = TravelDictionary.ultimateBuffsText;
					bool flag3;
					if (flag3)
					{
						bool flag4;
						while (flag4)
						{
						}
					}
					ulong num4;
					if (num4 != (ulong)0L)
					{
						goto IL_0108;
					}
				}
				int num5 = board.theWave;
				ulong num6;
				num6 += num6;
				num5 = (int)((ulong)num5 - num6);
				if (num5 != 1)
				{
					break;
				}
				Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData = TravelDictionary.debuffData;
				bool flag5;
				if (flag5)
				{
					bool flag6;
					while (flag6)
					{
					}
					bool flag7;
					while (flag7)
					{
					}
				}
			}
			while (num7 != (ulong)0L);
			object random = ListExtensions.GetRandom<object>(list);
			if (random != 0)
			{
				if (random == 0)
				{
					if (random == 0)
					{
						if (random == 0)
						{
							return;
						}
						TravelMgr instance = TravelMgr.Instance;
					}
					TravelMgr instance2 = TravelMgr.Instance;
				}
				TravelMgr instance3 = TravelMgr.Instance;
				InGameText instance4 = InGameText.Instance;
				string text = TravelMgr.Instance.GetText(random);
			}
			return;
			IL_0102:
			throw new NullReferenceException();
			IL_0108:
			throw new NullReferenceException();
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x00135C60 File Offset: 0x00133E60
		[Token(Token = "0x6003AFD")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public RandomMix3Level()
		{
		}

		// Token: 0x04002C9F RID: 11423
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002C9F")]
		protected float difficulty;
	}
}
