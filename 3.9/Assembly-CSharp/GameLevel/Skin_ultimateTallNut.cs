using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.Events;

namespace GameLevel
{
	// Token: 0x02000B39 RID: 2873
	[Token(Token = "0x2000B39")]
	public class Skin_ultimateTallNut : SkinLevelData
	{
		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06003BAD RID: 15277 RVA: 0x00138F94 File Offset: 0x00137194
		[Token(Token = "0x1700046C")]
		protected override SkinLevel Level
		{
			[Token(Token = "0x6003BAD")]
			[Address(RVA = "0x3F9920", Offset = "0x3F7F20", VA = "0x1803F9920", Slot = "42")]
			get
			{
				return SkinLevel.UltimateTallNut;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06003BAE RID: 15278 RVA: 0x00138FA4 File Offset: 0x001371A4
		[Token(Token = "0x1700046D")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003BAE")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06003BAF RID: 15279 RVA: 0x00138FB4 File Offset: 0x001371B4
		[Token(Token = "0x1700046E")]
		public override int MaxWave
		{
			[Token(Token = "0x6003BAF")]
			[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "10")]
			get
			{
				return 40;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x00138FC4 File Offset: 0x001371C4
		[Token(Token = "0x1700046F")]
		public override string Name
		{
			[Token(Token = "0x6003BB0")]
			[Address(RVA = "0x7F9610", Offset = "0x7F7C10", VA = "0x1807F9610", Slot = "8")]
			get
			{
				return "究极黑曜石高坚果皮肤挑战";
			}
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x00138FD8 File Offset: 0x001371D8
		[Token(Token = "0x6003BB1")]
		[Address(RVA = "0x7F9250", Offset = "0x7F7850", VA = "0x1807F9250", Slot = "39")]
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
			int skin = GameAPP.resourcesManager.GetSkin((PlantType)((uint)913));
			int current = skin;
			GameAPP.resourcesManager.SetSkin((PlantType)((uint)913), 1);
			UnityEvent dieEvent = board.DieEvent;
			UnityAction unityAction = delegate
			{
				ResourcesManager resourcesManager = GameAPP.resourcesManager;
				int current2 = current;
				resourcesManager.SetSkin((PlantType)((uint)913), current2);
			};
			dieEvent.AddListener(unityAction);
			board.boardTag.enableAllTravelPlant = true;
			BoardConfig config = board.config;
			board.timeUntilNextWave = 3f;
			config.waveInterval = 15f;
			TravelMgr instance = TravelMgr.Instance;
			int num = 0;
			instance.GetUltiBuff((UltiBuff)((uint)17), num != 0);
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x001390BC File Offset: 0x001372BC
		[Token(Token = "0x6003BB2")]
		[Address(RVA = "0x7F94B0", Offset = "0x7F7AB0", VA = "0x1807F94B0", Slot = "36")]
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

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06003BB3 RID: 15283 RVA: 0x001390F8 File Offset: 0x001372F8
		[Token(Token = "0x17000470")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003BB3")]
			[Address(RVA = "0x7F9880", Offset = "0x7F7E80", VA = "0x1807F9880", Slot = "20")]
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
				return list;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06003BB4 RID: 15284 RVA: 0x001391A8 File Offset: 0x001373A8
		[Token(Token = "0x17000471")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003BB4")]
			[Address(RVA = "0x7F9760", Offset = "0x7F7D60", VA = "0x1807F9760", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06003BB5 RID: 15285 RVA: 0x001391E4 File Offset: 0x001373E4
		[Token(Token = "0x17000472")]
		public override int CardCount
		{
			[Token(Token = "0x6003BB5")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "6")]
			get
			{
				return 10;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x001391F4 File Offset: 0x001373F4
		[Token(Token = "0x17000473")]
		public override List<PlantDataManager.PlantData> PlantDatas
		{
			[Token(Token = "0x6003BB6")]
			[Address(RVA = "0x7F9640", Offset = "0x7F7C40", VA = "0x1807F9640", Slot = "26")]
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

		// Token: 0x06003BB7 RID: 15287 RVA: 0x00139248 File Offset: 0x00137448
		[Token(Token = "0x6003BB7")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Skin_ultimateTallNut()
		{
		}
	}
}
