using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.Events;

namespace GameLevel
{
	// Token: 0x02000AF7 RID: 2807
	[Token(Token = "0x2000AF7")]
	public class Skin_ultimatePumpkin : SkinLevelData
	{
		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06003A5C RID: 14940 RVA: 0x00133BF0 File Offset: 0x00131DF0
		[Token(Token = "0x1700041C")]
		protected override SkinLevel Level
		{
			[Token(Token = "0x6003A5C")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "42")]
			get
			{
				return SkinLevel.UltimatePumpkin;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06003A5D RID: 14941 RVA: 0x00133C00 File Offset: 0x00131E00
		[Token(Token = "0x1700041D")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003A5D")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
			get
			{
				return SceneType.NightPool;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06003A5E RID: 14942 RVA: 0x00133C10 File Offset: 0x00131E10
		[Token(Token = "0x1700041E")]
		public override int MaxWave
		{
			[Token(Token = "0x6003A5E")]
			[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "10")]
			get
			{
				return 40;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06003A5F RID: 14943 RVA: 0x00133C20 File Offset: 0x00131E20
		[Token(Token = "0x1700041F")]
		public override string Name
		{
			[Token(Token = "0x6003A5F")]
			[Address(RVA = "0x792220", Offset = "0x790820", VA = "0x180792220", Slot = "8")]
			get
			{
				return "究极激光南瓜皮肤挑战";
			}
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x00133C34 File Offset: 0x00131E34
		[Token(Token = "0x6003A60")]
		[Address(RVA = "0x791E20", Offset = "0x790420", VA = "0x180791E20", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			if (this.CardCount != 0)
			{
				int cardCount = this.CardCount;
				board.cardCountLimit = cardCount;
			}
			BoardConfig boardConfig = base.Config.Copy();
			board.config = boardConfig;
			float firstWaveArrivedTimer = base.Config.firstWaveArrivedTimer;
			board.timeUntilNextWave = firstWaveArrivedTimer;
			int skin = GameAPP.resourcesManager.GetSkin((PlantType)((uint)911));
			int current = skin;
			GameAPP.resourcesManager.SetSkin((PlantType)((uint)911), 1);
			UnityEvent dieEvent = board.DieEvent;
			UnityAction unityAction = delegate
			{
				ResourcesManager resourcesManager = GameAPP.resourcesManager;
				int current2 = current;
				resourcesManager.SetSkin((PlantType)((uint)911), current2);
			};
			dieEvent.AddListener(unityAction);
			board.boardTag.enableAllTravelPlant = true;
			TravelMgr instance = TravelMgr.Instance;
			int num = 0;
			instance.GetUltiBuff((UltiBuff)((uint)25), num != 0);
			TravelMgr instance2 = TravelMgr.Instance;
			int num2 = 0;
			instance2.GetUltiBuff((UltiBuff)((uint)24), num2 != 0);
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1002));
			BoardConfig config = board.config;
			board.timeUntilNextWave = 3f;
			config.waveInterval = 15f;
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x00133D44 File Offset: 0x00131F44
		[Token(Token = "0x6003A61")]
		[Address(RVA = "0x7920C0", Offset = "0x7906C0", VA = "0x1807920C0", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			ulong num;
			do
			{
				board.theSun = (int)((ulong)1000L);
				List<CardUI> cards = InGameUI.Instance.Cards;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06003A62 RID: 14946 RVA: 0x00133D80 File Offset: 0x00131F80
		[Token(Token = "0x17000420")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003A62")]
			[Address(RVA = "0x7924E0", Offset = "0x790AE0", VA = "0x1807924E0", Slot = "20")]
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
				int size13 = list._size;
				int size14 = list._size;
				int size15 = list._size;
				int size16 = list._size;
				int size17 = list._size;
				int size18 = list._size;
				int size19 = list._size;
				int size20 = list._size;
				return list;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06003A63 RID: 14947 RVA: 0x00133E50 File Offset: 0x00132050
		[Token(Token = "0x17000421")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003A63")]
			[Address(RVA = "0x792370", Offset = "0x790970", VA = "0x180792370", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06003A64 RID: 14948 RVA: 0x00133E94 File Offset: 0x00132094
		[Token(Token = "0x17000422")]
		public override int CardCount
		{
			[Token(Token = "0x6003A64")]
			[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "6")]
			get
			{
				return 8;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06003A65 RID: 14949 RVA: 0x00133EA4 File Offset: 0x001320A4
		[Token(Token = "0x17000423")]
		public override List<PlantDataManager.PlantData> PlantDatas
		{
			[Token(Token = "0x6003A65")]
			[Address(RVA = "0x792250", Offset = "0x790850", VA = "0x180792250", Slot = "26")]
			get
			{
				List<PlantDataManager.PlantData> list = new List();
				PlantDataManager.PlantData plantData = new PlantDataManager.PlantData();
				plantData.thePlantType = (PlantType)((ulong)220L);
				plantData.cost = (int)((ulong)999999L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x00133EF8 File Offset: 0x001320F8
		[Token(Token = "0x6003A66")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Skin_ultimatePumpkin()
		{
		}
	}
}
