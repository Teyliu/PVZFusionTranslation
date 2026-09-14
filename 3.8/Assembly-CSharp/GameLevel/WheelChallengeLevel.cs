using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AED RID: 2797
	[Token(Token = "0x2000AED")]
	public class WheelChallengeLevel : ChallengeLevelData
	{
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06003A28 RID: 14888 RVA: 0x0013302C File Offset: 0x0013122C
		[Token(Token = "0x17000404")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003A28")]
			[Address(RVA = "0x79DEE0", Offset = "0x79C4E0", VA = "0x18079DEE0", Slot = "42")]
			get
			{
				return ChallengeLevel.WheelChallenge;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06003A29 RID: 14889 RVA: 0x00133040 File Offset: 0x00131240
		[Token(Token = "0x17000405")]
		public override string Name
		{
			[Token(Token = "0x6003A29")]
			[Address(RVA = "0x79DEF0", Offset = "0x79C4F0", VA = "0x18079DEF0", Slot = "8")]
			get
			{
				return "手推车挑战";
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06003A2A RID: 14890 RVA: 0x00133054 File Offset: 0x00131254
		[Token(Token = "0x17000406")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003A2A")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "12")]
			get
			{
				return SceneType.Travel_roof;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06003A2B RID: 14891 RVA: 0x00133064 File Offset: 0x00131264
		[Token(Token = "0x17000407")]
		public override int MaxWave
		{
			[Token(Token = "0x6003A2B")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x00133074 File Offset: 0x00131274
		[Token(Token = "0x6003A2C")]
		[Address(RVA = "0x79DAB0", Offset = "0x79C0B0", VA = "0x18079DAB0", Slot = "39")]
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
			TravelMgr instance = TravelMgr.Instance;
			TravelMgr instance2 = TravelMgr.Instance;
			TravelMgr instance3 = TravelMgr.Instance;
			board.config.startTip = "手推车可以用来暂存和移动植物，且可以刷新植物状态\n在这一关中仅需3秒冷却，通关后可在绝大部分关卡中使用";
			board.config.tipTime = 10f;
			List<PlantDataManager.PlantData> plantDatas = base.PlantDatas;
			PlantDataManager.PlantData plantData = new PlantDataManager.PlantData();
			plantData.thePlantType = (PlantType)((ulong)27L);
			int num = board.maxSun;
			num++;
			plantData.maxHealth = (int)((ulong)300L);
			plantData.cost = num;
			plantData.cd = 7.5f;
			int size = plantDatas._size;
		}

		// Token: 0x06003A2D RID: 14893 RVA: 0x00133160 File Offset: 0x00131360
		[Token(Token = "0x6003A2D")]
		[Address(RVA = "0x79DA30", Offset = "0x79C030", VA = "0x18079DA30", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			base.OnAnimUIOver(board);
			InGameUI.Instance.WheelBank.SetActive(true);
		}

		// Token: 0x06003A2E RID: 14894 RVA: 0x0013318C File Offset: 0x0013138C
		[Token(Token = "0x6003A2E")]
		[Address(RVA = "0x79DD40", Offset = "0x79C340", VA = "0x18079DD40", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			CreatePlant instance = CreatePlant.Instance;
			CreatePlant instance2 = CreatePlant.Instance;
			CreatePlant instance3 = CreatePlant.Instance;
			CreatePlant instance4 = CreatePlant.Instance;
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06003A2F RID: 14895 RVA: 0x001331C0 File Offset: 0x001313C0
		[Token(Token = "0x17000408")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003A2F")]
			[Address(RVA = "0x79DF20", Offset = "0x79C520", VA = "0x18079DF20", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				int size7 = list._size;
				int size8 = list._size;
				int size9 = list._size;
				int size10 = list._size;
				int size11 = list._size;
				int size12 = list._size;
				return list;
			}
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x00133250 File Offset: 0x00131450
		[Token(Token = "0x6003A30")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public WheelChallengeLevel()
		{
		}
	}
}
