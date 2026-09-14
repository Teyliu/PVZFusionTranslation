using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B49 RID: 2889
	[Token(Token = "0x2000B49")]
	public class SuperThreePeater : TravelAdvantureLevelData
	{
		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06003C18 RID: 15384 RVA: 0x0013A4B0 File Offset: 0x001386B0
		[Token(Token = "0x170004A8")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C18")]
			[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "42")]
			get
			{
				return TravelAdvanture.SuperThreePeater;
			}
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x0013A4C0 File Offset: 0x001386C0
		[Token(Token = "0x6003C19")]
		[Address(RVA = "0x832F30", Offset = "0x831530", VA = "0x180832F30", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "三线射手 + 火爆辣椒x3\n使用三叶草、铲子进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x0013A4EC File Offset: 0x001386EC
		[Token(Token = "0x6003C1A")]
		[Address(RVA = "0x7F2010", Offset = "0x7F0610", VA = "0x1807F2010", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06003C1B RID: 15387 RVA: 0x0013A518 File Offset: 0x00138718
		[Token(Token = "0x170004A9")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C1B")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06003C1C RID: 15388 RVA: 0x0013A528 File Offset: 0x00138728
		[Token(Token = "0x170004AA")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C1C")]
			[Address(RVA = "0x833120", Offset = "0x831720", VA = "0x180833120", Slot = "20")]
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

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06003C1D RID: 15389 RVA: 0x0013A588 File Offset: 0x00138788
		[Token(Token = "0x170004AB")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C1D")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06003C1E RID: 15390 RVA: 0x0013A598 File Offset: 0x00138798
		[Token(Token = "0x170004AC")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C1E")]
			[Address(RVA = "0x832FB0", Offset = "0x8315B0", VA = "0x180832FB0", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x0013A5DC File Offset: 0x001387DC
		[Token(Token = "0x6003C1F")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public SuperThreePeater()
		{
		}
	}
}
