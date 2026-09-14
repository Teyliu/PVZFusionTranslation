using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B06 RID: 2822
	[Token(Token = "0x2000B06")]
	public class SuperCaltrop : TravelAdvantureLevelData
	{
		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06003ABF RID: 15039 RVA: 0x00135008 File Offset: 0x00133208
		[Token(Token = "0x17000453")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003ABF")]
			[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "42")]
			get
			{
				return TravelAdvanture.SuperCaltrop;
			}
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x00135018 File Offset: 0x00133218
		[Token(Token = "0x6003AC0")]
		[Address(RVA = "0x793010", Offset = "0x791610", VA = "0x180793010", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "黄油地刺 + 窝刺\n使用花盆、铲子进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x00135044 File Offset: 0x00133244
		[Token(Token = "0x6003AC1")]
		[Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06003AC2 RID: 15042 RVA: 0x00135070 File Offset: 0x00133270
		[Token(Token = "0x17000454")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003AC2")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x00135088 File Offset: 0x00133288
		[Token(Token = "0x17000455")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003AC3")]
			[Address(RVA = "0x793200", Offset = "0x791800", VA = "0x180793200", Slot = "20")]
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

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06003AC4 RID: 15044 RVA: 0x001350F8 File Offset: 0x001332F8
		[Token(Token = "0x17000456")]
		public override int MaxWave
		{
			[Token(Token = "0x6003AC4")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x00135108 File Offset: 0x00133308
		[Token(Token = "0x17000457")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003AC5")]
			[Address(RVA = "0x793090", Offset = "0x791690", VA = "0x180793090", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x0013514C File Offset: 0x0013334C
		[Token(Token = "0x6003AC6")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public SuperCaltrop()
		{
		}
	}
}
