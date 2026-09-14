using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000AD8 RID: 2776
	[Token(Token = "0x2000AD8")]
	public abstract class LevelData
	{
		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06003973 RID: 14707 RVA: 0x0012FD68 File Offset: 0x0012DF68
		// (set) Token: 0x06003974 RID: 14708 RVA: 0x0012FD7C File Offset: 0x0012DF7C
		[Token(Token = "0x170003C1")]
		public virtual VictoryType VictoryType
		{
			[Token(Token = "0x6003973")]
			[Address(RVA = "0x39C420", Offset = "0x39AA20", VA = "0x18039C420", Slot = "4")]
			get;
			[Token(Token = "0x6003974")]
			[Address(RVA = "0x4A9D70", Offset = "0x4A8370", VA = "0x1804A9D70", Slot = "5")]
			set;
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06003975 RID: 14709 RVA: 0x0012FD90 File Offset: 0x0012DF90
		// (set) Token: 0x06003976 RID: 14710 RVA: 0x0012FDA4 File Offset: 0x0012DFA4
		[Token(Token = "0x170003C2")]
		public virtual int CardCount
		{
			[Token(Token = "0x6003975")]
			[Address(RVA = "0x78AF10", Offset = "0x789510", VA = "0x18078AF10", Slot = "6")]
			get;
			[Token(Token = "0x6003976")]
			[Address(RVA = "0x78AF60", Offset = "0x789560", VA = "0x18078AF60", Slot = "7")]
			set;
		} = (int)((ulong)14L);

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06003977 RID: 14711 RVA: 0x0012FDB8 File Offset: 0x0012DFB8
		// (set) Token: 0x06003978 RID: 14712 RVA: 0x0012FDCC File Offset: 0x0012DFCC
		[Token(Token = "0x170003C3")]
		public virtual string Name
		{
			[Token(Token = "0x6003977")]
			[Address(RVA = "0x3C9940", Offset = "0x3C7F40", VA = "0x1803C9940", Slot = "8")]
			get;
			[Token(Token = "0x6003978")]
			[Address(RVA = "0x4A9D50", Offset = "0x4A8350", VA = "0x1804A9D50", Slot = "9")]
			set;
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06003979 RID: 14713 RVA: 0x0012FDE0 File Offset: 0x0012DFE0
		// (set) Token: 0x0600397A RID: 14714 RVA: 0x0012FDF4 File Offset: 0x0012DFF4
		[Token(Token = "0x170003C4")]
		public virtual int MaxWave
		{
			[Token(Token = "0x6003979")]
			[Address(RVA = "0x3D1110", Offset = "0x3CF710", VA = "0x1803D1110", Slot = "10")]
			get;
			[Token(Token = "0x600397A")]
			[Address(RVA = "0x783390", Offset = "0x781990", VA = "0x180783390", Slot = "11")]
			set;
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600397B RID: 14715 RVA: 0x0012FE08 File Offset: 0x0012E008
		// (set) Token: 0x0600397C RID: 14716 RVA: 0x0012FE1C File Offset: 0x0012E01C
		[Token(Token = "0x170003C5")]
		public virtual SceneType SceneType
		{
			[Token(Token = "0x600397B")]
			[Address(RVA = "0x525960", Offset = "0x523F60", VA = "0x180525960", Slot = "12")]
			get;
			[Token(Token = "0x600397C")]
			[Address(RVA = "0x6FBEA0", Offset = "0x6FA4A0", VA = "0x1806FBEA0", Slot = "13")]
			set;
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x0012FE30 File Offset: 0x0012E030
		// (set) Token: 0x0600397E RID: 14718 RVA: 0x0012FE44 File Offset: 0x0012E044
		[Token(Token = "0x170003C6")]
		public virtual LevelType LevelType
		{
			[Token(Token = "0x600397D")]
			[Address(RVA = "0x525970", Offset = "0x523F70", VA = "0x180525970", Slot = "14")]
			get;
			[Token(Token = "0x600397E")]
			[Address(RVA = "0x788EE0", Offset = "0x7874E0", VA = "0x180788EE0", Slot = "15")]
			set;
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600397F RID: 14719 RVA: 0x0012FE58 File Offset: 0x0012E058
		// (set) Token: 0x06003980 RID: 14720 RVA: 0x0012FE6C File Offset: 0x0012E06C
		[Token(Token = "0x170003C7")]
		public virtual int LevelNumber
		{
			[Token(Token = "0x600397F")]
			[Address(RVA = "0x4B6F00", Offset = "0x4B5500", VA = "0x1804B6F00", Slot = "16")]
			get;
			[Token(Token = "0x6003980")]
			[Address(RVA = "0x78AF70", Offset = "0x789570", VA = "0x18078AF70", Slot = "17")]
			set;
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06003981 RID: 14721 RVA: 0x0012FE80 File Offset: 0x0012E080
		// (set) Token: 0x06003982 RID: 14722 RVA: 0x0012FE94 File Offset: 0x0012E094
		[Token(Token = "0x170003C8")]
		public virtual BoardConfig Config
		{
			[Token(Token = "0x6003981")]
			[Address(RVA = "0x7291C0", Offset = "0x7277C0", VA = "0x1807291C0", Slot = "18")]
			get;
			[Token(Token = "0x6003982")]
			[Address(RVA = "0x788ED0", Offset = "0x7874D0", VA = "0x180788ED0", Slot = "19")]
			set;
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06003983 RID: 14723 RVA: 0x0012FEA8 File Offset: 0x0012E0A8
		// (set) Token: 0x06003984 RID: 14724 RVA: 0x0012FEBC File Offset: 0x0012E0BC
		[Token(Token = "0x170003C9")]
		public virtual List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003983")]
			[Address(RVA = "0x7291A0", Offset = "0x7277A0", VA = "0x1807291A0", Slot = "20")]
			get;
			[Token(Token = "0x6003984")]
			[Address(RVA = "0x6FBEB0", Offset = "0x6FA4B0", VA = "0x1806FBEB0", Slot = "21")]
			set;
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06003985 RID: 14725 RVA: 0x0012FED0 File Offset: 0x0012E0D0
		// (set) Token: 0x06003986 RID: 14726 RVA: 0x0012FEE4 File Offset: 0x0012E0E4
		[Token(Token = "0x170003CA")]
		public virtual List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003985")]
			[Address(RVA = "0x74FED0", Offset = "0x74E4D0", VA = "0x18074FED0", Slot = "22")]
			get;
			[Token(Token = "0x6003986")]
			[Address(RVA = "0x74FFB0", Offset = "0x74E5B0", VA = "0x18074FFB0", Slot = "23")]
			set;
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06003987 RID: 14727 RVA: 0x0012FEF8 File Offset: 0x0012E0F8
		// (set) Token: 0x06003988 RID: 14728 RVA: 0x0012FF0C File Offset: 0x0012E10C
		[Token(Token = "0x170003CB")]
		public virtual List<ZombieType> PreselectCards_zombie
		{
			[Token(Token = "0x6003987")]
			[Address(RVA = "0x5B7FE0", Offset = "0x5B65E0", VA = "0x1805B7FE0", Slot = "24")]
			get;
			[Token(Token = "0x6003988")]
			[Address(RVA = "0x3BE880", Offset = "0x3BCE80", VA = "0x1803BE880", Slot = "25")]
			set;
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06003989 RID: 14729 RVA: 0x0012FF20 File Offset: 0x0012E120
		// (set) Token: 0x0600398A RID: 14730 RVA: 0x0012FF34 File Offset: 0x0012E134
		[Token(Token = "0x170003CC")]
		public virtual List<PlantDataManager.PlantData> PlantDatas
		{
			[Token(Token = "0x6003989")]
			[Address(RVA = "0x5B7FF0", Offset = "0x5B65F0", VA = "0x1805B7FF0", Slot = "26")]
			get;
			[Token(Token = "0x600398A")]
			[Address(RVA = "0x5B8270", Offset = "0x5B6870", VA = "0x1805B8270", Slot = "27")]
			set;
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600398B RID: 14731 RVA: 0x0012FF48 File Offset: 0x0012E148
		// (set) Token: 0x0600398C RID: 14732 RVA: 0x0012FF5C File Offset: 0x0012E15C
		[Token(Token = "0x170003CD")]
		public List<ZombieDataManager.ZombieData> ZombieDatas
		{
			[Token(Token = "0x600398B")]
			[Address(RVA = "0x78AF50", Offset = "0x789550", VA = "0x18078AF50")]
			get;
			[Token(Token = "0x600398C")]
			[Address(RVA = "0x78AFA0", Offset = "0x7895A0", VA = "0x18078AFA0")]
			set;
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x0600398D RID: 14733 RVA: 0x0012FF70 File Offset: 0x0012E170
		// (set) Token: 0x0600398E RID: 14734 RVA: 0x0012FF84 File Offset: 0x0012E184
		[Token(Token = "0x170003CE")]
		public virtual List<ScaryPotData> ScaryPotDatas
		{
			[Token(Token = "0x600398D")]
			[Address(RVA = "0x78AF30", Offset = "0x789530", VA = "0x18078AF30", Slot = "28")]
			get;
			[Token(Token = "0x600398E")]
			[Address(RVA = "0x78AF90", Offset = "0x789590", VA = "0x18078AF90", Slot = "29")]
			set;
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x0600398F RID: 14735 RVA: 0x0012FF98 File Offset: 0x0012E198
		// (set) Token: 0x06003990 RID: 14736 RVA: 0x0012FFAC File Offset: 0x0012E1AC
		[Token(Token = "0x170003CF")]
		public virtual List<OrderedSpawn> OrderedSpawns
		{
			[Token(Token = "0x600398F")]
			[Address(RVA = "0x78AF20", Offset = "0x789520", VA = "0x18078AF20", Slot = "30")]
			get;
			[Token(Token = "0x6003990")]
			[Address(RVA = "0x78AF80", Offset = "0x789580", VA = "0x18078AF80", Slot = "31")]
			set;
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06003991 RID: 14737 RVA: 0x0012FFC0 File Offset: 0x0012E1C0
		[Token(Token = "0x170003D0")]
		public virtual SpawnZombieConfig SpawnConfig
		{
			[Token(Token = "0x6003991")]
			[Address(RVA = "0x78AF40", Offset = "0x789540", VA = "0x18078AF40", Slot = "32")]
			get;
		}

		// Token: 0x06003992 RID: 14738 RVA: 0x0012FFD4 File Offset: 0x0012E1D4
		[Token(Token = "0x6003992")]
		[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "33")]
		public virtual bool ClickCard(CardUI card)
		{
			return false;
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x0012FFE4 File Offset: 0x0012E1E4
		[Token(Token = "0x6003993")]
		[Address(RVA = "0x78A990", Offset = "0x788F90", VA = "0x18078A990", Slot = "34")]
		public virtual void ReinforcePlant(Plant plant)
		{
			BoardConfig config = plant.board.config;
			if (config.applyRandomData)
			{
				float num = config.plantModifyMin;
				float plantModifyMax = config.plantModifyMax;
				float num2 = global::Core.Lawnf.GetRandomLogSymmetric(num, plantModifyMax);
				int num3 = 0;
				num = num2;
				plant.ModifyHealth((PlantHealthAdder)((uint)5), num2, num3 != 0);
				int num4 = 0;
				int num5 = 0;
				num2 = num;
				plant.ModifyDamage((PlantDamageAdder)((uint)44), num2, num5 != 0, num4);
				float plantSpeedAvg = config.plantSpeedAvg;
				float num6 = config.plantSpeedMax;
				float randomWithMean = global::Core.Lawnf.GetRandomWithMean(config.plantSpeedMin, num6, plantSpeedAvg);
				num6 = randomWithMean;
				plant.attributeSpeed = randomWithMean;
				plant.attackSpeedAdder = num6;
				num6 = randomWithMean;
				float num7 = num6 * plant.thePlantSpeed;
				plant.thePlantSpeed = num7;
				float num8;
				plant.thePlantProduceInterval = num8;
			}
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x001300A0 File Offset: 0x0012E2A0
		[Token(Token = "0x6003994")]
		[Address(RVA = "0x78AAE0", Offset = "0x7890E0", VA = "0x18078AAE0", Slot = "35")]
		public virtual void ReinforceZombie(Zombie zombie)
		{
			BoardConfig config = zombie.board.config;
			if (config.applyRandomData)
			{
				float zombieModifyMin = config.zombieModifyMin;
				float num = config.zombieModifyMax;
				float zombieModifyAvg = config.zombieModifyAvg;
				float randomWithMean = global::Core.Lawnf.GetRandomWithMean(zombieModifyMin, num, zombieModifyAvg);
				num = randomWithMean;
				global::Lawnf.SetZombieHealth(zombie, num);
				zombie.theAttackDamage = typeof(global::Core.Lawnf).TypeHandle;
				zombie.UpdateHealthText();
				float zombieSpeedAvg = config.zombieSpeedAvg;
				float zombieSpeedMax = config.zombieSpeedMax;
				float zombieSpeedMin = config.zombieSpeedMin;
				float theOriginSpeed = zombie.theOriginSpeed;
				float randomWithMean2 = global::Core.Lawnf.GetRandomWithMean(zombieSpeedMin, zombieSpeedMax, zombieSpeedAvg);
				zombie.theOriginSpeed = theOriginSpeed;
				Transform axis = zombie.axis;
				Vector3 vector;
				float z = vector.z;
				Transform transform = zombie.transform;
				float zombieScaleAvg = config.zombieScaleAvg;
				float zombieScaleMax = config.zombieScaleMax;
				float randomWithMean3 = global::Core.Lawnf.GetRandomWithMean(config.zombieScaleMin, zombieScaleMax, zombieScaleAvg);
			}
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x0013017C File Offset: 0x0012E37C
		[Token(Token = "0x6003995")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "36")]
		public virtual void OnBoardStart(Board board)
		{
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x0013018C File Offset: 0x0012E38C
		[Token(Token = "0x6003996")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "37")]
		public virtual void OnBoardWin(Board board)
		{
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x0013019C File Offset: 0x0012E39C
		[Token(Token = "0x6003997")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "38")]
		public virtual void CustomMapEdit(Board board)
		{
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x001301AC File Offset: 0x0012E3AC
		[Token(Token = "0x6003998")]
		[Address(RVA = "0x78A8D0", Offset = "0x788ED0", VA = "0x18078A8D0", Slot = "39")]
		public virtual void OnBoardAwake(Board board)
		{
			if (this.CardCount != 0)
			{
				int cardCount = this.CardCount;
				board.cardCountLimit = cardCount;
			}
			BoardConfig boardConfig = this.Config.Copy();
			board.config = boardConfig;
			float firstWaveArrivedTimer = this.Config.firstWaveArrivedTimer;
			board.timeUntilNextWave = firstWaveArrivedTimer;
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x001301FC File Offset: 0x0012E3FC
		[Token(Token = "0x6003999")]
		[Address(RVA = "0x78A810", Offset = "0x788E10", VA = "0x18078A810", Slot = "40")]
		public virtual void OnAnimUIOver(Board board)
		{
			if (!string.IsNullOrEmpty(this.Config.startTip))
			{
				InGameText instance = InGameText.Instance;
				string startTip = this.Config.startTip;
				float tipTime = this.Config.tipTime;
				int num = 0;
				instance.ShowText(startTip, tipTime, num != 0);
			}
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x00130250 File Offset: 0x0012E450
		[Token(Token = "0x600399A")]
		[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "41")]
		public virtual bool GameOver(Board board)
		{
			return true;
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x00130260 File Offset: 0x0012E460
		[Token(Token = "0x600399B")]
		[Address(RVA = "0x78AD10", Offset = "0x789310", VA = "0x18078AD10")]
		protected LevelData()
		{
			BoardConfig boardConfig = new BoardConfig();
			this.Config = boardConfig;
			List<ZombieType> list = new List();
			this.SpawnZombies = list;
			List<PlantType> list2 = new List();
			this.PreselectCards = list2;
			List<ZombieType> list3 = new List();
			this.PreselectCards_zombie = list3;
			List<PlantDataManager.PlantData> list4 = new List();
			this.PlantDatas = list4;
			List<ZombieDataManager.ZombieData> list5 = new List();
			this.ZombieDatas = list5;
			List<ScaryPotData> list6 = new List();
			this.ScaryPotDatas = list6;
			int num = 0;
			this.OnBoardStart(num);
		}
	}
}
