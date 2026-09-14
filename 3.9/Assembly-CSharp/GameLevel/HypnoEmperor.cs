using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B47 RID: 2887
	[Token(Token = "0x2000B47")]
	public class HypnoEmperor : TravelAdvantureLevelData
	{
		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06003C08 RID: 15368 RVA: 0x0013A220 File Offset: 0x00138420
		[Token(Token = "0x1700049E")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C08")]
			[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "42")]
			get
			{
				return TravelAdvanture.HypnoEmperor;
			}
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x0013A230 File Offset: 0x00138430
		[Token(Token = "0x6003C09")]
		[Address(RVA = "0x82B750", Offset = "0x829D50", VA = "0x18082B750", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "魅惑菇 + 魅惑菇\n使用樱桃炸弹、魅惑菇进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x0013A25C File Offset: 0x0013845C
		[Token(Token = "0x6003C0A")]
		[Address(RVA = "0x7F2010", Offset = "0x7F0610", VA = "0x1807F2010", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06003C0B RID: 15371 RVA: 0x0013A288 File Offset: 0x00138488
		[Token(Token = "0x1700049F")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C0B")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06003C0C RID: 15372 RVA: 0x0013A2A0 File Offset: 0x001384A0
		[Token(Token = "0x170004A0")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C0C")]
			[Address(RVA = "0x82B8F0", Offset = "0x829EF0", VA = "0x18082B8F0", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06003C0D RID: 15373 RVA: 0x0013A2F8 File Offset: 0x001384F8
		[Token(Token = "0x170004A1")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C0D")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06003C0E RID: 15374 RVA: 0x0013A308 File Offset: 0x00138508
		[Token(Token = "0x170004A2")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C0E")]
			[Address(RVA = "0x82B7D0", Offset = "0x829DD0", VA = "0x18082B7D0", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x0013A344 File Offset: 0x00138544
		[Token(Token = "0x6003C0F")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public HypnoEmperor()
		{
		}
	}
}
