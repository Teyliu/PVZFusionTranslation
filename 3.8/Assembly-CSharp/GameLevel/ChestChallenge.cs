using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000ABE RID: 2750
	[Token(Token = "0x2000ABE")]
	public class ChestChallenge : ChallengeLevelData
	{
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060038E4 RID: 14564 RVA: 0x0012D784 File Offset: 0x0012B984
		[Token(Token = "0x1700039C")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x60038E4")]
			[Address(RVA = "0x787A20", Offset = "0x786020", VA = "0x180787A20", Slot = "42")]
			get
			{
				return ChallengeLevel.ChestChallenge;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x0012D798 File Offset: 0x0012B998
		[Token(Token = "0x1700039D")]
		public override string Name
		{
			[Token(Token = "0x60038E5")]
			[Address(RVA = "0x787A30", Offset = "0x786030", VA = "0x180787A30", Slot = "8")]
			get
			{
				return "超级随机：随机箱子";
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060038E6 RID: 14566 RVA: 0x0012D7AC File Offset: 0x0012B9AC
		[Token(Token = "0x1700039E")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60038E6")]
			[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "12")]
			get
			{
				return SceneType.Day_6;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x0012D7BC File Offset: 0x0012B9BC
		[Token(Token = "0x1700039F")]
		public override int MaxWave
		{
			[Token(Token = "0x60038E7")]
			[Address(RVA = "0x3AAC80", Offset = "0x3A9280", VA = "0x1803AAC80", Slot = "10")]
			get
			{
				return 100;
			}
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x0012D7CC File Offset: 0x0012B9CC
		[Token(Token = "0x60038E8")]
		[Address(RVA = "0x7860F0", Offset = "0x7846F0", VA = "0x1807860F0", Slot = "39")]
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
			board.boardTag.isSuperRandom = true;
			board.boardTag.enableAllTravelPlant = true;
			board.boardTag.zombieDropSun = true;
			board.boardTag.disableSelectCard = true;
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1000));
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x0012D860 File Offset: 0x0012BA60
		[Token(Token = "0x60038E9")]
		[Address(RVA = "0x786220", Offset = "0x784820", VA = "0x180786220", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			int num = 0;
			this.lucky = num;
			int num2 = 0;
			Action<SpecialCard> action;
			string text;
			SpecialCard specialCard = this.CreateInfoCard("查看幸运", num2, action, text);
			this.luckyInfoCard = specialCard;
			SpecialCard specialCard2;
			this.upgradeLuckyCard = specialCard2;
			Action<SpecialCard> action2;
			string text2;
			SpecialCard specialCard3 = this.CreateInfoCard("购买普通箱子", 100, action2, text2);
			Action<SpecialCard> action3;
			string text3;
			SpecialCard specialCard4 = this.CreateInfoCard("购买白银箱子", 500, action3, text3);
			Action<SpecialCard> action4;
			string text4;
			SpecialCard specialCard5 = this.CreateInfoCard("购买黄金箱子", 1000, action4, text4);
			Action<SpecialCard> action5;
			string text5;
			SpecialCard specialCard6 = this.CreateInfoCard("购买钻石箱子", 1500, action5, text5);
			this.CreateGamblingCards();
			Board board2 = board;
			this.HideCard("购买白银箱子");
			this.HideCard("购买黄金箱子");
			this.HideCard("购买钻石箱子");
			this.HideCard("开就别怕");
			this.HideCard("怕就别开");
			this.HideCard("生死有命");
			this.HideCard("简单委托");
			this.HideCard("普通委托");
			this.HideCard("困难委托");
			Board board3 = board;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x0012D998 File Offset: 0x0012BB98
		[Token(Token = "0x60038EA")]
		[Address(RVA = "0x7868E0", Offset = "0x784EE0", VA = "0x1807868E0")]
		private void SetupCardUnlockSystem(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x0012D9B8 File Offset: 0x0012BBB8
		[Token(Token = "0x60038EB")]
		[Address(RVA = "0x786E80", Offset = "0x785480", VA = "0x180786E80")]
		private void UnlockCard(string cardName)
		{
			int num;
			do
			{
				num = 0;
				Func<SpecialCard, bool> func;
				if (Enumerable.Where<SpecialCard>(Enumerable.OfType<SpecialCard>(InGameUI.Instance.Cards), func) != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						if (num == typeof(IEnumerator).TypeHandle)
						{
							goto IL_0084;
						}
						num++;
					}
					GameObject gameObject;
					if (gameObject.activeSelf)
					{
						continue;
					}
					GameObject gameObject2;
					ulong num2;
					gameObject2.SetActive(num2 != 0UL);
					InGameText inGameText = InGameText.Instance;
					string cardName2 = cardName;
					string text = "解锁新卡牌：" + cardName2;
					int num3 = 0;
					inGameText.ShowText(text, 1f, num3 != 0);
					IL_0084:
					inGameText += inGameText;
				}
				if ("{il2cpp array field local13->}" != (ulong)0L)
				{
				}
			}
			while (num != 0);
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x0012DA88 File Offset: 0x0012BC88
		[Token(Token = "0x60038EC")]
		[Address(RVA = "0x785B90", Offset = "0x784190", VA = "0x180785B90")]
		private void HideCard(string cardName)
		{
			int num;
			do
			{
				num = 0;
				new ChestChallenge.<>c__DisplayClass22_0().cardName = cardName;
				Func<SpecialCard, bool> func;
				if (Enumerable.Where<SpecialCard>(Enumerable.OfType<SpecialCard>(InGameUI.Instance.Cards), func) != 0)
				{
					if (num >= typeof(IEnumerator).TypeHandle)
					{
						goto IL_003D;
					}
					num += num;
					if (num != typeof(IEnumerator).TypeHandle)
					{
						num++;
						goto IL_003D;
					}
					IL_0046:
					GameObject gameObject;
					gameObject += gameObject;
					int num2;
					num2 += 312;
					goto IL_0052;
					IL_003D:
					num2 = 0;
					gameObject.SetActive(num2 != 0);
					goto IL_0046;
				}
				IL_0052:
				if ("{il2cpp array field local13->}" != (ulong)0L)
				{
				}
			}
			while (num != 0);
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x0012DB10 File Offset: 0x0012BD10
		[Token(Token = "0x60038ED")]
		[Address(RVA = "0x785E60", Offset = "0x784460", VA = "0x180785E60", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			Board board2 = board;
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("点击南瓜可以打开箱子\n卡槽上有许多功能卡牌供你使用\n赚取一百万阳光以获取胜利", 10f, num != 0);
			board.maxSun = (int)((ulong)1000000L);
			Board board3 = board;
			Func<bool> func = delegate
			{
				Board board4 = board;
				int maxSun = board4.maxSun;
				return board4.theSun >= maxSun;
			};
			CustomVictory customVictory;
			customVictory.condition = func;
			board3.boardVicotry = customVictory;
			Action action = delegate
			{
				board.theWave = (int)((ulong)85L);
			};
			int num2 = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num2 != 0);
			LevelProgress component = InGameUI.Instance.LevProgress.GetComponent<LevelProgress>();
			component.useValue = true;
			component.flagCount = (int)((ulong)0L);
			Func<float> func2 = delegate
			{
				Board board5 = board;
				throw new NullReferenceException();
			};
			component.value = func2;
			component.hasHead = false;
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x0012DBEC File Offset: 0x0012BDEC
		[Token(Token = "0x60038EE")]
		[Address(RVA = "0x7840D0", Offset = "0x7826D0", VA = "0x1807840D0")]
		private void CreateChestBuyingCards()
		{
			Action<SpecialCard> action;
			string text;
			SpecialCard specialCard = this.CreateInfoCard("购买普通箱子", 100, action, text);
			Action<SpecialCard> action2;
			string text2;
			SpecialCard specialCard2 = this.CreateInfoCard("购买白银箱子", 500, action2, text2);
			Action<SpecialCard> action3;
			string text3;
			SpecialCard specialCard3 = this.CreateInfoCard("购买黄金箱子", 1000, action3, text3);
			Action<SpecialCard> action4;
			string text4;
			SpecialCard specialCard4 = this.CreateInfoCard("购买钻石箱子", 1500, action4, text4);
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x0012DC50 File Offset: 0x0012BE50
		[Token(Token = "0x60038EF")]
		[Address(RVA = "0x784990", Offset = "0x782F90", VA = "0x180784990")]
		private void CreateGamblingCards()
		{
			int num2;
			do
			{
				int num = 0;
				List<ChestChallenge.GamblingConfig> list = new List();
				ChestChallenge.GamblingConfig gamblingConfig;
				gamblingConfig.<Name>k__BackingField = "小赌一手";
				gamblingConfig.<Cost>k__BackingField = (int)((ulong)200L);
				gamblingConfig.<CD>k__BackingField = 3f;
				List<PlantType> basicGamblingPool = this.BasicGamblingPool;
				gamblingConfig.<PlantPool>k__BackingField = basicGamblingPool;
				gamblingConfig.<SlotCount>k__BackingField = (int)((ulong)3L);
				gamblingConfig.<Description>k__BackingField = "送你一个箱子，如果里面有两个相同的植物则获得二等奖，有三个相同则获得一等奖";
				List<ChestChallenge.GamblingReward> list2 = new List();
				ChestChallenge.GamblingReward gamblingReward;
				gamblingReward.<SunValue>k__BackingField = (int)((ulong)1L);
				gamblingReward.<RequiredCount>k__BackingField = (int)((ulong)3L);
				gamblingReward.<PrizeText>k__BackingField = "一等奖！";
				gamblingReward.<SoundType>k__BackingField = (SoundType)((ulong)125L);
				gamblingReward.<RewardCount>k__BackingField = (int)((ulong)30L);
				gamblingReward.<SunValue>k__BackingField = (int)((ulong)25L);
				int size = list2._size;
				list2._size = gamblingReward;
				gamblingReward.<SoundType>k__BackingField = gamblingReward;
				ChestChallenge.GamblingReward gamblingReward2;
				gamblingReward2.<SunValue>k__BackingField = (int)((ulong)1L);
				gamblingReward2.<RequiredCount>k__BackingField = (int)((ulong)2L);
				gamblingReward2.<PrizeText>k__BackingField = "二等奖！";
				gamblingReward2.<SoundType>k__BackingField = (SoundType)((ulong)117L);
				gamblingReward2.<RewardCount>k__BackingField = (int)((ulong)10L);
				gamblingReward2.<SunValue>k__BackingField = (int)((ulong)25L);
				int size2 = list2._size;
				list2._size = gamblingReward2;
				gamblingReward2.<SoundType>k__BackingField = gamblingReward2;
				gamblingConfig.<Rewards>k__BackingField = list2;
				int size3 = list._size;
				gamblingConfig.<PlantPool>k__BackingField = gamblingConfig;
				ChestChallenge.GamblingConfig gamblingConfig2;
				gamblingConfig2.<Name>k__BackingField = "开就别怕";
				gamblingConfig2.<Cost>k__BackingField = (int)((ulong)1000L);
				gamblingConfig2.<CD>k__BackingField = 7.5f;
				List<PlantType> superGamblingPool = this.SuperGamblingPool;
				gamblingConfig2.<PlantPool>k__BackingField = superGamblingPool;
				gamblingConfig2.<SlotCount>k__BackingField = (int)((ulong)5L);
				gamblingConfig2.<Description>k__BackingField = "送你一个箱子，根据相同植物数量获得不同等级奖励";
				List<ChestChallenge.GamblingReward> list3 = new List();
				ChestChallenge.GamblingReward gamblingReward3;
				gamblingReward3.<SunValue>k__BackingField = (int)((ulong)1L);
				gamblingReward3.<RequiredCount>k__BackingField = (int)((ulong)5L);
				gamblingReward3.<PrizeText>k__BackingField = "一等奖！";
				gamblingReward3.<SoundType>k__BackingField = (SoundType)((ulong)125L);
				gamblingReward3.<RewardCount>k__BackingField = (int)((ulong)1500L);
				gamblingReward3.<SunValue>k__BackingField = (int)((ulong)25L);
				int size4 = list3._size;
				list3._size = gamblingReward3;
				gamblingReward3.<SoundType>k__BackingField = gamblingReward3;
				ChestChallenge.GamblingReward gamblingReward4;
				gamblingReward4.<SunValue>k__BackingField = (int)((ulong)1L);
				gamblingReward4.<RequiredCount>k__BackingField = (int)((ulong)4L);
				gamblingReward4.<PrizeText>k__BackingField = "二等奖！";
				gamblingReward4.<SoundType>k__BackingField = (SoundType)((ulong)117L);
				gamblingReward4.<RewardCount>k__BackingField = (int)((ulong)750L);
				gamblingReward4.<SunValue>k__BackingField = (int)((ulong)25L);
				int size5 = list3._size;
				list3._size = gamblingReward4;
				gamblingReward4.<SoundType>k__BackingField = gamblingReward4;
				ChestChallenge.GamblingReward gamblingReward5;
				gamblingReward5.<SunValue>k__BackingField = (int)((ulong)1L);
				gamblingReward5.<RequiredCount>k__BackingField = (int)((ulong)3L);
				gamblingReward5.<PrizeText>k__BackingField = "三等奖！";
				gamblingReward5.<SoundType>k__BackingField = (SoundType)((ulong)117L);
				gamblingReward5.<RewardCount>k__BackingField = (int)((ulong)125L);
				gamblingReward5.<SunValue>k__BackingField = (int)((ulong)25L);
				int size6 = list3._size;
				list3._size = gamblingReward5;
				gamblingReward5.<SoundType>k__BackingField = gamblingReward5;
				gamblingConfig2.<Rewards>k__BackingField = list3;
				int size7 = list._size;
				gamblingConfig2.<PlantPool>k__BackingField = gamblingConfig2;
				ChestChallenge.GamblingConfig gamblingConfig3;
				gamblingConfig3.<Name>k__BackingField = "怕就别开";
				gamblingConfig3.<Cost>k__BackingField = (int)((ulong)5000L);
				gamblingConfig3.<CD>k__BackingField = 15f;
				List<PlantType> ultimateGamblingPool = this.UltimateGamblingPool;
				gamblingConfig3.<PlantPool>k__BackingField = ultimateGamblingPool;
				gamblingConfig3.<SlotCount>k__BackingField = (int)((ulong)5L);
				gamblingConfig3.<Description>k__BackingField = "送你一个箱子，根据相同植物数量获得不同等级奖励";
				List<ChestChallenge.GamblingReward> list4 = new List();
				ChestChallenge.GamblingReward gamblingReward6;
				gamblingReward6.<SunValue>k__BackingField = (int)((ulong)1L);
				gamblingReward6.<RequiredCount>k__BackingField = (int)((ulong)5L);
				gamblingReward6.<PrizeText>k__BackingField = "一等奖！";
				gamblingReward6.<SoundType>k__BackingField = (SoundType)((ulong)125L);
				gamblingReward6.<RewardCount>k__BackingField = (int)((ulong)1500L);
				gamblingReward6.<SunValue>k__BackingField = (int)((ulong)125L);
				int size8 = list4._size;
				list4._size = gamblingReward6;
				gamblingReward6.<SoundType>k__BackingField = gamblingReward6;
				ChestChallenge.GamblingReward gamblingReward7;
				gamblingReward7.<SunValue>k__BackingField = (int)((ulong)1L);
				gamblingReward7.<RequiredCount>k__BackingField = (int)((ulong)4L);
				gamblingReward7.<PrizeText>k__BackingField = "二等奖！";
				gamblingReward7.<SoundType>k__BackingField = (SoundType)((ulong)117L);
				gamblingReward7.<RewardCount>k__BackingField = (int)((ulong)750L);
				gamblingReward7.<SunValue>k__BackingField = (int)((ulong)125L);
				int size9 = list4._size;
				list4._size = gamblingReward7;
				gamblingReward7.<SoundType>k__BackingField = gamblingReward7;
				ChestChallenge.GamblingReward gamblingReward8;
				gamblingReward8.<SunValue>k__BackingField = (int)((ulong)1L);
				gamblingReward8.<RequiredCount>k__BackingField = (int)((ulong)3L);
				gamblingReward8.<PrizeText>k__BackingField = "三等奖！";
				gamblingReward8.<SoundType>k__BackingField = (SoundType)((ulong)117L);
				gamblingReward8.<RewardCount>k__BackingField = (int)((ulong)125L);
				gamblingReward8.<SunValue>k__BackingField = (int)((ulong)125L);
				int size10 = list4._size;
				list4._size = gamblingReward8;
				gamblingReward8.<SoundType>k__BackingField = gamblingReward8;
				gamblingConfig3.<Rewards>k__BackingField = list4;
				int size11 = list._size;
				gamblingConfig3.<PlantPool>k__BackingField = gamblingConfig3;
				ChestChallenge.GamblingConfig gamblingConfig4;
				gamblingConfig4.<Name>k__BackingField = "生死有命";
				gamblingConfig4.<Cost>k__BackingField = (int)((ulong)20000L);
				gamblingConfig4.<CD>k__BackingField = 30f;
				List<PlantType> ultimateGamblingPool2 = this.UltimateGamblingPool;
				gamblingConfig4.<PlantPool>k__BackingField = ultimateGamblingPool2;
				gamblingConfig4.<SlotCount>k__BackingField = (int)((ulong)5L);
				gamblingConfig4.<Description>k__BackingField = "富贵险中求！全部相同将获得巨额奖励，但失败的代价也很惨重";
				List<ChestChallenge.GamblingReward> list5 = new List();
				ChestChallenge.GamblingReward gamblingReward9;
				gamblingReward9.<SunValue>k__BackingField = (int)((ulong)1L);
				gamblingReward9.<RequiredCount>k__BackingField = (int)((ulong)5L);
				gamblingReward9.<PrizeText>k__BackingField = "一等奖！发财了！";
				gamblingReward9.<SoundType>k__BackingField = (SoundType)((ulong)125L);
				gamblingReward9.<RewardCount>k__BackingField = (int)((ulong)1500L);
				gamblingReward9.<SunValue>k__BackingField = (int)((ulong)500L);
				int size12 = list5._size;
				list5._size = gamblingReward9;
				gamblingReward9.<SoundType>k__BackingField = gamblingReward9;
				ChestChallenge.GamblingReward gamblingReward10;
				gamblingReward10.<SunValue>k__BackingField = (int)((ulong)1L);
				gamblingReward10.<RequiredCount>k__BackingField = (int)((ulong)4L);
				gamblingReward10.<PrizeText>k__BackingField = "二等奖！";
				gamblingReward10.<SoundType>k__BackingField = (SoundType)((ulong)117L);
				gamblingReward10.<RewardCount>k__BackingField = (int)((ulong)750L);
				gamblingReward10.<SunValue>k__BackingField = (int)((ulong)500L);
				int size13 = list5._size;
				list5._size = gamblingReward10;
				gamblingReward10.<SoundType>k__BackingField = gamblingReward10;
				ChestChallenge.GamblingReward gamblingReward11;
				gamblingReward11.<SunValue>k__BackingField = (int)((ulong)1L);
				gamblingReward11.<RequiredCount>k__BackingField = (int)((ulong)3L);
				gamblingReward11.<PrizeText>k__BackingField = "三等奖！回本了";
				gamblingReward11.<SoundType>k__BackingField = (SoundType)((ulong)117L);
				gamblingReward11.<RewardCount>k__BackingField = (int)((ulong)125L);
				gamblingReward11.<SunValue>k__BackingField = (int)((ulong)500L);
				int size14 = list5._size;
				list5._size = gamblingReward11;
				gamblingReward11.<SoundType>k__BackingField = gamblingReward11;
				gamblingConfig4.<Rewards>k__BackingField = list5;
				int size15 = list._size;
				gamblingConfig4.<PlantPool>k__BackingField = gamblingConfig4;
				num2 = 0;
				bool flag;
				if (flag)
				{
					ChestChallenge.<>c__DisplayClass25_0 CS$<>8__locals1;
					CS$<>8__locals1.<>4__this = this;
					CS$<>8__locals1.config = num;
					ChestChallenge.GamblingConfig config = CS$<>8__locals1.config;
					string <Name>k__BackingField = config.<Name>k__BackingField;
					int <Cost>k__BackingField = config.<Cost>k__BackingField;
					float <CD>k__BackingField = CS$<>8__locals1.config.<CD>k__BackingField;
					Action<SpecialCard> action;
					SpecialCard specialCard = this.CreateCoolCard(<Name>k__BackingField, <Cost>k__BackingField, action, <CD>k__BackingField);
				}
			}
			while (num2 != 0);
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x0012E294 File Offset: 0x0012C494
		[Token(Token = "0x60038F0")]
		[Address(RVA = "0x7842B0", Offset = "0x7828B0", VA = "0x1807842B0")]
		private void CreateCommissionCards(Board board)
		{
			ulong num2;
			do
			{
				int num = 0;
				ChestChallenge.<>c__DisplayClass26_0 CS$<>8__locals1;
				CS$<>8__locals1.<>4__this = this;
				CS$<>8__locals1.board = board;
				List<ChestChallenge.CommissionConfig> list = new List();
				ChestChallenge.CommissionConfig commissionConfig;
				commissionConfig.<Name>k__BackingField = "简单委托";
				commissionConfig.<Cost>k__BackingField = (int)((ulong)4294966796L);
				commissionConfig.<CD>k__BackingField = 7.5f;
				commissionConfig.<ZombieType>k__BackingField = (ZombieType)((ulong)105L);
				commissionConfig.<Waves>k__BackingField = (int)((ulong)3L);
				int size = list._size;
				list._size = commissionConfig;
				commissionConfig.<ZombieType>k__BackingField = commissionConfig;
				ChestChallenge.CommissionConfig commissionConfig2;
				commissionConfig2.<Name>k__BackingField = "普通委托";
				commissionConfig2.<Cost>k__BackingField = (int)((ulong)4294966296L);
				commissionConfig2.<CD>k__BackingField = 30f;
				commissionConfig2.<ZombieType>k__BackingField = (ZombieType)((ulong)110L);
				commissionConfig2.<Waves>k__BackingField = (int)((ulong)5L);
				int size2 = list._size;
				list._size = commissionConfig2;
				commissionConfig2.<ZombieType>k__BackingField = commissionConfig2;
				ChestChallenge.CommissionConfig commissionConfig3;
				commissionConfig3.<Name>k__BackingField = "困难委托";
				commissionConfig3.<Cost>k__BackingField = (int)((ulong)4294964296L);
				commissionConfig3.<CD>k__BackingField = 50f;
				commissionConfig3.<ZombieType>k__BackingField = (ZombieType)((ulong)215L);
				commissionConfig3.<Waves>k__BackingField = (int)((ulong)10L);
				int size3 = list._size;
				list._size = commissionConfig3;
				commissionConfig3.<ZombieType>k__BackingField = commissionConfig3;
				bool flag;
				if (flag)
				{
					ChestChallenge.<>c__DisplayClass26_1 CS$<>8__locals2;
					CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
					CS$<>8__locals2.config = num;
					ChestChallenge.CommissionConfig config = CS$<>8__locals2.config;
					string <Name>k__BackingField = config.<Name>k__BackingField;
					int <Cost>k__BackingField = config.<Cost>k__BackingField;
					float <CD>k__BackingField = CS$<>8__locals2.config.<CD>k__BackingField;
					Action<SpecialCard> action;
					SpecialCard specialCard = this.CreateCoolCard(<Name>k__BackingField, <Cost>k__BackingField, action, <CD>k__BackingField);
				}
			}
			while (num2 != (ulong)0L);
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x0012E430 File Offset: 0x0012C630
		[Token(Token = "0x60038F1")]
		[Address(RVA = "0x7869B0", Offset = "0x784FB0", VA = "0x1807869B0")]
		private void SetupGamblingChest(SpecialCard card, ChestChallenge.GamblingConfig config)
		{
			GameAPP.PlaySound((SoundType)((uint)97), 0.5f, 1f);
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = card.transform;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			ulong num4;
			Particle particle = instance.SetParticle((ParticleType)((uint)62), num, 11, num4 != 0UL, (float)num2);
			card.CD = (float)num3;
			Board.Instance.UseSun(1f);
			DroppedCard droppedCard;
			Action<Plant> action;
			droppedCard.plantAction = action;
			InGameText instance2 = InGameText.Instance;
			ChestChallenge.GamblingConfig config2 = config;
			int num5 = 0;
			string text;
			instance2.ShowText(text, 7.5f, num5 != 0);
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x0012E4D8 File Offset: 0x0012C6D8
		[Token(Token = "0x60038F2")]
		[Address(RVA = "0x7867E0", Offset = "0x784DE0", VA = "0x1807867E0")]
		private void ProcessGamblingResult(PumpinerChestMenu menu, ChestChallenge.GamblingConfig config)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x0012E4FC File Offset: 0x0012C6FC
		[Token(Token = "0x60038F3")]
		[Address(RVA = "0x786C30", Offset = "0x785230", VA = "0x180786C30")]
		private UniTask SpawnItemsAsync(int column, int row, int itemType, int totalCount, int sunValue = 1)
		{
			int num = 0;
			int num2 = 0;
			if (num == 0)
			{
			}
			if (num2 < typeof(UniTask).TypeHandle)
			{
				num2 += num2;
				num2++;
			}
			num2 += num2;
			return default(UniTask);
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x0012E534 File Offset: 0x0012C734
		[Token(Token = "0x60038F4")]
		[Address(RVA = "0x785A90", Offset = "0x784090", VA = "0x180785A90")]
		private void ExecuteCommission(SpecialCard card, Board board, ChestChallenge.CommissionConfig config)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x0012E558 File Offset: 0x0012C758
		[Token(Token = "0x60038F5")]
		[Address(RVA = "0x783AE0", Offset = "0x7820E0", VA = "0x180783AE0")]
		private void BuyChest(SpecialCard card, TreasureDifficulty difficulty)
		{
			int num = 0;
			List<Plant> list = global::Lawnf.Get1x1Plants(0, num);
			Func<Plant, bool> <>9__33_ = ChestChallenge.<>c.<>9__33_0;
			if (<>9__33_ == 0)
			{
				Func<Plant, bool> func;
				ChestChallenge.<>c.<>9__33_0 = func;
			}
			if (Enumerable.Any<Plant>(list, <>9__33_))
			{
				InGameText instance = InGameText.Instance;
				int num2 = 0;
				instance.ShowText("1-1被占用了，请先清空该格子的植物", 5f, num2 != 0);
				return;
			}
			CreatePlant instance2 = CreatePlant.Instance;
			int num3 = 0;
			Plant plant;
			if (plant == 0)
			{
			}
			int num4 = 0;
			if (!(plant == num4))
			{
				Board.Instance.UseSun(0.5f);
				int num5 = this.lucky;
				num5 += 2;
				uint num6;
				num6 -= typeof(Board).TypeHandle;
				while (typeof(Board).TypeHandle <= 0)
				{
				}
				List<PlantType> list2;
				PlantType random = ListExtensions.GetRandom<PlantType>(list2);
				num3++;
			}
			InGameText instance3 = InGameText.Instance;
			int num7 = 0;
			instance3.ShowText("未知原因购买失败", 3f, num7 != 0);
			throw new NullReferenceException();
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x0012E638 File Offset: 0x0012C838
		[Token(Token = "0x60038F6")]
		[Address(RVA = "0x787250", Offset = "0x785850", VA = "0x180787250")]
		private void UpgradeLucky(SpecialCard card)
		{
			if (this.lucky < 30)
			{
				Board instance = Board.Instance;
				string text;
				this.luckyInfoCard.text.text = text;
				SpecialCard specialCard = this.upgradeLuckyCard;
				string text2;
				this.upgradeLuckyCard.text.text = text2;
				ParticleManager instance2 = ParticleManager.Instance;
				Transform transform = card.transform;
				return;
			}
			InGameText instance3 = InGameText.Instance;
			int num = 0;
			instance3.ShowText("幸运等级已升满", 3f, num != 0);
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x0012E6B8 File Offset: 0x0012C8B8
		[Token(Token = "0x60038F7")]
		[Address(RVA = "0x783F10", Offset = "0x782510", VA = "0x180783F10")]
		private bool CheckPositionAvailable()
		{
			int num = 0;
			List<Plant> list = global::Lawnf.Get1x1Plants(0, num);
			Func<Plant, bool> <>9__33_ = ChestChallenge.<>c.<>9__33_0;
			if (<>9__33_ == 0)
			{
				Func<Plant, bool> func;
				ChestChallenge.<>c.<>9__33_0 = func;
			}
			if (!Enumerable.Any<Plant>(list, <>9__33_))
			{
			}
			InGameText instance = InGameText.Instance;
			int num2 = 0;
			instance.ShowText("1-1被占用了，请先清空该格子的植物", 5f, num2 != 0);
			throw new NullReferenceException();
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x0012E714 File Offset: 0x0012C914
		[Token(Token = "0x60038F8")]
		[Address(RVA = "0x7858A0", Offset = "0x783EA0", VA = "0x1807858A0")]
		private SpecialCard CreateInfoCard(string name, int cost, Action<SpecialCard> action, string text = "")
		{
			CardUI cardUI = InitBoard.Instance.CreateCard((FunctionCardType)((uint)19), true);
			cardUI.theSeedCost = 0;
			cardUI.GetComponentInChildren<TextMeshProUGUI>().text = name;
			TextMeshProUGUI text2 = cardUI.text;
			bool flag;
			if (flag)
			{
			}
			Delegate @delegate;
			if (@delegate == 0)
			{
			}
			if (@delegate != 0 && @delegate != 0)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x0012E76C File Offset: 0x0012C96C
		[Token(Token = "0x60038F9")]
		[Address(RVA = "0x7847B0", Offset = "0x782DB0", VA = "0x1807847B0")]
		private SpecialCard CreateCoolCard(string name, int cost, Action<SpecialCard> action, float cd)
		{
			CardUI cardUI = InitBoard.Instance.CreateCard((FunctionCardType)((uint)19), true);
			cardUI.theSeedCost = 0;
			cardUI.GetComponentInChildren<TextMeshProUGUI>().text = name;
			string text;
			cardUI.text.text = text;
			Delegate @delegate;
			if (@delegate == 0)
			{
			}
			if (@delegate != 0 && @delegate != 0)
			{
				cardUI.CD = (float)0;
				cardUI.fullCD = (float)0;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060038FA RID: 14586 RVA: 0x0012E7D0 File Offset: 0x0012C9D0
		[Token(Token = "0x170003A0")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x60038FA")]
			[Address(RVA = "0x787A60", Offset = "0x786060", VA = "0x180787A60", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x0012E814 File Offset: 0x0012CA14
		[Token(Token = "0x60038FB")]
		[Address(RVA = "0x7874C0", Offset = "0x785AC0", VA = "0x1807874C0")]
		public ChestChallenge()
		{
			List<PlantType> list = new List();
			int size = list._size;
			int size2 = list._size;
			int size3 = list._size;
			this.BasicGamblingPool = list;
			List<PlantType> list2 = new List();
			int size4 = list2._size;
			int size5 = list2._size;
			int size6 = list2._size;
			int size7 = list2._size;
			int size8 = list2._size;
			this.SuperGamblingPool = list2;
			List<PlantType> list3 = new List();
			int size9 = list3._size;
			int size10 = list3._size;
			int size11 = list3._size;
			int size12 = list3._size;
			int size13 = list3._size;
			this.UltimateGamblingPool = list3;
			base..ctor();
		}

		// Token: 0x04002AAB RID: 10923
		[Token(Token = "0x4002AAB")]
		private const int MAX_LUCKY_LEVEL = 30;

		// Token: 0x04002AAC RID: 10924
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002AAC")]
		private int lucky;

		// Token: 0x04002AAD RID: 10925
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002AAD")]
		private SpecialCard luckyInfoCard;

		// Token: 0x04002AAE RID: 10926
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002AAE")]
		private SpecialCard upgradeLuckyCard;

		// Token: 0x04002AAF RID: 10927
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002AAF")]
		private readonly List<PlantType> BasicGamblingPool;

		// Token: 0x04002AB0 RID: 10928
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002AB0")]
		private readonly List<PlantType> SuperGamblingPool;

		// Token: 0x04002AB1 RID: 10929
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002AB1")]
		private readonly List<PlantType> UltimateGamblingPool;

		// Token: 0x02000ABF RID: 2751
		[Token(Token = "0x2000ABF")]
		private class GamblingReward
		{
			// Token: 0x170003A1 RID: 929
			// (get) Token: 0x06003900 RID: 14592 RVA: 0x0012E92C File Offset: 0x0012CB2C
			// (set) Token: 0x06003901 RID: 14593 RVA: 0x0012E940 File Offset: 0x0012CB40
			[Token(Token = "0x170003A1")]
			public int RequiredCount
			{
				[Token(Token = "0x6003900")]
				[Address(RVA = "0x39C420", Offset = "0x39AA20", VA = "0x18039C420")]
				get;
				[Token(Token = "0x6003901")]
				[Address(RVA = "0x4A9D70", Offset = "0x4A8370", VA = "0x1804A9D70")]
				set;
			}

			// Token: 0x170003A2 RID: 930
			// (get) Token: 0x06003902 RID: 14594 RVA: 0x0012E954 File Offset: 0x0012CB54
			// (set) Token: 0x06003903 RID: 14595 RVA: 0x0012E968 File Offset: 0x0012CB68
			[Token(Token = "0x170003A2")]
			public string PrizeText
			{
				[Token(Token = "0x6003902")]
				[Address(RVA = "0x3C9940", Offset = "0x3C7F40", VA = "0x1803C9940")]
				get;
				[Token(Token = "0x6003903")]
				[Address(RVA = "0x4A9D50", Offset = "0x4A8350", VA = "0x1804A9D50")]
				set;
			}

			// Token: 0x170003A3 RID: 931
			// (get) Token: 0x06003904 RID: 14596 RVA: 0x0012E97C File Offset: 0x0012CB7C
			// (set) Token: 0x06003905 RID: 14597 RVA: 0x0012E990 File Offset: 0x0012CB90
			[Token(Token = "0x170003A3")]
			public SoundType SoundType
			{
				[Token(Token = "0x6003904")]
				[Address(RVA = "0x3D1110", Offset = "0x3CF710", VA = "0x1803D1110")]
				get;
				[Token(Token = "0x6003905")]
				[Address(RVA = "0x783390", Offset = "0x781990", VA = "0x180783390")]
				set;
			}

			// Token: 0x170003A4 RID: 932
			// (get) Token: 0x06003906 RID: 14598 RVA: 0x0012E9A4 File Offset: 0x0012CBA4
			// (set) Token: 0x06003907 RID: 14599 RVA: 0x0012E9B8 File Offset: 0x0012CBB8
			[Token(Token = "0x170003A4")]
			public int RewardCount
			{
				[Token(Token = "0x6003906")]
				[Address(RVA = "0x525960", Offset = "0x523F60", VA = "0x180525960")]
				get;
				[Token(Token = "0x6003907")]
				[Address(RVA = "0x6FBEA0", Offset = "0x6FA4A0", VA = "0x1806FBEA0")]
				set;
			}

			// Token: 0x170003A5 RID: 933
			// (get) Token: 0x06003908 RID: 14600 RVA: 0x0012E9CC File Offset: 0x0012CBCC
			// (set) Token: 0x06003909 RID: 14601 RVA: 0x0012E9E0 File Offset: 0x0012CBE0
			[Token(Token = "0x170003A5")]
			public int SunValue
			{
				[Token(Token = "0x6003908")]
				[Address(RVA = "0x525970", Offset = "0x523F70", VA = "0x180525970")]
				get;
				[Token(Token = "0x6003909")]
				[Address(RVA = "0x788EE0", Offset = "0x7874E0", VA = "0x180788EE0")]
				set;
			} = (int)((ulong)1L);

			// Token: 0x0600390A RID: 14602 RVA: 0x0012E9F4 File Offset: 0x0012CBF4
			[Token(Token = "0x600390A")]
			[Address(RVA = "0x788EF0", Offset = "0x7874F0", VA = "0x180788EF0")]
			public GamblingReward()
			{
			}
		}

		// Token: 0x02000AC0 RID: 2752
		[Token(Token = "0x2000AC0")]
		private class GamblingConfig
		{
			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x0600390B RID: 14603 RVA: 0x0012EA10 File Offset: 0x0012CC10
			// (set) Token: 0x0600390C RID: 14604 RVA: 0x0012EA24 File Offset: 0x0012CC24
			[Token(Token = "0x170003A6")]
			public string Name
			{
				[Token(Token = "0x600390B")]
				[Address(RVA = "0x787BE0", Offset = "0x7861E0", VA = "0x180787BE0")]
				get;
				[Token(Token = "0x600390C")]
				[Address(RVA = "0x787C10", Offset = "0x786210", VA = "0x180787C10")]
				set;
			}

			// Token: 0x170003A7 RID: 935
			// (get) Token: 0x0600390D RID: 14605 RVA: 0x0012EA38 File Offset: 0x0012CC38
			// (set) Token: 0x0600390E RID: 14606 RVA: 0x0012EA4C File Offset: 0x0012CC4C
			[Token(Token = "0x170003A7")]
			public int Cost
			{
				[Token(Token = "0x600390D")]
				[Address(RVA = "0x72EBF0", Offset = "0x72D1F0", VA = "0x18072EBF0")]
				get;
				[Token(Token = "0x600390E")]
				[Address(RVA = "0x787C00", Offset = "0x786200", VA = "0x180787C00")]
				set;
			}

			// Token: 0x170003A8 RID: 936
			// (get) Token: 0x0600390F RID: 14607 RVA: 0x0012EA60 File Offset: 0x0012CC60
			// (set) Token: 0x06003910 RID: 14608 RVA: 0x0012EA74 File Offset: 0x0012CC74
			[Token(Token = "0x170003A8")]
			public float CD
			{
				[Token(Token = "0x600390F")]
				[Address(RVA = "0x787BD0", Offset = "0x7861D0", VA = "0x180787BD0")]
				get;
				[Token(Token = "0x6003910")]
				[Address(RVA = "0x787BF0", Offset = "0x7861F0", VA = "0x180787BF0")]
				set;
			}

			// Token: 0x170003A9 RID: 937
			// (get) Token: 0x06003911 RID: 14609 RVA: 0x0012EA88 File Offset: 0x0012CC88
			// (set) Token: 0x06003912 RID: 14610 RVA: 0x0012EA9C File Offset: 0x0012CC9C
			[Token(Token = "0x170003A9")]
			public List<PlantType> PlantPool
			{
				[Token(Token = "0x6003911")]
				[Address(RVA = "0x4A9CF0", Offset = "0x4A82F0", VA = "0x1804A9CF0")]
				get;
				[Token(Token = "0x6003912")]
				[Address(RVA = "0x4A9D30", Offset = "0x4A8330", VA = "0x1804A9D30")]
				set;
			}

			// Token: 0x170003AA RID: 938
			// (get) Token: 0x06003913 RID: 14611 RVA: 0x0012EAB0 File Offset: 0x0012CCB0
			// (set) Token: 0x06003914 RID: 14612 RVA: 0x0012EAC4 File Offset: 0x0012CCC4
			[Token(Token = "0x170003AA")]
			public int SlotCount
			{
				[Token(Token = "0x6003913")]
				[Address(RVA = "0x525970", Offset = "0x523F70", VA = "0x180525970")]
				get;
				[Token(Token = "0x6003914")]
				[Address(RVA = "0x788EE0", Offset = "0x7874E0", VA = "0x180788EE0")]
				set;
			}

			// Token: 0x170003AB RID: 939
			// (get) Token: 0x06003915 RID: 14613 RVA: 0x0012EAD8 File Offset: 0x0012CCD8
			// (set) Token: 0x06003916 RID: 14614 RVA: 0x0012EAEC File Offset: 0x0012CCEC
			[Token(Token = "0x170003AB")]
			public List<ChestChallenge.GamblingReward> Rewards
			{
				[Token(Token = "0x6003915")]
				[Address(RVA = "0x7291C0", Offset = "0x7277C0", VA = "0x1807291C0")]
				get;
				[Token(Token = "0x6003916")]
				[Address(RVA = "0x788ED0", Offset = "0x7874D0", VA = "0x180788ED0")]
				set;
			}

			// Token: 0x170003AC RID: 940
			// (get) Token: 0x06003917 RID: 14615 RVA: 0x0012EB00 File Offset: 0x0012CD00
			// (set) Token: 0x06003918 RID: 14616 RVA: 0x0012EB14 File Offset: 0x0012CD14
			[Token(Token = "0x170003AC")]
			public string Description
			{
				[Token(Token = "0x6003917")]
				[Address(RVA = "0x7291A0", Offset = "0x7277A0", VA = "0x1807291A0")]
				get;
				[Token(Token = "0x6003918")]
				[Address(RVA = "0x6FBEB0", Offset = "0x6FA4B0", VA = "0x1806FBEB0")]
				set;
			}

			// Token: 0x06003919 RID: 14617 RVA: 0x0012EB28 File Offset: 0x0012CD28
			[Token(Token = "0x6003919")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public GamblingConfig()
			{
			}
		}

		// Token: 0x02000AC1 RID: 2753
		[Token(Token = "0x2000AC1")]
		private class CommissionConfig
		{
			// Token: 0x170003AD RID: 941
			// (get) Token: 0x0600391A RID: 14618 RVA: 0x0012EB3C File Offset: 0x0012CD3C
			// (set) Token: 0x0600391B RID: 14619 RVA: 0x0012EB50 File Offset: 0x0012CD50
			[Token(Token = "0x170003AD")]
			public string Name
			{
				[Token(Token = "0x600391A")]
				[Address(RVA = "0x787BE0", Offset = "0x7861E0", VA = "0x180787BE0")]
				get;
				[Token(Token = "0x600391B")]
				[Address(RVA = "0x787C10", Offset = "0x786210", VA = "0x180787C10")]
				set;
			}

			// Token: 0x170003AE RID: 942
			// (get) Token: 0x0600391C RID: 14620 RVA: 0x0012EB64 File Offset: 0x0012CD64
			// (set) Token: 0x0600391D RID: 14621 RVA: 0x0012EB78 File Offset: 0x0012CD78
			[Token(Token = "0x170003AE")]
			public int Cost
			{
				[Token(Token = "0x600391C")]
				[Address(RVA = "0x72EBF0", Offset = "0x72D1F0", VA = "0x18072EBF0")]
				get;
				[Token(Token = "0x600391D")]
				[Address(RVA = "0x787C00", Offset = "0x786200", VA = "0x180787C00")]
				set;
			}

			// Token: 0x170003AF RID: 943
			// (get) Token: 0x0600391E RID: 14622 RVA: 0x0012EB8C File Offset: 0x0012CD8C
			// (set) Token: 0x0600391F RID: 14623 RVA: 0x0012EBA0 File Offset: 0x0012CDA0
			[Token(Token = "0x170003AF")]
			public float CD
			{
				[Token(Token = "0x600391E")]
				[Address(RVA = "0x787BD0", Offset = "0x7861D0", VA = "0x180787BD0")]
				get;
				[Token(Token = "0x600391F")]
				[Address(RVA = "0x787BF0", Offset = "0x7861F0", VA = "0x180787BF0")]
				set;
			}

			// Token: 0x170003B0 RID: 944
			// (get) Token: 0x06003920 RID: 14624 RVA: 0x0012EBB4 File Offset: 0x0012CDB4
			// (set) Token: 0x06003921 RID: 14625 RVA: 0x0012EBC8 File Offset: 0x0012CDC8
			[Token(Token = "0x170003B0")]
			public ZombieType ZombieType
			{
				[Token(Token = "0x6003920")]
				[Address(RVA = "0x3D1110", Offset = "0x3CF710", VA = "0x1803D1110")]
				get;
				[Token(Token = "0x6003921")]
				[Address(RVA = "0x783390", Offset = "0x781990", VA = "0x180783390")]
				set;
			}

			// Token: 0x170003B1 RID: 945
			// (get) Token: 0x06003922 RID: 14626 RVA: 0x0012EBDC File Offset: 0x0012CDDC
			// (set) Token: 0x06003923 RID: 14627 RVA: 0x0012EBF0 File Offset: 0x0012CDF0
			[Token(Token = "0x170003B1")]
			public int Waves
			{
				[Token(Token = "0x6003922")]
				[Address(RVA = "0x525960", Offset = "0x523F60", VA = "0x180525960")]
				get;
				[Token(Token = "0x6003923")]
				[Address(RVA = "0x6FBEA0", Offset = "0x6FA4A0", VA = "0x1806FBEA0")]
				set;
			}

			// Token: 0x06003924 RID: 14628 RVA: 0x0012EC04 File Offset: 0x0012CE04
			[Token(Token = "0x6003924")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public CommissionConfig()
			{
			}
		}
	}
}
