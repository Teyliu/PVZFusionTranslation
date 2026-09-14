using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B08 RID: 2824
	[Token(Token = "0x2000B08")]
	public class ObsidianSpike : TravelAdvantureLevelData
	{
		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06003ACF RID: 15055 RVA: 0x001352A0 File Offset: 0x001334A0
		[Token(Token = "0x1700045D")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003ACF")]
			[Address(RVA = "0x3AC960", Offset = "0x3AAF60", VA = "0x1803AC960", Slot = "42")]
			get
			{
				return TravelAdvanture.ObsidianSpike;
			}
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x001352B0 File Offset: 0x001334B0
		[Token(Token = "0x6003AD0")]
		[Address(RVA = "0x7B3B70", Offset = "0x7B2170", VA = "0x1807B3B70", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "冰地刺王 + 火地刺王\n使用坚果墙、地刺王进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x001352DC File Offset: 0x001334DC
		[Token(Token = "0x6003AD1")]
		[Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06003AD2 RID: 15058 RVA: 0x00135308 File Offset: 0x00133508
		[Token(Token = "0x1700045E")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003AD2")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06003AD3 RID: 15059 RVA: 0x00135318 File Offset: 0x00133518
		[Token(Token = "0x1700045F")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003AD3")]
			[Address(RVA = "0x7B3DC0", Offset = "0x7B23C0", VA = "0x1807B3DC0", Slot = "20")]
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

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x00135388 File Offset: 0x00133588
		[Token(Token = "0x17000460")]
		public override int MaxWave
		{
			[Token(Token = "0x6003AD4")]
			[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x00135398 File Offset: 0x00133598
		[Token(Token = "0x17000461")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003AD5")]
			[Address(RVA = "0x7B3BF0", Offset = "0x7B21F0", VA = "0x1807B3BF0", Slot = "22")]
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

		// Token: 0x06003AD6 RID: 15062 RVA: 0x001353E4 File Offset: 0x001335E4
		[Token(Token = "0x6003AD6")]
		[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
		public ObsidianSpike()
		{
		}
	}
}
