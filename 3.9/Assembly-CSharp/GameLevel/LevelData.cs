using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B18 RID: 2840
	[Token(Token = "0x2000B18")]
	public abstract class LevelData
	{
		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x00134EBC File Offset: 0x001330BC
		// (set) Token: 0x06003AB8 RID: 15032 RVA: 0x00134ED0 File Offset: 0x001330D0
		[Token(Token = "0x17000409")]
		public virtual VictoryType VictoryType
		{
			[Token(Token = "0x6003AB7")]
			[Address(RVA = "0x3E8430", Offset = "0x3E6A30", VA = "0x1803E8430", Slot = "4")]
			get;
			[Token(Token = "0x6003AB8")]
			[Address(RVA = "0x5159A0", Offset = "0x513FA0", VA = "0x1805159A0", Slot = "5")]
			set;
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x00134EE4 File Offset: 0x001330E4
		// (set) Token: 0x06003ABA RID: 15034 RVA: 0x00134EF8 File Offset: 0x001330F8
		[Token(Token = "0x1700040A")]
		public virtual int CardCount
		{
			[Token(Token = "0x6003AB9")]
			[Address(RVA = "0x3EB740", Offset = "0x3E9D40", VA = "0x1803EB740", Slot = "6")]
			get;
			[Token(Token = "0x6003ABA")]
			[Address(RVA = "0x7F15D0", Offset = "0x7EFBD0", VA = "0x1807F15D0", Slot = "7")]
			set;
		} = (int)((ulong)14L);

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06003ABB RID: 15035 RVA: 0x00134F0C File Offset: 0x0013310C
		// (set) Token: 0x06003ABC RID: 15036 RVA: 0x00134F20 File Offset: 0x00133120
		[Token(Token = "0x1700040B")]
		public virtual string Name
		{
			[Token(Token = "0x6003ABB")]
			[Address(RVA = "0x3FDA60", Offset = "0x3FC060", VA = "0x1803FDA60", Slot = "8")]
			get;
			[Token(Token = "0x6003ABC")]
			[Address(RVA = "0x515980", Offset = "0x513F80", VA = "0x180515980", Slot = "9")]
			set;
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06003ABD RID: 15037 RVA: 0x00134F34 File Offset: 0x00133134
		// (set) Token: 0x06003ABE RID: 15038 RVA: 0x00134F48 File Offset: 0x00133148
		[Token(Token = "0x1700040C")]
		public virtual int MaxWave
		{
			[Token(Token = "0x6003ABD")]
			[Address(RVA = "0x41DF70", Offset = "0x41C570", VA = "0x18041DF70", Slot = "10")]
			get;
			[Token(Token = "0x6003ABE")]
			[Address(RVA = "0x7EA240", Offset = "0x7E8840", VA = "0x1807EA240", Slot = "11")]
			set;
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06003ABF RID: 15039 RVA: 0x00134F5C File Offset: 0x0013315C
		// (set) Token: 0x06003AC0 RID: 15040 RVA: 0x00134F70 File Offset: 0x00133170
		[Token(Token = "0x1700040D")]
		public virtual SceneType SceneType
		{
			[Token(Token = "0x6003ABF")]
			[Address(RVA = "0x590AF0", Offset = "0x58F0F0", VA = "0x180590AF0", Slot = "12")]
			get;
			[Token(Token = "0x6003AC0")]
			[Address(RVA = "0x761240", Offset = "0x75F840", VA = "0x180761240", Slot = "13")]
			set;
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06003AC1 RID: 15041 RVA: 0x00134F84 File Offset: 0x00133184
		// (set) Token: 0x06003AC2 RID: 15042 RVA: 0x00134F98 File Offset: 0x00133198
		[Token(Token = "0x1700040E")]
		public virtual LevelType LevelType
		{
			[Token(Token = "0x6003AC1")]
			[Address(RVA = "0x590B00", Offset = "0x58F100", VA = "0x180590B00", Slot = "14")]
			get;
			[Token(Token = "0x6003AC2")]
			[Address(RVA = "0x7EF910", Offset = "0x7EDF10", VA = "0x1807EF910", Slot = "15")]
			set;
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x00134FAC File Offset: 0x001331AC
		// (set) Token: 0x06003AC4 RID: 15044 RVA: 0x00134FC0 File Offset: 0x001331C0
		[Token(Token = "0x1700040F")]
		public virtual int LevelNumber
		{
			[Token(Token = "0x6003AC3")]
			[Address(RVA = "0x4F65C0", Offset = "0x4F4BC0", VA = "0x1804F65C0", Slot = "16")]
			get;
			[Token(Token = "0x6003AC4")]
			[Address(RVA = "0x7F15E0", Offset = "0x7EFBE0", VA = "0x1807F15E0", Slot = "17")]
			set;
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x00134FD4 File Offset: 0x001331D4
		// (set) Token: 0x06003AC6 RID: 15046 RVA: 0x00134FE8 File Offset: 0x001331E8
		[Token(Token = "0x17000410")]
		public virtual BoardConfig Config
		{
			[Token(Token = "0x6003AC5")]
			[Address(RVA = "0x78F240", Offset = "0x78D840", VA = "0x18078F240", Slot = "18")]
			get;
			[Token(Token = "0x6003AC6")]
			[Address(RVA = "0x7EF900", Offset = "0x7EDF00", VA = "0x1807EF900", Slot = "19")]
			set;
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06003AC7 RID: 15047 RVA: 0x00134FFC File Offset: 0x001331FC
		// (set) Token: 0x06003AC8 RID: 15048 RVA: 0x00135010 File Offset: 0x00133210
		[Token(Token = "0x17000411")]
		public virtual List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003AC7")]
			[Address(RVA = "0x78F220", Offset = "0x78D820", VA = "0x18078F220", Slot = "20")]
			get;
			[Token(Token = "0x6003AC8")]
			[Address(RVA = "0x761250", Offset = "0x75F850", VA = "0x180761250", Slot = "21")]
			set;
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06003AC9 RID: 15049 RVA: 0x00135024 File Offset: 0x00133224
		// (set) Token: 0x06003ACA RID: 15050 RVA: 0x00135038 File Offset: 0x00133238
		[Token(Token = "0x17000412")]
		public virtual List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003AC9")]
			[Address(RVA = "0x7B6890", Offset = "0x7B4E90", VA = "0x1807B6890", Slot = "22")]
			get;
			[Token(Token = "0x6003ACA")]
			[Address(RVA = "0x7B6970", Offset = "0x7B4F70", VA = "0x1807B6970", Slot = "23")]
			set;
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06003ACB RID: 15051 RVA: 0x0013504C File Offset: 0x0013324C
		// (set) Token: 0x06003ACC RID: 15052 RVA: 0x00135060 File Offset: 0x00133260
		[Token(Token = "0x17000413")]
		public virtual List<ZombieType> PreselectCards_zombie
		{
			[Token(Token = "0x6003ACB")]
			[Address(RVA = "0x5EDAB0", Offset = "0x5EC0B0", VA = "0x1805EDAB0", Slot = "24")]
			get;
			[Token(Token = "0x6003ACC")]
			[Address(RVA = "0x40B630", Offset = "0x409C30", VA = "0x18040B630", Slot = "25")]
			set;
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06003ACD RID: 15053 RVA: 0x00135074 File Offset: 0x00133274
		// (set) Token: 0x06003ACE RID: 15054 RVA: 0x00135088 File Offset: 0x00133288
		[Token(Token = "0x17000414")]
		public virtual List<PlantDataManager.PlantData> PlantDatas
		{
			[Token(Token = "0x6003ACD")]
			[Address(RVA = "0x5EDAC0", Offset = "0x5EC0C0", VA = "0x1805EDAC0", Slot = "26")]
			get;
			[Token(Token = "0x6003ACE")]
			[Address(RVA = "0x5EDD40", Offset = "0x5EC340", VA = "0x1805EDD40", Slot = "27")]
			set;
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06003ACF RID: 15055 RVA: 0x0013509C File Offset: 0x0013329C
		// (set) Token: 0x06003AD0 RID: 15056 RVA: 0x001350B0 File Offset: 0x001332B0
		[Token(Token = "0x17000415")]
		public List<ZombieDataManager.ZombieData> ZombieDatas
		{
			[Token(Token = "0x6003ACF")]
			[Address(RVA = "0x7F15C0", Offset = "0x7EFBC0", VA = "0x1807F15C0")]
			get;
			[Token(Token = "0x6003AD0")]
			[Address(RVA = "0x7F1610", Offset = "0x7EFC10", VA = "0x1807F1610")]
			set;
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06003AD1 RID: 15057 RVA: 0x001350C4 File Offset: 0x001332C4
		// (set) Token: 0x06003AD2 RID: 15058 RVA: 0x001350D8 File Offset: 0x001332D8
		[Token(Token = "0x17000416")]
		public virtual List<ScaryPotData> ScaryPotDatas
		{
			[Token(Token = "0x6003AD1")]
			[Address(RVA = "0x7F15A0", Offset = "0x7EFBA0", VA = "0x1807F15A0", Slot = "28")]
			get;
			[Token(Token = "0x6003AD2")]
			[Address(RVA = "0x7F1600", Offset = "0x7EFC00", VA = "0x1807F1600", Slot = "29")]
			set;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06003AD3 RID: 15059 RVA: 0x001350EC File Offset: 0x001332EC
		// (set) Token: 0x06003AD4 RID: 15060 RVA: 0x00135100 File Offset: 0x00133300
		[Token(Token = "0x17000417")]
		public virtual List<OrderedSpawn> OrderedSpawns
		{
			[Token(Token = "0x6003AD3")]
			[Address(RVA = "0x7F1590", Offset = "0x7EFB90", VA = "0x1807F1590", Slot = "30")]
			get;
			[Token(Token = "0x6003AD4")]
			[Address(RVA = "0x7F15F0", Offset = "0x7EFBF0", VA = "0x1807F15F0", Slot = "31")]
			set;
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x00135114 File Offset: 0x00133314
		[Token(Token = "0x17000418")]
		public virtual SpawnZombieConfig SpawnConfig
		{
			[Token(Token = "0x6003AD5")]
			[Address(RVA = "0x7F15B0", Offset = "0x7EFBB0", VA = "0x1807F15B0", Slot = "32")]
			get;
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x00135128 File Offset: 0x00133328
		[Token(Token = "0x6003AD6")]
		[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "33")]
		public virtual bool ClickCard(CardUI card)
		{
			return false;
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x00135138 File Offset: 0x00133338
		[Token(Token = "0x6003AD7")]
		[Address(RVA = "0x7F1010", Offset = "0x7EF610", VA = "0x1807F1010", Slot = "34")]
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

		// Token: 0x06003AD8 RID: 15064 RVA: 0x001351F4 File Offset: 0x001333F4
		[Token(Token = "0x6003AD8")]
		[Address(RVA = "0x7F1160", Offset = "0x7EF760", VA = "0x1807F1160", Slot = "35")]
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

		// Token: 0x06003AD9 RID: 15065 RVA: 0x001352D0 File Offset: 0x001334D0
		[Token(Token = "0x6003AD9")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "36")]
		public virtual void OnBoardStart(Board board)
		{
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x001352E0 File Offset: 0x001334E0
		[Token(Token = "0x6003ADA")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "37")]
		public virtual void OnBoardWin(Board board)
		{
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x001352F0 File Offset: 0x001334F0
		[Token(Token = "0x6003ADB")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "38")]
		public virtual void CustomMapEdit(Board board)
		{
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x00135300 File Offset: 0x00133500
		[Token(Token = "0x6003ADC")]
		[Address(RVA = "0x7F0F50", Offset = "0x7EF550", VA = "0x1807F0F50", Slot = "39")]
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

		// Token: 0x06003ADD RID: 15069 RVA: 0x00135350 File Offset: 0x00133550
		[Token(Token = "0x6003ADD")]
		[Address(RVA = "0x7F0E80", Offset = "0x7EF480", VA = "0x1807F0E80", Slot = "40")]
		public virtual void OnAnimUIOver(Board board)
		{
			if (!string.IsNullOrEmpty(this.Config.startTip))
			{
				InGameText instance = InGameText.Instance;
				BoardConfig config = this.Config;
				BoardConfig config2 = this.Config;
			}
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x00135390 File Offset: 0x00133590
		[Token(Token = "0x6003ADE")]
		[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "41")]
		public virtual bool GameOver(Board board)
		{
			return true;
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x001353A0 File Offset: 0x001335A0
		[Token(Token = "0x6003ADF")]
		[Address(RVA = "0x7F1390", Offset = "0x7EF990", VA = "0x1807F1390")]
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
