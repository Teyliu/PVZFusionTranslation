using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000AD0 RID: 2768
	[Token(Token = "0x2000AD0")]
	public class EvolutionWar : ChallengeLevelData
	{
		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x0012F658 File Offset: 0x0012D858
		[Token(Token = "0x170003B2")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003948")]
			[Address(RVA = "0x788D90", Offset = "0x787390", VA = "0x180788D90", Slot = "42")]
			get
			{
				return ChallengeLevel.EvolutionWar;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x0012F66C File Offset: 0x0012D86C
		[Token(Token = "0x170003B3")]
		public override string Name
		{
			[Token(Token = "0x6003949")]
			[Address(RVA = "0x788DA0", Offset = "0x7873A0", VA = "0x180788DA0", Slot = "8")]
			get
			{
				return "战争进化史";
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x0012F680 File Offset: 0x0012D880
		[Token(Token = "0x170003B4")]
		public override SceneType SceneType
		{
			[Token(Token = "0x600394A")]
			[Address(RVA = "0x6A1610", Offset = "0x69FC10", VA = "0x1806A1610", Slot = "12")]
			get
			{
				return SceneType.LongMap;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600394B RID: 14667 RVA: 0x0012F690 File Offset: 0x0012D890
		[Token(Token = "0x170003B5")]
		public override int MaxWave
		{
			[Token(Token = "0x600394B")]
			[Address(RVA = "0x3AAC80", Offset = "0x3A9280", VA = "0x1803AAC80", Slot = "10")]
			get
			{
				return 100;
			}
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x0012F6A0 File Offset: 0x0012D8A0
		[Token(Token = "0x600394C")]
		[Address(RVA = "0x7885B0", Offset = "0x786BB0", VA = "0x1807885B0", Slot = "39")]
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

		// Token: 0x0600394D RID: 14669 RVA: 0x0012F720 File Offset: 0x0012D920
		[Token(Token = "0x600394D")]
		[Address(RVA = "0x788690", Offset = "0x786C90", VA = "0x180788690", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			int num = 0;
			this.UpdatePlayerCards((EvolutionWar.Stage)num);
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x0012F74C File Offset: 0x0012D94C
		[Token(Token = "0x600394E")]
		[Address(RVA = "0x7884E0", Offset = "0x786AE0", VA = "0x1807884E0")]
		private void MainUpdate(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x0012F76C File Offset: 0x0012D96C
		[Token(Token = "0x600394F")]
		[Address(RVA = "0x7880D0", Offset = "0x7866D0", VA = "0x1807880D0")]
		public void AIUpdate()
		{
			float aitime = this.AITime;
			float deltaTime = Time.deltaTime;
			this.AITime = aitime;
			this.AITime = 1f;
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06003950 RID: 14672 RVA: 0x0012F79C File Offset: 0x0012D99C
		// (set) Token: 0x06003951 RID: 14673 RVA: 0x0012F7B0 File Offset: 0x0012D9B0
		[Token(Token = "0x170003B6")]
		private EvolutionWar.Stage AIStage
		{
			[Token(Token = "0x6003950")]
			[Address(RVA = "0x70F750", Offset = "0x70DD50", VA = "0x18070F750")]
			get;
			[Token(Token = "0x6003951")]
			[Address(RVA = "0x788E50", Offset = "0x787450", VA = "0x180788E50")]
			set;
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06003952 RID: 14674 RVA: 0x0012F7C4 File Offset: 0x0012D9C4
		// (set) Token: 0x06003953 RID: 14675 RVA: 0x0012F7D8 File Offset: 0x0012D9D8
		[Token(Token = "0x170003B7")]
		private int AIMoney
		{
			[Token(Token = "0x6003952")]
			[Address(RVA = "0x70F760", Offset = "0x70DD60", VA = "0x18070F760")]
			get;
			[Token(Token = "0x6003953")]
			[Address(RVA = "0x788E40", Offset = "0x787440", VA = "0x180788E40")]
			set;
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06003954 RID: 14676 RVA: 0x0012F7EC File Offset: 0x0012D9EC
		// (set) Token: 0x06003955 RID: 14677 RVA: 0x0012F800 File Offset: 0x0012DA00
		[Token(Token = "0x170003B8")]
		private int AIExperience
		{
			[Token(Token = "0x6003954")]
			[Address(RVA = "0x70F740", Offset = "0x70DD40", VA = "0x18070F740")]
			get;
			[Token(Token = "0x6003955")]
			[Address(RVA = "0x788E30", Offset = "0x787430", VA = "0x180788E30")]
			set;
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06003956 RID: 14678 RVA: 0x0012F814 File Offset: 0x0012DA14
		// (set) Token: 0x06003957 RID: 14679 RVA: 0x0012F828 File Offset: 0x0012DA28
		[Token(Token = "0x170003B9")]
		private EvolutionWar.Stage PlayerStage
		{
			[Token(Token = "0x6003956")]
			[Address(RVA = "0x7536F0", Offset = "0x751CF0", VA = "0x1807536F0")]
			get;
			[Token(Token = "0x6003957")]
			[Address(RVA = "0x788EC0", Offset = "0x7874C0", VA = "0x180788EC0")]
			set;
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06003958 RID: 14680 RVA: 0x0012F83C File Offset: 0x0012DA3C
		// (set) Token: 0x06003959 RID: 14681 RVA: 0x0012F85C File Offset: 0x0012DA5C
		[Token(Token = "0x170003BA")]
		private int PlayerMoney
		{
			[Token(Token = "0x6003958")]
			[Address(RVA = "0x788DE0", Offset = "0x7873E0", VA = "0x180788DE0")]
			get
			{
				return Board.Instance.theSun;
			}
			[Token(Token = "0x6003959")]
			[Address(RVA = "0x788E70", Offset = "0x787470", VA = "0x180788E70")]
			set
			{
				Board.Instance.theSun = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x0600395A RID: 14682 RVA: 0x0012F87C File Offset: 0x0012DA7C
		// (set) Token: 0x0600395B RID: 14683 RVA: 0x0012F890 File Offset: 0x0012DA90
		[Token(Token = "0x170003BB")]
		private int PlayerExperience
		{
			[Token(Token = "0x600395A")]
			[Address(RVA = "0x788DD0", Offset = "0x7873D0", VA = "0x180788DD0")]
			get;
			[Token(Token = "0x600395B")]
			[Address(RVA = "0x788E60", Offset = "0x787460", VA = "0x180788E60")]
			set;
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x0012F8A4 File Offset: 0x0012DAA4
		[Token(Token = "0x600395C")]
		[Address(RVA = "0x788BF0", Offset = "0x7871F0", VA = "0x180788BF0")]
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
			int num = 0;
			instance2.ShowText("等级已满", 3f, num != 0);
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x0012F90C File Offset: 0x0012DB0C
		[Token(Token = "0x600395D")]
		[Address(RVA = "0x788770", Offset = "0x786D70", VA = "0x180788770")]
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

		// Token: 0x0600395E RID: 14686 RVA: 0x0012FA40 File Offset: 0x0012DC40
		[Token(Token = "0x600395E")]
		[Address(RVA = "0x7882F0", Offset = "0x7868F0", VA = "0x1807882F0")]
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

		// Token: 0x0600395F RID: 14687 RVA: 0x0012FA98 File Offset: 0x0012DC98
		[Token(Token = "0x600395F")]
		[Address(RVA = "0x788110", Offset = "0x786710", VA = "0x180788110")]
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

		// Token: 0x06003960 RID: 14688 RVA: 0x0012FAFC File Offset: 0x0012DCFC
		[Token(Token = "0x6003960")]
		[Address(RVA = "0x788D10", Offset = "0x787310", VA = "0x180788D10")]
		public EvolutionWar()
		{
			Dictionary<EvolutionWar.Stage, EvolutionWar.WarConfig> dictionary = new Dictionary();
			this.configs = dictionary;
			base..ctor();
		}

		// Token: 0x04002AF8 RID: 11000
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002AF8")]
		private float AITime;

		// Token: 0x04002AFE RID: 11006
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002AFE")]
		private readonly Dictionary<EvolutionWar.Stage, EvolutionWar.WarConfig> configs;

		// Token: 0x02000AD1 RID: 2769
		[Token(Token = "0x2000AD1")]
		private class WarConfig
		{
			// Token: 0x170003BC RID: 956
			// (get) Token: 0x06003961 RID: 14689 RVA: 0x0012FB1C File Offset: 0x0012DD1C
			// (set) Token: 0x06003962 RID: 14690 RVA: 0x0012FB30 File Offset: 0x0012DD30
			[Token(Token = "0x170003BC")]
			public EvolutionWar.Stage Stage
			{
				[Token(Token = "0x6003961")]
				[Address(RVA = "0x39C420", Offset = "0x39AA20", VA = "0x18039C420")]
				get;
				[Token(Token = "0x6003962")]
				[Address(RVA = "0x4A9D70", Offset = "0x4A8370", VA = "0x1804A9D70")]
				set;
			}

			// Token: 0x170003BD RID: 957
			// (get) Token: 0x06003963 RID: 14691 RVA: 0x0012FB44 File Offset: 0x0012DD44
			// (set) Token: 0x06003964 RID: 14692 RVA: 0x0012FB58 File Offset: 0x0012DD58
			[Token(Token = "0x170003BD")]
			public List<EvolutionWar.ZombieConfig> Zombies
			{
				[Token(Token = "0x6003963")]
				[Address(RVA = "0x3C9940", Offset = "0x3C7F40", VA = "0x1803C9940")]
				get;
				[Token(Token = "0x6003964")]
				[Address(RVA = "0x4A9D50", Offset = "0x4A8350", VA = "0x1804A9D50")]
				set;
			}

			// Token: 0x170003BE RID: 958
			// (get) Token: 0x06003965 RID: 14693 RVA: 0x0012FB6C File Offset: 0x0012DD6C
			// (set) Token: 0x06003966 RID: 14694 RVA: 0x0012FB80 File Offset: 0x0012DD80
			[Token(Token = "0x170003BE")]
			public List<EvolutionWar.PlantConfig> Plants
			{
				[Token(Token = "0x6003965")]
				[Address(RVA = "0x4A9CF0", Offset = "0x4A82F0", VA = "0x1804A9CF0")]
				get;
				[Token(Token = "0x6003966")]
				[Address(RVA = "0x4A9D30", Offset = "0x4A8330", VA = "0x1804A9D30")]
				set;
			}

			// Token: 0x170003BF RID: 959
			// (get) Token: 0x06003967 RID: 14695 RVA: 0x0012FB94 File Offset: 0x0012DD94
			// (set) Token: 0x06003968 RID: 14696 RVA: 0x0012FBA8 File Offset: 0x0012DDA8
			[Token(Token = "0x170003BF")]
			public EvolutionWar.BigSkill BigSkill
			{
				[Token(Token = "0x6003967")]
				[Address(RVA = "0x4A9D20", Offset = "0x4A8320", VA = "0x1804A9D20")]
				get;
				[Token(Token = "0x6003968")]
				[Address(RVA = "0x4A9D80", Offset = "0x4A8380", VA = "0x1804A9D80")]
				set;
			}

			// Token: 0x170003C0 RID: 960
			// (get) Token: 0x06003969 RID: 14697 RVA: 0x0012FBBC File Offset: 0x0012DDBC
			// (set) Token: 0x0600396A RID: 14698 RVA: 0x0012FBD0 File Offset: 0x0012DDD0
			[Token(Token = "0x170003C0")]
			public int UpgradeCost
			{
				[Token(Token = "0x6003969")]
				[Address(RVA = "0x4A9D00", Offset = "0x4A8300", VA = "0x1804A9D00")]
				get;
				[Token(Token = "0x600396A")]
				[Address(RVA = "0x4A9D40", Offset = "0x4A8340", VA = "0x1804A9D40")]
				set;
			}

			// Token: 0x0600396B RID: 14699 RVA: 0x0012FBE4 File Offset: 0x0012DDE4
			[Token(Token = "0x600396B")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public WarConfig()
			{
			}
		}

		// Token: 0x02000AD2 RID: 2770
		[Token(Token = "0x2000AD2")]
		private class ZombieConfig
		{
			// Token: 0x0600396C RID: 14700 RVA: 0x0012FBF8 File Offset: 0x0012DDF8
			[Token(Token = "0x600396C")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public ZombieConfig()
			{
			}

			// Token: 0x04002B04 RID: 11012
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002B04")]
			public ZombieType ZombieType;

			// Token: 0x04002B05 RID: 11013
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4002B05")]
			public int attackDamage;

			// Token: 0x04002B06 RID: 11014
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002B06")]
			public int cost;

			// Token: 0x04002B07 RID: 11015
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4002B07")]
			public float cd;
		}

		// Token: 0x02000AD3 RID: 2771
		[Token(Token = "0x2000AD3")]
		private class PlantConfig
		{
			// Token: 0x0600396D RID: 14701 RVA: 0x0012FC0C File Offset: 0x0012DE0C
			[Token(Token = "0x600396D")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public PlantConfig()
			{
			}

			// Token: 0x04002B08 RID: 11016
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002B08")]
			public PlantType PlantType;

			// Token: 0x04002B09 RID: 11017
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4002B09")]
			public int attackDamage;

			// Token: 0x04002B0A RID: 11018
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002B0A")]
			public int cost;
		}

		// Token: 0x02000AD4 RID: 2772
		[Token(Token = "0x2000AD4")]
		private class BigSkill
		{
			// Token: 0x0600396E RID: 14702 RVA: 0x0012FC20 File Offset: 0x0012DE20
			[Token(Token = "0x600396E")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public BigSkill()
			{
			}

			// Token: 0x04002B0B RID: 11019
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002B0B")]
			public string name;

			// Token: 0x04002B0C RID: 11020
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002B0C")]
			public int cost;

			// Token: 0x04002B0D RID: 11021
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4002B0D")]
			public float cd;

			// Token: 0x04002B0E RID: 11022
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4002B0E")]
			public Action<SpecialCard> onActive;
		}

		// Token: 0x02000AD5 RID: 2773
		[Token(Token = "0x2000AD5")]
		private enum Stage
		{
			// Token: 0x04002B10 RID: 11024
			[Token(Token = "0x4002B10")]
			Stage1,
			// Token: 0x04002B11 RID: 11025
			[Token(Token = "0x4002B11")]
			Stage2,
			// Token: 0x04002B12 RID: 11026
			[Token(Token = "0x4002B12")]
			Stage3,
			// Token: 0x04002B13 RID: 11027
			[Token(Token = "0x4002B13")]
			Stage4,
			// Token: 0x04002B14 RID: 11028
			[Token(Token = "0x4002B14")]
			Stage5
		}
	}
}
