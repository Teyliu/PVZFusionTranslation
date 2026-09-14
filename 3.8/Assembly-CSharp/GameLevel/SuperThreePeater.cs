using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B07 RID: 2823
	[Token(Token = "0x2000B07")]
	public class SuperThreePeater : TravelAdvantureLevelData
	{
		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06003AC7 RID: 15047 RVA: 0x00135160 File Offset: 0x00133360
		[Token(Token = "0x17000458")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003AC7")]
			[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "42")]
			get
			{
				return TravelAdvanture.SuperThreePeater;
			}
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x00135170 File Offset: 0x00133370
		[Token(Token = "0x6003AC8")]
		[Address(RVA = "0x7B6C20", Offset = "0x7B5220", VA = "0x1807B6C20", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "三线射手 + 火爆辣椒x3\n使用三叶草、铲子进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x0013519C File Offset: 0x0013339C
		[Token(Token = "0x6003AC9")]
		[Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06003ACA RID: 15050 RVA: 0x001351C8 File Offset: 0x001333C8
		[Token(Token = "0x17000459")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003ACA")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06003ACB RID: 15051 RVA: 0x001351D8 File Offset: 0x001333D8
		[Token(Token = "0x1700045A")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003ACB")]
			[Address(RVA = "0x7B6E10", Offset = "0x7B5410", VA = "0x1807B6E10", Slot = "20")]
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

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06003ACC RID: 15052 RVA: 0x00135238 File Offset: 0x00133438
		[Token(Token = "0x1700045B")]
		public override int MaxWave
		{
			[Token(Token = "0x6003ACC")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06003ACD RID: 15053 RVA: 0x00135248 File Offset: 0x00133448
		[Token(Token = "0x1700045C")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003ACD")]
			[Address(RVA = "0x7B6CA0", Offset = "0x7B52A0", VA = "0x1807B6CA0", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x0013528C File Offset: 0x0013348C
		[Token(Token = "0x6003ACE")]
		[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
		public SuperThreePeater()
		{
		}
	}
}
