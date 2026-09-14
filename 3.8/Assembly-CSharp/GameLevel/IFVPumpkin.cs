using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B09 RID: 2825
	[Token(Token = "0x2000B09")]
	public class IFVPumpkin : TravelAdvantureLevelData
	{
		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06003AD7 RID: 15063 RVA: 0x001353F8 File Offset: 0x001335F8
		[Token(Token = "0x17000462")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003AD7")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "42")]
			get
			{
				return TravelAdvanture.IFVPumpkin;
			}
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x00135408 File Offset: 0x00133608
		[Token(Token = "0x6003AD8")]
		[Address(RVA = "0x7B0720", Offset = "0x7AED20", VA = "0x1807B0720", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "磁力南瓜 + 磁力菇\n使用杨桃、南瓜头进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003AD9 RID: 15065 RVA: 0x00135434 File Offset: 0x00133634
		[Token(Token = "0x6003AD9")]
		[Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06003ADA RID: 15066 RVA: 0x00135460 File Offset: 0x00133660
		[Token(Token = "0x17000463")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003ADA")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06003ADB RID: 15067 RVA: 0x00135470 File Offset: 0x00133670
		[Token(Token = "0x17000464")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003ADB")]
			[Address(RVA = "0x7B0970", Offset = "0x7AEF70", VA = "0x1807B0970", Slot = "20")]
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

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06003ADC RID: 15068 RVA: 0x001354E0 File Offset: 0x001336E0
		[Token(Token = "0x17000465")]
		public override int MaxWave
		{
			[Token(Token = "0x6003ADC")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06003ADD RID: 15069 RVA: 0x001354F0 File Offset: 0x001336F0
		[Token(Token = "0x17000466")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003ADD")]
			[Address(RVA = "0x7B07A0", Offset = "0x7AEDA0", VA = "0x1807B07A0", Slot = "22")]
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

		// Token: 0x06003ADE RID: 15070 RVA: 0x0013553C File Offset: 0x0013373C
		[Token(Token = "0x6003ADE")]
		[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
		public IFVPumpkin()
		{
		}
	}
}
