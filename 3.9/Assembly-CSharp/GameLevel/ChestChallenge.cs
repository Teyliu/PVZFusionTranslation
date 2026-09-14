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
	// Token: 0x02000AFE RID: 2814
	[Token(Token = "0x2000AFE")]
	public class ChestChallenge : ChallengeLevelData
	{
		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06003A28 RID: 14888 RVA: 0x001329AC File Offset: 0x00130BAC
		[Token(Token = "0x170003E4")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003A28")]
			[Address(RVA = "0x7EE450", Offset = "0x7ECA50", VA = "0x1807EE450", Slot = "42")]
			get
			{
				return ChallengeLevel.ChestChallenge;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06003A29 RID: 14889 RVA: 0x001329C0 File Offset: 0x00130BC0
		[Token(Token = "0x170003E5")]
		public override string Name
		{
			[Token(Token = "0x6003A29")]
			[Address(RVA = "0x7EE460", Offset = "0x7ECA60", VA = "0x1807EE460", Slot = "8")]
			get
			{
				return "超级随机：随机箱子";
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06003A2A RID: 14890 RVA: 0x001329D4 File Offset: 0x00130BD4
		[Token(Token = "0x170003E6")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003A2A")]
			[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "12")]
			get
			{
				return SceneType.Day_6;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06003A2B RID: 14891 RVA: 0x001329E4 File Offset: 0x00130BE4
		[Token(Token = "0x170003E7")]
		public override int MaxWave
		{
			[Token(Token = "0x6003A2B")]
			[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "10")]
			get
			{
				return 100;
			}
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x001329F4 File Offset: 0x00130BF4
		[Token(Token = "0x6003A2C")]
		[Address(RVA = "0x7ECAF0", Offset = "0x7EB0F0", VA = "0x1807ECAF0", Slot = "39")]
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

		// Token: 0x06003A2D RID: 14893 RVA: 0x00132A88 File Offset: 0x00130C88
		[Token(Token = "0x6003A2D")]
		[Address(RVA = "0x7ECC20", Offset = "0x7EB220", VA = "0x1807ECC20", Slot = "36")]
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

		// Token: 0x06003A2E RID: 14894 RVA: 0x00132BC0 File Offset: 0x00130DC0
		[Token(Token = "0x6003A2E")]
		[Address(RVA = "0x7ED2E0", Offset = "0x7EB8E0", VA = "0x1807ED2E0")]
		private void SetupCardUnlockSystem(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x00132BE0 File Offset: 0x00130DE0
		[Token(Token = "0x6003A2F")]
		[Address(RVA = "0x7ED890", Offset = "0x7EBE90", VA = "0x1807ED890")]
		private void UnlockCard(string cardName)
		{
			int num;
			do
			{
				num = 0;
				IEnumerable<SpecialCard> enumerable = Enumerable.OfType<SpecialCard>(InGameUI.Instance.Cards);
				Func<SpecialCard, bool> func = delegate(SpecialCard c)
				{
					string text2 = c.GetComponentInChildren<TextMeshProUGUI>().text;
					string cardName3 = cardName;
					return string.Equals(text2, cardName3);
				};
				if (Enumerable.Where<SpecialCard>(enumerable, func) != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						if (num == typeof(IEnumerator).TypeHandle)
						{
							goto IL_0081;
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
					IL_0081:
					inGameText += inGameText;
				}
				if ("{il2cpp array field local13->}" != (ulong)0L)
				{
				}
			}
			while (num != 0);
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x00132CAC File Offset: 0x00130EAC
		[Token(Token = "0x6003A30")]
		[Address(RVA = "0x7EC580", Offset = "0x7EAB80", VA = "0x1807EC580")]
		private void HideCard(string cardName)
		{
			int num;
			do
			{
				num = 0;
				IEnumerable<SpecialCard> enumerable = Enumerable.OfType<SpecialCard>(InGameUI.Instance.Cards);
				Func<SpecialCard, bool> func = delegate(SpecialCard c)
				{
					string text = c.GetComponentInChildren<TextMeshProUGUI>().text;
					string cardName2 = cardName;
					return string.Equals(text, cardName2);
				};
				if (Enumerable.Where<SpecialCard>(enumerable, func) != 0)
				{
					if (num >= typeof(IEnumerator).TypeHandle)
					{
						goto IL_004E;
					}
					num += num;
					if (num != typeof(IEnumerator).TypeHandle)
					{
						num++;
						goto IL_004E;
					}
					IL_005A:
					GameObject gameObject;
					gameObject += gameObject;
					int num2;
					num2 += 312;
					goto IL_006B;
					IL_004E:
					num2 = 0;
					gameObject.SetActive(num2 != 0);
					goto IL_005A;
				}
				IL_006B:
				if ("{il2cpp array field local13->}" != (ulong)0L)
				{
				}
			}
			while (num != 0);
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x00132D4C File Offset: 0x00130F4C
		[Token(Token = "0x6003A31")]
		[Address(RVA = "0x7EC850", Offset = "0x7EAE50", VA = "0x1807EC850", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			Board board2 = board;
			InGameText instance = InGameText.Instance;
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
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
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

		// Token: 0x06003A32 RID: 14898 RVA: 0x00132E14 File Offset: 0x00131014
		[Token(Token = "0x6003A32")]
		[Address(RVA = "0x7EAAC0", Offset = "0x7E90C0", VA = "0x1807EAAC0")]
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

		// Token: 0x06003A33 RID: 14899 RVA: 0x00132E78 File Offset: 0x00131078
		[Token(Token = "0x6003A33")]
		[Address(RVA = "0x7EB380", Offset = "0x7E9980", VA = "0x1807EB380")]
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

		// Token: 0x06003A34 RID: 14900 RVA: 0x001334BC File Offset: 0x001316BC
		[Token(Token = "0x6003A34")]
		[Address(RVA = "0x7EACA0", Offset = "0x7E92A0", VA = "0x1807EACA0")]
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

		// Token: 0x06003A35 RID: 14901 RVA: 0x00133658 File Offset: 0x00131858
		[Token(Token = "0x6003A35")]
		[Address(RVA = "0x7ED3B0", Offset = "0x7EB9B0", VA = "0x1807ED3B0")]
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
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x001336EC File Offset: 0x001318EC
		[Token(Token = "0x6003A36")]
		[Address(RVA = "0x7ED1E0", Offset = "0x7EB7E0", VA = "0x1807ED1E0")]
		private void ProcessGamblingResult(PumpinerChestMenu menu, ChestChallenge.GamblingConfig config)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x00133710 File Offset: 0x00131910
		[Token(Token = "0x6003A37")]
		[Address(RVA = "0x7ED640", Offset = "0x7EBC40", VA = "0x1807ED640")]
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

		// Token: 0x06003A38 RID: 14904 RVA: 0x00133748 File Offset: 0x00131948
		[Token(Token = "0x6003A38")]
		[Address(RVA = "0x7EC480", Offset = "0x7EAA80", VA = "0x1807EC480")]
		private void ExecuteCommission(SpecialCard card, Board board, ChestChallenge.CommissionConfig config)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x0013376C File Offset: 0x0013196C
		[Token(Token = "0x6003A39")]
		[Address(RVA = "0x7EA4A0", Offset = "0x7E8AA0", VA = "0x1807EA4A0")]
		private void BuyChest(SpecialCard card, TreasureDifficulty difficulty)
		{
			int num = 0;
			List<Plant> list = global::Lawnf.Get1x1Plants(0, num);
			Func<Plant, bool> <>9__33_ = ChestChallenge.<>c.<>9__33_0;
			if (<>9__33_ == 0)
			{
				ChestChallenge.<>c.<>9__33_0 = delegate(Plant a)
				{
					if (a.plantTag == (ulong)0L)
					{
						bool flag;
						return flag;
					}
					throw new NullReferenceException();
				};
			}
			if (Enumerable.Any<Plant>(list, <>9__33_))
			{
				InGameText instance = InGameText.Instance;
				return;
			}
			CreatePlant instance2 = CreatePlant.Instance;
			int num2 = 0;
			Plant plant;
			if (plant == 0)
			{
			}
			int num3 = 0;
			if (!(plant == num3))
			{
				Board.Instance.UseSun(0.5f);
				int num4 = this.lucky;
				num4 += 2;
				uint num5;
				num5 -= typeof(Board).TypeHandle;
				while (typeof(Board).TypeHandle <= 0)
				{
				}
				List<PlantType> list2;
				PlantType random = ListExtensions.GetRandom<PlantType>(list2);
				num2++;
			}
			InGameText instance3 = InGameText.Instance;
			throw new NullReferenceException();
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x0013382C File Offset: 0x00131A2C
		[Token(Token = "0x6003A3A")]
		[Address(RVA = "0x7EDC70", Offset = "0x7EC270", VA = "0x1807EDC70")]
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
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x00133898 File Offset: 0x00131A98
		[Token(Token = "0x6003A3B")]
		[Address(RVA = "0x7EA8F0", Offset = "0x7E8EF0", VA = "0x1807EA8F0")]
		private bool CheckPositionAvailable()
		{
			int num = 0;
			List<Plant> list = global::Lawnf.Get1x1Plants(0, num);
			Func<Plant, bool> <>9__33_ = ChestChallenge.<>c.<>9__33_0;
			if (<>9__33_ == 0)
			{
				ChestChallenge.<>c.<>9__33_0 = delegate(Plant a)
				{
					if (a.plantTag == (ulong)0L)
					{
						bool flag;
						return flag;
					}
					throw new NullReferenceException();
				};
			}
			if (!Enumerable.Any<Plant>(list, <>9__33_))
			{
			}
			InGameText instance = InGameText.Instance;
			throw new NullReferenceException();
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x001338EC File Offset: 0x00131AEC
		[Token(Token = "0x6003A3C")]
		[Address(RVA = "0x7EC290", Offset = "0x7EA890", VA = "0x1807EC290")]
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

		// Token: 0x06003A3D RID: 14909 RVA: 0x00133944 File Offset: 0x00131B44
		[Token(Token = "0x6003A3D")]
		[Address(RVA = "0x7EB1A0", Offset = "0x7E97A0", VA = "0x1807EB1A0")]
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

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06003A3E RID: 14910 RVA: 0x001339A8 File Offset: 0x00131BA8
		[Token(Token = "0x170003E8")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003A3E")]
			[Address(RVA = "0x7EE490", Offset = "0x7ECA90", VA = "0x1807EE490", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x001339EC File Offset: 0x00131BEC
		[Token(Token = "0x6003A3F")]
		[Address(RVA = "0x7EDEF0", Offset = "0x7EC4F0", VA = "0x1807EDEF0")]
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

		// Token: 0x04002C1E RID: 11294
		[Token(Token = "0x4002C1E")]
		private const int MAX_LUCKY_LEVEL = 30;

		// Token: 0x04002C1F RID: 11295
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002C1F")]
		private int lucky;

		// Token: 0x04002C20 RID: 11296
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002C20")]
		private SpecialCard luckyInfoCard;

		// Token: 0x04002C21 RID: 11297
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002C21")]
		private SpecialCard upgradeLuckyCard;

		// Token: 0x04002C22 RID: 11298
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002C22")]
		private readonly List<PlantType> BasicGamblingPool;

		// Token: 0x04002C23 RID: 11299
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002C23")]
		private readonly List<PlantType> SuperGamblingPool;

		// Token: 0x04002C24 RID: 11300
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002C24")]
		private readonly List<PlantType> UltimateGamblingPool;

		// Token: 0x02000AFF RID: 2815
		[Token(Token = "0x2000AFF")]
		private class GamblingReward
		{
			// Token: 0x170003E9 RID: 1001
			// (get) Token: 0x06003A44 RID: 14916 RVA: 0x00133B04 File Offset: 0x00131D04
			// (set) Token: 0x06003A45 RID: 14917 RVA: 0x00133B18 File Offset: 0x00131D18
			[Token(Token = "0x170003E9")]
			public int RequiredCount
			{
				[Token(Token = "0x6003A44")]
				[Address(RVA = "0x3E8430", Offset = "0x3E6A30", VA = "0x1803E8430")]
				get;
				[Token(Token = "0x6003A45")]
				[Address(RVA = "0x5159A0", Offset = "0x513FA0", VA = "0x1805159A0")]
				set;
			}

			// Token: 0x170003EA RID: 1002
			// (get) Token: 0x06003A46 RID: 14918 RVA: 0x00133B2C File Offset: 0x00131D2C
			// (set) Token: 0x06003A47 RID: 14919 RVA: 0x00133B40 File Offset: 0x00131D40
			[Token(Token = "0x170003EA")]
			public string PrizeText
			{
				[Token(Token = "0x6003A46")]
				[Address(RVA = "0x3FDA60", Offset = "0x3FC060", VA = "0x1803FDA60")]
				get;
				[Token(Token = "0x6003A47")]
				[Address(RVA = "0x515980", Offset = "0x513F80", VA = "0x180515980")]
				set;
			}

			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x06003A48 RID: 14920 RVA: 0x00133B54 File Offset: 0x00131D54
			// (set) Token: 0x06003A49 RID: 14921 RVA: 0x00133B68 File Offset: 0x00131D68
			[Token(Token = "0x170003EB")]
			public SoundType SoundType
			{
				[Token(Token = "0x6003A48")]
				[Address(RVA = "0x41DF70", Offset = "0x41C570", VA = "0x18041DF70")]
				get;
				[Token(Token = "0x6003A49")]
				[Address(RVA = "0x7EA240", Offset = "0x7E8840", VA = "0x1807EA240")]
				set;
			}

			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x06003A4A RID: 14922 RVA: 0x00133B7C File Offset: 0x00131D7C
			// (set) Token: 0x06003A4B RID: 14923 RVA: 0x00133B90 File Offset: 0x00131D90
			[Token(Token = "0x170003EC")]
			public int RewardCount
			{
				[Token(Token = "0x6003A4A")]
				[Address(RVA = "0x590AF0", Offset = "0x58F0F0", VA = "0x180590AF0")]
				get;
				[Token(Token = "0x6003A4B")]
				[Address(RVA = "0x761240", Offset = "0x75F840", VA = "0x180761240")]
				set;
			}

			// Token: 0x170003ED RID: 1005
			// (get) Token: 0x06003A4C RID: 14924 RVA: 0x00133BA4 File Offset: 0x00131DA4
			// (set) Token: 0x06003A4D RID: 14925 RVA: 0x00133BB8 File Offset: 0x00131DB8
			[Token(Token = "0x170003ED")]
			public int SunValue
			{
				[Token(Token = "0x6003A4C")]
				[Address(RVA = "0x590B00", Offset = "0x58F100", VA = "0x180590B00")]
				get;
				[Token(Token = "0x6003A4D")]
				[Address(RVA = "0x7EF910", Offset = "0x7EDF10", VA = "0x1807EF910")]
				set;
			} = (int)((ulong)1L);

			// Token: 0x06003A4E RID: 14926 RVA: 0x00133BCC File Offset: 0x00131DCC
			[Token(Token = "0x6003A4E")]
			[Address(RVA = "0x7EF920", Offset = "0x7EDF20", VA = "0x1807EF920")]
			public GamblingReward()
			{
			}
		}

		// Token: 0x02000B00 RID: 2816
		[Token(Token = "0x2000B00")]
		private class GamblingConfig
		{
			// Token: 0x170003EE RID: 1006
			// (get) Token: 0x06003A4F RID: 14927 RVA: 0x00133BE8 File Offset: 0x00131DE8
			// (set) Token: 0x06003A50 RID: 14928 RVA: 0x00133BFC File Offset: 0x00131DFC
			[Token(Token = "0x170003EE")]
			public string Name
			{
				[Token(Token = "0x6003A4F")]
				[Address(RVA = "0x7EE610", Offset = "0x7ECC10", VA = "0x1807EE610")]
				get;
				[Token(Token = "0x6003A50")]
				[Address(RVA = "0x3FB4B0", Offset = "0x3F9AB0", VA = "0x1803FB4B0")]
				set;
			}

			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x06003A51 RID: 14929 RVA: 0x00133C10 File Offset: 0x00131E10
			// (set) Token: 0x06003A52 RID: 14930 RVA: 0x00133C24 File Offset: 0x00131E24
			[Token(Token = "0x170003EF")]
			public int Cost
			{
				[Token(Token = "0x6003A51")]
				[Address(RVA = "0x794C70", Offset = "0x793270", VA = "0x180794C70")]
				get;
				[Token(Token = "0x6003A52")]
				[Address(RVA = "0x7EE630", Offset = "0x7ECC30", VA = "0x1807EE630")]
				set;
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06003A53 RID: 14931 RVA: 0x00133C38 File Offset: 0x00131E38
			// (set) Token: 0x06003A54 RID: 14932 RVA: 0x00133C4C File Offset: 0x00131E4C
			[Token(Token = "0x170003F0")]
			public float CD
			{
				[Token(Token = "0x6003A53")]
				[Address(RVA = "0x7EE600", Offset = "0x7ECC00", VA = "0x1807EE600")]
				get;
				[Token(Token = "0x6003A54")]
				[Address(RVA = "0x7EE620", Offset = "0x7ECC20", VA = "0x1807EE620")]
				set;
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06003A55 RID: 14933 RVA: 0x00133C60 File Offset: 0x00131E60
			// (set) Token: 0x06003A56 RID: 14934 RVA: 0x00133C74 File Offset: 0x00131E74
			[Token(Token = "0x170003F1")]
			public List<PlantType> PlantPool
			{
				[Token(Token = "0x6003A55")]
				[Address(RVA = "0x515920", Offset = "0x513F20", VA = "0x180515920")]
				get;
				[Token(Token = "0x6003A56")]
				[Address(RVA = "0x515960", Offset = "0x513F60", VA = "0x180515960")]
				set;
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06003A57 RID: 14935 RVA: 0x00133C88 File Offset: 0x00131E88
			// (set) Token: 0x06003A58 RID: 14936 RVA: 0x00133C9C File Offset: 0x00131E9C
			[Token(Token = "0x170003F2")]
			public int SlotCount
			{
				[Token(Token = "0x6003A57")]
				[Address(RVA = "0x590B00", Offset = "0x58F100", VA = "0x180590B00")]
				get;
				[Token(Token = "0x6003A58")]
				[Address(RVA = "0x7EF910", Offset = "0x7EDF10", VA = "0x1807EF910")]
				set;
			}

			// Token: 0x170003F3 RID: 1011
			// (get) Token: 0x06003A59 RID: 14937 RVA: 0x00133CB0 File Offset: 0x00131EB0
			// (set) Token: 0x06003A5A RID: 14938 RVA: 0x00133CC4 File Offset: 0x00131EC4
			[Token(Token = "0x170003F3")]
			public List<ChestChallenge.GamblingReward> Rewards
			{
				[Token(Token = "0x6003A59")]
				[Address(RVA = "0x78F240", Offset = "0x78D840", VA = "0x18078F240")]
				get;
				[Token(Token = "0x6003A5A")]
				[Address(RVA = "0x7EF900", Offset = "0x7EDF00", VA = "0x1807EF900")]
				set;
			}

			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x06003A5B RID: 14939 RVA: 0x00133CD8 File Offset: 0x00131ED8
			// (set) Token: 0x06003A5C RID: 14940 RVA: 0x00133CEC File Offset: 0x00131EEC
			[Token(Token = "0x170003F4")]
			public string Description
			{
				[Token(Token = "0x6003A5B")]
				[Address(RVA = "0x78F220", Offset = "0x78D820", VA = "0x18078F220")]
				get;
				[Token(Token = "0x6003A5C")]
				[Address(RVA = "0x761250", Offset = "0x75F850", VA = "0x180761250")]
				set;
			}

			// Token: 0x06003A5D RID: 14941 RVA: 0x00133D00 File Offset: 0x00131F00
			[Token(Token = "0x6003A5D")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public GamblingConfig()
			{
			}
		}

		// Token: 0x02000B01 RID: 2817
		[Token(Token = "0x2000B01")]
		private class CommissionConfig
		{
			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x06003A5E RID: 14942 RVA: 0x00133D14 File Offset: 0x00131F14
			// (set) Token: 0x06003A5F RID: 14943 RVA: 0x00133D28 File Offset: 0x00131F28
			[Token(Token = "0x170003F5")]
			public string Name
			{
				[Token(Token = "0x6003A5E")]
				[Address(RVA = "0x7EE610", Offset = "0x7ECC10", VA = "0x1807EE610")]
				get;
				[Token(Token = "0x6003A5F")]
				[Address(RVA = "0x3FB4B0", Offset = "0x3F9AB0", VA = "0x1803FB4B0")]
				set;
			}

			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x06003A60 RID: 14944 RVA: 0x00133D3C File Offset: 0x00131F3C
			// (set) Token: 0x06003A61 RID: 14945 RVA: 0x00133D50 File Offset: 0x00131F50
			[Token(Token = "0x170003F6")]
			public int Cost
			{
				[Token(Token = "0x6003A60")]
				[Address(RVA = "0x794C70", Offset = "0x793270", VA = "0x180794C70")]
				get;
				[Token(Token = "0x6003A61")]
				[Address(RVA = "0x7EE630", Offset = "0x7ECC30", VA = "0x1807EE630")]
				set;
			}

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x06003A62 RID: 14946 RVA: 0x00133D64 File Offset: 0x00131F64
			// (set) Token: 0x06003A63 RID: 14947 RVA: 0x00133D78 File Offset: 0x00131F78
			[Token(Token = "0x170003F7")]
			public float CD
			{
				[Token(Token = "0x6003A62")]
				[Address(RVA = "0x7EE600", Offset = "0x7ECC00", VA = "0x1807EE600")]
				get;
				[Token(Token = "0x6003A63")]
				[Address(RVA = "0x7EE620", Offset = "0x7ECC20", VA = "0x1807EE620")]
				set;
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x06003A64 RID: 14948 RVA: 0x00133D8C File Offset: 0x00131F8C
			// (set) Token: 0x06003A65 RID: 14949 RVA: 0x00133DA0 File Offset: 0x00131FA0
			[Token(Token = "0x170003F8")]
			public ZombieType ZombieType
			{
				[Token(Token = "0x6003A64")]
				[Address(RVA = "0x41DF70", Offset = "0x41C570", VA = "0x18041DF70")]
				get;
				[Token(Token = "0x6003A65")]
				[Address(RVA = "0x7EA240", Offset = "0x7E8840", VA = "0x1807EA240")]
				set;
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x06003A66 RID: 14950 RVA: 0x00133DB4 File Offset: 0x00131FB4
			// (set) Token: 0x06003A67 RID: 14951 RVA: 0x00133DC8 File Offset: 0x00131FC8
			[Token(Token = "0x170003F9")]
			public int Waves
			{
				[Token(Token = "0x6003A66")]
				[Address(RVA = "0x590AF0", Offset = "0x58F0F0", VA = "0x180590AF0")]
				get;
				[Token(Token = "0x6003A67")]
				[Address(RVA = "0x761240", Offset = "0x75F840", VA = "0x180761240")]
				set;
			}

			// Token: 0x06003A68 RID: 14952 RVA: 0x00133DDC File Offset: 0x00131FDC
			[Token(Token = "0x6003A68")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public CommissionConfig()
			{
			}
		}
	}
}
