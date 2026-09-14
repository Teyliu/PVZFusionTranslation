using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B46 RID: 2886
	[Token(Token = "0x2000B46")]
	public class CattailLour : TravelAdvantureLevelData
	{
		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06003C00 RID: 15360 RVA: 0x0013A0D0 File Offset: 0x001382D0
		[Token(Token = "0x17000499")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C00")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "42")]
			get
			{
				return TravelAdvanture.CattailLour;
			}
		}

		// Token: 0x06003C01 RID: 15361 RVA: 0x0013A0E0 File Offset: 0x001382E0
		[Token(Token = "0x6003C01")]
		[Address(RVA = "0x81B150", Offset = "0x819750", VA = "0x18081B150", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "香蒲 + 猫瓜\n使用闪电洋葱、香蒲进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x0013A10C File Offset: 0x0013830C
		[Token(Token = "0x6003C02")]
		[Address(RVA = "0x7F2010", Offset = "0x7F0610", VA = "0x1807F2010", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06003C03 RID: 15363 RVA: 0x0013A138 File Offset: 0x00138338
		[Token(Token = "0x1700049A")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C03")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06003C04 RID: 15364 RVA: 0x0013A150 File Offset: 0x00138350
		[Token(Token = "0x1700049B")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C04")]
			[Address(RVA = "0x81B340", Offset = "0x819940", VA = "0x18081B340", Slot = "20")]
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
				return list;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06003C05 RID: 15365 RVA: 0x0013A1B8 File Offset: 0x001383B8
		[Token(Token = "0x1700049C")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C05")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06003C06 RID: 15366 RVA: 0x0013A1C8 File Offset: 0x001383C8
		[Token(Token = "0x1700049D")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C06")]
			[Address(RVA = "0x81B1D0", Offset = "0x8197D0", VA = "0x18081B1D0", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x0013A20C File Offset: 0x0013840C
		[Token(Token = "0x6003C07")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public CattailLour()
		{
		}
	}
}
