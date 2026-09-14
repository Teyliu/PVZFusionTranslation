using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B0C RID: 2828
	[Token(Token = "0x2000B0C")]
	public class SuperHypnoDoom : TravelAdvantureLevelData
	{
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06003AEF RID: 15087 RVA: 0x001357F8 File Offset: 0x001339F8
		[Token(Token = "0x17000471")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003AEF")]
			[Address(RVA = "0x3AAFC0", Offset = "0x3A95C0", VA = "0x1803AAFC0", Slot = "42")]
			get
			{
				return TravelAdvanture.SuperHypnoDoom;
			}
		}

		// Token: 0x06003AF0 RID: 15088 RVA: 0x00135808 File Offset: 0x00133A08
		[Token(Token = "0x6003AF0")]
		[Address(RVA = "0x7B6710", Offset = "0x7B4D10", VA = "0x1807B6710", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "毁灭魅惑菇 + 毁灭菇\n使用金盏花、毁灭菇进行亚种切换\n<color=red>亚种在非旅行模式不推荐使用</color>";
			throw new NullReferenceException();
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x00135834 File Offset: 0x00133A34
		[Token(Token = "0x6003AF1")]
		[Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06003AF2 RID: 15090 RVA: 0x00135860 File Offset: 0x00133A60
		[Token(Token = "0x17000472")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003AF2")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06003AF3 RID: 15091 RVA: 0x00135870 File Offset: 0x00133A70
		[Token(Token = "0x17000473")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003AF3")]
			[Address(RVA = "0x7B6900", Offset = "0x7B4F00", VA = "0x1807B6900", Slot = "20")]
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

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x001358E0 File Offset: 0x00133AE0
		[Token(Token = "0x17000474")]
		public override int MaxWave
		{
			[Token(Token = "0x6003AF4")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06003AF5 RID: 15093 RVA: 0x001358F0 File Offset: 0x00133AF0
		[Token(Token = "0x17000475")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003AF5")]
			[Address(RVA = "0x7B6790", Offset = "0x7B4D90", VA = "0x1807B6790", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x00135934 File Offset: 0x00133B34
		[Token(Token = "0x6003AF6")]
		[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
		public SuperHypnoDoom()
		{
		}
	}
}
