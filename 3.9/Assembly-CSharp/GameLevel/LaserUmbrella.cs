using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B4C RID: 2892
	[Token(Token = "0x2000B4C")]
	public class LaserUmbrella : TravelAdvantureLevelData
	{
		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06003C30 RID: 15408 RVA: 0x0013A8A0 File Offset: 0x00138AA0
		[Token(Token = "0x170004B7")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C30")]
			[Address(RVA = "0x3F9920", Offset = "0x3F7F20", VA = "0x1803F9920", Slot = "42")]
			get
			{
				return TravelAdvanture.LaserUmbrella;
			}
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x0013A8B0 File Offset: 0x00138AB0
		[Token(Token = "0x6003C31")]
		[Address(RVA = "0x82C590", Offset = "0x82AB90", VA = "0x18082C590", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "流光仙人掌 + 流光保护伞\n使用寒冰菇、路灯花进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x0013A8DC File Offset: 0x00138ADC
		[Token(Token = "0x6003C32")]
		[Address(RVA = "0x7F2010", Offset = "0x7F0610", VA = "0x1807F2010", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06003C33 RID: 15411 RVA: 0x0013A908 File Offset: 0x00138B08
		[Token(Token = "0x170004B8")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C33")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06003C34 RID: 15412 RVA: 0x0013A918 File Offset: 0x00138B18
		[Token(Token = "0x170004B9")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C34")]
			[Address(RVA = "0x82C7E0", Offset = "0x82ADE0", VA = "0x18082C7E0", Slot = "20")]
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

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06003C35 RID: 15413 RVA: 0x0013A988 File Offset: 0x00138B88
		[Token(Token = "0x170004BA")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C35")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06003C36 RID: 15414 RVA: 0x0013A998 File Offset: 0x00138B98
		[Token(Token = "0x170004BB")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C36")]
			[Address(RVA = "0x82C610", Offset = "0x82AC10", VA = "0x18082C610", Slot = "22")]
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

		// Token: 0x06003C37 RID: 15415 RVA: 0x0013A9E4 File Offset: 0x00138BE4
		[Token(Token = "0x6003C37")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public LaserUmbrella()
		{
		}
	}
}
