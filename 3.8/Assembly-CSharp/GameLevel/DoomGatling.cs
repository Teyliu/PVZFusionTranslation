using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B00 RID: 2816
	[Token(Token = "0x2000B00")]
	public class DoomGatling : TravelAdvantureLevelData
	{
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06003A8F RID: 14991 RVA: 0x00134860 File Offset: 0x00132A60
		[Token(Token = "0x17000435")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003A8F")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "42")]
			get
			{
				return TravelAdvanture.DoomGatling;
			}
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x00134870 File Offset: 0x00132A70
		[Token(Token = "0x6003A90")]
		[Address(RVA = "0x787CD0", Offset = "0x7862D0", VA = "0x180787CD0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "机枪射手 + 毁灭菇\n使用胆小菇、豌豆射手进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x0013489C File Offset: 0x00132A9C
		[Token(Token = "0x6003A91")]
		[Address(RVA = "0x787D50", Offset = "0x786350", VA = "0x180787D50", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int theSun = board.theSun;
			board.theSun = this;
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06003A92 RID: 14994 RVA: 0x001348C4 File Offset: 0x00132AC4
		[Token(Token = "0x17000436")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003A92")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06003A93 RID: 14995 RVA: 0x001348DC File Offset: 0x00132ADC
		[Token(Token = "0x17000437")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003A93")]
			[Address(RVA = "0x787F60", Offset = "0x786560", VA = "0x180787F60", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06003A94 RID: 14996 RVA: 0x00134924 File Offset: 0x00132B24
		[Token(Token = "0x17000438")]
		public override int MaxWave
		{
			[Token(Token = "0x6003A94")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06003A95 RID: 14997 RVA: 0x00134934 File Offset: 0x00132B34
		[Token(Token = "0x17000439")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003A95")]
			[Address(RVA = "0x787D90", Offset = "0x786390", VA = "0x180787D90", Slot = "22")]
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

		// Token: 0x06003A96 RID: 14998 RVA: 0x00134984 File Offset: 0x00132B84
		[Token(Token = "0x6003A96")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public DoomGatling()
		{
		}
	}
}
