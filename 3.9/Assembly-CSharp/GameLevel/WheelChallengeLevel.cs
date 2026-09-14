using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B2D RID: 2861
	[Token(Token = "0x2000B2D")]
	public class WheelChallengeLevel : ChallengeLevelData
	{
		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06003B6C RID: 15212 RVA: 0x00138074 File Offset: 0x00136274
		[Token(Token = "0x1700044C")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003B6C")]
			[Address(RVA = "0x8048A0", Offset = "0x802EA0", VA = "0x1808048A0", Slot = "42")]
			get
			{
				return ChallengeLevel.WheelChallenge;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06003B6D RID: 15213 RVA: 0x00138088 File Offset: 0x00136288
		[Token(Token = "0x1700044D")]
		public override string Name
		{
			[Token(Token = "0x6003B6D")]
			[Address(RVA = "0x8048B0", Offset = "0x802EB0", VA = "0x1808048B0", Slot = "8")]
			get
			{
				return "手推车挑战";
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06003B6E RID: 15214 RVA: 0x0013809C File Offset: 0x0013629C
		[Token(Token = "0x1700044E")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B6E")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "12")]
			get
			{
				return SceneType.Travel_roof;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06003B6F RID: 15215 RVA: 0x001380AC File Offset: 0x001362AC
		[Token(Token = "0x1700044F")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B6F")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x001380BC File Offset: 0x001362BC
		[Token(Token = "0x6003B70")]
		[Address(RVA = "0x804470", Offset = "0x802A70", VA = "0x180804470", Slot = "39")]
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

		// Token: 0x06003B71 RID: 15217 RVA: 0x001381A8 File Offset: 0x001363A8
		[Token(Token = "0x6003B71")]
		[Address(RVA = "0x8043F0", Offset = "0x8029F0", VA = "0x1808043F0", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			base.OnAnimUIOver(board);
			InGameUI.Instance.WheelBank.SetActive(true);
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x001381D4 File Offset: 0x001363D4
		[Token(Token = "0x6003B72")]
		[Address(RVA = "0x804700", Offset = "0x802D00", VA = "0x180804700", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			CreatePlant instance = CreatePlant.Instance;
			CreatePlant instance2 = CreatePlant.Instance;
			CreatePlant instance3 = CreatePlant.Instance;
			CreatePlant instance4 = CreatePlant.Instance;
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06003B73 RID: 15219 RVA: 0x00138208 File Offset: 0x00136408
		[Token(Token = "0x17000450")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B73")]
			[Address(RVA = "0x8048E0", Offset = "0x802EE0", VA = "0x1808048E0", Slot = "20")]
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

		// Token: 0x06003B74 RID: 15220 RVA: 0x00138298 File Offset: 0x00136498
		[Token(Token = "0x6003B74")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public WheelChallengeLevel()
		{
		}
	}
}
