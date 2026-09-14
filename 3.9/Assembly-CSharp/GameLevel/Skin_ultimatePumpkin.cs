using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.Events;

namespace GameLevel
{
	// Token: 0x02000B37 RID: 2871
	[Token(Token = "0x2000B37")]
	public class Skin_ultimatePumpkin : SkinLevelData
	{
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06003BA0 RID: 15264 RVA: 0x00138C34 File Offset: 0x00136E34
		[Token(Token = "0x17000464")]
		protected override SkinLevel Level
		{
			[Token(Token = "0x6003BA0")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "42")]
			get
			{
				return SkinLevel.UltimatePumpkin;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06003BA1 RID: 15265 RVA: 0x00138C44 File Offset: 0x00136E44
		[Token(Token = "0x17000465")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003BA1")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
			get
			{
				return SceneType.NightPool;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06003BA2 RID: 15266 RVA: 0x00138C54 File Offset: 0x00136E54
		[Token(Token = "0x17000466")]
		public override int MaxWave
		{
			[Token(Token = "0x6003BA2")]
			[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "10")]
			get
			{
				return 40;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06003BA3 RID: 15267 RVA: 0x00138C64 File Offset: 0x00136E64
		[Token(Token = "0x17000467")]
		public override string Name
		{
			[Token(Token = "0x6003BA3")]
			[Address(RVA = "0x7F8870", Offset = "0x7F6E70", VA = "0x1807F8870", Slot = "8")]
			get
			{
				return "究极激光南瓜皮肤挑战";
			}
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x00138C78 File Offset: 0x00136E78
		[Token(Token = "0x6003BA4")]
		[Address(RVA = "0x7F8470", Offset = "0x7F6A70", VA = "0x1807F8470", Slot = "39")]
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

		// Token: 0x06003BA5 RID: 15269 RVA: 0x00138D88 File Offset: 0x00136F88
		[Token(Token = "0x6003BA5")]
		[Address(RVA = "0x7F8710", Offset = "0x7F6D10", VA = "0x1807F8710", Slot = "36")]
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

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06003BA6 RID: 15270 RVA: 0x00138DC4 File Offset: 0x00136FC4
		[Token(Token = "0x17000468")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003BA6")]
			[Address(RVA = "0x7F8B30", Offset = "0x7F7130", VA = "0x1807F8B30", Slot = "20")]
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

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06003BA7 RID: 15271 RVA: 0x00138E94 File Offset: 0x00137094
		[Token(Token = "0x17000469")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003BA7")]
			[Address(RVA = "0x7F89C0", Offset = "0x7F6FC0", VA = "0x1807F89C0", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06003BA8 RID: 15272 RVA: 0x00138ED8 File Offset: 0x001370D8
		[Token(Token = "0x1700046A")]
		public override int CardCount
		{
			[Token(Token = "0x6003BA8")]
			[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "6")]
			get
			{
				return 8;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x00138EE8 File Offset: 0x001370E8
		[Token(Token = "0x1700046B")]
		public override List<PlantDataManager.PlantData> PlantDatas
		{
			[Token(Token = "0x6003BA9")]
			[Address(RVA = "0x7F88A0", Offset = "0x7F6EA0", VA = "0x1807F88A0", Slot = "26")]
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

		// Token: 0x06003BAA RID: 15274 RVA: 0x00138F3C File Offset: 0x0013713C
		[Token(Token = "0x6003BAA")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Skin_ultimatePumpkin()
		{
		}
	}
}
