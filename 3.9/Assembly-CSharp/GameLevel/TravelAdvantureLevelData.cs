using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B40 RID: 2880
	[Token(Token = "0x2000B40")]
	public abstract class TravelAdvantureLevelData : LevelData
	{
		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06003BD1 RID: 15313 RVA: 0x001397B4 File Offset: 0x001379B4
		[Token(Token = "0x17000480")]
		public override int LevelNumber
		{
			[Token(Token = "0x6003BD1")]
			[Address(RVA = "0x7EA480", Offset = "0x7E8A80", VA = "0x1807EA480", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06003BD2 RID: 15314 RVA: 0x001397C4 File Offset: 0x001379C4
		[Token(Token = "0x17000481")]
		public override LevelType LevelType
		{
			[Token(Token = "0x6003BD2")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "14")]
			get
			{
				return LevelType.TravelAdvanture;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06003BD3 RID: 15315 RVA: 0x001397D4 File Offset: 0x001379D4
		[Token(Token = "0x17000482")]
		protected virtual TravelAdvanture Level
		{
			[Token(Token = "0x6003BD3")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "42")]
			get
			{
				return (TravelAdvanture)0;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06003BD4 RID: 15316 RVA: 0x001397EC File Offset: 0x001379EC
		[Token(Token = "0x17000483")]
		public override string Name
		{
			[Token(Token = "0x6003BD4")]
			[Address(RVA = "0x7FBC70", Offset = "0x7FA270", VA = "0x1807FBC70", Slot = "8")]
			get
			{
				int plantType = (int)this.PlantType;
				string text;
				return "旅行冒险 " + text;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06003BD5 RID: 15317 RVA: 0x00139810 File Offset: 0x00137A10
		[Token(Token = "0x17000484")]
		private PlantType PlantType
		{
			[Token(Token = "0x6003BD5")]
			[Address(RVA = "0x7FBCC0", Offset = "0x7FA2C0", VA = "0x1807FBCC0")]
			get
			{
				Type typeFromHandle = typeof(PlantType);
				TravelAdvanture level = this.Level;
				string text;
				object obj = Enum.Parse(typeFromHandle, text);
				throw new NullReferenceException();
			}
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x00139848 File Offset: 0x00137A48
		[Token(Token = "0x6003BD6")]
		[Address(RVA = "0x7FB3C0", Offset = "0x7F99C0", VA = "0x1807FB3C0", Slot = "39")]
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
			BoardConfig config = board.config;
			config.zombieCountMultiplier = 5f;
			config.tipTime = 10f;
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x001398B8 File Offset: 0x00137AB8
		[Token(Token = "0x6003BD7")]
		[Address(RVA = "0x7FBBE0", Offset = "0x7FA1E0", VA = "0x1807FBBE0", Slot = "35")]
		public override void ReinforceZombie(Zombie zombie)
		{
			base.ReinforceZombie(zombie);
			int theZombieType = (int)zombie.theZombieType;
			bool flag;
			if (!flag)
			{
				global::Lawnf.SetZombieHealth(zombie, 4f);
			}
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x001398EC File Offset: 0x00137AEC
		[Token(Token = "0x6003BD8")]
		[Address(RVA = "0x7FB4A0", Offset = "0x7F9AA0", VA = "0x1807FB4A0", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			int num;
			do
			{
				num = 0;
				List<PlantType> list = new List();
				this.plants = list;
				List<TravelAdvanture> list2 = Enumerable.ToList<TravelAdvanture>(GameAPP.config.travelLevelCompleted_runTime);
				Func<TravelAdvanture, int> <>9__13_ = TravelAdvantureLevelData.<>c.<>9__13_0;
				if (<>9__13_ == 0)
				{
					Func<TravelAdvanture, int> func;
					TravelAdvantureLevelData.<>c.<>9__13_0 = func;
				}
				if (Enumerable.OrderBy<TravelAdvanture, int>(list2, <>9__13_) != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						if (num == typeof(IEnumerator).TypeHandle)
						{
							goto IL_0065;
						}
						num++;
					}
					string text;
					object obj = Enum.Parse(typeof(PlantType), text);
				}
				IL_0065:
				if ("{il2cpp array field local13->}" != (ulong)0L)
				{
				}
			}
			while (num != 0);
			SeedLibrary instance = SeedLibrary.Instance;
			SeedLibrary instance2 = SeedLibrary.Instance;
			instance2.ShowCards("UltimateCards");
			InGameText.Instance.TimeOver();
			int num2 = 0;
			Action action;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num2 != 0);
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x001399C8 File Offset: 0x00137BC8
		[Token(Token = "0x6003BD9")]
		[Address(RVA = "0x7FB0C0", Offset = "0x7F96C0", VA = "0x1807FB0C0")]
		private void AddPlant(PlantType thePlantType)
		{
			List<PlantType> list = this.plants;
			bool flag;
			if (!flag)
			{
				List<PlantType> list2 = this.plants;
				int size = list2._size;
				int num = (int)(thePlantType + 1);
				list2._size = num;
				List<PlantType> ulockedPlants_temp = TravelMgr.Instance.ulockedPlants_temp;
				int size2 = ulockedPlants_temp._size;
				int num2 = (int)(thePlantType + 1);
				ulockedPlants_temp._size = num2;
				Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
				bool flag2;
				if (flag2)
				{
					List<PlantType> list3 = this.plants;
					List<PlantType> ulockedPlants_temp2 = TravelMgr.Instance.ulockedPlants_temp;
				}
				if (thePlantType == PlantType.SuperThreePeater)
				{
					int size3 = TravelMgr.Instance.ulockedPlants_temp._size;
				}
			}
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x00139A8C File Offset: 0x00137C8C
		[Token(Token = "0x6003BDA")]
		[Address(RVA = "0x7FBA90", Offset = "0x7FA090", VA = "0x1807FBA90")]
		private void OnCreateUltimateCard(CardUI card)
		{
			int thePlantType = (int)card.thePlantType;
			PlantType thePlantType2 = card.thePlantType;
			PlantDataManager.PlantData plantData;
			if (thePlantType2 > PlantType.NuclearDoomCherry)
			{
				if (thePlantType2 == PlantType.NuclearSquash || thePlantType2 == PlantType.UltimateIceDoom)
				{
					float fullCD = card.fullCD;
					card.CD = fullCD;
					int cost = plantData.cost;
					card.theSeedCost = cost;
					return;
				}
			}
			else
			{
				while (thePlantType2 == PlantType.SuperHypnoDoom)
				{
				}
				while (thePlantType2 == PlantType.NuclearDoomCherry)
				{
				}
			}
			float cd = plantData.cd;
			bool flag;
			if (!flag)
			{
				card.fullCD = cd;
				float fullCD2 = card.fullCD;
				card.CD = fullCD2;
				int cost2 = plantData.cost;
				card.theSeedCost = cost2;
				return;
			}
			card.fullCD = cd;
			float fullCD3 = card.fullCD;
			card.CD = fullCD3;
			card.theSeedCost = (int)fullCD3;
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x00139B50 File Offset: 0x00137D50
		[Token(Token = "0x6003BDB")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "43")]
		protected virtual void OnWaveAdd()
		{
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x00139B60 File Offset: 0x00137D60
		[Token(Token = "0x6003BDC")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		protected TravelAdvantureLevelData()
		{
		}

		// Token: 0x04002CDD RID: 11485
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002CDD")]
		private List<PlantType> plants;
	}
}
