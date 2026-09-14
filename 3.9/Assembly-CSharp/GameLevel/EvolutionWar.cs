using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B10 RID: 2832
	[Token(Token = "0x2000B10")]
	public class EvolutionWar : ChallengeLevelData
	{
		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06003A8C RID: 14988 RVA: 0x001347C0 File Offset: 0x001329C0
		[Token(Token = "0x170003FA")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003A8C")]
			[Address(RVA = "0x7EF7C0", Offset = "0x7EDDC0", VA = "0x1807EF7C0", Slot = "42")]
			get
			{
				return ChallengeLevel.EvolutionWar;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06003A8D RID: 14989 RVA: 0x001347D4 File Offset: 0x001329D4
		[Token(Token = "0x170003FB")]
		public override string Name
		{
			[Token(Token = "0x6003A8D")]
			[Address(RVA = "0x7EF7D0", Offset = "0x7EDDD0", VA = "0x1807EF7D0", Slot = "8")]
			get
			{
				return "战争进化史";
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06003A8E RID: 14990 RVA: 0x001347E8 File Offset: 0x001329E8
		[Token(Token = "0x170003FC")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003A8E")]
			[Address(RVA = "0x71B770", Offset = "0x719D70", VA = "0x18071B770", Slot = "12")]
			get
			{
				return SceneType.LongMap;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06003A8F RID: 14991 RVA: 0x001347F8 File Offset: 0x001329F8
		[Token(Token = "0x170003FD")]
		public override int MaxWave
		{
			[Token(Token = "0x6003A8F")]
			[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "10")]
			get
			{
				return 100;
			}
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x00134808 File Offset: 0x00132A08
		[Token(Token = "0x6003A90")]
		[Address(RVA = "0x7EEFD0", Offset = "0x7ED5D0", VA = "0x1807EEFD0", Slot = "39")]
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
			board.boardTag.evolutionWar = true;
			board.boardTag.disableInInterlude = true;
			board.boardTag.disableSummonZombie = true;
			board.boardTag.disableNormalSun = true;
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x00134888 File Offset: 0x00132A88
		[Token(Token = "0x6003A91")]
		[Address(RVA = "0x7EF0B0", Offset = "0x7ED6B0", VA = "0x1807EF0B0", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			int num = 0;
			this.UpdatePlayerCards((EvolutionWar.Stage)num);
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x001348B4 File Offset: 0x00132AB4
		[Token(Token = "0x6003A92")]
		[Address(RVA = "0x7EEF00", Offset = "0x7ED500", VA = "0x1807EEF00")]
		private void MainUpdate(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x001348D4 File Offset: 0x00132AD4
		[Token(Token = "0x6003A93")]
		[Address(RVA = "0x7EEAF0", Offset = "0x7ED0F0", VA = "0x1807EEAF0")]
		public void AIUpdate()
		{
			float aitime = this.AITime;
			float deltaTime = Time.deltaTime;
			this.AITime = aitime;
			this.AITime = 1f;
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06003A94 RID: 14996 RVA: 0x00134904 File Offset: 0x00132B04
		// (set) Token: 0x06003A95 RID: 14997 RVA: 0x00134918 File Offset: 0x00132B18
		[Token(Token = "0x170003FE")]
		private EvolutionWar.Stage AIStage
		{
			[Token(Token = "0x6003A94")]
			[Address(RVA = "0x774C80", Offset = "0x773280", VA = "0x180774C80")]
			get;
			[Token(Token = "0x6003A95")]
			[Address(RVA = "0x7EF880", Offset = "0x7EDE80", VA = "0x1807EF880")]
			set;
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06003A96 RID: 14998 RVA: 0x0013492C File Offset: 0x00132B2C
		// (set) Token: 0x06003A97 RID: 14999 RVA: 0x00134940 File Offset: 0x00132B40
		[Token(Token = "0x170003FF")]
		private int AIMoney
		{
			[Token(Token = "0x6003A96")]
			[Address(RVA = "0x774C90", Offset = "0x773290", VA = "0x180774C90")]
			get;
			[Token(Token = "0x6003A97")]
			[Address(RVA = "0x7EF870", Offset = "0x7EDE70", VA = "0x1807EF870")]
			set;
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06003A98 RID: 15000 RVA: 0x00134954 File Offset: 0x00132B54
		// (set) Token: 0x06003A99 RID: 15001 RVA: 0x00134968 File Offset: 0x00132B68
		[Token(Token = "0x17000400")]
		private int AIExperience
		{
			[Token(Token = "0x6003A98")]
			[Address(RVA = "0x774C70", Offset = "0x773270", VA = "0x180774C70")]
			get;
			[Token(Token = "0x6003A99")]
			[Address(RVA = "0x7EF860", Offset = "0x7EDE60", VA = "0x1807EF860")]
			set;
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06003A9A RID: 15002 RVA: 0x0013497C File Offset: 0x00132B7C
		// (set) Token: 0x06003A9B RID: 15003 RVA: 0x00134990 File Offset: 0x00132B90
		[Token(Token = "0x17000401")]
		private EvolutionWar.Stage PlayerStage
		{
			[Token(Token = "0x6003A9A")]
			[Address(RVA = "0x7BA290", Offset = "0x7B8890", VA = "0x1807BA290")]
			get;
			[Token(Token = "0x6003A9B")]
			[Address(RVA = "0x7EF8F0", Offset = "0x7EDEF0", VA = "0x1807EF8F0")]
			set;
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06003A9C RID: 15004 RVA: 0x001349A4 File Offset: 0x00132BA4
		// (set) Token: 0x06003A9D RID: 15005 RVA: 0x001349C4 File Offset: 0x00132BC4
		[Token(Token = "0x17000402")]
		private int PlayerMoney
		{
			[Token(Token = "0x6003A9C")]
			[Address(RVA = "0x7EF810", Offset = "0x7EDE10", VA = "0x1807EF810")]
			get
			{
				return Board.Instance.theSun;
			}
			[Token(Token = "0x6003A9D")]
			[Address(RVA = "0x7EF8A0", Offset = "0x7EDEA0", VA = "0x1807EF8A0")]
			set
			{
				Board.Instance.theSun = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06003A9E RID: 15006 RVA: 0x001349E4 File Offset: 0x00132BE4
		// (set) Token: 0x06003A9F RID: 15007 RVA: 0x001349F8 File Offset: 0x00132BF8
		[Token(Token = "0x17000403")]
		private int PlayerExperience
		{
			[Token(Token = "0x6003A9E")]
			[Address(RVA = "0x7EF800", Offset = "0x7EDE00", VA = "0x1807EF800")]
			get;
			[Token(Token = "0x6003A9F")]
			[Address(RVA = "0x7EF890", Offset = "0x7EDE90", VA = "0x1807EF890")]
			set;
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x00134A0C File Offset: 0x00132C0C
		[Token(Token = "0x6003AA0")]
		[Address(RVA = "0x7EF610", Offset = "0x7EDC10", VA = "0x1807EF610")]
		private void UpgradeStage(SpecialCard card)
		{
			if (this.<PlayerStage>k__BackingField != EvolutionWar.Stage.Stage5)
			{
				Board instance = Board.Instance;
				EvolutionWar.Stage stage = this.<PlayerStage>k__BackingField;
				this.<PlayerStage>k__BackingField = stage;
				this.UpdatePlayerCards(stage);
				return;
			}
			GameAPP.PlaySound(26, 0.5f, 1f);
			InGameText instance2 = InGameText.Instance;
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x00134A60 File Offset: 0x00132C60
		[Token(Token = "0x6003AA1")]
		[Address(RVA = "0x7EF190", Offset = "0x7ED790", VA = "0x1807EF190")]
		private void UpdatePlayerCards(EvolutionWar.Stage stage)
		{
			ulong num3;
			do
			{
				int num = 0;
				List<CardUI> cards = InGameUI.Instance.Cards;
				bool flag;
				if (flag)
				{
					bool flag2 = InGameUI.Instance.RemoveCardFromBank(num, true);
				}
				ulong num2;
				if (num2 != (ulong)0L)
				{
					goto IL_00FD;
				}
				EvolutionWar.WarConfig warConfig;
				List<EvolutionWar.ZombieConfig> <Zombies>k__BackingField = warConfig.<Zombies>k__BackingField;
				bool flag3;
				if (flag3)
				{
					EvolutionWar.<>c__DisplayClass37_0 CS$<>8__locals1;
					CS$<>8__locals1.item = num;
					InitBoard instance = InitBoard.Instance;
					ZombieType zombieType = CS$<>8__locals1.item.ZombieType;
					IZECard izecard = instance.CreateCard(zombieType, true);
					int cost = CS$<>8__locals1.item.cost;
					izecard.theSeedCost = cost;
					float cd = CS$<>8__locals1.item.cd;
					izecard.CD = cd;
					float cd2 = CS$<>8__locals1.item.cd;
					izecard.fullCD = cd2;
					Action<Zombie> action;
					izecard.onSetZombie = action;
				}
			}
			while (num3 != (ulong)0L);
			EvolutionWar.WarConfig warConfig2;
			EvolutionWar.BigSkill <BigSkill>k__BackingField = warConfig2.<BigSkill>k__BackingField;
			float cd3 = <BigSkill>k__BackingField.cd;
			Action<SpecialCard> onActive = <BigSkill>k__BackingField.onActive;
			int cost2 = <BigSkill>k__BackingField.cost;
			string name = <BigSkill>k__BackingField.name;
			return;
			IL_00FD:
			throw new NullReferenceException();
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x00134B94 File Offset: 0x00132D94
		[Token(Token = "0x6003AA2")]
		[Address(RVA = "0x7EED10", Offset = "0x7ED310", VA = "0x1807EED10")]
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

		// Token: 0x06003AA3 RID: 15011 RVA: 0x00134BEC File Offset: 0x00132DEC
		[Token(Token = "0x6003AA3")]
		[Address(RVA = "0x7EEB30", Offset = "0x7ED130", VA = "0x1807EEB30")]
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

		// Token: 0x06003AA4 RID: 15012 RVA: 0x00134C50 File Offset: 0x00132E50
		[Token(Token = "0x6003AA4")]
		[Address(RVA = "0x7EF740", Offset = "0x7EDD40", VA = "0x1807EF740")]
		public EvolutionWar()
		{
			Dictionary<EvolutionWar.Stage, EvolutionWar.WarConfig> dictionary = new Dictionary();
			this.configs = dictionary;
			base..ctor();
		}

		// Token: 0x04002C6B RID: 11371
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002C6B")]
		private float AITime;

		// Token: 0x04002C71 RID: 11377
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002C71")]
		private readonly Dictionary<EvolutionWar.Stage, EvolutionWar.WarConfig> configs;

		// Token: 0x02000B11 RID: 2833
		[Token(Token = "0x2000B11")]
		private class WarConfig
		{
			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x06003AA5 RID: 15013 RVA: 0x00134C70 File Offset: 0x00132E70
			// (set) Token: 0x06003AA6 RID: 15014 RVA: 0x00134C84 File Offset: 0x00132E84
			[Token(Token = "0x17000404")]
			public EvolutionWar.Stage Stage
			{
				[Token(Token = "0x6003AA5")]
				[Address(RVA = "0x3E8430", Offset = "0x3E6A30", VA = "0x1803E8430")]
				get;
				[Token(Token = "0x6003AA6")]
				[Address(RVA = "0x5159A0", Offset = "0x513FA0", VA = "0x1805159A0")]
				set;
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x06003AA7 RID: 15015 RVA: 0x00134C98 File Offset: 0x00132E98
			// (set) Token: 0x06003AA8 RID: 15016 RVA: 0x00134CAC File Offset: 0x00132EAC
			[Token(Token = "0x17000405")]
			public List<EvolutionWar.ZombieConfig> Zombies
			{
				[Token(Token = "0x6003AA7")]
				[Address(RVA = "0x3FDA60", Offset = "0x3FC060", VA = "0x1803FDA60")]
				get;
				[Token(Token = "0x6003AA8")]
				[Address(RVA = "0x515980", Offset = "0x513F80", VA = "0x180515980")]
				set;
			}

			// Token: 0x17000406 RID: 1030
			// (get) Token: 0x06003AA9 RID: 15017 RVA: 0x00134CC0 File Offset: 0x00132EC0
			// (set) Token: 0x06003AAA RID: 15018 RVA: 0x00134CD4 File Offset: 0x00132ED4
			[Token(Token = "0x17000406")]
			public List<EvolutionWar.PlantConfig> Plants
			{
				[Token(Token = "0x6003AA9")]
				[Address(RVA = "0x515920", Offset = "0x513F20", VA = "0x180515920")]
				get;
				[Token(Token = "0x6003AAA")]
				[Address(RVA = "0x515960", Offset = "0x513F60", VA = "0x180515960")]
				set;
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x06003AAB RID: 15019 RVA: 0x00134CE8 File Offset: 0x00132EE8
			// (set) Token: 0x06003AAC RID: 15020 RVA: 0x00134CFC File Offset: 0x00132EFC
			[Token(Token = "0x17000407")]
			public EvolutionWar.BigSkill BigSkill
			{
				[Token(Token = "0x6003AAB")]
				[Address(RVA = "0x515950", Offset = "0x513F50", VA = "0x180515950")]
				get;
				[Token(Token = "0x6003AAC")]
				[Address(RVA = "0x5159B0", Offset = "0x513FB0", VA = "0x1805159B0")]
				set;
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x06003AAD RID: 15021 RVA: 0x00134D10 File Offset: 0x00132F10
			// (set) Token: 0x06003AAE RID: 15022 RVA: 0x00134D24 File Offset: 0x00132F24
			[Token(Token = "0x17000408")]
			public int UpgradeCost
			{
				[Token(Token = "0x6003AAD")]
				[Address(RVA = "0x515930", Offset = "0x513F30", VA = "0x180515930")]
				get;
				[Token(Token = "0x6003AAE")]
				[Address(RVA = "0x515970", Offset = "0x513F70", VA = "0x180515970")]
				set;
			}

			// Token: 0x06003AAF RID: 15023 RVA: 0x00134D38 File Offset: 0x00132F38
			[Token(Token = "0x6003AAF")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public WarConfig()
			{
			}
		}

		// Token: 0x02000B12 RID: 2834
		[Token(Token = "0x2000B12")]
		private class ZombieConfig
		{
			// Token: 0x06003AB0 RID: 15024 RVA: 0x00134D4C File Offset: 0x00132F4C
			[Token(Token = "0x6003AB0")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public ZombieConfig()
			{
			}

			// Token: 0x04002C77 RID: 11383
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002C77")]
			public ZombieType ZombieType;

			// Token: 0x04002C78 RID: 11384
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4002C78")]
			public int attackDamage;

			// Token: 0x04002C79 RID: 11385
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002C79")]
			public int cost;

			// Token: 0x04002C7A RID: 11386
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4002C7A")]
			public float cd;
		}

		// Token: 0x02000B13 RID: 2835
		[Token(Token = "0x2000B13")]
		private class PlantConfig
		{
			// Token: 0x06003AB1 RID: 15025 RVA: 0x00134D60 File Offset: 0x00132F60
			[Token(Token = "0x6003AB1")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public PlantConfig()
			{
			}

			// Token: 0x04002C7B RID: 11387
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002C7B")]
			public PlantType PlantType;

			// Token: 0x04002C7C RID: 11388
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4002C7C")]
			public int attackDamage;

			// Token: 0x04002C7D RID: 11389
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002C7D")]
			public int cost;
		}

		// Token: 0x02000B14 RID: 2836
		[Token(Token = "0x2000B14")]
		private class BigSkill
		{
			// Token: 0x06003AB2 RID: 15026 RVA: 0x00134D74 File Offset: 0x00132F74
			[Token(Token = "0x6003AB2")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public BigSkill()
			{
			}

			// Token: 0x04002C7E RID: 11390
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002C7E")]
			public string name;

			// Token: 0x04002C7F RID: 11391
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002C7F")]
			public int cost;

			// Token: 0x04002C80 RID: 11392
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4002C80")]
			public float cd;

			// Token: 0x04002C81 RID: 11393
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4002C81")]
			public Action<SpecialCard> onActive;
		}

		// Token: 0x02000B15 RID: 2837
		[Token(Token = "0x2000B15")]
		private enum Stage
		{
			// Token: 0x04002C83 RID: 11395
			[Token(Token = "0x4002C83")]
			Stage1,
			// Token: 0x04002C84 RID: 11396
			[Token(Token = "0x4002C84")]
			Stage2,
			// Token: 0x04002C85 RID: 11397
			[Token(Token = "0x4002C85")]
			Stage3,
			// Token: 0x04002C86 RID: 11398
			[Token(Token = "0x4002C86")]
			Stage4,
			// Token: 0x04002C87 RID: 11399
			[Token(Token = "0x4002C87")]
			Stage5
		}
	}
}
