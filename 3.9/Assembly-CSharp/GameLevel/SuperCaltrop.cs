using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B48 RID: 2888
	[Token(Token = "0x2000B48")]
	public class SuperCaltrop : TravelAdvantureLevelData
	{
		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06003C10 RID: 15376 RVA: 0x0013A358 File Offset: 0x00138558
		[Token(Token = "0x170004A3")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C10")]
			[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "42")]
			get
			{
				return TravelAdvanture.SuperCaltrop;
			}
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x0013A368 File Offset: 0x00138568
		[Token(Token = "0x6003C11")]
		[Address(RVA = "0x832050", Offset = "0x830650", VA = "0x180832050", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "黄油地刺 + 窝刺\n使用花盆、铲子进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x0013A394 File Offset: 0x00138594
		[Token(Token = "0x6003C12")]
		[Address(RVA = "0x7F2010", Offset = "0x7F0610", VA = "0x1807F2010", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06003C13 RID: 15379 RVA: 0x0013A3C0 File Offset: 0x001385C0
		[Token(Token = "0x170004A4")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C13")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06003C14 RID: 15380 RVA: 0x0013A3D8 File Offset: 0x001385D8
		[Token(Token = "0x170004A5")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C14")]
			[Address(RVA = "0x832240", Offset = "0x830840", VA = "0x180832240", Slot = "20")]
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

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06003C15 RID: 15381 RVA: 0x0013A448 File Offset: 0x00138648
		[Token(Token = "0x170004A6")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C15")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06003C16 RID: 15382 RVA: 0x0013A458 File Offset: 0x00138658
		[Token(Token = "0x170004A7")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C16")]
			[Address(RVA = "0x8320D0", Offset = "0x8306D0", VA = "0x1808320D0", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x0013A49C File Offset: 0x0013869C
		[Token(Token = "0x6003C17")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public SuperCaltrop()
		{
		}
	}
}
