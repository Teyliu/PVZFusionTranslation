using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AFE RID: 2814
	[Token(Token = "0x2000AFE")]
	public abstract class TravelAdvantureLevelData : LevelData
	{
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x00134464 File Offset: 0x00132664
		[Token(Token = "0x17000430")]
		public override int LevelNumber
		{
			[Token(Token = "0x6003A80")]
			[Address(RVA = "0x783AC0", Offset = "0x7820C0", VA = "0x180783AC0", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06003A81 RID: 14977 RVA: 0x00134474 File Offset: 0x00132674
		[Token(Token = "0x17000431")]
		public override LevelType LevelType
		{
			[Token(Token = "0x6003A81")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "14")]
			get
			{
				return LevelType.TravelAdvanture;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06003A82 RID: 14978 RVA: 0x00134484 File Offset: 0x00132684
		[Token(Token = "0x17000432")]
		protected virtual TravelAdvanture Level
		{
			[Token(Token = "0x6003A82")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "42")]
			get
			{
				return (TravelAdvanture)0;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06003A83 RID: 14979 RVA: 0x0013449C File Offset: 0x0013269C
		[Token(Token = "0x17000433")]
		public override string Name
		{
			[Token(Token = "0x6003A83")]
			[Address(RVA = "0x7953F0", Offset = "0x7939F0", VA = "0x1807953F0", Slot = "8")]
			get
			{
				int plantType = (int)this.PlantType;
				string text;
				return "旅行冒险 " + text;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06003A84 RID: 14980 RVA: 0x001344C0 File Offset: 0x001326C0
		[Token(Token = "0x17000434")]
		private PlantType PlantType
		{
			[Token(Token = "0x6003A84")]
			[Address(RVA = "0x795440", Offset = "0x793A40", VA = "0x180795440")]
			get
			{
				Type typeFromHandle = typeof(PlantType);
				TravelAdvanture level = this.Level;
				string text;
				object obj = Enum.Parse(typeFromHandle, text);
				throw new NullReferenceException();
			}
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x001344F8 File Offset: 0x001326F8
		[Token(Token = "0x6003A85")]
		[Address(RVA = "0x794B40", Offset = "0x793140", VA = "0x180794B40", Slot = "39")]
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

		// Token: 0x06003A86 RID: 14982 RVA: 0x00134568 File Offset: 0x00132768
		[Token(Token = "0x6003A86")]
		[Address(RVA = "0x795360", Offset = "0x793960", VA = "0x180795360", Slot = "35")]
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

		// Token: 0x06003A87 RID: 14983 RVA: 0x0013459C File Offset: 0x0013279C
		[Token(Token = "0x6003A87")]
		[Address(RVA = "0x794C20", Offset = "0x793220", VA = "0x180794C20", Slot = "36")]
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

		// Token: 0x06003A88 RID: 14984 RVA: 0x00134678 File Offset: 0x00132878
		[Token(Token = "0x6003A88")]
		[Address(RVA = "0x794840", Offset = "0x792E40", VA = "0x180794840")]
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

		// Token: 0x06003A89 RID: 14985 RVA: 0x0013473C File Offset: 0x0013293C
		[Token(Token = "0x6003A89")]
		[Address(RVA = "0x795210", Offset = "0x793810", VA = "0x180795210")]
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

		// Token: 0x06003A8A RID: 14986 RVA: 0x00134800 File Offset: 0x00132A00
		[Token(Token = "0x6003A8A")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "43")]
		protected virtual void OnWaveAdd()
		{
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x00134810 File Offset: 0x00132A10
		[Token(Token = "0x6003A8B")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		protected TravelAdvantureLevelData()
		{
		}

		// Token: 0x04002B69 RID: 11113
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002B69")]
		private List<PlantType> plants;
	}
}
