using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B4E RID: 2894
	[Token(Token = "0x2000B4E")]
	public class SuperHypnoDoom : TravelAdvantureLevelData
	{
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06003C40 RID: 15424 RVA: 0x0013AB48 File Offset: 0x00138D48
		[Token(Token = "0x170004C1")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C40")]
			[Address(RVA = "0x3F6DC0", Offset = "0x3F53C0", VA = "0x1803F6DC0", Slot = "42")]
			get
			{
				return TravelAdvanture.SuperHypnoDoom;
			}
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x0013AB58 File Offset: 0x00138D58
		[Token(Token = "0x6003C41")]
		[Address(RVA = "0x832560", Offset = "0x830B60", VA = "0x180832560", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "毁灭魅惑菇 + 毁灭菇\n使用金盏花、毁灭菇进行亚种切换\n<color=red>亚种在非旅行模式不推荐使用</color>";
			throw new NullReferenceException();
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x0013AB84 File Offset: 0x00138D84
		[Token(Token = "0x6003C42")]
		[Address(RVA = "0x7F2010", Offset = "0x7F0610", VA = "0x1807F2010", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06003C43 RID: 15427 RVA: 0x0013ABB0 File Offset: 0x00138DB0
		[Token(Token = "0x170004C2")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C43")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06003C44 RID: 15428 RVA: 0x0013ABC0 File Offset: 0x00138DC0
		[Token(Token = "0x170004C3")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C44")]
			[Address(RVA = "0x832750", Offset = "0x830D50", VA = "0x180832750", Slot = "20")]
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
				return list;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06003C45 RID: 15429 RVA: 0x0013AC30 File Offset: 0x00138E30
		[Token(Token = "0x170004C4")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C45")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06003C46 RID: 15430 RVA: 0x0013AC40 File Offset: 0x00138E40
		[Token(Token = "0x170004C5")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C46")]
			[Address(RVA = "0x8325E0", Offset = "0x830BE0", VA = "0x1808325E0", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x0013AC84 File Offset: 0x00138E84
		[Token(Token = "0x6003C47")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public SuperHypnoDoom()
		{
		}
	}
}
