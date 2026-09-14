using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B52 RID: 2898
	[Token(Token = "0x2000B52")]
	public class GoldThreeTorch : TravelAdvantureLevelData
	{
		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06003C61 RID: 15457 RVA: 0x0013B1AC File Offset: 0x001393AC
		[Token(Token = "0x170004D5")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C61")]
			[Address(RVA = "0x715870", Offset = "0x713E70", VA = "0x180715870", Slot = "42")]
			get
			{
				return TravelAdvanture.GoldThreeTorch;
			}
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x0013B1BC File Offset: 0x001393BC
		[Token(Token = "0x6003C62")]
		[Address(RVA = "0x82B130", Offset = "0x829730", VA = "0x18082B130", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "三线火炬 + 吸金磁\n使用路灯花、火炬树桩进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x0013B1E8 File Offset: 0x001393E8
		[Token(Token = "0x6003C63")]
		[Address(RVA = "0x82B1B0", Offset = "0x8297B0", VA = "0x18082B1B0", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			int num2 = 0;
			board.theSun = num;
			if (num2 < board.rowNum)
			{
				CreatePlant instance = CreatePlant.Instance;
				num2++;
			}
			num2++;
			TravelMgr instance2 = TravelMgr.Instance;
			TravelMgr instance3 = TravelMgr.Instance;
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06003C64 RID: 15460 RVA: 0x0013B248 File Offset: 0x00139448
		[Token(Token = "0x170004D6")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C64")]
			[Address(RVA = "0x7185D0", Offset = "0x716BD0", VA = "0x1807185D0", Slot = "12")]
			get
			{
				return SceneType.Roof_Pool;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06003C65 RID: 15461 RVA: 0x0013B258 File Offset: 0x00139458
		[Token(Token = "0x170004D7")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C65")]
			[Address(RVA = "0x82B4E0", Offset = "0x829AE0", VA = "0x18082B4E0", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				return list;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06003C66 RID: 15462 RVA: 0x0013B2B8 File Offset: 0x001394B8
		[Token(Token = "0x170004D8")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C66")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06003C67 RID: 15463 RVA: 0x0013B2C8 File Offset: 0x001394C8
		[Token(Token = "0x170004D9")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C67")]
			[Address(RVA = "0x82B310", Offset = "0x829910", VA = "0x18082B310", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x0013B314 File Offset: 0x00139514
		[Token(Token = "0x6003C68")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public GoldThreeTorch()
		{
		}
	}
}
