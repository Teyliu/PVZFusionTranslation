using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B4A RID: 2890
	[Token(Token = "0x2000B4A")]
	public class ObsidianSpike : TravelAdvantureLevelData
	{
		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06003C20 RID: 15392 RVA: 0x0013A5F0 File Offset: 0x001387F0
		[Token(Token = "0x170004AD")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C20")]
			[Address(RVA = "0x3F87C0", Offset = "0x3F6DC0", VA = "0x1803F87C0", Slot = "42")]
			get
			{
				return TravelAdvanture.ObsidianSpike;
			}
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x0013A600 File Offset: 0x00138800
		[Token(Token = "0x6003C21")]
		[Address(RVA = "0x82F4B0", Offset = "0x82DAB0", VA = "0x18082F4B0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "冰地刺王 + 火地刺王\n使用坚果墙、地刺王进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x0013A62C File Offset: 0x0013882C
		[Token(Token = "0x6003C22")]
		[Address(RVA = "0x7F2010", Offset = "0x7F0610", VA = "0x1807F2010", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06003C23 RID: 15395 RVA: 0x0013A658 File Offset: 0x00138858
		[Token(Token = "0x170004AE")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C23")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06003C24 RID: 15396 RVA: 0x0013A668 File Offset: 0x00138868
		[Token(Token = "0x170004AF")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C24")]
			[Address(RVA = "0x82F700", Offset = "0x82DD00", VA = "0x18082F700", Slot = "20")]
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

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06003C25 RID: 15397 RVA: 0x0013A6D8 File Offset: 0x001388D8
		[Token(Token = "0x170004B0")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C25")]
			[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06003C26 RID: 15398 RVA: 0x0013A6E8 File Offset: 0x001388E8
		[Token(Token = "0x170004B1")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C26")]
			[Address(RVA = "0x82F530", Offset = "0x82DB30", VA = "0x18082F530", Slot = "22")]
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

		// Token: 0x06003C27 RID: 15399 RVA: 0x0013A734 File Offset: 0x00138934
		[Token(Token = "0x6003C27")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public ObsidianSpike()
		{
		}
	}
}
