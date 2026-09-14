using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000ADB RID: 2779
	[Token(Token = "0x2000ADB")]
	public class RandomMix3Level : ChallengeLevelData
	{
		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060039AC RID: 14764 RVA: 0x00130610 File Offset: 0x0012E810
		[Token(Token = "0x170003D8")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x60039AC")]
			[Address(RVA = "0x7915D0", Offset = "0x78FBD0", VA = "0x1807915D0", Slot = "42")]
			get
			{
				return ChallengeLevel.RandomMix3;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060039AD RID: 14765 RVA: 0x00130624 File Offset: 0x0012E824
		[Token(Token = "0x170003D9")]
		public override string Name
		{
			[Token(Token = "0x60039AD")]
			[Address(RVA = "0x7915E0", Offset = "0x78FBE0", VA = "0x1807915E0", Slot = "8")]
			get
			{
				return "随机融合：命运";
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060039AE RID: 14766 RVA: 0x00130638 File Offset: 0x0012E838
		[Token(Token = "0x170003DA")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x60039AE")]
			[Address(RVA = "0x791610", Offset = "0x78FC10", VA = "0x180791610", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060039AF RID: 14767 RVA: 0x0013067C File Offset: 0x0012E87C
		[Token(Token = "0x170003DB")]
		public override int MaxWave
		{
			[Token(Token = "0x60039AF")]
			[Address(RVA = "0x3AAC80", Offset = "0x3A9280", VA = "0x1803AAC80", Slot = "10")]
			get
			{
				return 100;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060039B0 RID: 14768 RVA: 0x0013068C File Offset: 0x0012E88C
		[Token(Token = "0x170003DC")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60039B0")]
			[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "12")]
			get
			{
				return SceneType.Day_6;
			}
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x0013069C File Offset: 0x0012E89C
		[Token(Token = "0x60039B1")]
		[Address(RVA = "0x790D20", Offset = "0x78F320", VA = "0x180790D20", Slot = "39")]
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
			TravelMgr instance = TravelMgr.Instance;
			if (this.SceneType == SceneType.Day_6)
			{
				board.boardTag.isRandomMix2 = true;
				int num = 0;
				board.boardTag.isDixMix = true;
				board.UpdateRandomData(num != 0);
				TravelMgr instance2 = TravelMgr.Instance;
				TravelMgr instance3 = TravelMgr.Instance;
			}
			TravelUnlocks[] enumValues = global::Core.Lawnf.GetEnumValues<TravelUnlocks>();
			int num2 = 0;
			if (num2 < enumValues.Length)
			{
				if (this != (ulong)14L)
				{
					TravelMgr instance4 = TravelMgr.Instance;
				}
				num2++;
			}
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x001307A0 File Offset: 0x0012E9A0
		[Token(Token = "0x60039B2")]
		[Address(RVA = "0x791320", Offset = "0x78F920", VA = "0x180791320", Slot = "37")]
		public override void OnBoardWin(Board board)
		{
			LevelComplete levelComplete = GameAPP.config.levelComplete;
			int levelNumber = base.LevelNumber;
			int num = 0;
			if (levelComplete.completeDictionary.TryGetValue(num, num))
			{
			}
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x001307D8 File Offset: 0x0012E9D8
		[Token(Token = "0x60039B3")]
		[Address(RVA = "0x790C60", Offset = "0x78F260", VA = "0x180790C60", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			SceneType sceneType = this.SceneType;
			if (sceneType != SceneType.Day_6)
			{
				InGameText instance = InGameText.Instance;
				int num = 0;
				instance.ShowText("每一波开始更新卡槽上的卡牌并获得随机阳光，越到后期金卡越多，\n植物、僵尸的数值随机\n对着植物按<color=yellow>H</color>可以查看植物数据", 15f, num != 0);
				return;
			}
			InGameText instance2 = InGameText.Instance;
			int num2 = 0;
			instance2.ShowText("每一波开始更新卡槽上的卡牌并获得随机阳光，越到后期金卡越多，\n可以拆分植物，拆分不需要阳光\n配方随机，定期更新配方，植物、僵尸的数值随机\n对着植物按<color=yellow>H</color>可以查看植物数据", 20f, num2 != 0);
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x00130830 File Offset: 0x0012EA30
		[Token(Token = "0x60039B4")]
		[Address(RVA = "0x790360", Offset = "0x78E960", VA = "0x180790360")]
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

		// Token: 0x060039B5 RID: 14773 RVA: 0x00130868 File Offset: 0x0012EA68
		[Token(Token = "0x60039B5")]
		[Address(RVA = "0x790420", Offset = "0x78EA20", VA = "0x180790420")]
		private int DynamicRandom(int good, int bad)
		{
			float num = this.DynamicRandom((float)good, (float)bad);
			return good;
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x00130884 File Offset: 0x0012EA84
		[Token(Token = "0x60039B6")]
		[Address(RVA = "0x791440", Offset = "0x78FA40", VA = "0x180791440", Slot = "43")]
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

		// Token: 0x060039B7 RID: 14775 RVA: 0x001308D0 File Offset: 0x0012EAD0
		[Token(Token = "0x60039B7")]
		[Address(RVA = "0x790FE0", Offset = "0x78F5E0", VA = "0x180790FE0", Slot = "36")]
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

		// Token: 0x060039B8 RID: 14776 RVA: 0x00130A50 File Offset: 0x0012EC50
		[Token(Token = "0x60039B8")]
		[Address(RVA = "0x790480", Offset = "0x78EA80", VA = "0x180790480", Slot = "44")]
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
						goto IL_0115;
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
						goto IL_011B;
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
				int num8 = 0;
				instance4.ShowText(text, 5f, num8 != 0);
			}
			return;
			IL_0115:
			throw new NullReferenceException();
			IL_011B:
			throw new NullReferenceException();
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x00130B80 File Offset: 0x0012ED80
		[Token(Token = "0x60039B9")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public RandomMix3Level()
		{
		}

		// Token: 0x04002B2C RID: 11052
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002B2C")]
		protected float difficulty;
	}
}
